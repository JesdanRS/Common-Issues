---
category: "UPD"
cvss: "9.8"
---
### Bash Specially Crafted Environment Variables Attack
The affected system{s||} {are||is} operating a version of the Bash (Bourne-Shell) command-line environment that is known to be vulnerable to remote code execution attacks. A vulnerability (referenced as CVE-2014-6271 and CVE-2014-7169, and nicknamed as "Shellshock") affects numerous platforms, including major UNIX and Linux based platforms directly, and a number of other systems indirectly.

This vulnerability relates to the ability of certain applications and services, such as Apache or OpenSSH, to arbitrarily define environment variables within Bash which specify a function definition without appropriately escaping related parameters. Vulnerable versions of Bash will process these function definitions, and then continue to process any shell commands which have been appended as parameters.

The following proof of concept example demonstrates how this vulnerability can be exploited through the Apache "mod_cgi" module, to display the contents of the local "shadow" file on the web server:

```
https://www.example.com/cgi-bin/defaultpage.cgi?x='() { :;}; echo x' bash -c "cat /etc/shadow"#
root:$6$X*****X/:1:0:1:1:::
```

For more information, please refer to the following links:

[https://nvd.nist.gov/vuln/detail/CVE-2014-6271]()
[https://access.redhat.com/security/vulnerabilities/shellshock]()
#### Impact: High
It is possible to execute privileged operating system commands in the context of the affected service, in this case {==the "apache" local user==}. This impacts the confidentiality and integrity of any information to which this context has access, as well as potentially supporting other attacks intended to compromise the server itself, or other internal infrastructure.
#### Likelihood: High
This vulnerability is highly publicised, actively being exploited, and exploit code is freely available. The prevalence of Bash as a command-line environment on Linux, UNIX and other similar embedded operating systems makes this a highly sought target by attackers.
#### Recommendation
Update to the latest version of Bash as a matter of urgency, and review existent patching and updating policies and procedures for all systems, particularly those which are exposed to the Internet, to ensure a rapid response to any such flaws identified in the future

Please note that this vulnerability relates to Bash itself, {==rather than Apache==}, and other reported attack vectors included OpenSSH and some DHCP client services. Consider, therefore, whether an alternative command-line environment may be appropriate.

Ensure, also, that non-interactive user accounts, {==such as the "Apache" account discussed above==}, do not have interactive shells, such as Bash, configured. This can be done on Linux systems by specifying the following parameter at the end of the relevant line in the "/etc/passwd" file:

```
/bin/false
```
