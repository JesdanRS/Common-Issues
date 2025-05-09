---
category: "PRC"
cvss: "4.7"
---
### Passwords and Password Hashes Available Online
Passwords and password hashes of accounts with "{==CLIENTDOMAIN==}" domains in their username were found online, including many indexed by search engines such as Google or Bing. The following information was extracted from publicly accessible documents by utilising the following Google query, as well as browsing subsequent websites:

"{==CLIENTDOMAIN==}" (site:siph0n.net OR site:skidpaste.org OR site:pastebin.com)

Examples of passwords and passwords hashes can be seen below. Note that passwords and password hashes have been masked.

{==URL==}
```
FILE CONTENT
```

Additionally, the email addresses listed below were found to be "compromised", in the sense that they appear in various databases leaked on the Internet, such as those indexed by [https://haveibeenpwned.com](). Leaked databases typically include clear text or hashed passwords, however there is no guarantee the associated password is genuine or still valid. Note that the email addresses below have been used to register on non-organisation owned websites. There is no evidence to suggest the passwords associated with these email addresses are in use for {==CLIENTNAME==} systems.

{==USE HAVEIBEENPWNED API TO RETIREVE LIST OF EMAIL ADDRESSES FOUND IN LEAKS==}
#### Impact: Medium
Usernames, email addresses, passwords, and password hashes are revealed. {==OPTION_IF_CREDS_WORKED==} {==INCREASE TO HIGH==} An attacker can authenticate to {==CLIENTNAME==} systems with the leaked credentials. {==OPTION_IF_NOT_TESTED==} Note that Dionach did not attempt to authenticate to {==CLIENTNAME==} systems with the discovered credentials, it is therefore unknown whether these credentials are valid.
#### Likelihood: High
This information can easily be gathered by means of a carefully crafted Google query or searching well-known websites containing breached databases. {==OPTION_IF_MFA==} {==REDUCE TO MEDIUM==} Dionach were unable to authenticate to {==CLIENTNAME==} systems due to multi factor authentication being enforced.
#### Recommendation
It is nearly impossible to remove this type of information from all sources on the Internet. Instead, ensure that affected users change their passwords immediately. Additionally, monitor password breaches for email addresses which contain organisation specific domains. The "Domain Search" functionality at the following URL provides notifications when matches are found:

[https://haveibeenpwned.com/DomainSearch]()

Consider adding a requirement to a social media or internet usage policy stating {==CLIENTNAME==} usernames and email address shall not be used on third-party websites.

Lastly, ensure all externally facing login portals have multi factor authentication enforced.
