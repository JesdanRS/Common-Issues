---
category: "APP-INJ"
cvss: "TBC"
---
### Insufficient Input Validation and Sanitisation
Pages on the affected website{s||} appear{s||} to allow almost any characters to be entered in {their||its} form fields and submitted.

{==URL+SCREENSHOT==}

{==OPTION UNENCODED CHARS==} Note that {==some of==} these characters were seen not to be encoded, as shown below:

{==POC==}

In some cases, this can lead to serious web application security flaws such as SQL injection or cross-site scripting {==OPTION==} (see section {==XREF==}) {==OPTION==}; however, such flaws were not identified during testing.
#### Impact: Medium
Lack of input validation and sanitisation can lead to serious injection-based security flaws with which attackers can attempt to harvest sensitive information or perform social engineering attacks against website users. {==OPTION==} Additionally, the validity of information collected by these forms cannot be guaranteed, which could affect supporting business processes which rely upon the information.
#### Likelihood: Low
This issue is straightforward to identify by injecting special characters into form fields and examining the website{s'||'s} responses. Lack of sanitisation would encourage attackers to look for further vulnerabilities {==OPTION==}; however, none were identified during testing.
#### Recommendation
Ensure that form data is appropriately validated using server-side scripts so that input submitted and processed is safe and expected. Consider using an allowlist-based approach to ensure that only required characters are allowed and that any special characters are encoded before being sent back from the server. For more information on validating input, please see the following:

[https://cheatsheetseries.owasp.org/cheatsheets/Input_Validation_Cheat_Sheet.html]()
