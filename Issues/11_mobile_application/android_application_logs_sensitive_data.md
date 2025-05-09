---
category: "MOB-DST"
cvss: "3.3"
---
### Android Application Logs Sensitive Data
{== NOTE: Adjust impact and risk accordingly depending on the findings, and if UAT or production app ==}
{==Review of the decompiled source code/Dynamic analysis for/of the mobile application==} (see section {==XREF==}) revealed that sensitive data such as {==login credentials==} are logged by the application to the system log. The following image shows an example of this:
{==XREF_Screenshot==}

As a result, any other application on the device with enough privileges will be able to access the system log and gain access to this data.
#### Impact: High
A malicious application that has access to the system logs could read sensitive information such as {==login credentials==} logged by {==CLIENTNAME's==} application. If exploited, this could compromise the confidentiality and the integrity of the users' data.
#### Likelihood: Low
As of Android's latest versions, application logs are isolated from any other third-party applications. However, older versions of Android (prior to 4.1), allowed access to system logs by any third-party application configured with the READ_LOGS permission, and therefore if {==CLIENT's==} application was to be used on an older version the logged data may be compromised.

Additionally, note that some device vendors may incorporate customisations in the Android OS that could allow logs to be read by other applications running on this device.
#### Recommendation
Although logging functionality is useful during development, it is recommended to disable this functionality, or at least ensure no sensitive data is being logged, once the development is finished and the application is released.

{==OPTION: LoggingInProductionApp==}Review current secure application development guidelines to ensure that any debug or logging functionality and system is removed from production applications.