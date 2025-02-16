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

### Format Code

alt shift f in vs code

### Config debuggging

- ctrl shift p, and type `.net genereate assets for build and debug`
  OR
- Go on Run menu, Add Configuration, C#. A launch.json will be created.

---

## Theory

### Définition des concepts

- . member access operator
- () method invocation operators
- overloaded methods signatures can be called different ways to behave differently.
- **Donnée** : Une donnée est une valeur présente dans la mémoire de l'ordinateur sous forme de bits.

- **Variable** : Une variable est un label pour une donnée, comme un nom de domaine en quelque sorte.

- **Type de donnée** : Un type de donnée est une façon de déterminer la quantité de mémoire que l'ordinateur va allouer à une donnée.

---

### Types de données

Il y a deux types de types de données :

1. **Variables de référence** : La variable contient un pointeur vers une valeur. Strings, arrays, classes. Stored in the heap.
2. **Variables de valeur** : La variable contient directement la valeur. Stored in the stack.

---

### Signed Integer

Un signed integer est un nombre entier qui représente un nombre de positifs et de négatifs égal.

### Unsigned Integer

Un unsigned integer est un nombre entier qui représente seulement les nombres de positifs.

### Floating-Point

#!/usr/bin/env python3

import unittest

from validations import validate_user

class TestValidateUser(unittest.TestCase):
def test_valid(self):
self.assertEqual(validate_user("validuser", 3), True)

def test_too_short(self):
self.assertEqual(validate_user("inv", 5), False)

def test_invalid_characters(self):
self.assertEqual(validate_user("invalid_user", 1), False)
def test_invalid_minlen(self):
self.assertRaises(ValueError, validate_user, "user", -1)

# Run the tests

unittest.main()

Un float est un nombre décimal. Il faut considérer le nombre de chiffre après la virgule et comment cela affecte les opérations.
5E+2 = 500

### Array

The best way to empty elements from an array would be to count the number of non-null elements by iterating through each item and increment a variable (a counter). Next, you would create a second array that is the size of the counter variable. Finally, you would loop through each element in the original array and copy non-null values into the new array.

### Errors

- Errors that occurs at runtime are exceptions.
- Errors that occurs at build process are errors.
- Testing can be divided into functional and non-functional testing.
- Exception handling is managing errors by means of try catch statements.
- Debugging is isolating and fixing issues in code logic.
- Exceptions are thrown by code that encounters an error and caught by code that can correct the error.

