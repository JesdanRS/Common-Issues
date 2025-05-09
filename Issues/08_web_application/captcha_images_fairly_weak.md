---
category: "APP-ATH"
cvss: "5.3"
---
### CAPTCHA Images Fairly Weak
The images used for the implemented CAPTCHA mechanism will not prevent more advanced automated OCR techniques. There are commercial tools available for breaking CAPTCHA images. Example images are as follows:

{==IMAGES==}
#### Impact: Medium
{==An attacker will be able to carry out denial of service attacks and send spam by sending multiple emails through the website.==}
#### Likelihood: Low
An attacker would need to be motivated to attack {==CLIENTNAME==} in this manner.
#### Recommendation
Consider implementing a stronger CAPTCHA mechanism. One solution is Google's reCAPTCHA. For more information, please see the following URLs:

[https://www.owasp.org/index.php/Testing_for_Captcha_(OWASP-AT-012)]()
[https://developers.google.com/recaptcha/docs/v3]()

Note that, while strong CAPTCHA mechanisms serve as a deterrent to denial of service attacks, determined attackers can still automate the solving of CAPTCHAs by employing sophisticated techniques or by paying CAPTCHA-solving services.
