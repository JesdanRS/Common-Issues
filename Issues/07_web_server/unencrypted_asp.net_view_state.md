---
category: "APP-DAT"
cvss: "5.3"
---
### Unencrypted ASP.NET View State
View State is not encrypted on the affected website{s||} listed above. The "ViewState" hidden field is used for state management between page posts in ASP.NET. It is unencrypted by default in that it is just encoded using Base64. Sensitive information or information useful to an attacker may be found in the View State field.

{==OPTION ViewState Mac and Encryption disabled==}Additionally, an attacker may be able to tamper with the ViewState in order to obtain remote code execution on the server running the website. {==OPTION ViewState MAC and/or Encryption enabled==}Additionally, an attacker who is able to obtain the Machine Key may be able to tamper with the ViewState in order to obtain remote code execution on the server running the website.
#### Impact: Medium
No sensitive information could be found, and if information is disclosed it will more than likely be system information. However, an attacker who is able to obtain the Machine Key may be able to execute arbitrary commands on the server running the website.
#### Likelihood: Low
No system or sensitive information was found in encoded View State fields and so it is unlikely that it will be disclosed in future software amendments.
#### Recommendation
Consider implementing ASP.NET View State encryption. Note that this may have an impact on performance. Please visit the link below for more information.

{==ASP.NET 2.0==}
[https://docs.microsoft.com/en-us/previous-versions/dotnet/articles/aa479501(v=msdn.10)]()

{==ASP.NET 3.5==}
[https://docs.microsoft.com/en-us/previous-versions/dotnet/netframework-3.0/ms178199(v=vs.85)]()
