## Overview

An example Playwright Framework with MSTest utilising the Page Object Model in order to demonstrate its capability for e2e UI automation.

## Why Playwright?

- Hugely popular Framework with tons of support which makes debugging and problem-solving easier
- Works with most popular languages
- Can also be used for API testing
- Modern means it's easier to navigate and setup


## Tech Stack

- .NET 8 (LTS)
- Playwright for .NET
- MSTest
- C#

## What you need

- .NET 8 SDK

## How to setup

- git clone the repo
- Open the project
- populate the props.env with the URL of the website in the Task
- Run `winget install Microsoft.DotNet.SDK.8` in the terminal to get .Net8 and the SDK in one go
- Run `dotnet restore` get the packages for MSTest and Playwright
- Run `dotnet build` so you can build the project
- remove `PlaywrightTests.sln` from the root directory as it will prevent test execution
- Run `dotnet test` to execute all tests











