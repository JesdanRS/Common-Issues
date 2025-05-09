# Common Issues

* Issues should not include comments (such as "adjust the risk level") except in very rare circumstances.
* Issues should be pluralised where possible.
* Try to keep the tone and writing style consistent with other issues.

# Issues
* Label issues where appropriate.
* Check if an issue or merge request on that subject already exists before creating one.

# Merge Requests

### General

* Give your merge request a useful title. If you don't set one, it'll default to the branch name (often master, see below), and having half a dozen merge requests just called "Master" isn't very helpful.
* Create a new branch in your repo for each merge request to keep things separate - don't use the master branch. Merge requests are done for branches, not commits, and if you get a merge request with half a dozen unrelated changes, and only want to merge one of them, it's a real pain.
* Make sure your local repo is up to date before you make changes to it (otherwise you might find someone else has already fixed the issue).
* Tick the "Squash Commits" option on the merge request to squash multiple commits into one. This keeps the main repo commit history clean and makes it easier to revent changes. See the section below for a quick guide on rebasing.
* You can automatically close a related issues by putting "closes #issuenum" or "fixes #issuenum" in one of your commit messages.
