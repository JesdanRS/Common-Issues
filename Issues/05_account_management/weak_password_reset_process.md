---
category: "{==APP-ATH/PRC==}"
cvss: "N/A"
---
### Weak Password Reset Process
During the penetration test, a number of support calls were heard where a user was requesting that their password was reset. Although the calls were primarily being made over the internal phone system, there did not appear to be any process to verify the identify of the user. {==OPTION==} Due to the size of the organisation, it is unlikely that the member of the IT team would recognise the users over the phone.

{==OPTION==} Additionally, the password given to these users was not randomly generated, and was seen to be very weak ("P******1"). It is not known whether the user accounts were marked to require a password change on login, however the following three user accounts were seen to have this default password:

{==LIST_OF_ACCOUNTS==}
#### Impact: Medium
An external attacker may be able to obtain valid credentials on the network by phoning IT support and requesting a forgotten password. Additionally, internal users may be able to hijack the accounts of other users. {==OPTION==} As the default password given to the users was very weak, it may be guessed or brute-forced by an attacker, potentially allowing them to compromise other users' accounts.
#### Likelihood: Medium
Social engineering attacks are increasingly common, and {==CLIENTNAME's multiple physical locations increase the likelihood of a successful telephone-based attack.==}
#### Recommendation
Review the procedures around remote users requesting forgotten passwords, and ensure that their identity is appropriately verified before their password is reset. {==OPTION==} When a password is reset, it should be set to a strong and unique password that the user is required to change on first login.
