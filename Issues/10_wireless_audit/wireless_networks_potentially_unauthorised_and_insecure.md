---
category: "NET"
cvss: "5.2"
---
### Wireless Networks Potentially Unauthorised and Insecure
A wireless network was detected which was not an expected SSID and may have been located on {==CLIENTNAME==} property.

{==OPTION1==} The wireless networks listed below were detected from the {==CLIENTNAME==} {==EXTERNAL_LOCATION_LIKE_CARPARK==}, which is not immediately adjacent to other businesses and domestic properties which may mean the signal was coming from the {==CLIENTNAME_BULIDING==} property. The networks were being offered by a device whose MAC address suggests it is a {==VENDORNAME==} based wireless access point:

{==SSIDLIST==}

{==ALTERNATIVETEXT==} The wireless audit at the {==LOCATION==} site detected a wireless network called "{==SSID==}" using {==ENCRYPTIONTYPE==} encryption operating from a device with the MAC address {==MACADDRESS==}. Note that this SSID was not within the scope of testing and so no further tests on it were performed.

{==OPTION==} These networks were not within the testing scope, and so an attack was not attempted, however it was noted that these used the outdated WEP encryption method, which is known to be insecure (see section {==XREF==}).
#### Impact: Medium
Unauthorised access points may accidentally allow an attacker access to privileged internal systems and resources.
#### Likelihood: Low
{==OPTION1==} WEP is widely known to be vulnerable and many automated tools can be used against it to gain access to the WEP protected wireless network. This access point may be independent of {==LOCATION==} networks however, and could be emanating from a third-party property.

{==ALTERNATIVETEXT==} This signal may be coming from unrelated properties nearby, from a personal device not connected to {==CLIENTNAME==} equipment or may be used on an isolated {==CLIENTNAME==} system. {==OPTION_IF_WEP==} Attacks on WEP are well known and automated tools mean the level of knowledge or skill required for a successful attack is not significant given enough time for encrypted traffic collection.
#### Recommendation
Investigate this SSID to determine if it is coming from {==CLIENTNAME==} property. If it is, determine the function of the network and the location of the wireless access point. If it is to be kept, upgrade the encryption from WEP to a WPA2.
