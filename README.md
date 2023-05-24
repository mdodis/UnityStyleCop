# Unity Style Cop

## Setup

**Install StyleCop Analyzers CLI**
```
dotnet tool install --global rookxx.stylecopanalyzers-cli
```

**Change git config path**

```
git config core.hooksPath "git-hooks/"
```

**Running StyleCop CLI Manually**

```
style check -r ./Assets/StyleCop/RequiredPackages/UnityStyleCop.ruleset ./StyleCop.sln
```
