[![Build Status](https://travis-ci.org/joemccann/dillinger.svg?branch=master)](https://travis-ci.org/joemccann/dillinger)
[![GitHub version](https://badge.fury.io/gh/Naereen%2FStrapDown.js.svg)](https://github.com/Naereen/StrapDown.js)



![Coverage](https://github.com/renanvolkers/DesignPatterns/main/coverage_badge.svg?sanitize=true)

# Main Stacks
* .NET 7 
* Minimal API
* Entity Framework


# Abstract Factory
Is a creational design pattern that lets you produce families of related objects without specifying their concrete classes.

# Exemple 1 
For example, in a pizza store, you may want to use the Abstract Factory pattern to create different types of pizzas. The factory would have a method for creating a pizza, and depending on the type of pizza you want to create, it will return an object of the appropriate class.

The Abstract Factory pattern would consist of two main parts: the factory interface and the concrete factories. The factory interface would define the method for creating a pizza, and the concrete factories would implement this method.

For example, you might have a factory interface called PizzaFactory, which has a method called createPizza() that takes a string argument specifying the type of pizza to create. You would then have concrete factories for each type of pizza, such as MargheritaPizzaFactory and PepperoniPizzaFactory, which would implement the createPizza() method.

When a customer orders a pizza, the pizzastore creates a factory according to the type of pizza, passing the type of pizza to the method createPizza().The factory creates the pizza and returns it to the pizzastore, which can then add toppings, bake it and serve it to the customer.

In this way, the pizzastore can create different types of pizzas without having to know the specific details of how they are made, making it more flexible and easier to add new types of pizzas in the future.
![image](https://user-images.githubusercontent.com/5272594/212394401-462cbd0f-98a2-4279-9365-a1b8be912808.png)


# Exemple 2 
Context command interface provides access to all non CRUD database operations.
Using two Context Entity Framework and MongoDb

UML Exemple 2
![image](https://user-images.githubusercontent.com/5272594/212362046-999926ff-6d68-4e2b-be77-b66099b474c6.png)

