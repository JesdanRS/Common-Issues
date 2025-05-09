---
category: "CNF"
cvss: "TBA"
---
### Weak Password and Key Encryption Algorithm
Cisco key type 7 {==add key and password type 5 too if implemented==} and password type 7 were seen to be in use for {==TACACS+, BGP neighbours, HSRP, OSPF and==} administrative accounts on the devices above.

{=examples=}

{==Additionally, Cisco type 5 password was also used on some devices:==}

{=examples=}

These encryption algorithms are not secure and should not be used as the key related to them can be easily decrypted, as explained in the guidance below:

https://community.cisco.com/t5/networking-knowledge-base/understanding-the-differences-between-the-cisco-password-secret/ta-p/3163238

{==Some devices do not support type 8 and 9 in which case the device has to be upgraded, additionally HSRP, OSPF, and BGP Type 8 & Type 9 are not supported on some models too.==}
#### Impact: High
In the event of an administrative encrypted password obtained and decrypted, attackers could fully compromise the network device{s||}. This could allow them to launch further attacks against {==client==} network.
#### Likelihood: Low
The encrypted password with type 7 encryption algorithm could be easily decrypted. However, the attacker would need to have access to the device configuration to obtain the encrypted password.
#### Recommendation
Consider using password type 9 as recommended by Cisco at the following URL:

https://www.cisco.com/c/en/us/support/docs/ip/access-lists/13608-21.html#anc50
