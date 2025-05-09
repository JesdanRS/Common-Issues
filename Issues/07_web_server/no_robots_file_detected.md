---
category: "APP-CNF"
cvss: "5.3"
report_on_external_network_test: true
---
### No Robots File Detected
The affected website{s||} {do||does} not make use of a robots.txt file to prevent automated website indexing by search engines such as Google and Bing.
#### Impact: Medium
Website content which may not be appropriate for search engine indexing may be made available in search engine results. This could lead to a subsequent impact on confidentiality.
#### Likelihood: Low
Provided appropriate access control and change management procedures are in place, it is unlikely that inappropriate content will be exposed in this manner. {==OPTION==} During testing, no inappropriate content was discovered.
#### Recommendation
Consider including a robots.txt file on the website{s||} that lists specific paths which are appropriate for search engine indexing. Note that using disallow rules can reveal potentially sensitive or inappropriate website folders to attackers which might otherwise have been undetected. Instead, consider using the "ROBOTS" meta tag or the "X-Robots-Tag" HTTP header on sensitive pages to prevent them from being indexed and to avoid including them in the robots.txt file. See the following page for more information:

[https://developers.google.com/search/docs/crawling-indexing/robots-meta-tag]()

Note also that while some search engines honour robots.txt files, not all do, and the use of robots.txt file will not prevent the use of an automated "spider" on the website.

More information about robots.txt files can be found at the following URL:

[https://www.robotstxt.org]()
