---
category: "MOB-PLF"
cvss: "2.9"
---
### Android Application Allows Backups
A user with physical access to the device where the Android application is installed can create a backup of the application's private data directory, which includes application files{==, such as databases and shared preferences==}.

This can be done by utilising Android Debug Bridge's (ADB) backup feature. The database can then be downloaded for offline processing, as shown below:

{==SCREENSHOT==}
#### Impact: Medium
An attacker gaining access to the application's {==sensitive files, such as XREF==} would be able to read sensitive data, such as {==credentials and personal user details==}.
#### Likelihood: Low
An attacker would need to have physical access to the device, to be able to unlock it and connect to it with ADB. This could also depend on other factors, such as the device having the Android USB debugging enabled.
#### Recommendation
Consider disallowing backups through ADB. This can be done by setting the "android:allowBackup" attribute to "false" in the application's manifest file ("AndroidManifest.xml").

Note that this attribute is set to "true" by default and has to be explicitly set to "false" to prevent backups.

Please also note that a sufficiently motivated attacker with physical access to the victim device would be able to root the device and obtain access to every application's private data directory.