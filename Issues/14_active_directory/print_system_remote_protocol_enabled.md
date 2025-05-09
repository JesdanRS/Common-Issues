---
category: "CNF"
cvss: "4.3"
---
### Print System Remote Protocol Enabled
The Print System Remote Protocol (MS-RPRN) was found to be enabled on the hosts mentioned above , {==including critical servers such as domain controllers==}.

The MS-RPRN protocol is used to provide communication about printing, for example print jobs. An attacker with access to a low privileged domain user account can exploit this by crafting an RPC request to ask the server to provide an update on print jobs and to send the results as a notification to an arbitrary system. The notification would prompt the affected server running the printing protocol to authenticate to the attacker-controlled system using NTLM authentication. An attacker can then relay this authentication onto another system where the computer account of the affected server has administrative privileges.

An attacker can use the following script to leverage the MS-RPRN protocol and force the vulnerable {==XREF_HOST==} server to authenticate to a machine they control at {==XREF_KALI_IP==}

{==AddPOC with printerbug.py or PrintSpooler==}

Once the RPC call has triggered the notification, the challenge-response can then be captured on the attacker's system using a tool such as {==Responder/SMBserver==} as shown below:

{==XREF_captured_hash==}

{==OPTION==}Please note that this can be abused to compromise the Active Directory domain as discussed in section {==XREF_exploitation_path==}.


{==OPTION PrinterNightmare==}
Furthermore, a number of critical vulnerabilities in the Print Spooler service have {==recently==} been discovered (CVE-2021-1675, CVE-2021-34527 and CVE-2021-34481). Among them, the well-known PrintNightmare vulnerability (CVE-2021-34527) leverages the fact that the Print Spooler service fails to restrict access to RpcAsyncAddPrinterDriver(), a function for installing printer drivers on a Windows system remotely, to execute arbitrary code with SYSTEM privileges on the affected systems.

During testing, the following hosts were seen to be vulnerable to the PrintNightmare vulnerability.{==OPTION NO EXPLOITATION==} Please note that the remote exploits against the Print Spooler may cause the targeted systems to crash in rare circumstances. As such, Dionach did not attempt to exploit this vulnerability.
#### Impact: Medium
{==OPTION_PRINTNIGHTMARE== raise impact} An attacker could be to exploit this issue to execute remote commands or to escalate their privileges on the affected targets. An attacker can exploit this issue to coerce an authentication from the affected host to a machine under their control and relay said authentication to other systems in {==CLIENTNAME==} network.
#### Likelihood: Medium
In order to exploit this issue an attacker requires a normal low privileged domain credentials and the MS-RPRN protocol to be enabled on {==CLIENTNAME==} systems. Public tools exist to exploit this issue; however an attacker can leverage this vulnerability only in conjunction with other vulnerabilities on other systems in {==CLIENTNAME==} network.
#### Recommendation
Disable the print spooler service if it is not required. If the service is required then ensure that computer accounts where the service is running are not part of any privileged group. {==OPTION_PRINTNIGHTMARE==}Moreover, ensure patches are applied to prevent exploitation of the PrintNightmare vulnerability.

Please note that additional considerations should be made before disabling this service on domain controllers. On a domain controller a thread is added to the service that is responsible for removing stale print queue objects from the Active Directory. For print pruning to take place automatically the print spooler service must be running on at least one domain controller at each site. If the service is disabled on all domain controllers then it is recommended that an alternative means of handling stale print queue objects be put in place.

For further information please see the following URLs:

[https://learn.microsoft.com/en-us/windows-server/security/windows-services/security-guidelines-for-disabling-system-services-in-windows-server#print-spooler]()
[https://learn.microsoft.com/en-us/defender-for-identity/security-assessment-print-spooler]()
[https://learn.microsoft.com/en-us/windows-server/identity/ad-ds/manage/how-to-configure-protected-accounts#BKMK_ProvidePUdcProtections]()
