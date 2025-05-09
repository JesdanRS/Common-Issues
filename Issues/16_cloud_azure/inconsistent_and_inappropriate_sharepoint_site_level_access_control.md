---
category: "PRV"
cvss: "TBA"
---
### Inconsistent and Inappropriate SharePoint Site Level Access Control
Inspection of the SharePoint sites revealed that site level access control is not applied consistently, and in some cases, sensitive data, such as passwords in clear text, could be read by users who potentially should not have access to the files.

The following active sites were found to have potentially overly permissive site level permissions, in the sense that {==everyone except external users==} could access data stored on the following sites:

{== * SITES LIST==}

{==ADD EXAMPLES WITH SCREENSHOTS==}
#### Impact: High
An attacker or a malicious user who has gained access to the SharePoint sites could gain access to potentially sensitive information, {==such as passwords and various infrastructure keys.==}
#### Likelihood: Low
Inbuilt search functionality makes it straight forward to identify files or folders with misconfigured permissions and containing sensitive information. However, an attacker would have to either exploit a vulnerability in SharePoint or socially engineer a user to gain access to an account.
#### Recommendation
Ensure that regular access control reviews are conducted and that any unnecessary privileges or inappropriate content are removed. Access control reviews can be conducted with the "Site Permissions" functionality within the site settings section of SharePoint. Access control can also be reviewed by logging in to the website as a user belonging to the reviewed role and selecting "Site Content" from the settings menu in order to view all accessible content or searching for known restricted page using the search functionality.
