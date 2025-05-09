---
category: "APP-ACC"
cvss: "4.3"
---
### Website Uses Predictable IDs
The affected website{s||} use{s||} identifiers (IDs) to locate unique {==objects/fields, such as users and orders==}. These IDs are {==numeric==} and appear to follow a predictable pattern, as they are {==sequential==}:

{==LIST OF IDS==}
#### Impact: Low
An attacker can extract multiple {==user==} IDs, and then use them to launch further attacks against the web application, {==such as using automated scripts to enumerate valid website users==}.
#### Likelihood: Medium
This issue is quickly identifiable by simple inspection of the IDs used by the website{s||}.
#### Recommendation
Consider using random, non-sequential values for {==user|website==} IDs such as a GUID (Globally Unique Identifier). Please note that some GUID versions are based on the timestamp and MAC address of the machine, and as such are not random. The following article provides further information on the various GUID versions:

[https://en.wikipedia.org/wiki/Universally_unique_identifier#Versions]()