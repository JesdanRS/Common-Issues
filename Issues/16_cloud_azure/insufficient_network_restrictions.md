---
category: "NET"
cvss: "4.3"
---
### Insufficient Network Restrictions
The following resources do not enforce network restrictions and as such allow full access from the public Internet:

| Type | Name |
| ---- | ---- |
| {==TYPE==} | {==NAME==} |

An example is shown below for the "{==NAME==}" {==TYPE==}:

{==SCREENSHOT OF NETWORK SETTINGS==}
#### Impact: High
An attacker may be able to access these resources from the Internet and so access or modify any data stored within them.
#### Likelihood: Low
The above resources all enforce access control and therefore an attacker would first require credentials in order to access any of the above resources.
#### Recommendation
Ensure that all resources that are not intended to have public access enforce appropriate network restrictions. Network level access should only be granted from addresses which specifically require access to the resource, particularly for extremely sensitive services, such as {==TYPE==}.
