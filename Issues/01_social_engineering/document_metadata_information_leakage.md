---
category: "PRC"
cvss: "5.8"
---
### Document Metadata Information Leakage
Publicly accessible documents, including many indexed by search engines such as Google or Bing, reveal internal and potentially sensitive information as part of their metadata. The following information was extracted from publicly accessible documents by utilising the following Google query, as well as browsing the website:

```
site:{==URL==} (filetype:pdf {==OR filetype:docx etc==})
```

Information Type
Examples
{==Information Type==}
{==Examples==}
#### Impact: Low
Unnecessary information is revealed that could aid an attacker in forming an attack strategy.
#### Likelihood: Medium
This information can easily be gathered by means of a carefully crafted Google query, and by examining the metadata of any retrieved documents.
#### Recommendation
Ensure that the metadata of published documentation is appropriately sanitised. Most word processing applications will provide the facility to do this automatically.

The following links provide more information for Microsoft Office and Adobe products:

[https://support.office.com/en-gb/article/remove-hidden-data-and-personal-information-by-inspecting-documents-presentations-or-workbooks-356b7b5d-77af-44fe-a07f-9aa4d085966f]()
[https://helpx.adobe.com/uk/acrobat/using/removing-sensitive-content-pdfs.html]()
