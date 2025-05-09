---
category: "TBA"
cvss: "TBA"
---
### SMS Multi-Factor Authentication in Use
The service at {==URL==} is configured to SMS multi-factor authentication (MFA) as part of the {==LOGIN||UPDATE==} process, which is known to have several security related weaknesses.

Flaws in the SMS authentication process are being actively exploited by attackers in an attempt to gain access to victim's verification codes. Attacks include compromising the Signalling System 7 (SS7) communications protocol used by mobile networks, which provides the attacker with the ability to intercept or spoof SMS messages, and "SIM swap" attacks that attempt to take over the SIM holder's account, allowing the attacker to receive SMS messages intended for the victim.

Exploitation of either of these vulnerabilities can result in the interception of SMS verification codes, which may allow an attacker to bypass MFA protection and perform unauthorised actions on behalf of the user.

Further information regarding the weaknesses of using SMS as a MFA mechanism is available at the following URL:

[https://www.ncsc.gov.uk/guidance/protecting-sms-messages-used-in-critical-business-processes]()
#### Impact: Medium
An attacker that is able to intercept or obtain SMS verification codes, or otherwise compromise the SMS verification process could potentially bypass the protections offered by MFA, allowing the attacker to {access to the victims account || perform sensitive actions on behalf of the victim}, potentially leading to full compromise of the {==CLIENT==} system.
#### Likelihood: Low
While the flaws in SMS verification are relatively well known, their exploitation is not trivial. An attacker would need to be technically proficient and sufficiently motivated to attack {==CLIENT==} users in this way{==, and a lack of immediate financial reward is likely to deter most attacks==}. An attacker would also need to have obtained a valid username and password for the target account or have bypassed the initial authentication stage in order to exploit the weaknesses in the SMS verification process.
#### Recommendation
Consider implementing and allowing users to choose stronger MFA mechanisms, such as those provides by an authenticator app, instead of SMS. These stronger mechanisms should be enabled by default, with a warning notifying the user of the associated risks should then decide to use SMS. Examples of third-party authenticator apps include Google Authenticator, Duo and Microsoft Authenticator, and some password managers such as LastPass also offer a similar service.

{==OPTION==} Alternatively, if MFA is only required for {==CLIENT==} staff, consider issuing hardware tokens to users instead of SMS verification codes.
