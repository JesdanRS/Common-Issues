---
category: "CNF"
cvss: "4.3"
---
### No Effective Mail Verification for Unused Domains
Although the {==DOMAIN==} domain{s are|| is} not used by {==CLIENTNAME==} for email, because no mail verification is taking place on {these domains||this domain} it is possible to use the domain{s||} as a phishing source to try and deceive staff at {==CLIENTNAME==}. {==OPTION==} Note that other {==CLIENTNAME==} owned domains also exist, such as {==DOMAINS==}.
{==OPTION==} Note that an SPF record exists on the main {==DOMAIN==} domain, and that this is configured to use DKIM signing.

Current best practise is to configure SPF records, DKIM signing, and DMARC, and this should be done for not only the primary domain, but on all subdomains and any other domain owned by the organisation.

Sender Policy Framework (SPF) is a simple DNS record based email validation system which allows receiving mail exchangers to check that incoming mail is being sent from a domain authorised by that domain's administrators.

DomainKeys Identified Mail (DKIM) is a technology that is used by the sending mail server to cryptographically sign the message with a private key. The receiving mail server can then use the published public key to verify the sender is legitimate and the message unaltered.

Domain-based Message Authentication, Reporting & Conformance (DMARC) builds on both SPF and DKIM to define how recipients should handle failing messages and to allow reports back to the legitimate domain when someone attempts to spoof messages from them.
#### Impact: Medium
Attackers could spoof emails from the targeted domains, and use this to target {==CLIENTNAME==}'s {==employees or clients==} in a social engineering attack. The reputation of the organisation could also be damaged if an attacker sends malicious or inappropriate emails that appear to be from {==CLIENTNAME==}.
#### Likelihood: Medium
It is relatively straightforward to send a spoofed email, and there are a number of public tools that allow users to automate this process.{==OPTION==} Although all {==CLIENTNAME==} mail is sent via {==DOMAIN==}.com, during the test a number of staff believed the emails from {==SPOOFED_DOMAIN==} were legitimate.
#### Recommendation
Consider configuring mail authentication technologies on all owned domains, not just the core domain used for legitimate mail.
For an unused parked domain, the following SPF record would signify that no host is allowed to send mail for the domain:

```
{==DOMAIN==} TXT "v=spf1 -all"
```

The following wildcard record would indicate that all keys from the unused domain have expired:

```
*._domainkey.{==DOMAIN==} TXT "v=DKIM1; p="
```

The following is an example of a DMARC record for a domain that is not intended to send mail, providing the policy that any mail from this domain should be rejected:

```
_dmarc.{==DOMAIN==} TXT "v=DMARC1; p=reject;
rua=mailto: dmarc-abuse-reports@{==REPORT_DOMAIN==}; ruf=mailto:dmarc-failure-reports@{==REPORT_DOMAIN==}"
```

Note that changing the DMARC record for each unused domain can be time consuming, as such a CNAME can be used within each parked domain to reduce effort:

```
_dmarc.{==PARKED_DOMAIN==} CNAME _dmarc.parked.{==PARKED_DOMAIN==}.
```

In the central domain, the record would then look like:

```
_dmarc.parked.{==PARKED_DOMAIN==} TXT "rua=mailto: dmarc-abuse-reports@{==REPORT_DOMAIN==}.com; ruf=mailto:dmarc-failure-reports@{==REPORT_DOMAIN==}.com"

*._report._dmarc.{==DOMAIN==} TXT "v=DMARC1"
```

For further information, please refer to the following NCSC guidelines:

[https://www.ncsc.gov.uk/collection/email-security-and-anti-spoofing]()