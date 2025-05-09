---
category: "{==APP-XXX==}"
cvss: "6.5"
report_on_external_network_test: true
---
### Insecure Development Practices
Although a full review of the web application source code was not performed during testing, as part of a partial inspection of the source code, a number of potentially insecure development practices were noted, included:

{==BULLETS==}
#### Impact: Medium
Insecure development practices can lead to vulnerabilities in the web application that can be difficult to detect from source code alone.
#### Likelihood: Medium
A number of insecure developer practices were identified throughout the codebase, which potentially introduce a number vulnerabilities into the application. However, in many cases these may not be directly exploitable. {==OPTIONPHP==} PHP as a language has evolved considerably over time and historically has suffered a number of vulnerabilities, as such, it contains a large number of legacy functions that are known to be weak or have special considerations.
#### Recommendation
Review best practices for the languages and frameworks in use and ensure that they are implemented throughout the codebase. The following guidance from NCSC provides further information about implementing secure practices throughout the entire development and deployment process:

[https://www.ncsc.gov.uk/guidance/secure-development-and-deployment]()

The use of static analysis tools as part of the development pipeline can be used to aid in identifying potentially insecure code. {==OPTIONPHP==} A list of common PHP analysis tools is available at the following URL:

[https://github.com/ziadoz/awesome-php#code-analysis]()
