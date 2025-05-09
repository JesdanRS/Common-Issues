---
category: "{==APP-DAT/NET==}"
cvss: "6.5"
generation:
  getIssueContext: |
    let issueContext = new Map();
    [...issueGeneration.nessus.context.querySelectorAll("ReportItem")]
      .map((x) => {
        return {
          name: issueGeneration.nessus.helpers.getServiceNameFromReportItem(x),
          reportItem: x,
          weakKey:
            x.hasAttribute("pluginID") &&
            x.getAttribute("pluginID") === "69551",
          weakHash:
            x.hasAttribute("pluginID") &&
            x.getAttribute("pluginID") === "35291",
          untrusted:
            x.hasAttribute("pluginID") &&
            x.getAttribute("pluginID") === "51192" &&
            x
              .querySelector("plugin_output")
              .firstChild.textContent.indexOf("unknown") > -1,
          expired:
            x.hasAttribute("pluginID") &&
            x.getAttribute("pluginID") === "51192" &&
            x
              .querySelector("plugin_output")
              .firstChild.textContent.indexOf("expired") > -1,
        };
      })
      .filter((x) => Object.values(x).some((x) => x === true))
      .forEach((x) => {
        if (issueContext.has(x.name)) {
          Object.keys(issueContext.get(x.name)).forEach(
            (key) =>
              (issueContext.get(x.name)[key] =
                issueContext.get(x.name)[key] || x[key])
          );
        } else {
          issueContext.set(x.name, x);
        }
      });
      return issueContext;
  getAffectedSystems: |
    return [...issueContext]
      .map((x) => x[1])
      .map((x) =>
        issueGeneration.nessus.helpers.getHostNameFromReportHost(
          x.reportItem.parentNode
        )
      );
  getPlaceholderContent: |
    return [
      "| Service | Weak Private Key | Weak Hashing Algorithm | Not Signed by Trusted CA | Certificate Expired |",
      "| -- | -- | -- | -- | -- |",
      [
        ...[...issueContext]
          .map((x) => x[1])
          .map(
            (x) =>
              `| ${x.name} | ${x.weakKey ? "X" : ""} |  ${x.weakHash ? "X" : ""} |  ${x.untrusted ? "X" : ""} |  ${x.expired ? "X" : ""} |`
          ),
      ].join("\n"),
    ].join("\n");
---
### Insecure Digital Certificates
The SSL certificate{s provided by the services below are|| provided by the service below is} insecure. The following table shows the associated vulnerabilities.

{==PLACEHOLDER==}

| Service | Weak Private Key | Weak Hashing Algorithm | Not Signed by Trusted CA | Certificate Expired |
| 1.2.3.4:995 | | | | |
| https://example.org | | | | |
#### Impact: Medium
{==IF_EITHER_WEAK==} An attacker may be able to derive the private key used to produce {these certificates||this certificate} in order to spoof the service{s||}.
{==IF_SIGNED_OR_EXPIRED==} Users will encounter certificate warnings when accessing {these services||this service}. Prolonged exposure to certificate warnings may encourage users to disregard legitimate warnings, for example if an attacker was performing a man in the middle attack with a spoofed certificate.
#### Likelihood: Low
{==IF_EITHER_WEAK==} Deriving the private key would require significant computational resources. A determined attacker may be able to construct an apparently valid SSL certificate, however they would still need to perform a man-in-the-middle attack in order to utilise it.
{==IF_SIGNED_OR_EXPIRED==} An attacker would have to perform a man in the middle attack with a spoofed certificate to exploit certificate trust issues.
#### Recommendation
{==IF_EITHER_WEAK==} Ensure that SSL certificates are securely generated using a key that is at least 2048 bits in length and is generated using a secure hashing algorithm such as SHA256.
{==IF_SIGNED_OR_EXPIRED==} Ensure that all services use digital certificates that are valid and are signed by a trusted certificate authority.

Replace the affected certificate{s with ones that meet|| with one that meets} industry best practices, as outlined in the following article:

[https://github.com/ssllabs/research/wiki/SSL-and-TLS-Deployment-Best-Practices]()
