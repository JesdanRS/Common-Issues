---
category: "MOB-CRP"
cvss: "1.6"
---
### Unencrypted iOS Cached Screenshots
{==NOTE: Depending on the nature of the app and info on the screenshots adjust risk levels from informational to medium==}
In order to provide the visual transitions in its interface, iOS captures and stores snapshots as images, which are stored in the local file system. This occurs when an application is suspended (rather than terminated), either by pressing the home button, making a phone call or when another event occurs suspending the application. These images often contain user and application data, as shown in the example below, where an attacker can gain access to {==sensitive data such as credit cards, passwords, address==}.

{==XREF SCREENSHOT PATH && SCREENSHOT==}
#### Impact: High
A malicious user gaining access to these cached images may be able to obtain access to {==sensitive data such as credit cards, passwords, address==}.
#### Likelihood: Low
An attacker would need to have root access to local files on a stolen or lost device in order to be able to exploit this issue.
#### Recommendation
Overlay an image, for example a blurry screen, as the application enters the background state. The overlaid image will "mask" the current screen, thus covering any sensitive information that may be on screen. This can be done by overriding the "applicationDidEnterBackground" method. Please refer to the following article for more information:

[https://developer.apple.com/library/archive/qa/qa1838/_index.html]()