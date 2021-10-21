# Federico Rossi #

# Portfolio site

Hi and welcome to the repo of my portfolio [site](https://artipo.github.io).
<br>
Powered by [F#](https://docs.microsoft.com/en-us/dotnet/fsharp/what-is-fsharp) and [Fable](https://github.com/fable-compiler/Fable).

The site is design as a spa, using the [Elmish](https://github.com/elmish/elmish) library.<br>
The styling is done through the use of the [Fss](https://github.com/Bjorn-Strom/FSS) library.

## Requirements

* [dotnet SDK](https://www.microsoft.com/net/download/core) 3.1 or higher
* [node.js](https://nodejs.org) with [npm](https://www.npmjs.com/)
* An F# editor like Visual Studio, Visual Studio Code with [Ionide](http://ionide.io/) or [JetBrains Rider](https://www.jetbrains.com/rider/).

## Running the app

* Install JS dependencies (this will also invoke `dotnet tool restore`, check package.json scripts): `npm install`
* Run Fable and Webpack server: `npm start`
* After the first compilation is finished, in your browser open: http://localhost:8080/

## Building to static html

* Instead of `npm start` run `npm build` and the Html, css and javascript produced will be found in ./public