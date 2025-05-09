---
category: "PRV"
cvss: "TBC"
---
### NFS Share Misconfigured
The affected system{s||} expose{s||} a Network File System (NFS) file share which is world readable (readable by "Everyone"). An attacker can mount the NFS share to gain access to any files.

As a proof of concept, it was possible to mount the NFS share and list the files of the {==FOLDERNAME==} folder:

```
mount -t nfs HOST:/Folder /mnt/
```

{==SCREENSHOT_FOLDER_CONTENT==}
#### Impact: Medium
An unauthenticated attacker could access {==documents==} or other sensitive information stored on the NFS share. {==OPTION==} Additionally, they could also modify any information stored within these files or add malicious code.
#### Likelihood: Medium
It is straightforward to identify this configuration.{==OPTION==} No sensitive information was identified on the NFS share.
#### Recommendation
Review whether NFS access to {these systems||this system} is required. If so, apply appropriate access control restrictions at both the file system and host level. To ensure that anonymous access is not permitted, configure the "exports" file and add known, trusted hosts which require access. Ensure that files are not world-readable and writable by any user, and only allow those authorised to access and perform operations against them.

For more information, please refer to the following URL:

[https://access.redhat.com/documentation/en us/red_hat_enterprise_linux/5/html/deployment_guide/s1 nfs security]()
