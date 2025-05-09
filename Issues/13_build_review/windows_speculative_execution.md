---
category: "CNF"
cvss: "6.5"
---
### Windows Speculative Execution
The sampled hosts are not utilising security settings that may protect against a category of currently known Windows attacks, called "speculative execution side-channel attacks". These attacks target the CPU hardware rather than the Windows operating system itself, and affect many modern processors including Intel, AMD, VIA, and ARM.

The sample hosts are not fully secured against this vulnerability due to the following insecure registry key configurations:

{==XREF==}

{==OPTION==}Note that this issue was identified by means of an automated vulnerability scanner, and due to time constraints was not confirmed by manual testing.
#### Impact: Medium
Successful exploitation can lead to compromise of the hosts, depending on the attack and attack vector.
#### Likelihood: Medium
Some speculative execution attacks have been simplified to the point of being exploitable via JavaScript in a webpage. A degree of social engineering may be required to get a user to run a malicious program or visit a malicious website.
#### Recommendation
The current Microsoft recommendations for the related registry settings are described in the following articles:

[https://support.microsoft.com/en-us/topic/kb4457951-windows-guidance-to-protect-against-speculative-execution-side-channel-vulnerabilities-ae9b7bcd-e8e9-7304-2c40-f047a0ab3385]()
[https://support.microsoft.com/en-us/topic/kb4073119-windows-client-guidance-for-it-pros-to-protect-against-silicon-based-microarchitectural-and-speculative-execution-side-channel-vulnerabilities-35820a8a-ae13-1299-88cc-357f104f5b11]()
