# Object-Oriented-Programming

All my personal POO projects here.

Some projects were designed in Java. You need to install JDK https://www.oracle.com/java/technologies/javase-downloads.html. To check if you already have that, run 'java -version'. After that, install "Java Extension Pack" in VS Code. To run the main file, go to the right directory witch has the main file using 'cd filename' in the terminal and type 'java filename' in the terminal.

Some other projects were designed in C#. To run this application, make sure you have .NET compiler installed in your computer https://dotnet.microsoft.com/pt-br/download. Go to the right directory witch has the main file using 'cd filename' in the terminal. After that, you need to type 'dotnet run' in the terminal.


# Command Pattern
Designed in C#. The Command Pattern is a behavioral design pattern that encapsulates a request as an object, thereby allowing it to be passed as a parameter to methods or stored in data structures. This pattern allows you to decouple the requester of the action from the object that performs the action, providing more flexibility and extensibility.

# Facade Pattern
Designed in Java. The Facade Pattern is a structural design pattern that provides a simplified interface to a complex system of classes, functions, or subsystems. It allows clients to interact with a simplified interface rather than dealing with the complexity of the underlying system directly, making it easier to use and understand.

# DAO
Designed in Java. DAO (Data Access Object) is a design pattern that separates the business logic from the data storage and retrieval logic in an application. It provides a layer of abstraction between the application code and the database, making it easier to change the underlying database without affecting the application code.

# Factory Method
Designed in Java. The Factory Method is a creational design pattern that provides an interface for creating objects in a superclass, but allows subclasses to alter the type of objects that will be created. This pattern allows for more flexibility and extensibility in object creation, as new objects can be created without changing the code in the superclass.

# Abstract Factory
Designed in Java. The Abstract Factory is a creational design pattern that provides an interface for creating families of related objects, without specifying their concrete classes. It allows you to create objects without specifying their implementation details, providing a way to decouple the code that creates objects from the code that uses them.

# Decorator 
Designed in C#. The Decorator pattern allows behavior to be added to individual objects without affecting the behavior of other objects in the same class. It involves wrapping an existing class with a new class that adds or modifies behavior. This pattern provides a flexible alternative to subclassing for extending functionality. It involves five main components: the Component interface, the ConcreteComponent class, the Decorator abstract class, Main class and the ConcreteDecorator classes. The Decorator pattern is useful for adding functionality to objects without modifying their original source code.

# Observer
Designed in C#. It defines a one-to-many dependency between objects so that when one object changes state, all its dependents are notified and updated automatically. In this pattern, the object that is being watched is called the "subject" or "observable", while the objects that are watching it are called "observers". The Observer pattern is used to decouple objects, promote reusability, and allow for greater flexibility in object interactions.

# Strategy
Designed in C#. It enables the selection of an algorithm at runtime from a family of interchangeable algorithms. It defines a set of algorithms, encapsulates each one, and makes them interchangeable within a context object. The context object can vary its behavior by delegating to different strategy objects. It is a useful tool for building software systems that require runtime flexibility in algorithm selection and behavior.
