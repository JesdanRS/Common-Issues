---
category: "APP-CNF"
cvss: "5.3"
report_on_external_network_test: true
---
### Website Pages Allow Username Harvesting
The {==login/registration/forgotten password==} page{==s==} of the affected website{s||} display{==s==} whether {==usernames/email addresses==} have already been registered. An attacker can therefore guess or brute force a series of names to enumerate valid users.

{==PoC for each case==}
#### Impact: Medium
An attacker can extract multiple {==usernames/email addresses==}, and then use them to attempt a brute force attack against the login page. An attacker may also use account names to mount a phishing attack.
#### Likelihood: Medium
An attacker can use an automated attack tool to run a brute-force or dictionary attack against these pages to find valid {==usernames/email addresses==}.
#### Recommendation
{==OPTION==} Show a generic message for login failures, such as "The username or password is incorrect". {==OPTION==} For the {==forgotten password==} page use a message such as "If the username entered is correct, you will receive further instructions via email".

{==OPTION==} Show a generic message for registration failures indicating that the user will receive further instructions by email. Should the provided email address be unique, the user should be sent a confirmation link in order to complete the registration. In cases where the email address has already been registered, the user should be sent an email advising them to either perform a password reset, or to report the email if they did not make the registration request.

{==OPTIONs WordPress==} For the WordPress author pages, ensure that WordPress stops the automated URL redirection. One possible solution can be the use of the following plugin:

[https://wordpress.org/plugins/disable-author-pages]()

For the WordPress login hint messages, {==CLIENTNAME's==} theme could be customised to display generic login errors. This can be achieved using code similar to the one below in the "functions.php":

```
function no_wordpress_errors(){
    return 'The username or password is incorrect.';
}
add_filter( 'login_errors', 'no_wordpress_errors' );
```

There are a number of WordPress plugins that attempt to stop user harvesting within WordPress. Consider installing the appropriate one and testing it to ensure it is operational.

{==OPTION if time based==} Mitigating timing-based vulnerabilities is a complex and difficult process, as it requires application functionality to return in constant time, regardless of the inputs. A common approach is to enforce a random time for the page to be returned. Further information can be found at the following URLs:

[https://owasp.org/www-community/controls/Blocking_Brute_Force_Attacks]()
[https://owasp.org/www-project-web-security-testing-guide/stable/4-Web_Application_Security_Testing/10-Business_Logic_Testing/04-Test_for_Process_Timing]()