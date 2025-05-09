---
category: "UPD"
cvss: "TBC"
---
### Old Version of HP iLO Firmware
The affected system{s||} {are|| is} running an old version of the HP Integrated Lights Out (iLO) management firmware {==VERSION==}, whereas the latest version of HP iLO firmware is {==VERSION==}. The version in use is known to have a critical security flaw ({==CVE-2017-12542==}), that can lead to a full compromise of the controller, as demonstrated further below.

{==HOSTS==}

It was possible to exploit this vulnerability in order to add the user {==USERNAME==} as an administrator to the controller using a publicly available script, as shown below:

{==POC==}

Further details regarding this attack can be found at the following URL:

[https://cve.mitre.org/cgi-bin/cvename.cgi?name=CVE-2017-12542]()
#### Impact: High
An attacker can leverage this vulnerability to fully compromise the device{s listed||} above. This could be used in order to launch further attacks against the server, such as attempting to access the host operating system through the remote console or causing a denial of service.
#### Likelihood: High
The version information would be easily identified on the web interface of the device and public scanning tools would identify this issue. Additionally, exploit code is publicly available, which can be used to reliably exploit this vulnerability.
#### Recommendation
Update the HP iLO firmware to the latest supported version. Further information is available at the following URL:

[https://support.hpe.com/hpsc/doc/public/display?docId=hpesbhf03769en_us]()
