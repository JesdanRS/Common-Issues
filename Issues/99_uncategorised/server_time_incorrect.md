---
category: "CNF"
cvss: "5.3"
---
### Server Time Incorrect
The server{s listed below were|| at HOSTNAME was} found to have the incorrect time set, {as shown below||and was XX minutes SLOW/FAST}. The server's time was compared against a server synchronised to the "pool.ntp.org" NTP time service. Timestamps were retrieved from {==the HTTP headers sent by the server.==}

```
{==PROOF==}
```
#### Impact: Medium
An incorrect time on a system affects the validity of audit logs. This has an impact on the accountability of actions performed on the server, and it becomes more difficult to correlate activities and log files between multiple systems. This can have an effect on any forensic or legal investigations.
#### Likelihood: Medium
A number of high profile forensic investigations have been compromised as a result of inconsistent time-keeping.
#### Recommendation
Ensure the server's time is synchronised with three or more trusted time servers using NTP. Ideally the primary time sources should be Stratum 3 or above. See the following URL for further details:

[https://www.ntppool.org/en/]()

{==OPTION_YEARS_OUT_LINUX==}Note that some NTP software may refuse to correct a system if the retrieved time is significantly different, such as by a number of years. For this reason it may be necessary to first manually set the system time to the approximate current time. The following command is an example of how to manually set the date and time on a Linux based system from the command line:

```
date -s "29 MAY 2018 13:30:00"
```
