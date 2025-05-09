---
category: "APP-CNF"
cvss: "N/A"
---
### HTTP Response Splitting
The affected website is vulnerable to HTTP response splitting. This is an indirect attack that allows arbitrary web content to be shown to a victim in the context of the website. This is done by adding custom headers to amend and split the responses. For this to be exploited by an attacker, a victim needs to visit a specially crafted link created by the attacker, for example sent to the victim in an email.

An example URL is as follows:

{==URLwithHeaders==}

The response shows the fake headers inserted:

```
{==Response==}
```

Further information relating to this vulnerability can be found at the following links:

[https://www.owasp.org/index.php/HTTP_Response_Splitting]()
#### Impact: High
This can be used to either mount a cross-site scripting attack, or a web cache poisoning attack.
#### Likelihood: Low
This vulnerability would be difficult to exploit and would require an amount of expertise.
#### Recommendation
Sanitize all user supplied data or properly encode output in HTTP headers that would otherwise be visible to users in order to prevent the injection of carriage return sequences.