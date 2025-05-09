---
category: CNF
cvss: N/A
---
### DynamoDB No Backups
Inspection of the {==DynamoDB tables below==} revealed that backups are not being taken either via the point-in-time recovery (PITR) feature or on-demand backups.

{==XREF_BULLET_POINTS==}

This can be seen in the example shown below:

{==XREF_SCREENSHOT==}
#### Impact: Medium
Availability of DynamoDB data cannot be guaranteed if the data is accidentally or intentionally deleted or modified.
#### Likelihood: Low
An attacker would need to have privileged access to the DynamoDB database in order to delete or modify the data. Alternatively, they would need to exploit another vulnerability in a service that interacts with the DynamoDB database.
#### Recommendation
Consider configuring DynamoDB backups using settings that align with the organisation's current data retention and backup policies. The following article from AWS provides more information:

[https://aws.amazon.com/dynamodb/backup-restore/]()
