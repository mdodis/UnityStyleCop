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

## Miscellaneous

- Can't we make this more automated?
- No. The folder `.git/hooks` can never be tracked and is local *to your repo instance*.

**Run StyleCop Manually**

```
style check -r ./Assets/StyleCop/RequiredPackages/UnityStyleCop.ruleset ./StyleCop.sln
```
