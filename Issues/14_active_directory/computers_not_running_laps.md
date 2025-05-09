---
category: "CNF"
cvss: "N/A"
---
### Computers Not Running LAPS
Local Administrator Password Solution (LAPS) is a Windows feature that grants uniquely generated, strong and automatically managed password for local administrator accounts on domain joined machines.

A large number of systems within {==CLIENTNAME==}'s network{s||} were seen to not make use of LAPS, resulting in an increase in likelihood of the administrator password being reused across systems {==OPTION==} as detailed in section {==XREF_LOCAL_ADMIN_PW_REUSE==}.

For more information about LAPS please refer to the following link:

[https://learn.microsoft.com/en-us/windows-server/identity/laps/laps-overview]()
#### Impact: Medium
Machines that do not have the local administrator password managed through LAPS are more likely to be subject to password reuse. An attacker that is able to compromise one system could potentially be able to leverage this access to compromise other computers in order to move laterally through {==CLIENTNAME==}'s network.
#### Likelihood: Low
{==OPTION If some computers have LAPS and other don't==}: A number of tested systems were seen to have LAPS enabled. However, many were seen to be missing LAPS. Systems with no LAPS are more likely to reuse local Administrator password.
#### Recommendation
{==OPTION If LAPS is already deployed==}Review whether the systems listed in the {==Appendix X==} should be incorporated into the existing LAPS deployment. For systems where this is not possible, ensure that unique and strong local administrator passwords are used.
{==OPTION If No LAPS is deployed==} Consider deploying LAPS on all computers within the Active Directory environment.

For more information about LAPS deployment please refer to the following link:

[https://techcommunity.microsoft.com/t5/itops-talk-blog/step-by-step-guide-how-to-configure-microsoft-local/ba-p/2806185]()