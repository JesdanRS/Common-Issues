---
category: "UPD"
cvss: "4.7"
---
### Dell OpenManage URL Redirection
A vulnerability in the Dell OpenManage web administration portal, which allows attackers to redirect the user to any URL they wish, was detected on the affected system{s||} listed above. This issue is known to affect Dell OpenManage versions earlier than "6.2", as detailed in the following link:

[https://www.securityfocus.com/bid/40247]()

A user could be tricked into clicking a specially crafted URL which redirects them to a fake Dell OpenManage login page. Submitted user credentials could then be captured, and the user returned to the real server without realising that anything unusual had occurred.

The link below demonstrates this vulnerability by redirecting a {==CLIENTNAME==} Dell OpenManage user to the Dionach website.

{==URL?file=https://www.dionach.com==}

An attacker could try to mask the full content of the URL by putting the link in an email in the following format:

{==MASKED URL==}
#### Impact: High
Users' credentials could be captured without them realising. As domain usernames and passwords are used to access Dell OpenManage, this could lead to further compromise of other systems.
#### Likelihood: Low
A malicious user would need to be motivated to target {==CLIENTNAME==} with this vulnerability. Also, an element of social engineering would be required.
#### Recommendation
Consider upgrading Dell OpenManage to the latest version, or disabling it if it is not specifically required. Additionally, consider filtering access to it by allowing only trusted IP address.
