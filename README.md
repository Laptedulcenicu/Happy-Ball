# Happy-Ball

## How to try the game? 
The game can be tested from the phone, by downloading the HappyBall.apk. Also in "Screenshots" you can find the main screenshots that will help you to understand the game logic. You can find the patterns in Happy-Ball/Happy Ball/Assets/Scripts

## Introduction
Our team designed a simple survival game Happy Ball. The main character is the white ball, its life is represented by the green bar at the top of the screen. The goal is to keep the ball alive. It can lose its power by a simple touch of an enemy. Enemies are designed as smaller balls than will change their trajectory based on main ball movement. 
We created 3 types of enemies in order to implement the desired design patterns. One is very fast but has little life, another one has more life but is slower. The third one takes more life from our main ball, but his movement is not based on the ball.


## The patterns that we have used 
### Singleton
Singleton is a creational design pattern that lets you ensure that a class has only one instance, while providing a global access point to this instance. To implement the pattern, it is needed to take the default constructor private, to prevent other objects from using the new operator with the Singleton class and to create a static creation method that acts as a constructor. Under the hood, this method calls the private constructor to create an object and saves it in a static field. All following calls to this method return the cached object. Object Pools are usually implemented as Singletons. Object pools are used to manage the object caching. A client with access to an Object pool can avoid creating a new Objects by simply asking the pool for one that has already been instantiated instead.  Object pooling can offer a significant performance boost. It is most effective in situations where the cost of initializing a class instance is high, the rate of instantiation of a class is high, and the number of instantiations in use at any one time is low.

### Factory method
Factory method is a design pattern that helps us create and manage new objects of different classes. To implement factory method, we would have to make a general interface for objects to follow. That interface should declare methods that would make sense for all types of classes, then, we should add an empty factory method inside the creator class. The return type of the method should match the common type interface. Now, create a set of creator subclasses for each type of object listed in the factory method. Override the factory method in the subclasses and extract the appropriate bits of construction code from the base method. 

### Bridge
Bridge: is one of structural design patterns that came up to split a big class into different and independent structures. It appeared as a solution to a well-known problem which is adding an optional feature to a hierarchy of classes. As a result, it is needed to create for each existing class a combination with that new feature. The hierarchy will grow in this case exponentially. For example, if we have a class mobile with subclasses as iPhone and Samsung, adding a new feature like memory will force us to make new classes iPhone 64GB and iPhone 256GB for example, same with another phone type. Using this pattern, we will separate this feature in an independent hierarchy (through composition). In this way a bridge is creating from our initial superclass and the “feature” class.

### Memento
Memento is a behavioral design pattern that lets you save and restore the previous state of an object without revealing the details of its implementation. This pattern is used when you need to save the state of object. But because the encapsulation you can't access all needed fields, either you need to make all fields public or restrict access to their state, making it impossible to change the state. This pattern delegates creating the state snapshots to actual owner, the object. Instead of other objects trying to copy the original class the class itself can make snapshot. It is implemented using: nested classes, or intermediate interface. Memento is used when you want to produce snapshots of the object's state to be able to restore to a previous state of object, or when direct access to the object's fields/getters/setters violates its encapsulation.

### Enjoy the game
