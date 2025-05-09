---
category: "CNF"
cvss: "N/A"
---
### Services Do Not Use Chroot Jails
The user-facing {services below do|SERVICENAME service does} not make use of chroot jailing to isolate the processes from the rest of the operating system. Chroot jails provide the processes running inside them with a limited view of the filesystem, so that only the files specifically required for the process are accessible. This provides an additional layer of security that must be bypassed in the event of an attacker compromising the service{s||}.

```
$ sudo ls -l /proc/$(pidof -s {==SERVICE==})/root
{==OUTPUT==}
```
#### Impact: Medium
The lack of chroot jails means that if an attacker can exploit a vulnerability in the service{s||}, they will gain access to the root filesystem of the server, which could potentially allow them to access sensitive information (see section {==XREFCleartextPasswords==}), and to escalate their privileges.
#### Likelihood: Low
An attacker would need to exploit a vulnerability in the server software in order to exploit this issue. {==OPTION==} Additionally, virtualisation is used to provide isolation between different services on the network.
#### Recommendation
Consider running the services inside chroot jails. The following documentation contains further details about configuring this with {==SERVICENAME==}:

{==LINK==}
