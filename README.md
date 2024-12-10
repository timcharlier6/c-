## C#

Ressource: learn.microsoft.com

### Installation

On VS Code:

- install c# dev kit extension.
- install intellisense c# extension.
- go in view -> command pallet, and type `.NET install`.
- press enter.
- wait then restart vs code.

### Start a project

- Create a new .NET Console Application project in the current directory with the necessary files (like Program.cs and a .csproj file):
  `dotnet new console -o <optional path>`
- Compile the application and generates the necessary binaries (DLLs, EXEs) in the bin directory:
  `dotnet build`
- Build (if needed) and runs the application directly:
  `dotnet run`

### Lexic

- . member access operator
- () method invocation operators 
- overloaded methods signatures can be called different ways to behave differently.

### Formatting

alt shift f in vs code