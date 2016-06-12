mkdir -p build

mcs -out:build/conway.exe -pkg:dotnet conway/*.cs
