---
category: "APP-DAT"
cvss: "5.4"
---
### Website Pages Load Mixed Content
Pages on the affected website{s||} attempt{s||} to load content over HTTP from the sources listed below, even though the {websites are||website is} being accessed over HTTPS.

{==Sources==}
#### Impact: Medium
An attacker performing a Man in the Middle (MitM) attack may be able to intercept or tamper with content requested over HTTP. Additionally, users with modern browsers will be shown a security warning as a result of a page loaded over HTTPS attempting to load content over HTTP, and some modern browsers will refuse to load the insecure resources.
#### Likelihood: Low
An attacker will need to be on the same local network as a user accessing the website{s||} to intercept sensitive information, and the attack requires an amount of specialist knowledge. Many browsers are blocking HTTP content on HTTPS sites, so usability issues will become more common for users. However, users can choose to ignore the browser's normal behaviour and allow insecure content to be loaded.
#### Recommendation
Ensure that all content included in HTTPS pages comes from HTTPS sources. Note that omitting the protocol and prefixing a link with a double slash, as is done in the example below, will use the protocol currently in use by the page.

{==//example.com==}