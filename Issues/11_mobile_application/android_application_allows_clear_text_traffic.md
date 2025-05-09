---
category: "TBA"
cvss: "TBA"
---
### Android Application Allows Clear Text Traffic
The Android application allowed the use of clear text traffic, as described in the manifest file:

AndroidManifest.xml
{==Part of the file where android:usesCleartextTraffic="true" ==}

{==OPTION==} Note that although the application manifest allows the use of clear-text traffic, all communication with {==the API server==} was seen to be performed using HTTPS.
#### Impact: Medium
An attacker might be able to intercept and tamper with the application traffic, which might allow an attacker to perform further attacks, such as {==displaying arbitrary text to the victim==}.
#### Likelihood: Low
An attacker would need to perform a man-in-the middle attack.
#### Recommendation
Consider disabling clear-text traffic. This can be done by setting the "android:usesCleartextTraffic" attribute to "false" in the application's manifest file ("AndroidManifest.xml").