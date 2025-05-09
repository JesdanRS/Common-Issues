---
category: "CNF"
cvss: "5.3"
---
### Email Headers Reveal Internal Systems
Automated emails sent out by the website {==URL==} have mail headers that reveal internal systems, version information and internal IP addresses. This can be useful information to an attacker.

```
{==TRIMMEDHEADER==}
```
#### Impact: Low
Unnecessary system information is exposed. {==OPTION==} Note that requirement 1.4.5 of PCI DSS states that internal IP addresses must not be disclosed.
#### Likelihood: Medium
To obtain this information someone needs to receive an automated email from the website and examine the email headers.
#### Recommendation
If possible, remove email headers which disclose unnecessary system information at the mail gateway to the Internet.
