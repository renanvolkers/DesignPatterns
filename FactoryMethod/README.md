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

# Example Communication Channel
For example, in a Channel comunication, you may want to use the Factory Method pattern to create different types of Channel. The factory would have a method for creating a sendMessage, and depending on the type of channel you want to create, it will return an object of the appropriate class.

![image](https://user-images.githubusercontent.com/5272594/215632218-5e24f296-d295-4928-9665-5477b047bdae.png)
