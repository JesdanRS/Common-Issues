---
category: "NET"
cvss: "9.3"
---
### Broadcast Protocols Enabled
A sample review of the systems in scope and analysis of the traffic showed that NetBIOS over TCP/IP, Link-Local Multicast Name Resolution (LLMNR) and multicast DNS (mDNS) were enabled. These protocols are used by Windows systems to send broadcast messages on the network when DNS requests fail, for example requests for the "wpad" (Web Proxy Auto-Discovery Protocol) domain which is requested by default when Internet Explorer is opened on a system without the Microsoft MS16-077 patch installed.

As a result, an attacker can reply to broadcast messages in order to capture the NTLM challenge responses which contain users' password hashes. The captured password hashes can be cracked offline with dictionary attacks or used to perform SMB relay attacks, in other words, they could be re-used to authenticate on systems which have SMB signing disabled (see section {==XREFtoSMBSigningDisabled==}).

The following image shows that default settings to request "wpad" domain were enabled on the domain controller {==HOSTNAME (IP ADDRESS)==}.

{==ADDSCREENSHOT==}

Furthermore, the NetBIOS over TCP/IP and LLMNR settings were enabled, as shown in the images below:

{==ADDSCREENSHOT==}

{==OPTION==} Using a well-known tool, Responder, it was possible to capture {NetNTLMv2 hashes||a NetNTLMv2 hash} for the following {accounts||account}. Please note that the password {hashes have||hash has} been masked in the output below.

$ responder -I eth0
```
[...]
USERNAME IN BOLD:HOSTNAME:CHALLENGE:MASKED/TRUNCATED HASH
```

{==OPTION==} As {these users had weak passwords||this user had a weak password} (see section {==XREFWeakPasswords==}), it was possible to crack the password {hashes||hash} and obtain the {passwords||password} in clear text.
#### Impact: Medium
NTLM challenge responses can be captured by an attacker on the internal {==DOMAIN==} network. These responses contain users' password hashes which can be cracked offline or {==OPTION==} used to authenticate against systems that do not enforce SMB signing (see section {==XREFtoSMBSigningDisabled==}). As a result, an attacker can compromise users that have weak passwords, including privileged accounts or obtain operating system access on a large number of systems.
#### Likelihood: High
A number of tools that perform and automate this attack are publicly available {==OPTION==} and there is no segregation between different subnets of the {==CLIENTNAME==} internal network (see section {==XREFNetworkSegregation==}). {==OPTION==} A large number of privileged accounts have weak passwords (see section {==XREFWeakAdministratorPasswords==}) and were seen to be used on a daily basis (see section {==XREFInsufficientPrivilegeSeparation==}).
#### Recommendation
Where possible, NetBIOS over TCP/IP, LLMNR, and mDNS protocols should be disabled and {==only the IPv4==} DNS protocol should be used instead. Please note that this may affect applications that depend only on those protocols. For example, the "Computer Browser" service and the "net view" command will not be able to produce the list of visible internal systems. Consider testing these settings on a staging environment before enabling them on production systems.

NetBIOS over TCP/IP can be disabled in several ways:

Group Policy
```
Computer Configuration > Policies > Administrative Templates > Network > DNS Client > Configure NetBIOS settings > Disable NetBIOS name resolution
```

Graphical User Interface
```
Control Panel > Network and Internet > {Network adapter name} > Properties > Network Connections > Internet Protocol Version 4 > Properties > Advanced > WINS tab > Disable NetBIOS
```

Command line (the commands below will configure all network interfaces)
```
wmic nicconfig where TcpipNetbiosOptions=0 call SetTcpipNetbios 2
wmic nicconfig where TcpipNetbiosOptions=1 call SetTcpipNetbios 2
```

LLMNR can be disabled through Group Policy by enabling the following setting:

```
Computer Configuration > Policies > Administrative Templates > Network > DNS Client > Turn off Multicast Name Resolution
```

mDNS can be disabled through a Group Policy Object to create a registry key:

```
Action: Create
Hive: HKEY_LOCAL_MACHINE
Key Path: SYSTEM\CurrentControlSet\Services\Dnscache\Parameters
Value name: EnableMDNS
Value type: REG_DWORD
Value data: 0
```

{==OPTION==} Furthermore, segregate the internal network by isolating subnets based on functionality and sensitivity levels (see section {==XREF==}).
