---
category: "MOB-QAL"
cvss: "TBC"
---
### Android Application Unprotected Exported Components
{==NOTE: Adapt this issue accordingly, depending on what you can do the risk could be from informational to high! Also note the components will have to be exposed explicitly, otherwise only root can interact with them==}

The {==AppName==} Android app defines a number of components, such as {==OPTION: Activities, Content Providers, Broadcast Receivers, Services==}, which are not protected. This means that an attacker, or a malicious application, can interact with these components. The affected components are listed below{==, and a proof of concept follows==}.

{==CODIFY components in sections. Give a proof of concept of what an attacker could do==}
#### Impact: Medium
An attacker that is able to interact with {==this component || these components==} could {==abuse this to aid in various attacks, such as bypassing application controls, against the application or other users==}.
#### Likelihood: Medium
It is straightforward for an attacker to identify unprotected application components by manually inspecting the manifest file ("AndroidManifest.xml"), or by using automated tools.
#### Recommendation
Ensure that the app reduces its exported application components down to the essentials, by for instance only exporting the main activity. This exposure level can most of the times be achieved unless the app must offer integration with other mobile apps.

{==OPTION==} If this is not possible, define permission elements by setting the "android:protectionLevel" attribute to "signature" or "signatureOrSystem". Assign these permissions to the defined components by using the "android:permission" attribute. The following articles provide further information:

[https://developer.android.com/guide/topics/manifest/activity-element]()
{==Find Links related to the components==}

Please note that the root user {==(see section XREF-Root-Detection)==} will still be able to interact with protected application components.
