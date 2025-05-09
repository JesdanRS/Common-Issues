---
category: "APP-CNF"
cvss: "6.1"
report_on_external_network_test: true
---
### Open URL Redirection
{The affected website{s||} {are||is} vulnerable to open URL redirection. An attacker is able to redirect a user to a website of their choosing by sending a URL to a user with a modified {=="redirect" parameter on the login page==}, such as in the URL below:

{==PoC URL==}

When a user {==clicks/logs in at==} the above URL, they will be redirected to the attacker's website. An attacker can mask this URL with a location different from the displayed text, as shown below:

{==Masked URL==}
#### Impact: Medium
An attacker may be able to use this vulnerability to add legitimacy to fake login pages hosted on their server. Additionally, an attacker may be able to hijack a user's trust in the {websites' domains||website's domain} to launch drive-by download attacks against {their||its} users.
#### Likelihood: Medium
This is a well-known vulnerability, however an attacker would need to be sufficiently motivated to target {the websites'||the website's} users in this manner, and an element of social engineering is required.
#### Recommendation
Use server-side checks to restrict redirection to authorised URLs. Please see the following OWASP article for more information:

[https://cheatsheetseries.owasp.org/cheatsheets/Unvalidated_Redirects_and_Forwards_Cheat_Sheet.html]()

Please note that it is possible to omit the protocol from URLs to signify that the current protocol should be used, as shown in the URL below. As such, it is not sufficient to denylist protocol names in order to prevent this issue.

```
//example.org
```
