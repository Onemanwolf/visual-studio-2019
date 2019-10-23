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
#### If you do not see the Console App (.NET Core) template, you can install it from the Create a new project window. In the Not finding what you're looking for? message, choose the Install more tools and features link.

 #### Then, in the Visual Studio Installer, choose the .NET Core cross-platform development workload.

 #### After that, choose the Modify button in the Visual Studio Installer. You might be prompted to save your work; if so, do so. Next, choose Continue to install the workload. Then, return to step 2 in this "Create a project" procedure. 


4. In the `Configure your new project` window, type or enter Calculator in the `Project name` box. Then, choose `Create`.

![alt text](https://github.com/Onemanwolf/visual-studio-2019/blob/master/docs/images/csharp-name-your-calculator-project.png?raw=true "Request Pipeline")

Visual Studio opens your new project, which includes default "Hello World" code.
Create the app

First, we'll explore some basic integer math in C#. Then, we'll add code to create a basic calculator. After that, we'll debug the app to find and fix errors. And finally, we'll refine the code to make it more efficient.
Explore integer math

Let's start with some basic integer math in C#.
In the code editor, delete the default "Hello World" code.

Specifically, delete the line that says, Console.WriteLine("Hello World!");.
In its place, type the following code:
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


`Notice` that when you do so, the IntelliSense feature in Visual Studio offers you the option to autocomplete the entry.

`Choose Calculator` to run your program, or `press F5`.

A console window opens that reveals the sum of 42 + 119, which is 161.

(Optional) You can change the operator to change the result. For example, you can change the + operator in the int c = a + b; line of code to - for subtraction, * for multiplication, or / for division. Then, when you run the program, the result changes, too.
Close the console window.

## Improved search

Formerly known as Quick Launch, our new search experience is faster and more effective. Now, search results appear dynamically as you type. And, search results can often include keyboard shortcuts for commands, so that you can more easily memorize them for future use.



