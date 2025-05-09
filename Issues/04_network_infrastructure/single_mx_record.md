---
category: "{==APP-CNF/CNF==}"
cvss: "5.8"
---
### Single MX Record
The DNS record{s||} for the {domains below|| domain DOMAIN} only contains a single mail exchange (MX) record - {||MXRECORD (MXIP)}. If this IP address were to become inaccessible for some reason, any email traffic for this domain would most likely be bounced back to the sender.

{==DOMAINS==}
#### Impact: Medium
Most mail servers have a retry period extending to several hours. However, if there were to be an extended outage of either the mail server or the internet connection that it is situated on, mail could be bounced back to the sender. This could lead to loss of information and reputational damage.
#### Likelihood: Low
Internet connections are generally reliable and both the Internet connection and mail server infrastructure may have resiliency built in. Additionally, many mail servers will attempt to re-send email periodically if the server does not respond.
#### Recommendation
Consider adding a secondary MX record for them to reduce the risk to email availability. Most Internet Service Providers offer fall back mail relay services.
