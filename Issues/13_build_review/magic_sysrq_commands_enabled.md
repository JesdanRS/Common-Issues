---
category: "CNF"
cvss: "2.1"
---
### Magic SysRq Commands Enabled
Linux provides a number of keyboard shortcuts to perform low-level operating system actions, which can be accessed by pressing the Ctrl, Alt and SysRq (or in the case of a laptop, printscreen) keys, in combination with a specific letter. These can be used to perform actions such as remounting the filesystem as read only, killing processes, or causing an immediate reboot or crash of the system.

A full list of functionality can be found in the following article, {==OPTION==} although some of these commands are disabled in Debian by default.

[https://www.kernel.org/doc/html/v4.15/admin-guide/sysrq.html#what-are-the-command-keys]()
#### Impact: Medium
An attacker can perform unintended actions on the system, such as killing the graphical X11 server. {==OPTION==} However, it did not appear to be possible to use these to gain further access to the system.
#### Likelihood: Low
While the magic SysRq keys are well known, there is no obvious path to exploit them.
#### Recommendation
Ensure that magic SysRq keys are disabled with the following sysctl options:

```
kernel.sysrq = 0
```
