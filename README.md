# Common Issues

Common issues can be edited by submitting a merge request. It is possible to do this within the GitLab UI by [creating a new branch](https://gitlab.com/mrbl4ck/common-issues/-/branches) and then clicking the "Edit" button on a file you want to edit, and then submitting changes as a merge request.

Merge requests are regularly reviewed at Common Issue Review Board meetings.

**Please raise one merge request per common issue** rather than a bulk load for new issues/major changes to multiple common issues.

Updates to the master branch (when a merge request is accepted) will automatically result in an update of the MrBl4ck common issue library.

A docx of all common issues can be obtained by clicking on the download button and then "Download 'documents'" or [here](https://gitlab.com/mrbl4ck/common-issues/-/artifacts).

Integration with Word, allowing common issues to be inserted directly into a document, is also available through an add-in. The word add-in is accesible through `Insert -> My Add-ins -> My Organization -> Common Issues`.

### Naming

- Filenames should be the common issue title, converted to lowercase and with special characters or spaces replaced with underscores.
- The repository folder name is used to specify the vulnerability category.

### Common Issue Markdown

Common issues (should) only contain simple formatting which can be easily achieved using Markdown. Look at existing issues for a full reference

- Title should be Heading3 (`### zzz`)
- Subtitles should be Heading4 and be followed by ': risk' for impacts and likelihoods (`#### Likelihood: Low`)
- Impacts and Likelihoods must be either "Low", "Medium" or "High". You can't use highlighting here.
- Highlight is (`{==zzz==}`)
- Bullet points start with a space, followed by an asterisk, followed by a space (`*`)
- Common issue text should end with a horizontal line (`***`)
- Following the horizontal line, add the vulnerability type, prefixed with 'Type: ' (`Type: Undefined`)

### Style

Pleas use the following style guidelines to keep common issues consistent and easy to use:

- Use a highlighted `XREF` to denote cross references that needed to be filled in. It can also be useful to give these helpful names, like `{==XREFAccessControl==}`.
- Put a space after an `{==OPTION==}` highlight to allow it to be quickly selected and deleted without selecting the next word as well.
- Minimise the use of the client's name in issues. Where you do need it, put it as `{==CLIENTNAME==}` or `{==CLIENTNAME==}'s`
- Use "organisation" rather than "company" to avoid having to change it for non-commercial clients.

### CI Unit Tests

To ensure changes in common issues do not break our reporting, a number of unit tests are ran when you are making changes.

### Nessus Integration

Refer to the documentation for Nessus integration.

### Pluralisation

Common issues should support pluralisation. Where text is required to be in either the plural or the singular the following syntax should be used:

```
{ pluralisation || singularisation }
```

Either the pluralisation or singularisation can be optional. For example:

- `The following web server{s export|| exports}` becomes `The following web server exports` (one) or `The following web servers export` (many)
- `server{s||}` becomes `server` (one) or `servers` (many)

Try to avoid putting a large number of pluralisation sections in quick sucession when a single larger section would be more readable:

```
Th{ese are||is is an} example{s||} of{|| a} case{s||} where bigger tags are more readable.
vs
{These are examples of cases||This is an example of a case} where bigger tags are more readable.
```

**Note: Plaintext only (no highlights etc) inside the pluralisation tags**

### Example

```
### Old and Unsupported Versions of Software
The software on the following host{s||} is old and full of bugs:

{==HOSTS==}
```

Widget 0.1
Stuff 0.2.1.7

````
#### Impact: High
Bad stuff will happen.
#### Likelihood: Medium
Sometimes but not always.
#### Recommendation
Update to the latest version. See the following URL for more information.

[https://gitlab.com/mrbl4ck/common-issues]()
***
Type: Undefined
NessusPlugin: 12345
[```csharp]
/* code to process plugin output */
[```]
````
