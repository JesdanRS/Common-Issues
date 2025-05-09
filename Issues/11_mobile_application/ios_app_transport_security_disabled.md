---
category: "MOB-COM"
cvss: "2.9"
---
### iOS App Transport Security Disabled
The App Transport Security (ATS) was seen to be disabled on the iOS application. The "NSAllowsArbitraryLoads" policy is set to "true" in the application's Info.plist file, meaning that ATS is disabled, as shown below.

/private/var/containers/Bundle/Application/{==UUID==}/{==APPNAME==}/Info.plist
```
<dict>
  <key>
  NSAllowsArbitraryLoads
  </key>
  <true/>
<dict>
```

ATS was introduced in iOS version 9.0 and allows mobile application developers to implement a network security policy for their apps on the client side by preventing the use of clear text protocols, invalid self-signed certificates for TLS connections, and weak cipher suites.

Further information about ATS can be found at the following URLs:

[https://developer.apple.com/library/archive/documentation/General/Reference/InfoPlistKeyReference/Articles/CocoaKeys.html#//apple_ref/doc/uid/TP40009251-SW35]()
[https://books.nowsecure.com/secure-mobile-development/en/ios/implement-app-transport-security.html]()
#### Impact: Medium
An attacker would be able to intercept sensitive information and use it to perform further attacks such as hijacking users' sessions. This would impact {==CLIENTNAME==}'s reputation if attackers were able to exploit this issue.
#### Likelihood: Low
This configuration would be very difficult to exploit. An attacker must be on the same network as the victim and perform a man-in-the-middle attack.
#### Recommendation
Enforce ATS by setting the "NSAllowsArbitraryLoads" key to NO. For iOS 9.0 "NSExceptionAllowsInsecureHTTPLoads" or "NSThirdPartyExceptionAllowsInsecureHTTPLoads" keys can be used to make exceptions for any domain where TLS cannot be enforced. Apple originally planned to require that all apps submitted to the App Store support ATS in January 2017, however, they have extended the deadline but have not yet announced a date.

For more information on how to configure ATS configuration please refer to the links listed above.
