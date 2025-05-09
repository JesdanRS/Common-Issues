---
category: "PRC"
cvss: "8"
---
### Staff Vulnerable to Credential Harvesting
A fake website, shown below, was created in order to manipulate {==CLIENTNAME==} staff into disclosing their credentials through a specially crafted login form. {==CLIENTNAME==} staff were manipulated into visiting this website through a carefully targeted spear-phishing email campaign. Targets were identified as being potentially vulnerable as a result of having clicked on hidden links within initial phishing emails (see section {==XREFStaffVulnerableToPhishing==}).

{==LOGIN PAGE SCREENSHOT==}

An example of the spear-phishing email is shown below:

{==PHISHING EMAIL==}

Of the {==NUMBER==} people identified as being potentially vulnerable, {==NUMBER==} ({==PERCENT==}%) responded to the spear-phishing email, with {==NUMBER==} visits identified. This suggests that some people attempted to visit the website multiple times. {==NUMBER==} ({==PERCENT==}% of those visiting ({==PERCENT==}% of those initially targeted) submitted credentials to the website, {==OPTION ==}although {==NUMBER==} of these were identified as being invalid. {==OPTION ==}A complete breakdown of the credentials obtained is shown in Appendix {==B==}. {==OPTION==} Please note that Dionach did not attempt to verify the credentials, at {==CLIENTNAME==}'s request.
#### Impact: High
An attacker successfully targeting {==CLIENTNAME==} staff through a targeted spear-phishing attack could get access to {==CLIENTNAME==} credentials. These credentials could then be used to launch attacks against other {==CLIENTNAME==} systems, such as web applications or VPN connections. Additionally, {==CLIENTNAME==} staff may reuse the same passwords on other non-{== CLIENTNAME==} accounts, such as personal email or social media sites, which could also be compromised as a result of this issue.
#### Likelihood: High
Valid credentials which grant access to internal systems is the ultimate goal of any client-side or social engineering attack. These attacks are performed regularly, and have a high success rate. {==OPTION==} Additionally, public sector organisations, particularly councils, are high priority targets due to the potential for access to other public sector systems or personal data, which can be used for identity theft.
#### Recommendation
Ensure that {==CLIENTNAME==} staff are trained in how to spot potential phishing and faked websites, particularly those intended to harvest credentials. Ensure that {==CLIENTNAME==} staff never enter credentials into a website unless it is trusted, well-known, and presents a digital certificate signed by a verified certification authority (CA).
