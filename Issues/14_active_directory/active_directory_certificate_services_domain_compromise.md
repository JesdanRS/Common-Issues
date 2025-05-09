---
category: "CNF"
cvss: "9.0"
---
### Active Directory Certificate Services Domain Compromise
Active Directory Certificate Services (AD CS) was seen to be deployed in the {==XREF_DOMAIN==} domain. AD CS is Microsoft's implementation of a public key infrastructure (PKI), and offers a variety of features, including file system encryption, digital signatures, and domain user authentication.

However, the deployment of AD CS can expose the Active Directory domain to a large number of critical vulnerabilities related to insufficient Certificate Authority (CA) server hardening and misconfiguration of certificate templates. These issues could allow a standard domain user to escalate their privileges to domain administrator, leading to a complete compromise of the Active Directory domain. The {==PSPKIAudit/Certify==} tool was run against the {==XREF_DOMAIN==} domain and reported multiple AD CS related security issues, as summarised in the following table.

| Host | Vulnerable Component | Vulnerability | Reference |
| SRV1-HOST | Certificate Authority: AUTH01 | NTLM Relay to AD CS HTTP Endpoints | ESC8 |
| SRV2-HOST | Certificate Template: TemplateName | Misconfigured Certificate Templates | ESC1 |
|  |  |  |  |

