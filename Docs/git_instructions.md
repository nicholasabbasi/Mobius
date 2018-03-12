# Instructions:

## Prerequisites:
Git installed
[Git flow installed](https://github.com/nvie/gitflow/wiki/Installation)

## Getting Started:
```bash
# Create and enter the initial Repo
git clone https://github.com/chbachman/Mobius.git
cd Mobius

# Checkout the master branch, since we need it to setup git flow
git checkout -b master origin/master

# Setup Git Flow
git flow init
```

Now, git flow will ask you a couple questions. Hit enter at all of the questions asked. Here is a list:

```
Which branch should be used for bringing forth production releases?
   - develop
   - master
Branch name for production releases: [master]

Which branch should be used for integration of the "next release"?
   - develop
Branch name for "next release" development: [develop]

How to name your supporting branch prefixes?
Feature branches? [feature/]
Bugfix branches? [bugfix/]
Release branches? [release/]
Hotfix branches? [hotfix/]
Support branches? [support/]
Version tag prefix? []
Hooks and filters directory? [$Your_Folder/Mobius/.git/hooks]
```

Now let's setup unity with the latest develop.

```bash
git checkout develop
```

Now launch Unity and open up the Mobius folder.
To get the file to open, type: `pwd` in the terminal

There will be some problems. To fix the import issues:

`Unity -> Assets -> Import Package -> Characters`

Then import all.
Open the Main Scene and hit play. You should be able to walk around in the world and see the current progress.


## Creating a Feature:
Start with the working tree clean and in the develop branch.

$name = feature name

```bash
git flow feature start $name
```

This will start a new feature, move you to the correct branch, and let you start working.

Now add whatever feature you want, and then once you are done, or just want to back up your work use:

```bash
git flow feature publish $name
```

This will push all your changes to github.

Now to actually create the Pull Request for your feature, go to [Github](https://github.com/chbachman/Mobius) and click on the Branch dropdown menu.

Select your feature branch `feature/$name` from the dropdown list.
It should say something like: 

This branch is 3 commits ahead of develop. `Pull Request` `Compare`

Now hit Pull Request and fill out the description box. Then create the Pull Request.

When your Pull Request is reviewed, approved, and merged, delete the branch on Github and use this command locally:

```bash
git checkout develop
git branch -d feature/$name
```

This will delete your local branch. Then you will be on develop with a clean working tree and able to start a new feature!

## Reviewing a Feature:
Start with the working tree clean and in the develop branch.

```bash
git checkout -b feature/$name origin/feature/$name
```

Now switch to Unity and run the project. It will have the new feature implemented.

Test the feature to your heart's content. Once you are done, comment on the Pull Request that you are reviewing and run this:

```bash
git checkout develop
git branch -d feature/$name
```
