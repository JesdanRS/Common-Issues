---
category: "APP-CNF"
cvss: "N/A"
report_on_external_network_test: true
---
### Dynamic Cross Origin Resource Sharing Policy
The affected website{s||} set{||s} a Cross-Origin Resource Sharing (CORS) policy that allows access from any origin. This is because the Access-Control-Allow-Origin header value is generated using the domain from the Origin header, which is set in requests made to the website. This is shown in the website's response when a user visits a Dionach controlled website that makes a request to the URL below:

{==URL==}
```
Access-Control-Allow-Origin: https://www.1dn.eu
Access-Control-Allow-Credentials: true
```

The website's Access-Control-Allow-Origin header allows arbitrary domains to read responses from the website and the Access-Control-Allow-Credentials header allows making these requests in the user's authenticated session. Other websites may be able to access resources from the website{s||} by submitting requests to the website{s||} from a user's browser.

Further information on CORS is available at the following URL:

[https://developer.mozilla.org/en-US/docs/Web/HTTP/CORS]()
#### Impact: High
An attacker could create a phishing site with functionality to make users' browsers communicate with both the attacker's website and the affected website, and capture sensitive information such as {==session refresh tokens, personally identifiable information, and ...==}.
#### Likelihood: Medium
This vulnerability would be quickly identified by inspecting HTTP responses from the application. An element of social engineering would be required for a successful phishing attack.
#### Recommendation
Remove this header if it is not explicitly required, or restrict the allowed origin to a domain allowlist. For more information, please see the following OWASP article:

[https://cheatsheetseries.owasp.org/cheatsheets/HTML5_Security_Cheat_Sheet.html#cross-origin-resource-sharing]()
