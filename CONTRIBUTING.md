# Contributing to RESTCountries.NET

We'd love for you to contribute to our source code and to make RESTCountries.NET even better than it is
today! Here are the guidelines we'd like you to follow:

 - [Question or Problem?](#question)
 - [Issues and Bugs](#issue)
 - [Feature Requests](#feature)
 - [Submission Guidelines](#submit)
 - [Coding Rules](#rules)

## <a name="question"></a> Got a Question or Problem?

If you have questions about how to use RESTCountries.NET, please direct these to [@lioncoding](https://twitter.com/lioncoding).

## <a name="issue"></a> Found an Issue?

If you find a bug in the source code or a mistake in the documentation, you can help us by
submitting an issue here. Even better you can submit a Pull Request with a fix.

**Please see the [Submission Guidelines](#submit) below.**

## <a name="feature"></a> Want a Feature?

You can request a new feature by submitting an issue.

 If you would like to implement a new feature then consider what kind of change it is:

* **Major Changes** that you wish to contribute to the project should be discussed first on [Twitter](https://twitter.com/lioncoding) so that we can better coordinate our efforts,
  prevent duplication of work, and help you to craft the change so that it is successfully accepted
  into the project.
* **Small Changes** can be crafted and submitted to the  [GitHub](https://github.com/egbakou/RESTCountries.NET) Repository as a Pull Request.

## <a name="submit"></a> Submission Guidelines

### Submitting an Issue

If your issue appears to be a bug, and hasn't been reported, open a new issue. Help us to maximize the effort we can spend fixing issues and adding new features, by not reporting duplicate issues.

Providing the following information will increase the chances of your issue being dealt with
quickly:

* **Overview of the Issue** - if an error is being thrown a stack trace helps
* **Motivation for or Use Case** - explain why this is a bug for you
* **RESTCountries.NET Version(s)** - is it a regression?
* **Reproduce the Error** - provide a example or an unambiguous set of steps.
* **Related Issues** - has a similar issue been reported before?
* **Suggest a Fix** - if you can't fix the bug yourself, perhaps you can point to what might be
  causing the problem (line of code or commit)

**If you get help, help others. Good karma rulez!**

### Submitting a Pull Request
Before you submit your pull request consider the following guidelines:

* Search [GitHub]([GitHub](https://github.com/egbakou/RESTCountries.NET)) for an open or closed Pull Request
  that relates to your submission. You don't want to duplicate effort.
  
* Make your changes in a new git branch:

    ```shell
    git checkout -b my-fix-branch main
    ```

* Create your patch, **including appropriate test cases**.

* Run the test suite, as described below.

* Commit your changes using a descriptive commit message.

    ```shell
    git commit -a
    ```
  Note: the optional commit `-a` command line option will automatically "add" and "rm" edited files.
  
* Make sure you use a distinctive commit author name.

* Push your branch to GitHub:

    ```shell
    git push origin my-fix-branch
    ```

In GitHub, send a pull request to `main`.

If we suggest changes, then:

* Make the required updates.
* Re-run the test suite to ensure tests are still passing.
* Commit your changes to your branch (e.g. `my-fix-branch`).
* Push the changes to your GitHub repository (this will update your Pull Request).

If the PR gets too outdated we may ask you to rebase and force push to update the PR:

```shell
git rebase target_branch -i
git push origin my-fix-branch -f
```

That's it! Thank you for your contribution!

#### After your pull request is merged

After your pull request is merged, you can safely delete your branch and pull the changes
from the main (upstream) repository:

* Delete the remote branch on GitHub either through the GitHub web UI or your local shell as follows:

    ```shell
    git push origin --delete my-fix-branch
    ```

* Check out the mainbranch:

    ```shell
    git checkout main -f
    ```

* Delete the local branch:

    ```shell
    git branch -D my-fix-branch
    ```

* Update your master with the latest upstream version:

    ```shell
    git pull --ff upstream main
    ```
## Coding

### Developer Environment

- The latest .NET 6 SDK is required.

- Visual Studio / Rider / Vs Code / Your preferred IDE

### <a name="rules"></a> Coding Rules

To ensure consistency throughout the source code, keep these rules in mind as you are working:

* All features or bug fixes **must be tested** by one or more unit tests (if possible and applicable).
* All public API methods **must be documented** with XML documentation.
