---
category: "MOB-PLF"
cvss: "N/A"
---
### Android Application Debugging Enabled
The Android application permits debugging through an Android Debug Bridge (ADB) connection, as specified in its manifest file:

AndroidManifest.xml
{==XREF_CodifySnipper==}

This would allow an attacker to inspect and step through the application's code during execution in a controlled manner.

{==OPTION==}Please note that this is most likely enabled due to the application being under development.
#### Impact: Low
While no obviously sensitive information was exposed during testing as a result of this behaviour, debugging of a mobile application can lead to attackers bypassing security restrictions or forcing the application to behave in certain ways that it was not designed to.
#### Likelihood: Medium
This setting is straightforward to identify by inspecting the application's manifest file ("AndroidManifest.xml") file or by using freely available Android security assessment tools.
#### Recommendation
Disable application debugging as discussed in the following article:

[https://developer.android.com/studio/publish/preparing]()

Ensure all production applications have any debugging mechanisms disabled before they are released.
