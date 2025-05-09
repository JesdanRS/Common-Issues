---
category: "APP-CNF"
cvss: "N/A"
---
### WordPress Debug Logs Publicly Accessible
The WordPress "debug.log" file was found to be publicly accessible on the affected website{s||} via the following URL:

{==URL==}
```
{==debug.log CONTENT==}
```
#### Impact: Medium
Internal system paths are unnecessarily exposed. Although in isolation this information may not be significant, an accumulation of information relating to internal systems can help an attacker to form an attack strategy.
#### Likelihood: Low
Debug and log pages are straightforward to discover by guessing common filenames and extensions, or by using website scanning tools.
#### Recommendation
Disable WordPress debugging by changing to the following "wp-config.php" file line:

```
define( 'WP_DEBUG_LOG', false );
```

More information can be found at the following URL:

[https://developer.wordpress.org/advanced-administration/debug/debug-wordpress/]()