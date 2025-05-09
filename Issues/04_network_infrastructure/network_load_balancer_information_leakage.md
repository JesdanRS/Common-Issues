---
category: "{==APP-CNF/CNF==}"
cvss: "5.3"
---
### Network Load Balancer Information Leakage
The affected web server{s||} appear{s||} to make use of a {==NAME==} device for Network Load Balancing (NLB). The HTTP banner information exposed by this NLB device is shown below:

{==INFORMATION==}
#### Impact: Low
Unnecessary system information is revealed.
#### Likelihood: Medium
This information is presented in HTTP headers so a simple scan or banner grab would obtain this information.
#### Recommendation
Review the information exposed and undertake a risk assessment to determine whether this information is acceptable. If not, modify the NLB configuration to remove this information. The vendor documentation gives more information on how to do this.

{==VENDOR URL==}
