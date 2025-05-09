---
category: "MOB-DST"
cvss: "9.8"
---
### Android Application Contains Hardcoded Credentials
{==NOTE: This issue has to be adjusted for access tokens, encryption or API keys or any other sensitive information discovered. Risk levels have to be adjusted depending on how sensitive the info is.==}
The Android application{s were|| was} found to store hardcoded credentials in plain text in the source code. This can be seen below.

{==FIXME CODIFY/CLASS PATH==}

Please note that other sensitive information may be present in the source code that is not listed above.
#### Impact: High
An attacker obtaining access to these credentials {==could be able to connect on other XREF_CLIENT's services==}. Additionally, password reuse is very common across organisations.
#### Likelihood: Medium
It is relatively easy for a determined attacker to decompile the Android application{||s} and search for hardcoded credentials in the source code.
#### Recommendation
Avoid storing hardcoded credentials or other sensitive information in the application{s'||'s} source code if possible.

{==OPTION (Depends on Android API they target)==} If the {==key==} has to be stored locally, consider storing it in the system Keystore. The following links provide further details:

[https://developer.android.com/reference/android/security/keystore/KeyGenParameterSpec]()
[https://source.android.com/security/keystore/]()

Additionally, consider obfuscating the source code of the application{||s} (see section {== XREF==}).
