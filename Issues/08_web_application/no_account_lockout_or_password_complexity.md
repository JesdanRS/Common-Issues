---
category: "APP-ATH"
cvss: "N/A"
---
### No Account Lockout or Password Complexity
During testing, there was no evidence of account lockout following {==NUMBER==} login failures. In addition, password complexity is not enforced beyond a minimum of {==NUMBER==} characters. This combination leaves the web application susceptible to brute force attacks.

{==LOGINLINKS==}

{==OPTION==} Additionally, password complexity was seen to be enforced using client-side controls only. This could allow users of the website to set a weak password upon registration, if they have JavaScript support disabled in their browser.
#### Impact: Medium
A successful brute force attack will lead to the exposure of personal details.
#### Likelihood: Medium
An attacker will require knowledge of user names {==OPTION: which is possible due to the user enumeration issue (see section XREF).==} Users will also need to use weak passwords such as dictionary words or common names.
#### Recommendation
Lock out accounts for a short period of time, say 30 minutes, if the account has multiple login failures, such as 5 in a row. Alternatively, use a strong CAPTCHA mechanism such as Google reCAPTCHA {==OPTION (see section XREFFunctionalityInsufficientlyProtectedfromAutomatedAttacks)==}, after a certain number of login failures. Assign a failure count to the user record rather than the user's session.

Enforce passwords which are sufficiently long and complex for the sensitivity of the data protected. OWASP's recommendations for password complexity can be found at the following URL.

[https://cheatsheetseries.owasp.org/cheatsheets/Authentication_Cheat_Sheet.html#implement-proper-password-strength-controls]()

Consider relaxing complexity rules if the password is deemed to be of sufficient length, enabling users to use long memorable pass-phrases as passwords.

{==OPTION==} Finally, ensure that passwords are validated using server-side controls.
