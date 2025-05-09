---
category: "APP-DAT"
cvss: "4.3"
---
### Sensitive Data in Local Storage
The affected website{s||} store{s||} {==the API authorisation token in local storage==}, making it accessible through JavaScript, as shown below.

```
>>> localStorage
{==VALUES==}
```

This means that an attacker who is able to exploit any cross-site scripting vulnerabilities (see section {==XREF XSS==}) or otherwise gain access to the browser's local storage, is able to read this information.
#### Impact: Medium
An attacker successfully exploiting any cross-site scripting issues may be able to {==hijack an administrator's API token, allowing them to perform actions as an administrator on the website{s||}==}.
#### Likelihood: Low
An attacker needs to successfully exploit a cross-site scripting flaw in the website{s||}, or otherwise gain access to the browser's local storage.
#### Recommendation
Consider storing {==the token==} as a cookie with the "HttpOnly" flag set so that it cannot be accessed using JavaScript. Additionally, the "secure" flag should be set on this cookie so that it will not be sent over plain text HTTP connections, and the "SameSite" attribute should be set to "Strict" in order to prevent cross-origin information leakage.

{==OPTION ASP.NET==} More information on these flags, as well as how to set them in ASP.NET is available from the following URLs:

[https://msdn.microsoft.com/en-gb/library/system.web.httpcookie.httponly]()
[https://msdn.microsoft.com/en-gb/library/system.web.httpcookie.secure]()
[https://docs.microsoft.com/en-us/dotnet/api/system.web.httpcookie.samesite]()
[https://learn.microsoft.com/en-us/previous-versions/dotnet/netframework-4.0/ms228262(v=vs.100)]()

{==OPTION PHP==} More information on these flags, as well as how to set them in PHP is available from the following URLs:

[https://secure.php.net/manual/en/session.configuration.php#ini.session.cookie-httponly]()
[https://secure.php.net/manual/en/session.configuration.php#ini.session.cookie-secure]()
[https://www.php.net/manual/en/session.configuration.php#ini.session.cookie-samesite]()
[https://secure.php.net/manual/en/function.setcookie.php]()

If this is not possible, then consider storing sensitive information in session storage rather than local storage so that it is not available after the page session ends. More information on session storage can be found at the URL below:

[https://developer.mozilla.org/en-US/docs/Web/API/Window/sessionStorage]()

Note that if the API token is stored in a cookie, this may expose the website to cross-site request forgery. The application will therefore need to restrict sensitive actions to POST methods and add a hidden key field to forms that validate requests. The hidden key should be unique to the page request and validated on post back. Please see the following OWASP link for more information.

[https://owasp.org/www-community/attacks/csrf]()