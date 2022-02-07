# Simple SOLID smells
This repo contains simple code examples. Each one violate a SOLID principle.

## How to do those kata
For each folder:
1. Analyze the code and identify which principle is not followed
2. Refactor the code to respect the principle

And voilà !

## SOLID Principles
### Single Responsibility Principle
Eery class should have a single responsibility. There should never be more than one reason for a class to change.

### Open/Closed Principle
Entities should be open for extension, but closed for modification.
You should make all member variables private by default. Write getters and setters only when you need them.

### Liskov Substitution Principle
Objects should be replaceable with instances of their subtypes without altering the correctness of the program.

### Interface Segregation Principle
To reduce coupling, classes should not have to implement methods that they do not use.

### Dependency Inversion Principle
Abstractions should not depend upon details, details should depend upon abstractions.
