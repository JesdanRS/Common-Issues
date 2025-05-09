---
category: "MAL"
cvss: "3.2"
---
### Use of Removable Media Permitted
{==OPTION==} Although some restrictions were seen to be in place to prevent the use of USB sticks, it was possible to use an alternative device such as a mobile phone to transfer data from the system{s||}. {==OR==} {==OPTION==} There are no restrictions currently in place on the inspected system{s||} to prevent the use of removable media, such as {==USB sticks or mobile phones==}.
#### Impact: Medium
Removable media is a common vector for stealing sensitive data or introducing malware into an internal network.
#### Likelihood: Medium
A number of recent high profile network and data compromises have occurred as a result of uncontrolled use of removable media.
#### Recommendation
Consider restricting access to removable media. This can be done in a number of ways, depending upon the extent to which access must be restricted, including physically disabling removable media ports, or applying software controls. Some system BIOS configurations permit USB ports to be disabled with a BIOS setting. Note that many modern phones present themselves to Windows as a Media Transfer Protocol (MTP) or Picture Transfer Protocol (PTP) device, rather than a mass storage device, and as such may not be blocked by some methods.
