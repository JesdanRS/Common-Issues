---
category: "PRC"
cvss: "6.8"
---
### Workstations Left Unlocked and Unattended
During testing, a number of workstations were observed to be unlocked and unattended, including in {==AREAS==}.

{==PHOTO==}

{==OPTION==} Please note that automatic lock of systems was not seen implemented (see section {==XREFNoAutomaticWorkstationLocking==}).

{==OPTION==} Please note that while workstations were configured to lock automatically, this only occurred after {==NUMBER==} minutes.
#### Impact: Medium
The confidentiality and integrity of any data accessed by an unlocked workstation cannot be guaranteed. Accountability and non-repudiation would be impossible as there is no way to ensure that a given action was actually taken by the recorded user account.
#### Likelihood: Medium
The majority of staff appeared to lock their workstations when leaving them unattended. {==OPTION==} The layout of the offices makes it unlikely that such an attack would go unnoticed, thus decreasing the likelihood of unattended workstations being compromised.
#### Recommendation
Implement, and test, automatic locking of unattended workstations. This can be achieved through Group Policy by forcing the screensaver to activate after a specified time and password protecting the screensaver. Additionally, ensure that all staff are aware of the process (Windows key+L) to lock a workstation, and that user education is performed to encourage them to do so.
