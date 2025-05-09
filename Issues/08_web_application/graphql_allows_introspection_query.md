---
category: "APP-CNF"
cvss: "N/A"
---
### GraphQL Allows Introspection Query
The GraphQL endpoint{s||} allow{||s} introspection queries to enumerate the schemas for the APIs consumed by the {==APPLICTION_NAME==} web application{s||}. The endpoint{s||} expose{||s} information related to the queries, mutations, subscriptions, and available data types, as shown in the following example:

{==POST URL}
```
Introspection Query Response
```
#### Impact: Low
Information is exposed which may be useful to an attacker in exploiting other vulnerabilities in the API{s||}. {==OPTION==}However, no sensitive queries were found within the testing timeframe.
#### Likelihood: High
Introspection is a well-documented feature of GraphQL APIs and would quickly be discovered by an attacker.
#### Recommendation
Ensure the GraphQL API{s do|| does} not allow introspection. Implementations may vary; however, common frameworks typically provide an option to disable introspection. Further information is available at the following URL:

[https://cheatsheetseries.owasp.org/cheatsheets/GraphQL_Cheat_Sheet.html#introspection-graphiql]()
