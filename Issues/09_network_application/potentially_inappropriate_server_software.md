---
category: "CNF"
cvss: "N/A"
---
### Potentially Inappropriate Server Software
A number of servers within the {==CLIENTNAME==} network were seen to have software installed which did not appear to be required for their function, and may not be appropriate. Examples of the software identified include:

 * {==LIST==}

Please note that the above lists are not exhaustive, and it is possible that other potentially unnecessary software is installed which was not identified during testing.
#### Impact: High
Each of these applications increases the overall potential attack surface area of the servers, as they are all potential targets for remote and local attack. They also increase the administrative overhead involved in maintaining the servers' patch levels, and provide additional avenues for data infiltration and exfiltration. {==OPTION==} Note that some of this software was seen to be outdated, as discussed in section {==XREFOldVersionsOfThirdPartySoftware==}.
#### Likelihood: Low
In order for the installed software to be used to support attacks against the servers, they would need to be outdated or known to be vulnerable to remote or local compromise. {==OPTION==} Additionally, an attacker would need to find a way to interact with the software, for example if an administrator was browsing the internet from the server.
#### Recommendation
Review the servers' intended functions and ensure that only software which is specifically required is installed. This could be done through the use of carefully designed and maintained server build images, and monitored through tools such as Microsoft System Centre Configuration Manager (SCCM) and Microsoft System Centre Operations Manager (SCOM). Where software is deemed to be required, ensure that processes are in place to keep it up to date with necessary security patches.
