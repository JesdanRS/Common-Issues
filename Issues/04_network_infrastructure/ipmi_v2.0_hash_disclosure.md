---
category: "NET"
cvss: "7.5"
generation:
  getIssueContext: |
    return issueGeneration.nessus.helpers.getReportItemsForPluginIds("80101");
  getAffectedSystems: |
    return [...new Set(issueContext.map((x) => x.hostName))].sort((a, b) =>
      a.localeCompare(b)
    );
---
### IPMI v2.0 Hash Disclosure
The affected system{s||} {allow||allows} baseboard management using version 2.0 of the IPMI specification.

The authentication process of version 2.0 of the IPMI specification mandates that the server sends a salted SHA1 or MD5 hash of the requested user's password to the client, prior to the client authenticating. This means that an attacker can obtain a user's password hash simply by making a connection attempt whilst specifying a valid user.

The following proof of concept example demonstrates how an attacker could use well-known tools, such as the Metasploit module below, in order to retrieve IPMI hashes:

```
$ msf auxiliary(ipmi_dumphashes) > run
[+] 192.168.5.13:623 - IPMI - Hash found: Administrator:[...]
```

{==OPTION==} It was possible to crack this hash to obtain the clear text password, as discussed in section {==XREFWeakIPMIPassword==}.

Further information regarding this vulnerability is available at the following page:

[http://fish2.com/ipmi/remote-pw-cracking.html]()
#### Impact: High
An attacker obtaining password hashes could attempt to crack them and obtain clear text passwords, which could be used to access the baseboard management controller and perform a variety of actions, including powering off the systems. This would lead to a loss of availability of any services hosted by the systems.
#### Likelihood: Low
Whilst it is straightforward to obtain the password hashes, the passwords in use would need to be weak in order for them to be cracked. {==OPTION==} This was seen to be the case, as discussed in section {==XREFWeakIPMIPassword==}.
#### Recommendation
As this is a vulnerability in the IPMI specification, there is no resolution for disclosing user hashes. It is therefore very important that strong passwords are being used for the administrative accounts. Additionally, consider disabling IPMI if it is not required. If IPMI is required, ensure that access is restricted to trusted management workstations only at the firewall level, as discussed in section {==XREFInsufficientNetworkSegregation==}.
