# WhisperWatch
This is a website, mqtt subscriber and backend for the WhisperWatch application. It subscribes to a 
Webserver is build with the ASP.NET Core Web Application API template.

## Dependencies
- Node.Js
- NPM
- .NET Core 3.1

## Getting started
- Configure database settings in `Core.Webserver/appsettings.json`
- Configure mqtt host, optional password and topic in settings in `MQTT.Webserver.Subscriber/appsettings.json`
- Open a command line in `Core.Webserver/FrontEnd`
- Run ``npm install``
- Run ``npm run build``
- Open solution in Visual Studio 2019
- Build

### Optional
Files found under `Classes.Webserver/Data/*Context` can be configured to use other initialization data.

