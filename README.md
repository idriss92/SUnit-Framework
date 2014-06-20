#SUnit 

**Sunit**  is a free home made test framework, created step by step to learn how to create one 
and understand the problems and techniques used in this kind of framework


##What is SUnit ?
SUnit is a unit-testing framework for all **c#** language. The current production release, version 1.0, is the first production of SUnit test framework. It is written entirely in C# and take advantage of many .NET language features, for example custom attributes and other reflection related capabilities. The framework used for this project is .NET 4.5 doesn't means it can't works with another .NET Framework .


For a user **SUnit** is subdivised into two main parts :

* The test framework to reference in your test projects
* The runner to execute the tests



##Description the 2 main parts

###1.Test Framework

This part contains 3 parts : 

1. Core: It contains our 2 main attributes that identify the test cases :
	  *	Decorate tests classes with `TestClass`
	  *	Decorate tests methods with `Test`

2. Assertions: It contains our Assert Class as main assertion

3. Exceptions : It contains each Customize `Exception` for our each `Assert method`	

(**) each Assert method can take an optional expected message  

###2.The Runner

The runner is a console executable. It takes a dll as argument and set the
working path to the parent folder of the library in order to load
dependencies correctly.

It will search the library for TestClasses, find each test method 
and then instantiates the class and executes the method for each test.


The runner when executed should print a header with it's name, it's version in clean form and a starting and ending time

Then it prints in a nice way:

	X tests found, Y success, Z failed.

It's printed in green if `all` tests pass, in red if at least
`one`test fails.

If tests failed then it's able to print for each one:

* The full name of the tested method (ex : `MyApp.Web.Tests.HomeControllerTests.ShouldGetOkWhenCallRoot()`)
* The type of the verification(s) (ex: `IsTrue verification failed`)
* The error message that comes with each verification (ex: `expected True instead of False`)


## Process 
We try to work in **TDD** (Test Driven Developpement) mode and test at least the things that we feel have more value!

The target was to do modern C# programming, so, we try to apply as possible clean and modern C# (solid,lambdas,anonymous,etc...). 

## End word


## How does it works ?
You have to have on your computer .NET Framework 4.5 if you don't want to configure our build script.

Once you get it or if you have it yet,
We have a building script:

* it build your sources from command line
* run your tests
* if everything is ok, then copy executable and libraries to an artifacts folder


For simple user your have to fork the project : 
1. For the repository
2. Create a Class Library project for your Unit test in Sample Directory
 	*  <a><img src="https://github.com/idriss92/SUnit-Framework/blob/master/Project/SUnit/Nouveau%20projet.PNG" title="SUnit.net"</a>
 	
2. Then Then Create your `TestClass` : Exemple
 	* <a><src="https://github.com/idriss92/SUnit-Framework/blob/master/Project/SUnit/TestClass.PNG" title="SUnit.net" /></a>

3. Add in reference the SUnit.Framework.dll in your project
4. Then Go to the content of SUnit directory and double click on build_user. Should print something like :
5. 
	* <a><img src="https://github.com/idriss92/SUnit-Framework/blob/master/Project/SUnit/Worked.PNG title="SUnit.net" /></a>
 	
	
	* Add in reference The SUnit.Framework.dll in your file.
	* Then Go to the content of SUnit directory and double click on build_user


For more information you can watch the documentation:
* it explain the tool
* it explain how to use your tool and write tests


