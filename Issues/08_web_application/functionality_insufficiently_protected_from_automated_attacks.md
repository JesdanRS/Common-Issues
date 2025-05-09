---
category: "APP-ATH"
cvss: "5.3"
---
### Functionality Insufficiently Protected from Automated Attacks
The {==OPTION: Registration/Login/PassReset/Newsletter/ContactUs/SendToFriend pages/forms/API endpoints (UNAUTHENTICATED ENDPOINTS ONLY)==} below {allow||allows} an attacker to make multiple, scripted submissions.

{==OPTION API==}Please note that during the course of testing a rate limiting mechanism did not appear to be in place; however, denial of service and thorough stress tests were not performed.
{==URL==}
#### Impact: Medium
{==OPTION REGISTRATION/CONTACT/SIGNUP FORMS==}An attacker can write a script that will send large number of requests which could overwhelm the {==web application, APIs==} and cause a denial of service. {==OPTION==} The department processing these requests may receive thousands of emails, and not be able to identify and respond to legitimate ones.{==OPTION==} Lack of such protections could aid attackers in exploiting other vulnerabilities in a scripted manner, such as the {==XREF_Example_Issue==}, {==or to conduct a brute force attack against user accounts==}.
#### Likelihood: Low
A simple script or pre-built tool could be used to perform this attack. However, an attacker would need to be motivated to attack {==CLIENTNAME==} in this manner.
#### Recommendation
Review the identified functionality along with current business requirements and implement protections against automated attacks where possible. For web forms or APIs, consider using an effective CAPTCHA mechanism. One possible solution is Google's reCAPTCHA software, available at the following URL:

[https://cloud.google.com/security/products/recaptcha]()

{==OPTION: If APIs==}Alternatively, investigate the possibility of implementing a rate limiting mechanism for this functionality to impede attackers. This should be done with server-side controls and could return a "429 - Too Many Requests" error code, for example.

Finally, note that the suggested protection mechanisms serve as a deterrent and hinder attacks. However, determined attackers can still circumvent those protections{==, for instance by automatically solving CAPTCHAs by employing sophisticated techniques or using CAPTCHA-solving services, or by distributing the generated requests across multiple IPs and proxies.==}
