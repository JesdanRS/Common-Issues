---
category: "CNF"
cvss: "5.8"
---
### WHOIS Information Leakage
WHOIS records for the {domains below reveal||DOMAINNAME domain reveals} personally identifiable information, including {==details about the registrant==}. This information could be of use to an attacker as part of a social engineering or client-side attack.

{==DOMAINLIST==}

An example of the information available is shown below:

$ whois {==DOMAIN==}
```
{==WHOISDATA==}
```
#### Impact: Low
While no obviously sensitive information is exposed, information about staff members is often harvested by attackers preparing for a social engineering attack. {==OPTION==} This data exposes the email naming convention for the organisation allowing an attacker to derive email addresses from employee names.
#### Likelihood: Medium
This information is publicly available, requiring very little technical knowledge to obtain. WHOIS entries are a common source of information for attackers.
#### Recommendation
Consider updating the WHOIS contact details to remove this information unless there is a specific business requirement for this information to be publicly available. {==OPTION==} Where email addresses are required, consider using generic accounts rather than individual's emails. Alternatively consider using privacy protection services, such as WhoisGuard, if possible.
