---
category: "PRV"
cvss: "3.7"
---
### Azure Service Buses Anonymously Available
The Azure Service Buses below appear to allow anonymous access and return detailed error messages in response to requests.

{==SERVERS==}

When a POST request is sent with invalid JSON, an error message is returned, as shown below:

```
{"body":{"status":"700","errors":[{"code":"700","message":"There was a failure executing the receive pipeline: [...] Reason: Invalid property identifier character: {. Path '', line 1, position 1. "}]}}
```

If a valid JSON is sent, a different error is returned, implying that the service is attempting to parse the message without first checking for an appropriate authentication header:

{==URL==}
```
{"body":{"status":"700","errors":[{"code":"700","message":"There was a failure executing the receive pipeline: [...] Reason: Object reference not set to an instance of an object. "}]}}
```
#### Impact: Medium
An anonymous user may be able to send or receive messages from the Service Bus, which could potentially allow them to access sensitive data, or to inject malicious messages into other applications.
#### Likelihood: Low
An attacker would need to identify the URL of the Service Bus, and would also need to know the structure of the JSON required in order to communicate with the Service Bus.
#### Recommendation
Review all Azure Service Buses, and if anonymous access is not required then restrict it. Where access is required, ensure that it is based on the principle of least privilege, with access only being granted to resources when it is specifically required. Please refer to the following Microsoft article for further information:

[https://docs.microsoft.com/en-us/azure/service-bus-messaging/service-bus-messaging-security-controls]()