{==SELECT OR EXPLAIN THE RELEVANT ESC#. Please make sure to amend the below ACCORDINGLY. They are just examples and will need modifications, especially if you have several vulnerable ESC==}
{==OPTION ESC1. MAKE SURE YOUR AMEND THE BELOW WITH THE MISCONF ON YOUR DOMAIN. The below is just an example==}
Certificate Template Vulnerability (ESC1) {==Add this and underline to make it a small title if you list several ESC==}
The combination of the following settings on the "{==XREF_TemplateName==}" certificate template allows any domain user to escalate their privileges and take full control of the {==XREF_DomainName==} domain:

- The Certificate Authority ({==XREF_SRV_CA==}) grants low-privileged users enrolment rights.
- Low-privileged users who are members of the "Domain Users" {==OPTION or "Domain Computers"==} group{==s==} are allowed to request a certificate.
- Manager approval is disabled.
- No authorised signatures are required.
- An Extended Key Usage (EKU) for {==client authentication (OID 1.3.6.1.5.5.7.3.2)==} is defined.
- Requesters are allowed to specify a Subject Alternative Name (SAN) in a certificate signing request (CSR).

As such, since this certificate template is used for client authentication and authorise the requester to specify the "Subject Name" of the certificate, this allows an attacker with a domain account to request a valid authentication certificate on behalf of any domain user, including high privileged users. {==OPTION==} A proof of concept of this attack was described in the exploitation path section ({==XREF==}) and demonstrated how an attacker can take full control of the {==XREF_DomainName==} domain. {==OPTION 2: Include your Poc below==}

{==OPTION ESC4==}
Certificate Template Vulnerability (ESC4) {==Add this and underline to make it a small title if you list several ESC==}
The output above shows that the "{==XREF_TEMPLATE==}" certificate template managed by the "{==XREF_CA==}" certificate authority on the {==XREF_HOST==} had insufficient access control since the "{==Authenticated Users==}" group has {=="FullControl" and "Write"==} rights on this template.

Certificate templates are used to define all the settings a certificate authority needs to generate a valid certificate. Therefore, any domain user with "FullControl" and "Write" rights can modify the "{==XREF_TEMPLATE==}" certificate template in an attempt to escalate their privileges and take full control of the Active Directory domain.

For example, a malicious domain user can enable client authentication on the "{==XREF_TEMPLATE==}" certificate template by modifying the Extended Key Usage (EKU). The malicious user will then be able to request a certificate from the {==XREF_CA==} certificate authority and use it to authenticate to any system within the {==XREF_DOMAIN==} domain where they are authorised to.

Furthermore, certificate templates contain a setting called Subject Alternative Name (SAN), which, if enabled, allows the requester to specify who the certificate will be issued for. The vulnerable "{==XREF_TEMPLATE==}" was seen to have this setting enabled, which means the attacker can request a certificate on behalf of any domain user and use it to log in to arbitrary systems. Successful exploitation of this misconfiguration would allow attackers to impersonate a domain administrator, resulting in the complete compromise of the {==XREF_DOMAIN==} domain.

{==POC==}
{==OPTION_CAVEAT_NO_EXPLOITATION_ESC4==} Please note that due to the potential disruption that modifying an actively used certificate template could cause, Dionach did not attempt to exploit this issue. However, a similar misconfiguration has been reproduced internally in a test environment and successfully exploited to gain full administrative privileges on the Active Directory domain.

{==POC==}
{==OPTION ESC7==}
Certificate Authority Vulnerability ESC7 {==Add this and underline to make it a small title if you list several ESC==}
The output above shows that the certificate authority "{==XREF_SRV_CA==}" has insufficient access control since the "{==Authenticated Users==}" group has {=="ManageCA/ManageCertificates"==} rights.
A user or group, with said rights is allowed to:
- perform modifications to the Certificate Authority.
- enable or disable certificate templates.
- request, approve, issue and retrieve certificates on behalf of any user, including any Domain Admin.

If an attacker manages to compromise an account with ManageCA or ManageCertificates rights, he will be able to enable the SubCA certificate template which is present by default (although disabled) and use it to request a certificate for a domain administrator, resulting in complete compromise.

{==OPTION ESC8==}
Certificate Authority Vulnerability (ESC8) {==Add this and underline to make it a small title if you list several ESC==}
The certificate authority "{==XREF_SRV_CA==}" was seen to expose HTTP-based certificate enrolment interfaces, which are vulnerable to NTLM relay attacks.

If an attacker manages to relay an NTLM authentication connection to these web enrolment interfaces, they will be able to impersonate the account and request a client authentication certificate based on a valid certificate template, such as the default "User" or "Machine" templates.

{==POC==}
{==OPTION ESC11==}
Certificate Authority Vulnerability (ESC11) {==Add this and underline to make it a small title if you list several ESC==}
The certificate authority "{==XREF_SRV_CA==}" was seen to expose RPC-based certificate enrolment interfaces, which are vulnerable to NTLM relay attacks.The server hosting the affected certificate authority was seen to also have SMB Signing disabled "{==XREF_SMB_SIGN==}".

If an attacker manages to relay an NTLM authentication connection to these RPC enrolment interfaces, they will be able to impersonate the account and request a client authentication certificate based on a valid certificate template, such as the default "User" or "Machine" templates.


{==POC==}

{==OPTION ESC6 TO DO==}

A complete description of the {==ESC_XREF==} misconfigurations can be found in the following blog post:

[https://posts.specterops.io/certified-pre-owned-d95910965cd2]()
#### Impact: High
The misconfigurations observed in AD CS allow attackers to generate a valid certificate on behalf of any user {==OPTION==} or computer account, including domain administrator accounts. This could be leveraged to gain access to critical systems such as a domain controller, resulting in complete compromise of the {==XREF_Domain==} domain.
#### Likelihood: Medium
Any low privileged domain user can exploit these misconfigurations. AD CS is a common target within Active Directory and will be a primary focus for attackers. Additionally, public tools are available to detect and exploit this issue.
#### Recommendation
{==OPTION ESC6==} Disable EDITF_ATTRIBUTESUBJECTALTNAME2 on the certificate authority by running the following command with administrative privileges:

```
certutil -config "{==CA_HOST\CA_NAME==}" -setreg policy\EditFlags - EDITF_ATTRIBUTESUBJECTALTNAME2

Get-Service -ComputerName {==CA_HOST==} certsvc | Restart-Service -Force
```

If this setting cannot be disabled, enable manager approvals for any certificate template that allows for domain authentication. More information about implementing Subject Alternative Name (SAN) setting in an Active Directory environment can be found in the following Microsoft article:

[https://docs.microsoft.com/en-us/previous-versions/windows/it-pro/windows-server-2008-R2-and-2008/ff625722(v=ws.10)]()

{==OPTION ESC3==} Restrict which principals can act as enrolment agents, and for which users or templates those agents can enrol on behalf of. This can be configured on each certificate authority through the Certificate Authority MMC snap-in (certsrv.msc) by right clicking on the CA -> Properties -> Enrollment Agents. Details on configuring enrolment agents can be found at the following URL:

[https://learn.microsoft.com/en-us/archive/technet-wiki/10942.ad-cs-security-guidance#Establish_Restricted_Enrollment_Agents]()

{==OPTION ESC7==} Remove the "Issue and Manage Certificates" and "Manage CA" permissions from the {==XREF_VULN_GROUP/USER==} group/user. {==CLIENTNAME==} should restrict these permissions to appropriate administrative groups.

{==OPTION ESC6/ESC3/ESC7==} Ensure that the above recommendations are applied on every certificate authority within the {==CLIENTNAME==} internal network.

{==OPTION ESC1/ESC2/ESC3/ESC4/ESC5==} For each certificate authority, review published certificate templates in order to prevent domain administrator privilege escalation. It is possible to enumerate the templates published to a certificate authority through the Certificate Authority MMC snap-in (certsrv.msc), by expanding a CA, clicking on "Certificate Templates", right-clicking on "Certificate Templates", and then "Manage" to apply the following relevant recommendations.

{==OPTION ESC1/ESC2/ESC3==} Under the "Extension" tab, ensure that certificate templates specify the minimum number of Extended Key Usages (EKUs) necessary to function. The following EKUs allow domain authentication or grant excessive permissions, as such {==CLIENTNAME==} should ensure that they are enabled only if strictly necessary:

- Client Authentication (1.3.6.1.5.5.7.3.2)
- PKINIT Client Authentication (1.3.6.1.5.2.3.4)
- Smart Card Logon (1.3.6.1.4.1.311.20.2.2)
- Any Purpose (2.5.29.37.0)
- SubCA (no EKUs)

{==OPTION ESC1==} Under the "Subject Name" tab, disable the "Supply in Request" setting for the affected templates to prevent requesters from controlling the subject name of a certificate. If this setting that allows domain user impersonation cannot be removed, enforce certificate approval on the template by enabling the "CA certificate manager approval" setting under the "Issuance Requirements" tab.

{==OPTION ESC1/ESC2/ESC3==} Under the "Security" tab, restrict users and groups that have "Enroll" permission on the affected templates. {==OPTION==} Removing this permission from the "Authenticated User" group will prevent arbitrary domain users to request a certificate via this template.

{==OPTION ESC4==} Under the "Security" tab, review and remove excessive permissions on the affected certificate templates. {==OPTION==} The "{==XREF_GROUP==}" group should {==only have "Read" and/or "Enroll" permissions==} on a certificate template.

{==OPTION ESC5==} Remove "{==XREF_VULNERABLE_PERMISSION==}" permissions for the {=="XREF_GROUP/USER" group/user==} on the {=="XREF_PKI_OBJECT" computer account/object/containers==}.

{==OPTION ESC8==} Remove AD CS HTTP endpoints on the affected certificate authority if they are not required. Otherwise, enforce HTTPS and restrict NTLM authentication. If disabling NTLM is infeasible, enforce HTTPS and enable Extended Protection for Authentication. More details can be found in the following article:

[https://support.microsoft.com/en-gb/topic/kb5005413-mitigating-ntlm-relay-attacks-on-active-directory-certificate-services-ad-cs-3612b773-4043-4aa9-b23d-b87910cd3429]()

{==OPTION ESC11==} Remove AD CS RPC endpoints on the affected certificate authority if they are not required. Otherwise, enforce SMB Signing and restrict NTLM authentication.

Furthermore, enforce encryption by setting the IF_ENFORCEENCRYPTICERTREQUEST flag with the following commands:

```
certutil -setreg CA\InterfaceFlags +IF_ENFORCEENCRYPTICERTREQUEST
net stop certsvc & net start certsvc
```

More details can be found in the following article:

[https://learn.microsoft.com/en-us/defender-for-identity/security-assessment-enforce-encryption-rpc]()

{==OPTION ANY ESC==} Lastly, a complete guide on how to implement the above recommendations can be found at the following URL:

[https://www.specterops.io/assets/resources/Certified_Pre-Owned.pdf#page=100]()