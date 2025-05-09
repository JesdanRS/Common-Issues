---
category: "MOB-DST"
cvss: "2.9"
---
### Insecure Shared Preferences Credentials Storage
The Android {applications were||application was} found to store sensitive information insecurely in the shared preferences folder on the device. Information such as {==username and password==} is stored in clear-text in the {==FILE PATH==} file, as shown below:

{==PoC==}
#### Impact: Medium
{==OPTION: consider amending impact depending how sensitive the application is==}
An attacker can extract sensitive information from the device {==and hijack user accounts==}.
#### Likelihood: Low
Privileged access is needed on the device in order to access this file {==(see section XREF_no_root)==}. Additionally an attacker would need to be very motivated to target application users with this vulnerability.
#### Recommendation
Avoid storing credentials locally. If this is not possible, consider storing them securely in an encrypted SQLite database. One available solution is SQLCipher, which provides encryption for database files. More information can be found at the following links:

[https://www.zetetic.net/sqlcipher]()
[https://www.zetetic.net/sqlcipher/open-source]()

Alternatively, if passwords need to be stored in the shared preferences file, consider encrypting them with a key and decrypting them when needed on run time. Please note that if the key would be stored in the source code, an attacker will be able to retrieve that by decompiling the APK. To securely store the keys, consider using the Android Keystore system introduced in Android API level 18:

[https://developer.android.com/training/articles/keystore.html]()
