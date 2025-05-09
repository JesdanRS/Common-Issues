---
category: "PRC"
cvss: "N/A"
report_on_external_network_test: false
---
### Application Vulnerable to DLL Hijacking
Inspection of the {==APPLICATION NAME==} application determined that while a number of dynamic-link library (DLL) files are loaded during the application launch, some of these files appear to be missing, and can be listed by applying the following Process Monitor filters:

1. Process name equals {==application.exe==}
2. Path ends with .dll
3. Result contains NOT FOUND

Once the filters are applied, Process Monitor shows that a number of files cannot be found, as shown below. A full list of files can be found in {==Appendix D==}.
{==SCREENSHOT==}

When an application is unable to find a DLL, or one is loaded without specifying a fully qualified path name, Windows attempts to locate the DLL by searching a well-defined set of directories in a particular order. If an attacker gains control of one of the directories on the DLL search path, they can place a copy of the DLL in that directory, designed to perform malicious actions or attempt privilege elevation if the application is running with administrator privileges.

{==OPTION==} Note that while Windows enforces "safe DLL search mode" by default, it was possible to disable it during testing, as discussed in section {==XREF DLL Safe Search Mode can be Disabled==}. This is shown in the proof of concept below:

{==POC==}
#### Impact: High
An attacker could exploit the missing files to launch a malicious DLL under the context of the application, and perform a number of arbitrary actions or commands in order to achieve a persistent presence on the system, for example. {==Note that as the application was seen to be running with administrative privileges (see section XREF_Admin_privs), it is possible to escalate the privileges of the user, as showing in the proof of concept above==}
#### Likelihood: Low
An attacker would need to have knowledge of the application, as well as local access to the system on which the application is run. To successfully exploit this, an attacker would require write permissions to a directory from which the missing DLLs might try to be loaded by the system.
#### Recommendation
{==.NET==}Ensure that fully qualified paths to DLL files are specified where possible when using the LoadLibrary, LoadLibraryEx, CreateProcess, or ShellExecute functions, and that "safe DLL search mode" is enabled and enforced.

Further information about additional DLL protections can be found at the following URL:
[https://learn.microsoft.com/en-us/windows/win32/dlls/dynamic-link-library-security]()