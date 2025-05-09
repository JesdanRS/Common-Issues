---
category: "PRC"
cvss: "5.8"
---
### Staff Personal Details Exposed on Website
{==Names, email addresses and photographs==} of staff members were found in the following page{s||} on the website:

{==URL==}

While {==no obviously sensitive information==} is exposed, information about staff members is often harvested by attackers preparing for a social engineering attack.
#### Impact: Low
Information of potential use to an attacker planning a social engineering attack is revealed. {==OPTION==} The email addresses themselves provide limited information, however they will be automatically harvested by spammers. They also serve as usernames on some websites. Harvested email addresses can also be used for targeted phishing attacks, and for exploiting any reflected cross-site scripting vulnerabilities on the website {==(see section XREFrxss)==}.
#### Likelihood: Medium
{==OPTION==} {These pages||This page} could be quickly identified by browsing the website. {==OPTION==} Spammers will harvest these email addresses, even if they have been encoded. Attackers will frequently attempt to use email addresses as usernames to authenticate on externally facing systems.
#### Recommendation
Consider removing unnecessary personal information about staff members from the website. Contact email addresses should not include staff members' names; instead consider changing them to generic email addresses based upon role or function. To impede spammers, consider encoding or breaking up any displayed email addresses using JavaScript. The StackOverflow discussion below contains a number of different techniques that can be used. Please note that it may still be possible for spammers to obtain the email addresses, and that the use of these methods may decrease the accessibility of the website.

[https://stackoverflow.com/questions/483212/effective-method-to-hide-email-from-spam-bots]()
