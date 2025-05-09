---
category: "APP-ACC"
cvss: "N/A"
report_on_external_network_test: false
---
### DLL Safe Search Mode Can be Disabled
A review of the {==workstation==} hosting the tested thick-client application indicated that the DLL safe search mode can be disabled. Dynamic Link Library (DLL) files hold executable code that can be used by applications, and it is common for multiple versions of the same DLL file to exist in different locations within the operating system's (OS) file system. The specific file location that should be used by the application can be enforced by providing the full path, although if that method is not used, then the system searches a number of designated locations for the DLL at load time.

The search order depends on whether the application is packaged (using MSIX) or unpackaged, although the search order for an unpackaged application, with safe DLL search mode enabled, is as follows:

1. DLL Redirection
2. API sets
3. SxS manifest redirection
4. Loaded-module list
5. Known DLLs
6. The package dependency graph of the process. (Windows 11 version 21H2, Windows 10.0, Build 22000, and later)
7. The folder from which the application loaded
8. The system folder
9. The 16-bit system folder
10. The Windows folder
11. The current folder
12. The directories that are listed in the PATH environment variable

However, during testing it was possible to disable the safe DLL search mode by modifying the following DWORD registry key, and setting its value to zero:

```
{==HKEY_LOCAL_MACHINE\System\CurrentControlSet\Control\Session Manager\SafeDllSearchMode==}
```

Once disabled, the search order is changed so that "the current folder" moves from position 11 to position 8 in the sequence, immediately after step 7, and results in the application being more susceptible to DLL high jacking attacks {==XREF_DLL_HIJACKING==}.

Further information about the DLL search order can be found at the URL below:

[https://learn.microsoft.com/en-us/windows/win32/dlls/dynamic-link-library-search-order]()
#### Impact: Medium
An attacker or malicious user that is able to disable safe DLL search mode may be able to force the application into running a custom DLL file from the current folder, leading to system compromise.
#### Likelihood: Low
The application would need to be vulnerable to DLL hi jacking, as discussed in section {==XREF DLL HiJacking}.
#### Recommendation
Consider enforcing safe DLL search mode through Group Policy via the registry settings below and ensure that adequate registry permissions are enforced to prevent low privileged users from creating or modifying registry values and disabling safe DLL search mode.

```
Action: Update
Hive: HKEY_LOCAL_MACHINE
Key Path: SYSTEM\CurrentControlSet\Control\Session Manager
Value name: SafeDllSearchMode
Value type: REG_DWORD
Value data: 1
Base: Decimal
```