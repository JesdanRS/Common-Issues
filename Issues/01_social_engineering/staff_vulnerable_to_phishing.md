---
category: "PRC"
cvss: "8"
---
### Staff Vulnerable to Phishing
{==CLIENTNAME==} staff were targeted in multiple phishing attacks, by Dionach, using email addresses obtained through searching public information resources, such as Google and Bing, {==CLIENTNAME==} websites, and social media services such as Facebook and LinkedIn.

{==OPTION==} Please note that, to enhance the testing, a list of email addresses was also provided to Dionach by {==CLIENTNAME==}. This was used in addition to the emails gathered as part of the initial reconnaissance process.

Specially crafted phishing emails were sent to all of the gathered email addresses. An example of the style of emails sent is shown below.

{==PHISHING EMAIL==}

Each email contained a hyperlink which resolved to a server under Dionach's control, which, when visited executed client-side JavaScript intended to uniquely identify the user, and also to gather information about their workstation.

The initial phishing emails were sent to {==NUMBER==} {==CLIENTNAME==} email addresses. Dionach received {==NUMBER==} successful clicks, from {==NUMBER==} ({==PERCENT==}%) unique sources; {==OPTION==} many responses were from users making multiple attempts to access the hyperlinks. An example of the information obtained is shown below, {==OPTION==} while a comprehensive breakdown of the click behaviour is shown in Appendix {==B==}. Please note that the website was taken down at the end of testing, so any subsequent visits will not be recorded.

Email Address
***.*******@{==CLIENTDOMAIN==}
Date
{==DAY==} {==DATE==} {==TIME==}
IP Address
{==SOURCEIP==}
User Agent
{==FULL USERAGENT==}
Browser
{==BROWSER FULLNAME AND VERSION==}
Operating System
{==BUILD AND VERSION==}
Cookies Enabled
{==TRUE/FALSE==}
System Language
{==en-GB==}
User Language
{==en-GB==}
Flash Enabled
{==YES/NO==}
#### Impact: High
By sending a carefully crafted email, an attacker could potentially socially engineer a target {==CLIENTNAME==} employee into executing malicious code on their local machine or divulging sensitive information. This could then be used to launch other attacks or gain further access to internal systems.
#### Likelihood: Medium
Phishing is a popular attack vector for compromising {==corporate==} networks, and technical measures may be overcome by a sufficiently determined attacker. A number of high profile cases have been reported where organisations or individuals have been successfully targeted using this method of attack.
#### Recommendation
{==CLIENTNAME==} should consider regular information security awareness training for all employees. There should be a particular focus on defending against social engineering and phishing attacks. Consider implementing a system of incident reporting, and instructing {==CLIENTNAME==} staff to report any suspicious emails or telephone calls.
