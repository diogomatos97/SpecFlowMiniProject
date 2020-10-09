# SpeckFlowMiniProject



#### Project Description

This project consists of a testing framework for the [Swag Labs](https://www.saucedemo.com/) demo website, using Page Object Model (POM) with Specflow and Selenium to automate the end to end process of  a customer login in and purchasing a product.

Specflow is a testing tool that allows to convert requirement user stories (Gherkin Syntax) into test cases, with the use of Behaviour Driven Development (BDD) methodology.

Selenium allows to identify page elements and web components to easily interact with (click buttons, fill forms). It also provides web drivers which allow users to initialize a web within a test case.



#### NuGet Packages Required:

- [NUnit](https://nunit.org/)
- [NUnit Test Adapter](https://docs.nunit.org/articles/vs-test-adapter/Adapter-Installation.html)
- [Specflow and Specflow NUnit](https://specflow.org/)
- [Selenium and Selenium Chrome Driver](https://www.selenium.dev/)



#### Class Diagram

![](https://github.com/diogomatos97/SpeckFlowMiniProject/blob/main/images/classDIagram.PNG)



#### Usage

###### 1 - Clone Repository

Using CLI:

```
gh repo clone diogomatos97/SpeckFlowMiniProject
```



###### 2 - Run Available Tests 

![](https://github.com/diogomatos97/SpeckFlowMiniProject/blob/main/images/Tests.PNG)

With the Visual Studio Test Explorer, click on "Run All" to run the available tests for this solution.



###### 3 - Visualise the output:

In the SeleniumDriverConfig class,

![](https://github.com/diogomatos97/SpeckFlowMiniProject/blob/main/images/driver%20config.PNG)



Comment out the following line:

```c#
options.AddArgument("headless");
```



#### Project Review

During this project, it was able to achieve partial state - transition testing, as the main focus was to test the buying path that a customer would take. 



#### Project Retrospective

During this project, timeboxing method was used, as to split the projects into smaller task (create framework, create individual page model, create scenarios for test cases). This provided to be a good technique which sped up the process of creating the testing framework. As to blockers encountered during the project, there were no significant found.  