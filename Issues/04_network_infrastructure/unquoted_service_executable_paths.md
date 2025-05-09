---
category: "CNF"
cvss: "6.3"
---
### Unquoted Service Executable Paths
The affected system{s||} {was||is} identified as using the indicated unquoted service executable path{s||}. An unquoted service path could be exploited by an attacker in order to escalate privileges. For this attack to work, a system must be running a service, with higher privileges than that of the attacker, and which is launched using a path which contains spaces and is not quoted.

```
PATHTOEXE
```

When a service path with space characters is not quoted, Windows will interpret the path as being any of a number of variations of the path, broken at the space characters, and starting with the root of the file system. This means that when Windows encounters an unquoted path such as the following:

```
C:\Program Files (x86)\Company Name\Service Name.exe
```

Windows will try to execute a service at the following locations in the indicated order:

```
C:\Program.exe
C:\Program Files.exe
C:\Program Files (x86)\Company.exe
C:\Program Files (x86)\Company Name\Service.exe
C:\Program Files (x86)\Company Name\Service Name.exe
```

An attacker, with appropriate privileges, could place an executable payload at any of these locations prior to the genuine service path. When Windows attempts to launch the genuine service, the executable payload will be launched in the context of the genuine service account.
#### Impact: Medium
An attacker could attempt to escalate privileges by launching an executable payload within the context of the original service.
#### Likelihood: Low
In order to exploit this issue an attacker would first need to identify a service with a unquoted executable path, which is launched in the context of a higher privileged account to the attacker. An attacker would also need appropriate permissions to place an executable payload in a location that would be launched in place of the genuine service, and would either need to wait for the service to restart, for example during a system reboot, or forcibly cause the genuine service to restart, for example by causing a denial of service. Note that automated scripts are publicly available to identify and exploit this issue.
#### Recommendation
Review the configuration for the service executable paths listed above, and any others where path names contain spaces, and ensure that the paths are delimited using double-quotes at the beginning and end of the path string, indicating to Windows that the string should be treated as a single path. {==OPTION==} This may require liaising with the software vendors.
