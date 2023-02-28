[![Build Status](https://travis-ci.org/joemccann/dillinger.svg?branch=master)](https://travis-ci.org/joemccann/dillinger)
[![GitHub version](https://badge.fury.io/gh/Naereen%2FStrapDown.js.svg)](https://github.com/Naereen/StrapDown.js)



![Coverage](https://github.com/renanvolkers/DesignPatterns/main/coverage_badge.svg?sanitize=true)

# Main Stacks
* .NET 7 
* Minimal API



# Singleton
is a creational design pattern that lets you ensure that a class has only one instance, while providing a global access point to this instance.

We must pay attention to the use of AddSingleton, it is important to know when to use it, since we will always have the
same information (Same instance) of the object for all users of the application.

In a Mobile or Desktop App, where we only have one user or even in Blazor WASM, this is not a problem, but on the web it is different.

ASP.NET applications are constantly running, serving different users, so be careful when using
   o Singleton, since the data will be shared between all requests.

# Get Instance

![image](https://user-images.githubusercontent.com/5272594/221732770-26d12fcf-d1a2-4298-b1fc-f0816fc4baba.png)


Configuration Program EntityFramework
//builder.Services.AddIdentityEntityFrameworkContextConfiguration(options =>
//    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"),
//    b => b.MigrationsAssembly("MinimalPilot")));



