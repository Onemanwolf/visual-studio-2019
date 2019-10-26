# Debug

## Visual Studio 2019

### Data Break Points

[Video](https://www.youtube.com/watch?v=hr72Fs8n_9c)


Performance gains
We've taken the once-exclusive C++ data breakpoints and adapted them for .NET Core applications.

```
Demo: 


We taken the exclusive c++ break points and adapted them for .Net Core applications
these break points allow to watch a specific object property even when it goes out of
scope and when that object property changes setting the data break point is as simple
as searching for the object property you are interested in with the new debug search 
tool locating the objec property right clicking it and select break when value 
changes from there you can press F5 to conitune and then you will recieve a
notification popup informing you the change accord and where it occured.


1. Place Break point on the switch statement of the  itemFetched.

2. Start Degugging press F5 once the Break Point is heat goto the search tool in Debug window search for Legs.

3. Right click Legs in the below Search Results and select Break when value changes from the options listed Note: notice the value is 4.

4. Click Continue a Data Break Point Hit PopUP Window stating the value was changed in the Call Stack window you can see where was changed click on the stack items to examine the where it chnaged in the App during run time
```
![alt text](https://github.com/Onemanwolf/visual-studio-2019/blob/master/docs/images/debug-data-breakpoints.gif?raw=true "Request Pipeline")

So whether you're coding in C++ or .NET Core, data breakpoints can be a good alternative to just placing regular breakpoints. Data breakpoints are also great for scenarios such as finding where a global object is being modified or being added or removed from a list.

And, if you're a C++ developer who develops large applications, Visual Studio 2019 has made symbols out of proc, which allows you to debug those applications without experiencing memory-related issues.

### Search while debugging
You've probably been there before, looking in the Watch window for a string amongst a set of values. In Visual Studio 2019, we've added search in the Watch, Locals, and Autos windows to help you find the objects and values you're looking for.

![alt text](https://github.com/Onemanwolf/visual-studio-2019/blob/master/docs/images/debug-window-search.gif?raw=true "Request Pipeline")




```
  Demo:

```

You can also format how a value is displayed within the Watch, Locals, and Autos windows. Double-click one of the items in any of the windows and add a comma (",") to access the drop-down list of possible format specifiers, each of which includes a description of its intended effect.

![alt text](https://github.com/Onemanwolf/visual-studio-2019/blob/master/docs/images/search-watch-window.png?raw=true "Request Pipeline")

For more information, see the [Enhanced in Visual Studio 2019: Search for Objects and Properties in the Watch, Autos, and Locals Windows](https://devblogs.microsoft.com/visualstudio/enhanced-in-visual-studio-2019-search-for-objects-and-properties-in-the-watch-autos-and-locals-windows/) blog post.

```
 Demo: 

```

### Snapshot Debugger
Get a snapshot of your app's execution in the cloud to see exactly what's happening. (This feature is available in Visual Studio Enterprise, only.)

![alt text](https://github.com/Onemanwolf/visual-studio-2019/blob/master/docs/images/snapshot-debugger.gif?raw=true "Request Pipeline")

We've added support for targeting ASP.NET (Core and desktop) applications that run on an Azure VM. And, we've added support for applications that run in an Azure Kubernetes Service. The Snapshot Debugger can help you dramatically reduce the time it takes to resolve issues that occur in production environments.

For more information, see the [Debug live ASP.NET Azure apps using the Snapshot Debugger](https://docs.microsoft.com/en-us/visualstudio/debugger/debug-live-azure-applications?view=vs-2019) page, and the [Introducing Time Travel Debugging for Visual Studio Enterprise 2019](https://devblogs.microsoft.com/visualstudio/introducing-time-travel-debugging-for-visual-studio-enterprise-2019/) blog post.

### Microsoft Edge Insider support
New in 16.2: You can set a breakpoint in a JavaScript application and start a debug session by using the [Microsoft Edge Insider](https://www.microsoftedgeinsider.com/en-us/) browser. When you do so, Visual Studio opens a new browser window with debugging enabled, which you can then use to step through application JavaScript within Visual Studio.



### Debug Javascript

![alt text](https://github.com/Onemanwolf/visual-studio-2019/blob/master/docs/images/snapshot-debugger.gif?raw=true "Request Pipeline")

[Debug JavaScript in Microsoft Edge from Visual Studio](https://devblogs.microsoft.com/visualstudio/debug-javascript-in-microsoft-edge-from-visual-studio/)

[Microsoft Edge Insider](https://www.microsoftedgeinsider.com/en-us/)

[Microsoft Edge Insider](https://www.microsoftedgeinsider.com/en-us/)




Install [16.3 release](https://devblogs.microsoft.com/visualstudio/debug-javascript-in-microsoft-edge-from-visual-studio/)