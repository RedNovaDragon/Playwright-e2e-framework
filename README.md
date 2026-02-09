## Baby's first readme

An example Playwright Framework using Page Object Model in order to demonstrate its capability for e2e UI automation.
Built from my sweat and tears, it contains a single magnificent test which also happens to work!

## Tech Stack

- .NET 8 (LTS)
- Playwright for .NET
- MSTest
- C#

## What you need

- .NET 8 SDK
- PowerShell (Windows)
- Playwright installed

## How to setup

- git clone the repo
- Run `winget install Microsoft.DotNet.SDK.8` to get .Net8 and the SDK in one go
- Run `dotnet add package Microsoft.Playwright.MSTest` to get MSTest for Playright
- Run `dotnet build` so you can build the project
- Run `pwsh bin/Debug/net8.0/playwright.ps1 install` so you will get the nessecary Browsers for Playwright - (this Framework tests only on Chromium)
- Run `dotnet test` to execute all tests











