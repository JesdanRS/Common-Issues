---
category: "MOB-PLF"
cvss: "N/A"
---
### Android Application Insecure Signing
The Android application is signed using a v1 signature scheme, making it vulnerable to the Janus vulnerability (CVE-2017-13156) on Android versions 5.1.1 to 8.0, inclusive, which would allow an attacker to tamper with the APK without invalidating its signature. It is possible to verify the signing scheme by using a tool such as "apksigner", as shown below:

apksigner verify -v {==appname.apk==}
{==CODEBLOCK==}
#### Impact: Medium
An attacker would be able to tamper with the APK without invalidating the signature, which would allow them to add malicious code to the legitimate {==APPNAME==} application.
#### Likelihood: Low
The victim would need to install a malicious version of the application; therefore an element of social engineering would be required.
#### Recommendation
Consider using only a secure v2 scheme, as discussed in the following article:

[https://source.android.com/docs/security/features/apksigning/v2]()

Please note that this will prevent the application from being installed on versions of Android below 7.0.

In order to change the signature algorithm, it could be necessary changing the API level supported by the application. Please refer to the following article for further information:

[https://developer.android.com/reference/java/security/Signature]()
