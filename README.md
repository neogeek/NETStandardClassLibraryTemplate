# .NET Standard Class Library Template

> Template for building a .NET Standard Class Library in Rider.

[![Nuget](https://img.shields.io/nuget/v/com.scottdoxey.netstandardclasslibrary)](https://www.nuget.org/packages/com.scottdoxey.netstandardclasslibrary/)

## Install

### NuGet

Download latest [release](https://github.com/neogeek/NETStandardClassLibraryTemplate/releases) and install via the Project Templates dialog in Rider.

<img src="Screenshots/install.png" width="500">

or via command line

```bash
$ dotnet new --install "com.scottdoxey.netstandardclasslibrary.1.0.0.nupkg"
```

### Repo

```bash
$ dotnet new --install "$(shell pwd)/NETStandardClassLibrary"
```

## Uninstall

### NuGet

```bash
$ dotnet new --uninstall com.scottdoxey.netstandardclasslibrary
```

### Repo

```bash
$ dotnet new --uninstall "$(shell pwd)/NETStandardClassLibrary"
```

## Setup

<img src="Screenshots/setup.png" width="500">
