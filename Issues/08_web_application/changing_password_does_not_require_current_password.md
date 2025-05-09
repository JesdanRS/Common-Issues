---
category: "APP-ATH"
cvss: "N/A"
---
### Changing Password Does Not Require Current Password
An authenticated user on the {==URL==} website can change their password without entering their current password. {==OPTION==} Additionally, the user is not notified when this action takes place.
#### Impact: High
An attacker gaining temporary access to a victim's account, for example if the victim had left their session active on a shared computer, would be able to change the account's password. {==OPTION==} CSRF attacks can also be used to change user's passwords, and thus compromise their accounts (see section {==XREF==}).
#### Likelihood: Low
An attacker would have to gain access to an authenticated user's session, or exploit another vulnerability in the website.
#### Recommendation
Require the user to enter their current password when changing their password. Consider notifying the user via email when changes are made to their authentication settings.