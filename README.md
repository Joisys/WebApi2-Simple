# WebApi2-Simple
WebApi2 Simple [OWIN]

## Nuget Packages

- [x] Microsoft.AspNet.WebApi.Core
	- This package contains the core runtime assemblies for ASP.NET Web API. 
	- This package is used by hosts of the ASP.NET Web API runtime. 
	- To host a Web API in IIS use the Microsoft.AspNet.WebApi.WebHost package. 
	- To host a Web API in your own process use the Microsoft.AspNet.WebApi.SelfHost package.

- [x] Microsoft.Owin.Host.SystemWeb
	- OWIN server that enables OWIN-based applications to run on IIS using the ASP.NET request pipeline.

- [x] Microsoft.AspNet.WebApi.Owin
	- This package allows you to host ASP.NET Web API within an OWIN server and provides access to additional OWIN features.

## How to run this applications

- Press F5 to run the application
- Navigate to /location in the browser

##Posible Errors
	- No assembly found containing an OwinStartupAttribute.
		- [x] [assembly: OwinStartup(typeof(WebApi2_Simple.Startup))] (Add to the Startup class attribute)