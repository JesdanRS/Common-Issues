---
category: "MOB-PLF"
cvss: "N/A"
---
### Potentially Insufficient WebView Hardening
The mobile application{s were||was} seen to be using the WebView component to process web pages. Analysis of the source code revealed that the following features may be unnecessary, increasing the attack surface of the application{s||}:

 * {==OPTION JavaScript is enabled==}
 * {==OPTION Support for plugins is enabled==}
 * {==OPTION File system access is enabled==}
 * {==OPTION OTHER_ISSUES==}
#### Impact: Medium
The lack of WebView security features can potentially allow an attacker to exploit further vulnerabilities, {==OPTION==}such as cross-site scripting on rendered web pages or accessing sensitive content on the device.
#### Likelihood: Low
An attacker would need to be very motivated and highly skilled in order to exploit any of these misconfigurations. Additionally, certain conditions would have to be met for this to be exploitable. {==OPTION==}During testing, these configurations did not appear to be in use.
#### Recommendation
{==OPTION==}If JavaScript is not required, consider disabling it by using the following code:

```webview.getWebSettings().setJavaScriptEnabled(false);```

{==OPTION==}Browser plugin support can be disabled using the following code:

```webView.getWebSettings().setPluginState(WebSettings.PluginState.OFF);```

{==OPTION==}Local file access can be disabled using the following code:

```webview.getWebSettings().setAllowFileAccess(false);```

For more information please refer to the following URL:

[https://developer.android.com/reference/android/webkit/WebSettings]()