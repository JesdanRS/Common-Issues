---
category: "MOB-REV"
cvss: "2.4"
---
### Android Application Code Not Obfuscated
The {==XREFAppName==} Android application is compiled in such a way that the code is not obfuscated. As a result, an attacker can decompile the Android application package (APK) file and retrieve the application source code. Sensitive information such as {==cryptographic keys, web services, API keys and tokens==} can be identified. Additionally, an attacker can read the application's source code and potentially alter its functionality {==(see section XREF-NoTamperingDetection)==}.

{==The following example shows a snippet of code extracted from the XREF Java class. ==}
{==XREF CODIFY(or SCREENSHOT)==}
{==NOTE If they store lots of sensitive stuff, the likelihood should be increased and adjusted keeping the issue independent==}
#### Impact: Medium
Application source code is revealed. An attacker could identify sensitive information such as {==API keys of supporting systems used by the app==}. Additionally, an attacker could modify the app to bypass protections and various client side controls. Finally, reading the application's code would allow an attacker, looking to exploit further vulnerabilities, to gain a better understanding of how it works. {==OPTION==} This could also lead to intellectual property theft, such as a competitor stealing parts of the application's source code.
#### Likelihood: Low
Decompiling an application is relatively easy to achieve using publicly available tools, however an attacker would have to be motivated to target {==CLIENTNAME==}'s' application in this manner and search for sensitive information. {==Additionally, no evident sensitive information was found after reviewing the source code.==}
#### Recommendation
Consider using tools that obfuscate the Android source code. The following article discusses a number of protection mechanisms which can be implemented on an Android application to deter attackers from tampering with it:

[https://www.dionach.com/blog/android-binary-protection-methods]()

Please note that obfuscation tools increase the difficulty of comprehending the obfuscated code, however they do not prevent a determined and skilled attacker from reverse engineering the application.