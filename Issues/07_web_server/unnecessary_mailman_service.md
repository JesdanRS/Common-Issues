---
category: "{==APP-CNF/NET==}"
cvss: "N/A"
report_on_external_network_test: true
---
### Unnecessary Mailman Service
The default mailman server is accessible at the following link:

{==http://LINK/mailman/listinfo==}
#### Impact: Low
Mailman appears to not be configured, as administration actions result in an error.
#### Likelihood: Medium
Mailman would need to be configured with mailboxes, forwarding rules etc. to be subject to abuse, or known account credentials would be needed, perhaps obtained by exploiting other vulnerabilities in the website. It would then be possible to create new mailing lists, which could be used for phishing campaigns or spam generation.
It is however, a well-known service, and easy to test for.
#### Recommendation
If mailman is not required for site functionality, remove it; otherwise ensure that access is restricted.