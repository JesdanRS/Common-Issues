---
category: "APP-CNF"
cvss: "3.1"
report_on_external_network_test: true
---
### Overly Permissive Content Security Policy
The Content Security Policy (CSP) for the affected website{s||} was seen to be overly permissive. The weaknesses in the current configuration{s||} are:

{==URLs==}
 * {==OPTION unsafe-inline==} Arbitrary inline scripts are permitted (see section {==XREF XSS==})
 * {==OPTION unsafe-eval==} The use of unsafe JavaScript functions such as "eval" and "setTimeout" is allowed
 * {==OPTION dangerous script-src==} A number of domains included in the "script-src" directive host versions of JavaScript libraries known to be vulnerable to DOM-based cross-site scripting, allowing for the CSP to be bypassed
 * {==OPTION missing 'frame-ancestors'==} Website pages may be embedded into other websites, which allows attacks such as clickjacking  {==Check for the directive manually as it is not reported by CSP evaluators such as [https://csp-evaluator.withgoogle.com]()==}
 * {==Other misconfigurations==}

The content security policy header{s are|| is} shown below:

{==CSPs with misconfigurations in bold==}

For more information on content security policies, please see the following URL:

[https://developer.mozilla.org/en-US/docs/Web/HTTP/CSP]()
#### Impact: Medium
The website does not make use of all available protections offered by the CSP header, and as such is more vulnerable to cross-site scripting attacks (see section {==XREF XSS==}). {==OPTION dangerous script-src==} An attacker can potentially import a vulnerable JavaScript library hosted on one of the sites listed in the "script-src" directive and exploit a cross-site scripting vulnerability to bypass the CSP altogether.
#### Likelihood: Low
An attacker would need to exploit an existing flaw in the website in order to take advantage of {these configurations||this configuration}. {==OPTION==}During testing no cross-site scripting vulnerabilities were identified.
#### Recommendation
Consider hardening the current CSP configuration{s||}. If possible, remove the {=="unsafe-inline" and "unsafe-eval"==} directives {==and limit the number of domains permitted to load scripts onto the website==}. {==OPTION missing frame-ancestors==} Use the "frame-ancestors" directive to prevent clickjacking attacks {==OPTION X-Frame-Options header is present==} and remove the "X-Frame-Options" header from HTTP responses as this header is now deprecated. For more information, please see the above URL.
