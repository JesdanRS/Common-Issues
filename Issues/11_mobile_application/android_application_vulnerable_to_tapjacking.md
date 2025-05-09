---
category: "MOB-PLF"
cvss: "1.7"
---
### Android Application Vulnerable to Tapjacking
The Android application is vulnerable to Tapjacking, a vulnerability which allows a malicious application to overlay fake user interface elements over an activity (a single screen) of the vulnerable application, in order to trick the victim into clicking something unintentionally.
{==OPTION (if MWR PoC was used)==}This can be seen in the following proof of concept example, where a "Terms and Conditions" dialog box is placed over the application's {==XREF==} button.
{==SCREENSHOT==}

As a result, an attacker could socially engineer a situation where a victim is directed into unknowingly performing actions on the Android application. For further information about this vulnerability, please refer to the following article:

[https://developer.android.com/privacy-and-security/risks/tapjacking]()
#### Impact: Medium
A user may be manipulated into performing unintended actions on the application, which could potentially lead to sensitive data {==such as XREF==} being exposed, or impact on the accountability of actions performed on the application.
#### Likelihood: Low
This would be difficult to exploit, as apart from requiring an element of social engineering, it would also depend on specific configuration to be in place in the victim's device. This is because newer versions of the Android OS (Operating System) require specific permissions to be granted before allowing overlay elements, and additionally, some vendors have fixed this issue in the Android OS level. An attacker would need to devote time and resources to target the application in this manner.
#### Recommendation
To ensure that performing Tapjacking attacks on sensitive activities of the application is not possible, set the "filterTouchesWhenObscured" attribute to true on sensitive application Views. This can be done programmatically or by setting this value in the layout files of activities.

Please see the following links for further information:

[https://developer.android.com/reference/android/view/View#attr_android:filterTouchesWhenObscured]()
[https://developer.android.com/reference/android/view/View#setFilterTouchesWhenObscured(boolean)]()
