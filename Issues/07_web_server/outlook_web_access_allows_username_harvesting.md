---
category: "APP-CNF"
cvss: "5.3"
report_on_external_network_test: true
---
### Outlook Web Access Allows Username Harvesting
The Outlook Web Access (OWA) page at {==URL==} reveals whether usernames exist within Active Directory (AD) based on response times. An attacker can therefore guess or brute force a series of accounts to enumerate valid user accounts, which could subsequently be used in a brute force or password spraying attack, for example against this or other online portals.

When a login to OWA is performed through the page above, the following POST request is sent to the server.

{==Truncated POST request==}

When a username is valid, the server is able to quickly determine that the supplied password is incorrect. However, when a username is not valid, it takes significantly longer for the server to respond. By observing this difference in response time, it is possible to determine whether an account exists within the AD.

The following image shows the difference in response time in milliseconds between a login request for valid accounts such as {==example valid account==}, and invalid or disabled accounts such as {==example invalid account==}.

{==Screenshot clearly showing response time for valid/invalid account==}

The following valid domain usernames were discovered:

{==Table of usernames==}

Note that employee names that were used during testing were obtained from public sources such as LinkedIn{==OPTION: and the public employee directory found on the website at URL==}. An attacker would typically attempt to convert these into valid domain names by trying different common formats such as "firstname.lastname".
#### Impact: Medium
An attacker can extract multiple usernames, and then use them to attempt brute force attacks against any external AD integrated authentication portals such as Outlook Web Access. An attacker may also use account names to mount a phishing attack. If users use weak passwords, it could give an attacker access to their emails, as well as providing an initial foothold into the network. Additionally, an attacker could use this account to launch phishing campaigns which would appear to originate from an internal email account.
#### Likelihood: Medium
An attacker can use an automated attack tool to run a brute-force or dictionary attack against the Outlook Web Access page to find valid domain usernames. Additionally, many names can be found on public websites such as LinkedIn.
#### Recommendation
Currently, Microsoft has no plans to address this issue. Perform a risk assessment to determine whether the potential to enumerate valid usernames is a risk accepted by the organisation. Note that Office 365 cloud hosted versions of the application do not currently suffer from this issue.

Monitor the Outlook Web Access portal for multiple failed login attempts and password spraying activity.

Additionally, ensure that externally exposed services such as Outlook Web Access make use of multi-factor authentication, that there is a strong password policy, and that outbound SMB traffic on port 445 is blocked.

{==OPTION:==} Consider removing or restricting employee directories that are publicly available, as these are a useful source for attackers launching social engineering and password guessing attacks.

{==OPTION IF metadata:==} Analyse any documents that are publicly available that may expose unnecessary information through metadata. Furthermore, implement a policy to strip metadata from any documents that are going to be made available publicly.