---
category: "BUS"
cvss: "5.8"
report_on_external_network_test: true
---
### Send To Friend Spam Abuse
The send to a friend page allows a website visitor to send an email to an arbitrary email address. This type of function is commonly found to be vulnerable to abuse by spammers. In this case, the fields {==FIELDS allow any text and carriage returns/HTML==} to be inserted that allows the email message to be altered to suit the spammer. An example of a request and resulting email are shown below:

{==FORM POST==}
{==EMAIL==}
#### Impact: Medium
This would impact the reputation of {==COMPANY==}. The mail server may be denylisted by organisations that use services such as the Spamhaus block list. This would prevent emails being successfully delivered that use this mail server, which could be many other websites.
#### Likelihood: High
Spammers continually look for forms that send automated emails to see if they can be abused. This attack is relatively straightforward to implement.
#### Recommendation
Restrict the length of the name field and only allow certain characters, such as alphanumeric characters. Add a CAPTCHA to the send to friend form, one possible solution is Google's reCAPTCHA software, available at the following URL:

[https://www.google.com/recaptcha/intro/index.html]()