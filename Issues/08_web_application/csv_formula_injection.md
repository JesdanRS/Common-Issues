---
category: "APP-INJ"
cvss: "4.7"
report_on_external_network_test: true
---
### CSV Formula Injection
The {forms at the URLs below allow||form at the URL below allows} users to inject CSV formulas in {their||its} fields, as shown:

{==SCREENSHOT==}

{==Administrators==} can then export the form data, including the injected content, into a CSV file using the functionality at the following URL:

{==URL==}

If the user opens the file in Microsoft Excel, the file will issue an operating system command to {==open the Windows calculator==}, as shown below:

{==SCREENSHOT==}

Please note that currently supported Excel versions will run the command only if Dynamic Data Exchange (DDE) security has been reduced. For more information on changes to DDE security, see the following advisory:

[https://docs.microsoft.com/en-gb/security-updates/securityadvisories/2017/4053440]()
#### Impact: Medium
{==OPTION (increase impact if mass targeting other users is possible)==} An attacker could target website users by injecting malicious CSV formulas into the form{s||} above. This could be used to spread malware or harvest sensitive information, which would affect {==CLIENTNAME==} reputation. {==OPTION (increase impact if the export is used by client staff)==} If an attacker is able to compromise an administrator's workstation with this attack, it could allow them to gain a foothold on the {==CLIENTNAME==} internal network.
#### Likelihood: Low
This attack involves an element of social engineering, as the victim would need to accept a number of security warnings in order for the exploit to succeed. However, as the exported CSV file originates from the {==WEBSITE NAME==} website, it is likely that the victim would trust the content within the exported file and ignore any security warnings.

Additionally, the victim would need to have an old or insecurely configured version of Microsoft Excel or similar software installed in order for the exploit to run. Note that antivirus or certain workstation configurations may prevent malicious payloads from running even if a user has accepted all security warnings.
#### Recommendation
Validate the data entered into form fields using server-side controls {==XREF INSUFFICIENT DATA VALIDATION==}. If possible, use an allowlisting approach to allow only necessary characters. At a minimum, ensure that user supplied input does not begin with one of the following symbols:

 * At (@)
 * Equals (=)
 * Minus (-)
 * Plus (+)

Further information about this attack can be found at the following URL:

[https://owasp.org/www-community/attacks/CSV_Injection]()
