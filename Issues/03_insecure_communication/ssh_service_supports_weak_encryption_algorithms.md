---
category: "{==APP-CRY/CRY==}"
cvss: "5.3"
generation:
  getIssueContext: |
    let issueContextMap = new Map();
    issueGeneration.nessus.helpers
      .getReportItemsForPluginIds("70658", "71049", "90317", "153953", "10882", "187315")
      .map((x) => ({
        ...x,
        cbc: x.reportItem.getAttribute("pluginID") === "70658",
        mac: x.reportItem.getAttribute("pluginID") === "71049",
        arcfour: x.reportItem.getAttribute("pluginID") === "90317",
        dhe: x.reportItem.getAttribute("pluginID") === "153953",
        v1: x.reportItem.getAttribute("pluginID") === "10882",
        terrapin: x.reportItem.getAttribute("pluginID") === "187315",
      }))
      .filter((x) => Object.values(x).some((x) => x === true))
      .forEach((x) => {
        if (issueContextMap.has(x.serviceName)) {
          Object.keys(issueContextMap.get(x.serviceName)).forEach(
            (key) =>
              (issueContextMap.get(x.serviceName)[key] =
                issueContextMap.get(x.serviceName)[key] || x[key])
          );
        } else {
          issueContextMap.set(x.serviceName, x);
        }
      });
    return [...issueContextMap.entries()]
      .map((x) => x[1])
      .sort((a, b) => a.serviceName.localeCompare(b.serviceName));
  getAffectedSystems: |
    return [...new Set(issueContext.map((x) => x.hostName))].sort((a, b) =>
      a.localeCompare(b)
    );
  getPlaceholderContent: |
    return [
      "| Service | CBC Ciphers | Weak MAC Algorithms | ArcFour | Weak DHE Keys | SSHv1 | Terrapin |",
      "| -- | -- | -- | -- | -- | -- | -- |",
      [
        ...issueContext.map(
          (x) =>
            `| ${x.serviceName} | ${x.cbc ? "X" : ""} | ${x.mac ? "X" : ""} | ${
              x.arcfour ? "X" : ""
            } | ${x.dhe ? "X" : ""} | ${x.v1 ? "X" : ""} | ${x.terrapin ? "X" : ""} |`
        ),
      ].join("\n"),
    ].join("\n");
---
### SSH Service Supports Weak Encryption Algorithms
The Secure Shell (SSH) service available on TCP port 22 of the affected system{s support|| supports} connections made using weak encryption algorithms.

{==PLACEHOLDER==}

| Service | CBC Ciphers | Weak MAC Algorithms | ArcFour | Weak DHE Keys | SSHv1 |
| HOSTNAME | | | | | |

{==OPTION==} There are a number of known weaknesses in CBC ciphers that may allow an attacker to recover plaintext data from encrypted communications. The following advisory provides more information about this issue:

[https://www.openssh.com/txt/cbc.adv]()

{==OPTION==} MD5-based or 96 bit MAC algorithms are considered to be cryptographically weak.

{==OPTION==} The ArcFour cipher (better known as RC4) has a number of widely publicised cryptographic weaknesses.

{==OPTION==} There are a number of cryptographic weaknesses with SSH version 1, as discussed in the following articles:

[https://www.kb.cert.org/vuls/id/13877]()
[https://www.kb.cert.org/vuls/id/315308]()
[https://www.kb.cert.org/vuls/id/684820]()

{==OPTION==} There are a number of documented weaknesses associated with using small Diffie-Hellman moduli. For more information, please see the following URL:

[https://weakdh.org]()

{==OPTION==} SSH servers supporting ChaCha20-Poly1305 or CBC with Encrypt-then-MAC algorithms may be vulnerable to the "Terrapin" attack (CVE-2023-48795), which could allow an attacker performing a man-in-the-middle attack to bypass integrity checks and downgrade connection security. Further information is available at the following URL:

[https://terrapin-attack.com]()
#### Impact: Medium
An attacker could decrypt communications, commands and any transmitted authentication details.
#### Likelihood: Low
This vulnerability would be very difficult to exploit.
#### Recommendation
{==OPTION==} Configure the SSH server to only use secure cipher suites, using modern algorithms and modes such as AES in GCM or CTR mode, in line with the best practices outlined in the following article:

[https://infosec.mozilla.org/guidelines/openssh#modern-openssh-67]()

{==OPTION==} Configure the server to require the use of SSHv2, which is not affected by these weaknesses.

{==OPTION Linux==} For most Linux distributions, the default configuration file is "/etc/ssh/sshd_config", for which the following option will configure the service to accept version 2 only:

```
Protocol 2
```

{==OPTION_WEAK_DHE==} Either enforce the use of Elliptic Curve DHE, or generate strong DHE keys, as discussed in the following article:

[https://weakdh.org/sysadmin.html#openssh]()

{==OPTION Cisco==} For Cisco devices, the following commands can be used to harden the SSH service:

```
ssh version 2
ssh cipher encryption high
ssh cipher integrity high
ssh key-exchange group dh-group14-sha1
```
