# Serie A Excercices
## Single Responsibility Principle
### Corresponding folder: Rectangle
The class combines two responsibilities: handling a rectangle and its properties (width, height, ...), and printing it.
### How to correct it
Separate the existing class in two entities: Rectangle and something like RectanglePrinter / Widget. Bonus point if your mindful of the law of Demeter.

### Open/Closed Principle
### Corresponding folder: Itinerary finder
The ItinerarySearchEngine probably had a simple ```Itinerary OptimalItinerary(Trip trip)``` method. In order to add the possibility to search for cheapest or shortest, the method signature was modified to add the Itinerary preference option.
### How to correct it
Instead of modifying it, you should allow the caller to extend it directly. One way to do it is to remove the switch from the OptimalItinary method, by passing it a filter (function) instead of an Itinary preference. Bonus point if you re-introduce some ubiquitous language.

### Liskov Substitution Principle
### Corresponding folder: Simple Geometry
Square inherit from rectangle. While it makes sense from the domain (geometry) point of view, it does violate the Liskov principle. Indeed, square does not need both width and height, thus, square and rectangle cannot be substituted (see the tests). 
### How to correct it
You may implement an interface with the ```Area``` method. Then rectangle and square will implement this interface.

### Interface Segregation Principle
### Corresponding folder: Printer 
In order to print, the SimplePrinter has to implement methods it cannot perform.
### How to correct it
You should have one interface per function. SimplePrinter only implements Printer, while MultiFunctionCopier will implement the four of them.

### Dependency Inversion Principle
### Corresponding folder: Book reservation
BookingService use a AvailabilityDaoImpl attribute. It makes it coupled to this specific implementation.
### How to correct it
BookingService && BookingTEsts should use the interface. Bonus point if you are careful about the interface package.

# Serie B Excercices
## Single Responsibility Principle
### Corresponding folder: 

### How to correct it


### Open/Closed Principle
### Corresponding folder: Geometry Area

### How to correct it


### Liskov Substitution Principle
### Corresponding folder: 

### How to correct it


### Interface Segregation Principle
### Corresponding folder: Printer

### How to correct it


### Dependency Inversion Principle
### Corresponding folder: 

### How to correct it