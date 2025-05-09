---
category: "APP-CNF"
cvss: "N/A"
---
### Website Functionality Provided by Cross-Domain Includes
The affected website{s||} include{s||} functionality provided by third-party scripts, sourced from domains which are outside of {==CLIENTNAME==} control. These include {==fonts, reCAPTCHA, and analytics scripts==} from the following URLs:

{==URL LIST==}

{==OPTION==} Please note that the {==list OR URL==} above may not be exhaustive as more scripts could be loaded dynamically within other web pages or scripts.
#### Impact: Medium
Any security issues affecting included scripts could potentially be used to target the website{s||}. If third-party domains hosting the scripts are compromised, this could lead to reputational damage for {==CLIENTNAME==}.
#### Likelihood: Low
The third {==party==} hosting {==these scripts==} would have to be compromised for this issue to affect the website{s||}.
#### Recommendation
Undertake a risk assessment to determine the potential exposure that including third-party resources in {==CLIENTNAME==} websites could lead to, and ensure that processes are in place to regularly review such content.

Consider embedding a hash of any included scripts in the "integrity" attribute of the script tag to ensure that if any scripts are changed from their originally included form, they are not loaded by the website{s||}. For more information, please see the following article:

[https://developer.mozilla.org/en-US/docs/Web/Security/Subresource_Integrity]()

{==OPTION==} Please note that subresource integrity is not supported when resources are dynamically generated, as is the case with {==Google Fonts==}. In such cases, consider hosting the resources locally to the website{s||}.
