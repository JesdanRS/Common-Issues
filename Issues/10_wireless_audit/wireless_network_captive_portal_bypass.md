---
category: "NET"
cvss: "4.7"
---
### Wireless Network Captive Portal Bypass
The "{==SSID==}" wireless network allows any client to connect to it, however the network is configured to use a captive portal. A captive portal is a web page that a user of a public-access network is obliged to view and interact with before access to the wireless network is granted. It was found that the captive portal in use relies on the MAC address of clients to verify who has access and who does not. By spoofing a valid MAC address it is possible to bypass the captive portal authentication mechanism and access the network, as shown below.

The following image shows the original MAC address of the wireless adapter used by the consultant to connect to the above networks:
{==SCREENSHOT==}

Once connected to one of the above networks the following login page is shown when trying to access any site on internet:
{==SCREENSHOT_OF_PORTAL==}

In order to bypass this captive portal authentication login page, a malicious user would have to intercept traffic of other legitimates user connected to the network to grab one of their MAC addresses, this is shown below:
{==SCREENSHOT==}

Once one or more valid MAC addresses are discovered, an attacker would proceed to spoof one of them:
{==MACCHANGER_SCREENSHOT==}

Finally, access to internet is granted without entering any valid credentials:
{==GOOGLE_SCREENSHOT==}
#### Impact: Medium
An attacker bypassing the captive portal authentication login page will gain access to the wireless network without valid credentials, and could potentially perform illegal activities that would have an impact in the reputation of {==CLIENTNAME==}.
#### Likelihood: Medium
A malicious user would have to be within the signal range of this wireless network and also have some technical knowledge in order to carry out the above described attack. An attacker would need to be motivated to attack {==CLIENTNAME==} in this manner {==OPTION_NO_INTERNAL==} as only internet connectivity would be gained. {==OPTION_INTERNAL_ROUTING==} which the access to internal resources may provide if known of in advance.
#### Recommendation
{==OPTION_IS_GUESTNETWORK==} It's not possible to prevent MAC address spoofing on an unencrypted guest network, as such conduct a risk assessment of providing the service. Ensure only guests are using the service, that the service only allows traffic to the internet and that precautions against abuse are in place. To dissuade use of the guest system by staff, ensure that staff have a secure supported alternative such as a system based on WPA2-Enterprise.

{==OPTION_IS_STAFFNETWORK==} Consider using a more secure configuration such as pre-shared key implementation to protect the initial network itself, such as WPA2-PSK.

In the longer term, consider migrating to a secure alternative such as a WPA2-Enterprise with a RADIUS server and a guest account creation process for legitimate verified visitors.
