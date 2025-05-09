---
category: "MOB-COM"
cvss: "1.8"
---
### iOS HTTP Response Caching Data Leakage
iOS applications often use "UIWebView" objects to render the HTML content of websites. The "UIWebView" object automatically caches server responses to the local file system. This cached data can be found in the "Cache.db" database, located within the application's "Library/Caches/" folder, as shown below.

{==(This can be seen in the following proof of concept example...)==}

{==XREF Cache.db PATH==}
{==XREF SCREENSHOTS==}
#### Impact: High
An attacker gaining access to these or other unencrypted databases, would be able to retrieve sensitive information {==such as...==}. The integrity and confidentiality of the data stored in the application could be compromised. {==Talk specifically about this case if possible==}
#### Likelihood: Low
An attacker would need to first gain root access {==OPTION (see section XREF)==} to a lost or stolen device in order to be able to exploit this issue.
#### Recommendation
For HTTP response caching, several strategies allow developers to clear the application's cache or prevent it from caching, although the implementation will vary depending on the design of the application.

The URLCache class object can be used to remove all cached responses as shown below:

```
URLCache.shared.removeAllCachedResponses()
```

Please refer to the official documentation below for further information about this object:

[https://developer.apple.com/documentation/foundation/urlcache]()