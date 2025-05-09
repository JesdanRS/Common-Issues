---
category: "APP-DAT"
cvss: "6.5"
---
### Website Permits Basic Authentication over HTTP
The website available at the URL{s||} listed above permits Basic authentication over clear text HTTP for the folders indicated below. Basic authentication utilises a Base64 encoded version of the entered credentials, rather than sending credentials in clear text, however these can be decoded in real-time, allowing an attacker to obtain the credentials from intercepted traffic. Please note that there may be other web folders which also allow Basic authentication over HTTP.

{==URL==}
```
{==/folder/==}
```
#### Impact: High
An attacker on a network local to someone accessing these folders can attempt to intercept the communication, decode the credentials, and then logon to the system as that user. This vulnerability also gives scope for obtaining credentials through client-side attacks, such as cross-site scripting, without the user's knowledge or interaction.
#### Likelihood: Low
This issue would require an attacker to intercept traffic from an authorised user, or manipulate them into passing credentials to these websites, over a shared network.
#### Recommendation
If Basic authentication is required, ensure that it takes place over an encrypted HTTPS connection, secured with a digital certificate which is signed by a trusted Certification Authority. In addition, consider reviewing the firewall configuration for the web server to prevent access to this service from the Internet.
