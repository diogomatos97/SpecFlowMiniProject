# SpeckFlowMiniProject



#### Project Description

This project consists of a testing framework for the https://www.saucedemo.com/ website, using Page Object Model (POM) with Specflow to automate the end to end process of  a customer login in and purchasing a product.



#### NuGet Packages Required:

- [NUnit](https://nunit.org/)
- [NUnit Test Adapter](https://docs.nunit.org/articles/vs-test-adapter/Adapter-Installation.html)
- [Specflow and Specflow NUnit](https://specflow.org/)
- [Selenium and Selenium Chrome Driver](https://www.selenium.dev/)



#### Class Diagram

![]()



#### Usage

###### 1 - Clone Repository

Using CLI:

```
gh repo clone diogomatos97/SpeckFlowMiniProject
```



###### 2 - Run Available Tests 

![]()

With the Visual Studio Test Explorer, click on "Run All" to run the available tests for this solution.



###### 3 - Visualise the output:

In the SeleniumDriverConfig class,

![]()



Comment out the following line:

```c#
options.AddArgument("headless");
```

