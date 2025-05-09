---
category: "TBC"
cvss: "TBC"
---
### Network Devices Default Credentials
The following service{s||} {were||was} seen to be using default credentials{==, including a default lack of authentication,==} on {their||its} {==OPTION web interface{s||}==}. Please note that due to the large number of services, a sampling approach was used and additional services using default passwords might be present which are not reported.

{==SERVICES==}

This can be seen in the following example, for the {==OPTION switch==} at {==HOST==} which was using default credentials of "{==USER/PASSWORD==}":

{==SCREENSHOT==}
#### Impact: Low
{==OPTION Adjust for interesting devices==}An attacker with access to {these||this} system{s||} would be able to access unauthorised information and potentially render the device{s||} unavailable. However, the devices above were seen to be predominantly printers and other devices of limited exploitability.
#### Likelihood: Medium
Although this issue will be quickly identified by manual inspection, an attacker would have to be motivated to attack the organisation in this manner. However, any unauthenticated user with network level access would be able to exploit this vulnerability.
#### Recommendation
Change the default password{s||} for the system{s||} identified. Please refer to the following guidelines on how to implement secure passwords:

[https://www.ncsc.gov.uk/collection/passwords/updating-your-approach]()

Review policies and procedures to ensure that software and systems have their default password changed prior to deployment.
