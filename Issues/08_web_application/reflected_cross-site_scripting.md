---
category: "APP-XSS"
cvss: "6.1"
report_on_external_network_test: true
---
### Reflected Cross-Site Scripting
Web pages on the affected website{s||} are vulnerable to reflected cross-site scripting. This allows a user's session to be hijacked or allows an attacker to take control of the user's browser.

For reflected cross-site scripting to be exploited by an attacker, a victim needs to visit a specially crafted link created by the attacker, for example sent to the victim in an email. The table below lists pages found with vulnerable fields. A proof of concept example follows this. Note that other pages may be vulnerable that are not listed below.

Page
Fields
{==RELATIVEURL==}
{==LISTOFFIELDS==}

{==Describe a realistic attacking scenario - alert box should only be used where limitations are in place.
Can you actually target other users? For self XSS, how can you deliver a practical attack against other users?==}

Further details on the risks related to cross-site scripting can be found at the following URL:

[https://www.dionach.com/blog/the-real-impact-of-cross-site-scripting]()
#### Impact: High
{==(Option: Please verify that session cookie is not HTTPOnly and that you can hijack session. Otherwise say that you can take control of victim's browser)==} {==IFLOGIN==} An attacker can leverage this vulnerability to steal session cookies and hijack users' accounts to perform arbitrary actions on their behalf, or {==access their personal details==}. This can also lead to further attacks such as creating fake login portals to harvest users' credentials, or drive-by download attacks for obtaining access to users' systems. {==ETC==}. There is an impact on the organisation's reputation if this flaw is publicised or if a client has personal information exposed as a result of this flaw. Phishers and other attackers may also try to target the organisation's staff with this flaw to get personal information or internal access.
#### Likelihood: Medium
Cross-site scripting is a well-known flaw that is being widely used in phishing attacks. It requires an element of social engineering.{==Mention if the victim needs to be authenticated. Also XREF to CSRF for delivering payloads in POST requests.==}
#### Recommendation
Encode all fields when displaying them in the web browser. {==OPTIONdotnet==} Encoding can be done by using the ASP.NET "HttpServerUtility.HtmlEncode()" method. {==OPTIONphp==} Encoding can be done using the PHP "htmlentities()" function. {==OPTIONjsp==} Encoding can be done using the "<c:out>" JSTL tag. {==OPTIONClassicASP==} Encoding can be done by using the "Server.HTMLEncode()" method. This should be done for all information that is returned from the user's browser and output to a web page. See the following OWASP link for more information:

[https://cheatsheetseries.owasp.org/cheatsheets/Cross_Site_Scripting_Prevention_Cheat_Sheet.html]()

Note that there are many ways to exploit cross-site scripting, as shown by the XSS filter evasion cheat sheet at the following URL:

[https://cheatsheetseries.owasp.org/cheatsheets/XSS_Filter_Evasion_Cheat_Sheet.html]()

{==OPTIONBlindXSS==}Note that cross-site scripting payloads may be reflected in other components, applications or sections of the website that were not part of the scope of this engagement, such as internal administrative panels.
