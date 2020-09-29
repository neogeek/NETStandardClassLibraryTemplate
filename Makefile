build:
	dotnet build NETStandardClassLibrary/*.csproj

test:
	dotnet test NETCoreAppClassLibraryTest/*.csproj

clean:
	git clean -xdf
