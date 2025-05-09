---
category: "APP-INJ"
cvss: "6.1"
---
### Emails HTML/URL Injection
The website at {==URL==} sends automated emails to users {==whenever they carry out actions, such as resetting their password==}. By including specially crafted content in the vulnerable fields, it is possible to inject custom {==OPTION HTML/text==} in the website's automatically generated emails. {==IF URL injection only: ==} Although user input is restricted, weaknesses in data validation (see section {==XREF==}) allow a user to {==provide a domain name as part of the input, which will be converted into a hyperlink by most modern email clients==}.

{==As shown in the proof of concept example below, an attacker can inject FIXME==}

The victim would then receive the following email:

{==XREF SCREENSHOT==}

As a result, an attacker could carry out social engineering attacks against {==CLIENTNAME==} staff or website visitors.

{==OPTION==} Please note that as there is no CAPTCHA mechanism on the web form (see section {==XREF==}), an attacker can use automated scripts which will target a large number of email addresses.
#### Impact: High
An attacker could target {==CLIENTNAME==} staff and website users by including phishing content in emails in an attempt to compromise their credentials or other sensitive information. An attacker could also exploit this issue to include abusive or spam content in automated emails. As the emails are sent from {==CLIENTNAME's==} mail server, this could result in reputational damage, or in {==CLIENTNAME's==} servers being denylisted.
#### Likelihood: Medium
This issue would be quickly identified by an attacker, however in order to target website users an attacker would require knowledge of user email addresses {==(see section XREFUSERENUM)==} and this would also require an element of social engineering for a successful phishing attack. {==IF HTML injection==} Due to the fact that an attacker can fully control the HTML layout of the generated email, the likelihood of such an attack succeeding would be higher. {==IF URL Injection only==} Exploiting this issue would be difficult, as injecting {==arbitrary URLs and text==} will break the logical flow of the email and the email may look suspicious to the victim.
#### Recommendation
Encode all fields when displaying them in any manner, including email and web pages. Review user input validation for data entered into automated emails, in order to ensure that entered values are realistic, within required constraints, and only allow acceptable characters.

Please note that modern email clients convert domain names and IP addresses into hyperlinks, therefore it is important that validation is in place, and ensure that it is consistent and blocks potentially dangerous inputs, such as domain names.

{==OPTION==} Additionally, consider using an effective CAPTCHA mechanism (see section {==XREF==}).
