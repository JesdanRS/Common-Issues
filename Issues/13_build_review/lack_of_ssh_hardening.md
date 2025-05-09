---
category: "CNF"
cvss: "N/A"
---
### Lack of SSH Hardening
A review of the SSH configuration files on the affected server{s||} indicated that {they had||it has} not been hardened in accordance with industry best practices.

The service{s are|| is} not configured to require 2-factor authentication (see section {==XREFSingleFactorAuth==}). Additionally, a number of other security best practices were not seen to be in place, such as:

 * Blocking logins with the root account.
 * Blocking SSH port forwarding.
 * Blocking X11 forwarding.
 * Logging actions performed through SFTP.
 * Logging SSH key fingerprints when users authenticate.
 * Disabling weak encryption algorithms (see section {==XREFWeakSSHEncryption==})
#### Impact: Medium
The lack of hardening could allow aid an attacker in targeting other systems, and could hamper incident response and detection.
#### Likelihood: Low
An attacker would need to be authenticated to exploit the majority of these issues.
#### Recommendation
Where possible, harden the SSH server configuration in line with industry best practices, as outlined in the Mozilla guidance below:

[https://infosec.mozilla.org/guidelines/openssh.html#configuration]()
