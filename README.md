# Object-Oriented-Programming

All Software Patterns from GoF designed during Computer Sciences Bachelor.

Some projects were designed in Java. You need to install JDK https://www.oracle.com/java/technologies/javase-downloads.html. To check if you already have that, run 'java -version'. After that, install "Java Extension Pack" in VS Code. To run the main file, go to the right directory witch has the main file using 'cd filename' in the terminal and type 'java filename' in the terminal.

Some other projects were designed in C#. To run this application, make sure you have .NET compiler installed in your computer https://dotnet.microsoft.com/pt-br/download. Go to the right directory witch has the main file using 'cd filename' in the terminal. After that, you need to type 'dotnet run' in the terminal.


## Abstract Factory
Designed in Java. The Abstract Factory is a creational design pattern that provides an interface for creating families of related objects, without specifying their concrete classes. It allows you to create objects without specifying their implementation details, providing a way to decouple the code that creates objects from the code that uses them.

## Bridge

Designed in C#. It is a game of Checkers in oriented-object programming. This is a structural pattern that separates an object's interface from its implementation. It allows the two to vary independently, allowing you to create different combinations of the interface and implementation.

## Builder 

Designed in C#. A creational pattern that separates the construction of a complex object from its representation, allowing you to create different representations of the same object. It provides a step-by-step process for building a complex object, allowing you to vary the object's internal representation.

## Chain of Responsibility

Designed in C#. A behavioral pattern that allows you to chain together a series of objects to handle a request. It provides a way to decouple a sender and receiver of a request by allowing multiple objects to handle the request.

## Command Pattern

Designed in C#. The Command Pattern is a behavioral design pattern that encapsulates a request as an object, thereby allowing it to be passed as a parameter to methods or stored in data structures. This pattern allows you to decouple the requester of the action from the object that performs the action, providing more flexibility and extensibility.

## DAO

Designed in Java. DAO (Data Access Object) is a design pattern that separates the business logic from the data storage and retrieval logic in an application. It provides a layer of abstraction between the application code and the database, making it easier to change the underlying database without affecting the application code.

## Decorator 

Designed in C#. The Decorator pattern allows behavior to be added to individual objects without affecting the behavior of other objects in the same class. It involves wrapping an existing class with a new class that adds or modifies behavior. This pattern provides a flexible alternative to subclassing for extending functionality. It involves five main components: the Component interface, the ConcreteComponent class, the Decorator abstract class, Main class and the ConcreteDecorator classes. The Decorator pattern is useful for adding functionality to objects without modifying their original source code.

## Facade Pattern

Designed in Java. The Facade Pattern is a structural design pattern that provides a simplified interface to a complex system of classes, functions, or subsystems. It allows clients to interact with a simplified interface rather than dealing with the complexity of the underlying system directly, making it easier to use and understand.

## Factory Method

Designed in Java. The Factory Method is a creational design pattern that provides an interface for creating objects in a superclass, but allows subclasses to alter the type of objects that will be created. This pattern allows for more flexibility and extensibility in object creation, as new objects can be created without changing the code in the superclass.

## Memento

Designed in C#. A behavioral pattern that allows you to capture and externalize an object's internal state, allowing you to restore the object to its previous state. It provides a way to undo operations without violating encapsulation.

## Observer

Designed in C#. It defines a one-to-many dependency between objects so that when one object changes state, all its dependents are notified and updated automatically. In this pattern, the object that is being watched is called the "subject" or "observable", while the objects that are watching it are called "observers". The Observer pattern is used to decouple objects, promote reusability, and allow for greater flexibility in object interactions.

## Proxy

Designed in C#. A structural pattern that provides a surrogate or placeholder for another object to control access to it. It allows you to create a class that represents the functionality of another class.

## State

Designed in C#. A behavioral pattern that allows you to alter an object's behavior when its state changes. It provides a way to encapsulate the state of an object and to switch between different behaviors depending on that state.

## Strategy

Designed in C#. It enables the selection of an algorithm at runtime from a family of interchangeable algorithms. It defines a set of algorithms, encapsulates each one, and makes them interchangeable within a context object. The context object can vary its behavior by delegating to different strategy objects. It is a useful tool for building software systems that require runtime flexibility in algorithm selection and behavior.
