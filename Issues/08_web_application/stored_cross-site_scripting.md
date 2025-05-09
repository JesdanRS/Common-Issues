---
category: "APP-XSS"
cvss: "6.1"
report_on_external_network_test: true
---
### Stored Cross-Site Scripting
The pages below are vulnerable to stored cross-site scripting. Stored cross-site scripting allows an attacker with access to these pages to enter JavaScript that will later be run in the context of another user's browser. This is an indirect attack that allows the user's session to be hijacked or allows an attacker to take control of a victim's browser. Note that other pages may be vulnerable that are not listed below.

Page
Fields
{==RELATIVEURL==}
{==LISTOFFIELDS==}

{==EXAMPLE WITH SCREENSHOT (document.cookie)==}

Further details on the risks related to cross-site scripting can be found at the following URL:

[https://www.dionach.com/blog/the-real-impact-of-cross-site-scripting]()
#### Impact: High
{==(Option: Please verify that session cookie is not HTTPOnly and that you can hijack session. Otherwise say that you can take control of victim's browser)==} {==IFLOGIN==} An attacker can leverage this vulnerability to steal session cookies and hijack users' accounts to perform arbitrary actions on their behalf, or {==access their personal details==}. This can also lead to further attacks such as creating fake login portals to harvest users' credentials, or drive-by download attacks for obtaining access to users' systems. {==ETC==}. There is an impact on the organisation's reputation if this flaw is publicised or if a client has personal information exposed as a result of this flaw. Phishers and other attackers may also try to target the organisation's staff with this flaw to get personal information or internal access.
#### Likelihood: High
Cross-site scripting is a well-known and widely exploited vulnerability; however this is an indirect attack. {==OPTION==} Only {==ROLE==} users will be able to exploit this vulnerability.
#### Recommendation
Encode all fields when displaying them in the web browser. {==EITHER==} Encoding can be done by using the ASP.NET "HttpServerUtility.HtmlEncode()" method. {==OR==} Encoding can be done using the PHP "htmlentities()" function. {==OR (for JSP)==} Encoding can be done using the "<c:out>" JSTL tag. This should be done for all information that is output to a web page. See the following OWASP link for more information:

[https://cheatsheetseries.owasp.org/cheatsheets/Cross_Site_Scripting_Prevention_Cheat_Sheet.html]()

Note that there are many ways to exploit cross-site scripting, as shown by the XSS filter evasion cheat sheet at the following URL:

[https://cheatsheetseries.owasp.org/cheatsheets/XSS_Filter_Evasion_Cheat_Sheet.html]()

{==OPTIONBlindXSS==}Note that cross-site scripting payloads may be reflected in other components, applications or sections of the website that were not part of the scope of this engagement, such as internal administrative panels.
