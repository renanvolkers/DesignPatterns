[![Build Status](https://travis-ci.org/joemccann/dillinger.svg?branch=master)](https://travis-ci.org/joemccann/dillinger)
[![GitHub version](https://badge.fury.io/gh/Naereen%2FStrapDown.js.svg)](https://github.com/Naereen/StrapDown.js)



![Coverage](https://github.com/renanvolkers/DesignPatterns/main/coverage_badge.svg?sanitize=true)

# Main Stacks
* .NET 7 
* Minimal API



# Prototype
All prototype classes should have a common interface that makes it possible to copy objects even if their concrete classes are unknown. Prototype objects can produce full copies since objects of the same class can access each other’s private fields.

Understanding the Prototype Design Pattern in C#:
Let us understand the Prototype Design Pattern with an example. In C#, when we try to copy one object to another object using the assignment (=) operator, then both the objects will share the same memory address. And the reason is the assignment operator (=) copies the reference, not the object except when there is a value type field. This operator will always copy the reference, not the actual object.

# Example 1 



Configuration Program EntityFramework
//builder.Services.AddIdentityEntityFrameworkContextConfiguration(options =>
//    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"),
//    b => b.MigrationsAssembly("MinimalPilot")));


