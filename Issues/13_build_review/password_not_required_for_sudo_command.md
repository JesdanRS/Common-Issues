---
category: "PWD"
cvss: "7"
---
### Password Not Required for Sudo Command
The sudo configuration on {==HOSTNAME==} has overly permissive entries that allow specific users to run any system command as root without providing the user's password. An example is shown below:

/etc/sudoers.d/USER
```
USER ALL=(ALL) NOPASSWD: /usr/bin/COMMAND
```
#### Impact: High
If an account is compromised an attacker can easily escalate their privileges and take complete control of the server. This would allow an attacker to access sensitive resources on {==HOSTNAME==}.
#### Likelihood: Low
The attacker would need to have obtained access to {==HOSTNAME==}.
#### Recommendation
Ensure that users are required to enter their password when executing commands via sudo. Also, consider applying granular permissions to specific commands, rather than permitting "ALL=(ALL)". Ensure that binaries with known privilege escalation techniques are not permitted, such as "/bin/su", "/usr/bin/vim" or "/usr/sbin/tcpdump". Please refer to the following page for the full list:

[https://gtfobins.github.io]()

Finally, ensure that regular auditing of security group membership and user access rights is undertaken to prevent inappropriate permissions from being granted to user accounts. Please refer to the following NCSC guidelines for further information:

[https://www.ncsc.gov.uk/guidance/10-steps-managing-user-privileges]()
