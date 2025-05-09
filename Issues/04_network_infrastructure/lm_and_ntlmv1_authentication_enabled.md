---
category: "ATH"
cvss: "5.8"
generation:
  getIssueContext: |
    return issueGeneration.nessus.helpers.getReportItemsForPluginIds("63478");
  getAffectedSystems: |
    return [...new Set(issueContext.map((x) => x.hostName))].sort((a, b) =>
      a.localeCompare(b)
    );
---
### LM and NTLMv1 Authentication Enabled
The affected systems allow the use of the LM and NTLMv1 authentication protocols. These protocols are cryptographically weak, and could allow an attacker intercepting the traffic to obtain credentials for accounts on {==DOMAIN==} domain.

The following example shows how it was possible to use the {==PetitPotam/Printerbug==} tool to coerce an authentication from the host at {==HOSTNAME==} and capture the NTLMv1 hash of the computer account on the attacker's server with a tool such as Responder:

{==PoC==}

{==OPTION==}Please note that since domain controllers are affected by this issue, it would be possible for an attacker to crack this hash and compromise the Active Directory domain{== as discussed in section XREF_to_exploitation_path==}.
#### Impact: Medium
{==NOTE: increase impact to High if DC or highly privileged servers is vulnerable==}
An attacker successfully intercepting an authentication request could crack the intercepted hashes to obtain credentials that can be used to gain unauthorised access against {==CLIENTNAME==} systems. {==OPTIONAL==}This could allow them to compromise the internal network if a domain controller hash is compromised.
#### Likelihood: Medium
{==NOTE: increase likelihod to High if flat network==}It is straightforward for an attacker with valid domain credentials to coerce an authentication request. Also, there are a number of tools available to crack the obtained hashes. {==OPTION==}However, the attacker would need to be able to intercept the response from the target system.
#### Recommendation
Disable the use of LM and NTLMv1 protocols by setting the following Group Policy value to "Send NTLMv2 response only/refuse LM and NTLM".

```
Computer Configuration -> Windows Settings -> Security Settings -> Security Options -> "Network security: LAN Manager authentication level"
```

Please note that this may cause compatibility issues with legacy clients. See the following Microsoft articles for more information.

[https://learn.microsoft.com/en-us/previous-versions/tn-archive/cc512606(v=technet.10)]()
[https://learn.microsoft.com/en-us/previous-versions/windows/it-pro/windows-server-2003/cc738867(v=ws.10)]()
