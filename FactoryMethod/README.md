[![Build Status](https://travis-ci.org/joemccann/dillinger.svg?branch=master)](https://travis-ci.org/joemccann/dillinger)
[![GitHub version](https://badge.fury.io/gh/Naereen%2FStrapDown.js.svg)](https://github.com/Naereen/StrapDown.js)



![Coverage](https://github.com/renanvolkers/DesignPatterns/main/coverage_badge.svg?sanitize=true)

# Main Stacks
* .NET 7 
* Minimal API
* Entity Framework
* ChatGpt


# Factory Method
The Factory Method design pattern defines an interface for creating an object, but let subclasses decide which class to instantiate. This pattern lets a class defer instantiation to subclasses.

# Example Translate
For example, in a Language Grammar, you may want to use the Factory Method pattern to create different types of Laguage. The factory would have a method for creating a Grammar, and depending on the type of Grammar you want to create, it will return an object of the appropriate class.

