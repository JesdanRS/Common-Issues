---
category: "APP-CNF"
cvss: "5.3"
---
### FrontPage Server Extensions Enabled
The web server{s||} listed above {have|has} FrontPage Server Extensions enabled. FrontPage Server Extensions allow web developers and administrators to modify web content from a remote location. While this is a fairly typical scenario on an internal local area network, FrontPage Server Extensions should not be available to anonymous users via the Internet (or any other untrusted third-party network).
#### Impact: Medium
In a worst case scenario, FrontPage Server Extensions can allow full unrestricted access to the website in addition to unnecessary system information leakage.
#### Likelihood: Low
Dionach were unable to exploit this vulnerability and gain unauthorized access to the web server{s||} during the course of the test. However, unnecessary information about the anonymous user was easily extracted. Visible FrontPage Server Extension signatures can give an impression of an unhardened default install and attract the interest of a potential intruder.
#### Recommendation
Disable FrontPage Server Extensions on the web server.
