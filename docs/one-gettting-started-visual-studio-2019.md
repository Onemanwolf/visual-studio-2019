# Getting Started

## Visual Studio 2019

[Docs Reference](https://docs.microsoft.com/en-us/visualstudio/ide/whats-new-visual-studio-2019?view=vs-2019)


Install [16.3 release](https://docs.microsoft.com/en-us/visualstudio/releases/2019/release-notes)

With Visual Studio 2019, you'll get best-in-class tools and services for any developer, any app, and any platform. Whether you're using Visual Studio for the first time or you've been using it for years, there's a lot to like in this new version!

Here's a high-level recap of what's new:

Develop: Stay focused and productive with improved performance, instant code cleanup, and better search results.

Collaborate: Enjoy natural collaboration through a Git-first workflow, real-time editing and debugging, and code reviews right in Visual Studio.
Debug: Highlight and navigate to specific values, optimize memory use, and take automatic snapshots of your application's execution.
For a complete list of everything that's new in this version, see the release notes.

## Create New Project
[Getting Started](https://docs.microsoft.com/en-us/visualstudio/get-started/csharp/?view=vs-2019)

To start, we'll create a C# application project. The project type comes with all the template files you'll need, before you've even added anything!

1. Open Visual Studio 2019.  [`tip:` right click run as Admin.]
2. On the start window, choose Create a `new project`.


![alt text](https://github.com/Onemanwolf/visual-studio-2019/blob/master/docs/images/create-new-project-dark-theme.png?raw=true "Request Pipeline")


3. On the `Create a new project` window, enter or type console in the search box. Next, choose `C#` from the Language list, and then choose `Windows` from the Platform list.

After you apply the language and platform filters, choose the `Console App (.NET Core)` template, and then choose `Next`.

![alt text](https://github.com/Onemanwolf/visual-studio-2019/blob/master/docs/images/csharp-create-new-project-search-console-net-core-filtered.png?raw=true "Request Pipeline")

 `Note:` 
 >If you do not see the Console App (.NET Core) >template, you can install it from the Create a new >project window. In the Not finding what you're >looking for? message, choose the Install more tools >and features link.
>
 >Then, in the Visual Studio Installer, choose the >.NET Core cross-platform development workload.
>
 >After that, choose the Modify button in the Visual >Studio Installer. You might be prompted to save >your work; if so, do so. Next, choose Continue to >install the workload. Then, return to step 2 in >this "Create a project" procedure. 


4. In the `Configure your new project` window, type or enter Calculator in the `Project name` box. Then, choose `Create`.

![alt text](https://github.com/Onemanwolf/visual-studio-2019/blob/master/docs/images/csharp-name-your-calculator-project.png?raw=true "Request Pipeline")

Visual Studio opens your new project, which includes default "Hello World" code.
Create the app

First, we'll explore some basic integer math in C#. Then, we'll add code to create a basic calculator. After that, we'll debug the app to find and fix errors. And finally, we'll refine the code to make it more efficient.
Explore integer math

Let's start with some basic integer math in C#.
In the code editor, delete the default "Hello World" code.

Specifically, delete the line that says, Console.WriteLine("Hello World!");.
In its place, `type` the following code:
C#

``` Copy
//error for debug example
        int a = 42;
        int b = 119;
        int c = a + b;
        Console.WriteLine(c);
        Console.ReadKey();
//error        
```


 Notice: 
 > that when you do so, *the IntelliSense 
 > feature in Visual Studio offers you the option to
 > autocomplete the entry.

![alt text](https://github.com/Onemanwolf/visual-studio-2019/blob/master/docs/images/integer-math-intellisense.gif?raw=true "Request Pipeline")

5. `Choose Calculator` to run your program, or `press F5`.

A console window opens that reveals the sum of 42 + 119, which is 161.

(Optional) You can change the operator to change the result. For example, you can change the + operator in the int c = a + b; line of code to - for subtraction, * for multiplication, or / for division. Then, when you run the program, the result changes, too.
Close the console window.

## Improved search

```
  Demo search:

  Search for Font Ctrl + Q  font  change font. 
  Search for Class  add Class MyAwesome New Class
  



```





Formerly known as Quick Launch, our new search experience is faster and more effective. Now, search results appear dynamically as you type. And, search results can often include keyboard shortcuts for commands, so that you can more easily memorize them for future use.


The new fuzzy search logic will find anything you need, regardless of typos. So, whether you're looking for commands, settings, documentation, or other useful things, the new search feature makes it easier to find what you're looking for.

## Refactorings
There are lots of new and highly useful refactorings in C# that make it easier to organize your code. They show up as suggestions in the light bulb and include actions such as moving members to interface or base class, adjusting namespaces to match folder structure, convert foreach-loops to Linq queries, and more.

```
  Demo search:

Search for Class  add Class MyAwesome New Class create Dog class.
 
  Ctrl + . inside  
  
  type `: IAnimal` after Dog as below:
   class Dog : IAnimal
    {
    }
click inside IAnimal Ctrl + .
`Select` create Interface in another file

goto IAnimal file double click add Leg Property
internal interface IAnimal
    {

        int Legs { get; set;}
    }

inside dog class type this method
class Dog : IAnimal
    {
    }

```
img

Simply invoke the refactorings by pressing Ctrl+. and selecting the action you want to take.

## IntelliCode
Visual Studio IntelliCode enhances your software development efforts by using artificial intelligence (AI). IntelliCode trains across 2,000 open-source projects on GitHub—each with over 100 stars—to generate its recommendations.

img

Here are a few ways that Visual Studio IntelliCode can help enhance your productivity:

Deliver context-aware code completions
Guide developers to adhere to the patterns and styles of their team
Find difficult-to-catch code issues
Focus code reviews by drawing attention to areas that really matter
We initially supported only C# when we first previewed the IntelliCode as an extension for Visual Studio. Now, new in 16.1, we've added support for C# and XAML "in-the-box". (Support for C++ and TypeScript/JavaScript are still in preview, however.)

And if you're using C#, we've also added the ability to train a custom model on your own code.

For more information about IntelliCode, see the Announcing the general availability of IntelliCode plus a sneak peek and Code more, scroll less with Visual Studio IntelliCode blog posts.

## Code cleanup
Paired with a new document health indicator is a new code cleanup command. You can use this new command to identify and then fix both warnings and suggestions with the click of a button.

The cleanup will format the code and apply any code fixes as suggested by the current settings and .editorconfig files.

img

You can also save collections of fixers as a profile. For example, if you have a small set of targeted fixers that you apply frequently while you code, and then you have another comprehensive set of fixers to apply before a code review, you can configure profiles to address these different tasks.

