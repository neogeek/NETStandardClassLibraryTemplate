build:
	dotnet pack "$(shell pwd)/NETStandardClassLibraryTemplate.csproj"

install:
	dotnet new --install "$(shell pwd)/bin/Debug/com.scottdoxey.netstandardclasslibrary.*.nupkg"

uninstall:
	dotnet new --uninstall com.scottdoxey.netstandardclasslibrary

clean:
	git clean -xdf
