---
category: "{==APP-CRY/CRY==}"
cvss: "5.3"
generation:
  getIssueContext: |
    let issueContext = new Map();
    [...issueGeneration.nessus.context.querySelectorAll("ReportItem")]
      .map((x) => {
        return {
          name: issueGeneration.nessus.helpers.getServiceNameFromReportItem(x),
          reportItem: x,
          sslv2:
            x.hasAttribute("pluginID") &&
            x.getAttribute("pluginID") === "56984" &&
            x
              .querySelector("plugin_output")
              .firstChild.textContent.indexOf("SSLv2") > -1,
          sslv3:
            x.hasAttribute("pluginID") &&
            x.getAttribute("pluginID") === "56984" &&
            x
              .querySelector("plugin_output")
              .firstChild.textContent.indexOf("SSLv3") > -1,
          tlsv10:
            x.hasAttribute("pluginID") &&
            x.getAttribute("pluginID") === "56984" &&
            x
              .querySelector("plugin_output")
              .firstChild.textContent.indexOf("TLSv1.0") > -1,
          tlsv11:
            x.hasAttribute("pluginID") &&
            x.getAttribute("pluginID") === "56984" &&
            x
              .querySelector("plugin_output")
              .firstChild.textContent.indexOf("TLSv1.1") > -1,
          cbc:
            x.hasAttribute("pluginID") &&
            x.getAttribute("pluginID") === "70544" &&
            (x
              .querySelector("plugin_output")
              .firstChild.textContent.indexOf("Low Strength Ciphers") > -1 ||
            x
              .querySelector("plugin_output")
              .firstChild.textContent.indexOf("Medium Strength Ciphers") > -1),
          rc4: x.hasAttribute("pluginID") && x.getAttribute("pluginID") === "65821",
          dhe: x.hasAttribute("pluginID") && x.getAttribute("pluginID") === "83875",
          export:
            x.hasAttribute("pluginID") && x.getAttribute("pluginID") === "81606",
          anon:
            x.hasAttribute("pluginID") && x.getAttribute("pluginID") === "31705",
          null:
            x.hasAttribute("pluginID") && x.getAttribute("pluginID") === "66848",
          compression:
            x.hasAttribute("pluginID") && x.getAttribute("pluginID") === "62565",
          gzip: false, // todo
          deflate: false, // todo
          fallbackscsv: false, // todo
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
      "| Service | SSL 2.0 | SSL 3.0 | TLS 1.0 | TLS 1.1 | CBC | RC4 | Weak DHE | Export | Anonymous | Null | Compression | gzip | Deflate | Fallback SCSV |",
      "| -- | -- | -- | -- | -- | -- | -- | -- | -- | -- | -- | -- | -- | -- | -- |",
      [
        ...[...issueContext]
          .map((x) => x[1])
          .map(
            (x) =>
              `| ${x.name} | ${x.sslv2 ? "X" : ""} | ${x.sslv3 ? "X" : ""} | ${
                x.tlsv10 ? "X" : ""
              } | ${x.tlsv11 ? "X" : ""} | ${x.cbc ? "X" : ""} | ${
                x.rc4 ? "X" : ""
              } | ${x.dhe ? "X" : ""} | ${x.export ? "X" : ""} | ${
                x.anon ? "X" : ""
              } | ${x.null ? "X" : ""} | ${x.compression ? "X" : ""} | TODO | TODO | TODO |`
          ),
      ].join("\n"),
    ].join("\n");
---
### Insufficient Transport Layer Protection
The service{s below provide|| below provides} insufficient transport layer protection. As a result, an attacker can potentially intercept and decrypt data. Crosses in the table below denote each security weakness, split by insecure protocol, cipher suite, and service configuration:

{==PLACEHOLDER==}

{==Format the text direction of the headers to vertical, so that the words start at the bottom of the cell and end at the top - Also, leave the SERVICES header in the standard direction==}
{==To do this just highilght the cells, right-click, text direction...==}
| Service | SSL 2.0 | SSL 3.0 | TLS 1.0 | TLS 1.1 | Weak CBC | RC4 | Weak DHE |Export | Anonymous | Null | Compression Enabled | GZIP | Deflate | Fallback SCSV Not Supported |
| 1.2.3.4:995 | | | | | | | | | | | | | | |
| https://example.org | | | | | | | | | | | | | | |

{==Complete the table using the references below, depending on the supported protocols, ciphers, and server configuration==}
SSL 2.0       = SSL2.0 SUPPORTED
SSL 3.0       = SSL3.0 SUPPORTED
TLS 1.0       = TLS1.0 SUPPORTED
TLS 1.1       = TLS1.1 SUPPORTED
Weak CBC      = TLS and 64-bit _CBC_ cipher or Any cipher with _DES-CBC3_
RC4           = Any cipher with _RC4_
Weak DHE      = DHE key s <= 1024 bits
Export        = Any cipher with _DHE_EXPORT_ or _RSA_EXPORT_
Anonymous     = Any cipher with _ANON_
Null          = Any cipher with _NULL_
Compression   = TLS and compression enabled
GZIP          = HTTPS and GZIP
Deflate       = HTTPS and deflate
Fallback SCSV = TLS_FALLBACK_SCSV_NOT_SUPPORTED {==OPTION: DO NOT REPORT FOR IIS or ONLY WHEN TLSv1.2 IS SUPPORTED==}

{==OPTION==} Please note that enforcing strong ciphers on some SMTP servers might result in using plaintext communication because the servers do not support the security features required, as indicated in the following RFC:

[https://datatracker.ietf.org/doc/html/rfc7672#section-8.2]()

{==OPTION==} Please note that major browsers, including Chrome, Firefox, Edge, and Safari, have deprecated TLS 1.0 and TLS 1.1. Please refer to the article below for more information:

[https://hacks.mozilla.org/2020/02/its-the-boot-for-tls-1-0-and-tls-1-1]()
#### Impact: Medium
It may be possible to decrypt sensitive traffic that is either sent to or received from {these services||this service}. {==OPTION==} PCI DSS 4.0 does not permit the use of SSL, TLS 1.0, or TLS 1.1 unless additional controls are in place to mitigate the associated vulnerabilities.
#### Likelihood: Low
{These configurations||This configuration} would be very difficult to exploit. An attacker must be on the same network as the victim and perform a man-in-the-middle attack.
#### Recommendation
Review the affected service{s and align their|| and align its} configuration with industry best practices, as outlined in the following article:

[https://github.com/ssllabs/research/wiki/SSL-and-TLS-Deployment-Best-Practices]()

{==OPTIONIIS==} The following URL can be used to generate recommended TLS configuration for IIS servers:

[https://learn.microsoft.com/en-us/dotnet/framework/network-programming/tls]()

{==OPTIONOtherServer==} The following URL can be used to generate recommended TLS configuration for various web servers:

[https://ssl-config.mozilla.org]()

{==OPTIONAzure==} Utilise the Azure encryption options to configure only TLS 1.2  and above. See the following URL for further details:

[https://azure.github.io/AppService/2018/06/13/TLS-Configuration-now-fixed-to-block-1.0.html]()
