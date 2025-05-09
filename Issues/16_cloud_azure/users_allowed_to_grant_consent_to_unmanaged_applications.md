---
category: "TBA"
cvss: "TBA"
---
### Users Allowed to Grant Consent to Unmanaged Applications
Users can grant consent to any application; this means that a user can log into a third-party application using their Azure Active Directory credentials and grant the third-party application permissions to access user and organisational data.
#### Impact: High
Users can log in to third-party applications and grant consent for the third-party to access user and organisational data outside of the oversight and control of the organisation. A malicious third-party application could also exploit this to deliberately harvest data.
#### Likelihood: Medium
The current tenant configuration allows users to log into and grant consent to data access for any third-party application, however the application would have to be designed in a manner which deliberately harvests data, or otherwise contravenes organisational policies to pose a direct security risk.
#### Recommendation
Require administrator consent for all third-party applications to ensure control over the applications that users can authenticate to using Azure Active Directory and the data to which those applications have access.

Further information regarding application consent is available at the following URLs:

<https://docs.microsoft.com/en-gb/azure/active-directory/manage-apps/configure-user-consent>
<https://docs.microsoft.com/en-gb/azure/active-directory/manage-apps/configure-admin-consent-workflow>
