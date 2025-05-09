---
category: "TBA"
cvss: "TBA"
---
### Mobile Applications Pasteboard and Clipboard Data Leakage
{==NOTE Depending on the sensitivity of the application, the risk level can be increased or issue removed==}
The mobile applications for {==iOS and Android==} do not sufficiently restrict the clipboard functionality, in that it allows users to copy and paste data from the global system clipboard.

The mobile applications do not use their own private custom pasteboard. As a result, when text is selected and the "Cut" or "Copy" buttons are tapped, a copy of this data is stored on the device's clipboard and is accessible by any application.
#### Impact: Medium
A malicious user could gain access to sensitive data stored in the pasteboard following the use of the "Copy" and "Paste" functionality.{==OPTION==} However, no sensitive data was seen to be managed by the applications.
#### Likelihood: Low
A misconfigured clipboard is accessible by any application, and therefore it would be relatively straightforward to access any sensitive information stored in it. However, the user would first have to copy and paste text to the clipboard prior to the attacker being able to gain access to it.
#### Recommendation
For iOS, consider implementing a custom pasteboard for the application. This can be done by using the following code snippet:

```
UIPasteboard *userPasteBoard = [UIPasteboard pasteboardWithName:@"AppDefinedCustomPasteboard"] create:YES];
userPasteBoard.persistent = YES;
```

Please see the following reference for further details:

[https://developer.apple.com/library/ios/documentation/UIKit/Reference/UIPasteboard_Class]()

Alternatively, consider disabling pasteboard operations unless they are strictly necessary. It is possible to create a subclass of "UITextView" that overrides the "canPerformAction:withSender:" method to return "NO" for actions that shouldn't be allowed. Alternatively, completely disable the pasteboard menu.

For Android, consider disabling clipboard operations unless consider strictly necessary. This can be done by stopping copy, paste, cut and custom context menus from appearing with the following code:

```
edittext.setCustomSelectionActionModeCallback(new ActionMode.Callback() {

        public boolean onPrepareActionMode(ActionMode mode, Menu menu) {
            return false;
        }

        public void onDestroyActionMode(ActionMode mode) {
        }

        public boolean onCreateActionMode(ActionMode mode, Menu menu) {
            return false;
        }

        public boolean onActionItemClicked(ActionMode mode, MenuItem item) {
            return false;
        }
});
```