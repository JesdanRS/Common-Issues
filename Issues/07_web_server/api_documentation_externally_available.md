---
category: "TBC"
cvss: "TBC"
---
### API Documentation Externally Available
{==OPTION1==} The documentation for the {==supporting API==} is externally available at the URL below:

{==URL e.g Swagger==}

{==URL==}
#### Impact: Low
An attacker may be able to discover the structure of website requests, which could assist in exploiting vulnerabilities in the application.
#### Likelihood: Medium
{==OPTION 1==} While searching for API documentation is a common technique for attackers, {==a valid bearer token==} would be required to proceed further.{==OPTION 2 and increase Impact==} Searching for API documentation is a common technique for attackers; additionally a number of API endpoints were seen to be available without authentication.
#### Recommendation
Remove the documentation if it is not required to be publicly available. Alternatively, implement an allowlist so that only trusted IP addresses can access it.
