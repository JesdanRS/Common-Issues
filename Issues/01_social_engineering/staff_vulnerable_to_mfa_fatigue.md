---
category: "PRC"
cvss: "7"
---
### Staff Vulnerable to MFA Fatigue
Staff have been observed approving Multi-Factor Authentication (MFA) challenges received from unknown or unexpected sources. This could potentially grant unauthorised access to systems or sensitive information.

{==OPTION==} Simulated MFA challenges were generated and sent to {==NUMBER==} employees that appeared to be from legitimate sources, however, they were controlled by Dionach.
#### Impact: High
Approving MFA challenges from unknown sources may result in unauthorised access to systems, compromising the confidentiality, availability and integrity of data stored or processed. This could lead to a data breach or potentially further compromise of the network.
#### Likelihood: Medium
Given that MFA is a critical security control, attackers will attempt to gain MFA approvals from staff. Attackers will need valid credentials{==OPTION==}; however, this was accomplished as outlined in (see section {==XREFStaffVulnerableToCredentialHarvesting==}).
#### Recommendation
Review and update MFA approval processes and policies to ensure they align with best practices and enhance the overall security posture of the organisation. Conduct regular training sessions for staff regarding secure MFA practices. Emphasise the importance of reporting suspicious MFA challenges that were not triggered by the user. Consider implementing additional controls, such as alerting mechanisms for suspicious MFA requests.
