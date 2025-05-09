---
category: "CNF"
cvss: "5.3"
---
### DNS Server Discloses Version
The Domain Name System (DNS) server{s at the following addresses disclose their versions|| at ADDRESS discloses its version} in response to queries for the text record "version.bind" in the CHAOS class.

{==HOSTS==}
#### Impact: Low
Version information can be useful to an attacker.
#### Likelihood: Medium
This is straightforward to find by making a "version.bind" DNS query.
#### Recommendation
{==OPTIONBind==} Set the "version" directive in the "options" section in the named.conf configuration file of the DNS server.

{==OPTIONMicrosoft==} The command line utility "dnscmd" can be used to disable version query responses in Microsoft DNS, as shown below:

```
dnscmd /config /EnableVersionQuery 0
```

Further information regarding "dnscmd" and the various configuration properties can be found at the following URLs:

[https://learn.microsoft.com/en-us/previous-versions/windows/it-pro/windows-server-2012-R2-and-2012/cc772069(v=ws.11)]()
[https://msdn.microsoft.com/en-us/library/cc422472.aspx]()
