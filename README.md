[![Build Status](https://travis-ci.org/rbritton1988/name-sorter.svg?branch=master)](https://travis-ci.org/rbritton1988/name-sorter)

**NameSorter** 
--

A dotnet core (2.1) console application written in C# that accepts a path to a .txt file as an argument.
The argument file should contain a list of unsorted names.
The application will then sort the names alphabetically in lastname order. 
The results are printed to the console and written to a *sorted-names-list.txt* file in applications working directory.

**To build both the main and tests projects run:**

`dotnet build NameSorter.sln`

**To run tests project run:**

`dotnet build NameSorterTests`\
`dotnet test NameSorterTests`

**To publish a standalone executable Release on a Windows 10 machine**

`dotnet publish NameSorter -c Release -r win10-x64`
