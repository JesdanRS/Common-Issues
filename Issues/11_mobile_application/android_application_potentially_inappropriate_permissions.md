---
category: "MOB-ATZ"
cvss: "N/A"
---
### Android Application Potentially Inappropriate Permissions
{==NOTE The risk level depends on what kind and how many permissions it asks for, adjust accordingly ==}
The {==AppName==} Android app requires a number of permissions for installation, most of which seem to be required. However, the following permissions may not be mandatory in order for the application to function properly:

{==CODIFY Permissions==}
#### Impact: Medium
Unnecessary permissions could widen the attack surface, and Android users will be less inclined to trust the app due to the extra permissions required.
#### Likelihood: Low
Users are unlikely to stop using the application due to this issue. Note that these permissions may be required, and therefore this may be a false positive.
#### Recommendation
Consider reviewing the Android application, and amending its manifest file ("AndroidManifest.xml") to only request the permissions specifically required. Please see the following link for further information:

[https://developer.android.com/privacy-and-security/security-tips#Permissions]()