---
category: "APP-CNF"
cvss: "9.3"
report_on_external_network_test: true
---
### Cross-Site Request Forgery
The {affected websites listed above||website at URL} {are||is} vulnerable to cross-site request forgery (CSRF) on all pages that cause actions such as updates and deletes. A CSRF attack forces a logged-on victim's browser to send a request to a vulnerable web application, which then performs the chosen action on behalf of the victim. An example is the following HTML, which {==changes the user's email address==}:

```
{==<html><form><input...>==}
```

When a logged in user on the website visits a page containing the HTML code above, a "{==ChangeEmail==}" request is sent to the web server by the web browser in the context of the logged in user, causing the website to {==update the user's email address==}. Note that as the user is logged in, web browsers automatically attach the user's session cookie to the request.

Please see the following OWASP reference for more information:

[https://owasp.org/www-community/attacks/csrf]()
#### Impact: High
A malicious user exploiting this issue would be able to {==modify victim's account information, leading to a take over of the account and further access to sensitive data and functionality==}.
#### Likelihood: Medium
The victim needs to be logged in and the attacker needs to have knowledge of the website. {==OPTION==} Some of the actions are done with GET requests which means that a victim only needs to click on a malicious link to the website. The attacker needs to get the victim to visit a website under the control of the attacker or that is vulnerable to cross-site scripting.
#### Recommendation
{==OPTION==} Utilise framework CSRF protection to restrict actions to POST methods and add a hidden key field to forms that validate requests. The hidden key should be unique to the page request and validated on post back. Please see the following OWASP link for more information.

[https://cheatsheetseries.owasp.org/cheatsheets/Cross-Site_Request_Forgery_Prevention_Cheat_Sheet.html]()

In addition, consider setting the "SameSite" attribute on the website's session cookie, as discussed in section {==XREFInsufficientCookieProtection==}.
