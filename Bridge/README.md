[![Build Status](https://travis-ci.org/joemccann/dillinger.svg?branch=master)](https://travis-ci.org/joemccann/dillinger)
[![GitHub version](https://badge.fury.io/gh/Naereen%2FStrapDown.js.svg)](https://github.com/Naereen/StrapDown.js)



![Coverage](https://github.com/renanvolkers/DesignPatterns/main/coverage_badge.svg?sanitize=true)

# Main Stacks
* .NET 7 
* Minimal API



# Bridge
Is a structural design pattern that lets you split a large class or a set of closely related classes into two separate hierarchies—abstraction and implementation—which can be developed independently of each other.

Abstraction(ContentWriter): This is the interface that defines the operation and maintains a reference of the Implementor.
RefinedAbstraction(SalaryCalculator): This is a concrete class that implements the Abstraction interface and provides a variant functionality.
Implementor(IFileWriter): This is the interface that declares the common functionality for all the concrete implementors. The Abstraction uses the reference of it to communicate with the implementation at runtime.
ConcreteImplementor(JSONWriter,XMLWriter): This is the concrete class that implements the Implementor interface and provides the actual functionality.

# Register Staff 



Configuration Program EntityFramework
//builder.Services.AddIdentityEntityFrameworkContextConfiguration(options =>
//    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"),
//    b => b.MigrationsAssembly("MinimalPilot")));



