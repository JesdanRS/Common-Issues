---
category: "CNF"
cvss: "N/A"
---
### Mailbox Delegation Enabled
Mailbox delegation allows users to manage other users' mail and calendar on their behalf. Currently, there are {==xx out of yy==} active accounts with mailbox delegation permissions enabled, as shown in the example below:

{==SCREENSHOT==}
#### Impact: Medium
An attacker abusing this issue would be able to gain access to potentially sensitive data belonging to other users.
#### Likelihood: Low
A malicious user would first need to compromise an account that has been configured with access to other mailboxes.
#### Recommendation
Consider disabling this functionality unless strictly required. In the Exchange admin centre (EAC), disallow mailbox delegation for a user by navigating to recipient -> mailboxes. Click on the mailbox that you want to remove delegation for and then click Edit. On the mailbox properties page, click Mailbox Delegation, to remove a permission from a delegate, select the delegate in the list under the appropriate permission, and then click Remove. Alternatively, consider using the "Remove-MailboxPermission" PowerShell cmdlet to remove permissions from a user's mailbox.

Please refer to the following URL for more information:

[https://learn.microsoft.com/en-us/powershell/module/exchange/remove-mailboxpermission?view=exchange-ps]()
