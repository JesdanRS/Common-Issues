---
category: "CNF"
cvss: "8"
---
### Staff Vulnerable to Rogue Access Point Attacks
Staff are vulnerable to credentials being intercepted via an attack using an access point with an identical SSID to a legitimate wireless network, known as an "Evil Twin" attack.

A rogue access point broadcasting the SSID "{==SSID==}" was set up at the {==LOCATION==} building on {==DATE==}. When a client was connected to the rogue access point any web traffic was redirected to the following login portal, which invited the user to enter domain credentials in order to grant access to the network.

{==SCREENSHOT_OF_PORTAL==}

{==OPTION==} The SSID "{==SSID==}" was used for the interception test due to having the largest number of connected clients. In general, the more clients that are connected, the more chance that a victim will connect to the rogue access point.
{==ALTERNATIVE==} As the genuine services uses WPA2, a {==OPTION==} generic SSID of "Free Open Wireless" was setup {==OPTION==} misspelling of the SSID of the genuine service was setup as "{==SSID==}".

During the time available the following credentials were obtained:

```
{==NUMBER==} times the password of the shared "guest" account were submitted
{==NUMBER==} domain user credentials were submitted.
```

{==OPTION==} The obtained domain credentials were checked, and one account was seen to be valid as shown in the image below.
{==SCREENSHOT==}
#### Impact: High
An attacker setting up a rogue access point is able to harvest domain user credentials and captive portal logins. When this information is obtained, it can be used to access {==CLIENTNAME==} network and resources.
#### Likelihood: High
This type of attack is straightforward to execute and generally has highly success rate. Although an attacker would have to have physical access to the site, they may be more motivated to target the wireless networks due to a low chance for being located.
#### Recommendation
Where possible, consider migrating wireless networks to WPA2 Enterprise with authentication utilising a valid server certificate to help validate the services authenticity. Ensure security training makes staff aware of the importance of not ignoring certificate errors and where possible consider configuring devices to not allow the ignoring of certificate errors.

Consider installing wireless intrusion prevention systems to constantly monitor the radio spectrum for the detection of unauthorised access points with identical or similar SSIDS.
