## Overview

An example Playwright Framework with MSTest utilising the Page Object Model in order to demonstrate its capability for e2e UI automation.

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
- Open the project
- Run `winget install Microsoft.DotNet.SDK.8` in the terminal to get .Net8 and the SDK in one go
- Run `winget install Microsoft.PowerShell` to install Powershell
- Run `dotnet restore` get the packages for MSTest and Playwright
- Run `dotnet build` so you can build the project
- Run `pwsh bin/Debug/net8.0/playwright.ps1 install` so you will get the nessecary Browsers for Playwright - (this Framework tests only on Chromium)
- Run `dotnet test` to execute all tests











