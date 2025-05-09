---
category: "CNF"
cvss: "N/A"
---
### Insufficient DNS Security Measures
The following DNS protections were not implemented on the affected domain{s||} and could be added to improve security:

* Domain Name System Security Extensions (DNSSEC)
* Certification Authority Authorization (CAA) record

{==OPTION DNSSEC==} DNSSEC is a feature of the Domain Name System that guarantees the integrity of responses retrieved from a DNS server and ensures they have not been tampered with.

{==OPTION CAA==} Implementing a CAA record should limit which Certificate Authorities can issue certificates for the domain{s||} to those mentioned in the record. This provides additional protections from potentially compromised Certificate Authorities, or accidental mis-issuance due to internal or external mistakes.
#### Impact: Medium
Without these protections in place, it may be possible for an attacker to modify DNS requests as they are in transit, or potentially obtain a certificate signed by any trusted Certificate Authority.
#### Likelihood: Low
An attacker would need to have compromised other DNS infrastructure services, positioned  themselves to conduct a man in the middle attack, or have exploited vulnerabilities in the web server leading to remote code execution to exploit either of these weaknesses.
#### Recommendation
Implementing DNSSEC is a two-step process. Ensure the relevant DNS server can serve special records for public keys, signatures, and other records to authenticate the zones' contents. The top-level domain registry must have a "DS" record that authenticates a DNSKEY record in the zone; this requires activating DNSSEC with the domain registrar. Many domain registrars that offer DNS services will provide DNSSEC as an option, most likely in the services control panel. For information regarding implementing DNSSEC on a self-hosted system, please consult the relevant documentation for the software in use.

Similarly, a CAA record can be added either via the DNS provider's control panel, or by adding an entry manually in the DNS servers' configuration.

For more information about DNSSEC and CAA records, please see the following URLs:

{==OPTION DNSSEC==} [https://www.icann.org/resources/pages/dnssec-what-is-it-why-important-2019-03-05-en]()
{==OPTION CAA==} [https://letsencrypt.org/docs/caa/]()
