---
category: TBA
cvss: TBA
---
### NTLM Authentication Supported Externally
The {==web or mail==} server{s||} listed above support{s||} NTLM authentication over the Internet. Authentication with the NTLM protocol requires the server to return internal information to unauthenticated users, including the server's internal host name and Active Directory domain. The following request retrieves the NTLM authentication challenge:

{==curl -I URL --ntlm --user ':'==}

Decoding the challenge reveals domain information otherwise not exposed to external users:

{==echo TlRMTVNTUAAC... | ntlmdecoder.py==}
#### Impact: Low
Unnecessary system information is disclosed, which could be useful to an attacker preparing attacks against internal hosts.
#### Likelihood: Medium
Gathering internal information is a common part of an attack strategy against an organisation, particularly with the aim of obtaining information relating to Active Directory. Public tools are available to identify services requiring authentication.
#### Recommendation
Disable NTLM authentication on externally accessible services. For more information on configuring Windows NTLM authentication in IIS, see the following guidance:

[https://docs.microsoft.com/en-us/previous-versions/windows/it-pro/windows-server-2012-R2-and-2012/hh831496(v=ws.11)#windows-authentication]()
[https://docs.microsoft.com/en-us/iis/configuration/system.webserver/security/authentication/windowsauthentication/]()
