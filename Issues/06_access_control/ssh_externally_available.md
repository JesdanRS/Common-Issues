---
category: "{==APP-CNF/NET==}"
cvss: "N/A"
---
### SSH Externally Available
The Secure Shell (SSH) service is externally available on the affected system{s||} listed above.
#### Impact: Medium
An attacker guessing or brute-forcing valid credentials may be able to authenticate on the system{s||}, and thus take full administrative control. This could allow them to access sensitive data stored on the system{s||}, and to use {them||it} as a staging platform for further attacks.
#### Likelihood: Low
An attacker would either need to guess, brute force or otherwise obtain valid credentials in order to authenticate. {==OPTION==} It is unknown whether two factor authentication has been implemented using SSH keys.
#### Recommendation
Consider restricting access to {these services||this service} either by allowlisting specific IP addresses that need to connect to {them||it}, or requiring users connect to a VPN before they can access the SSH service{s||}.

Alternatively, consider requiring users authenticate with both SSH keys and passwords, by setting both values in the "AuthenticationMethods" configuration option in OpenSSH, as shown below:

```
AuthenticationMethods "publickey,password" "publickey,keyboard-interactive"
```

See the OpenSSH man pages for further information:

[https://www.openssh.com/manual.html]()

If the above is not feasible consider implementing brute-force protections using a program such as fail2ban, if not already in place. See the following URL for further details:

{==OPTION UBUNTU==} [https://help.ubuntu.com/community/Fail2ban]()

{==OPTION CENTOS==} [https://www.digitalocean.com/community/tutorials/how-to-protect-ssh-with-fail2ban-on-centos-7]()

At a minimum, ensure that accounts able to use the service{s||} are secured with a complex password, which adheres to organisational password policies, and that the service software is kept up to date with the latest security patches.
