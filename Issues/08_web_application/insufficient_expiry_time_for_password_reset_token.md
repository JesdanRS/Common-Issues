---
category: "APP-ATH"
cvss: "3.7"
---
### Insufficient Expiry Time for Password Reset Token
When a user requests a password reset, a token is generated to authorise the request. {==OPTION EXPIRY TIME:==}However, the token is valid for {==24==} hours, which may be excessive as it increases the risk of compromise. {==OPTION NEVER EXPIRE:==}However, the token does not have an expiration date and it is valid until its usage, increasing the risk of compromise.

{==SCREENSHOT_OF_RECEIVED_EMAIL==}
#### Impact: Medium
An attacker obtaining access to a password reset token, for example through physical or remote access to their computer, viewing web server logs, or email account backups, could change the user's password {==OPTION EXPIRY TIME:==}in case they act within the {==24==}-hour period of token validity.{==OPTION NEVER EXPIRE:=}in case the token is still unused.
#### Likelihood: Low
An attacker would need to get physical or logical access to the victim's computer or email account backup.
#### Recommendation
Invalidate the password reset token after an appropriate period, say ten minutes. This should be done using server-side functionality, and not rely on client-side cookies or scripts. Please see the following URL{==s==} for more information:

[https://cheatsheetseries.owasp.org/cheatsheets/Forgot_Password_Cheat_Sheet.html#url-tokens]()
{==OPTION .NET==}[https://learn.microsoft.com/en-us/aspnet/identity/overview/features-api/account-confirmation-and-password-recovery-with-aspnet-identity]()
