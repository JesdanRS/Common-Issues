---
category: "APP-ATH"
cvss: "5.4"
---
### Sensitive Information in HTTP GET Request
{==Authentication details/OAuth token/CSRF token/session identifiers==} for the affected websites{s||} are submitted as part of a GET request, which means that they form part of a URL's query string. This means the information will be recorded in web logs and browser histories.

{==XREF_URL_EXAMPLES==}

The following page provides more information:

[https://cwe.mitre.org/data/definitions/598.html]()
#### Impact: High
{==Authentication details==} will be stored in web logs and browser histories and as such, exposed to non-website users.
#### Likelihood: Low
Obtaining these details would require access to web logs or browser histories.{==OPTION==} URLs may be passed through Referers to other websites.{==OPTION OAuth IF NOT SHORT-LIVED AND SINGLE USE==} The authorisation code in the request can be re-used once the user has accessed the URL.
#### Recommendation
Submit sensitive information as part of a POST request {==OPTION IF HTTP==} and enforce encrypted communications over HTTPS (see section {==XREF==}).{==OPTION OAuth==} See the following RFC for OAuth 2.0 authentication requirements:

[https://www.rfc-editor.org/rfc/rfc6749.html#section-3.2]()
