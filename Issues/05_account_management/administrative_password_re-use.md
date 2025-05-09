---
category: "PWD"
cvss: "TBC"
---
### Administrative Password Re-Use
Variations on the same password were seen to be used in a number of locations.

These included the following:

 * {==A domain account which was a member of the privileged "Administrators" domain security group==}
 * {==The local "Administrator" account on several of the systems tested==}
 * {==A SQL Server Login==}
 * {==Network infrastructure devices==}

{==OPTION==} Discussion with IT staff indicated that variants of this password had been used for a number of years at {==CLIENTNAME==}.

{==Please note that in many cases these passwords were seen to be relatively weak, as discussed in issues XREF, XREF and XREF.==}

{==OPTION==} Note that the password for the local Administrator account was also shared between multiple systems, as discussed in section {==XREFLocalAdministratorPasswordReuse==}.
#### Impact: High
An attacker guessing or obtaining the password from any of these locations could potentially compromise other user accounts or {==CLIENTNAME==} resources.
#### Likelihood: Medium
Testing an obtained password on multiple systems or user accounts is a common attack strategy. {==OPTION==} Additionally, as the password has been in use for a long time then it is likely to be known by people who no longer work at {==CLIENTNAME==}.
#### Recommendation
Avoid using the same password for multiple user accounts and systems where possible, particularly if any of these accounts are granted privileged access to systems or resources.
