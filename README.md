# Introduction
This is the official open-source repository for the [Learning Hub](https://learninghub.nhs.uk/) platform. 

The Learning Hub is the national digital learning platform providing easy access to a wide range of educational resources and support for the health and care workforce and educators.

The Learning Hub is provided and supported by the Technology Enhanced Learning Platforms team at [NHS England](https://www.england.nhs.uk/).

# Getting Started

## Required installs
- [Visual Studio Professional 2022](https://visualstudio.microsoft.com/downloads/) or other suitable An IDE that supports the Microsoft Tech Stack
  - Make sure you have the [NPM Task Runner](https://marketplace.visualstudio.com/items?itemName=MadsKristensen.NPMTaskRunner) extension
- [Git](https://git-scm.com/download)

## Getting the code
Clone the repository from [GitHub](https://github.com/TechnologyEnhancedLearning/LearningHub.Nhs.Models):

```bash
git clone git@github.com:(https://github.com/TechnologyEnhancedLearning/LearningHub.Nhs.Models.git)
```

## Build the solution
You should now be able to open the solution in your IDE by finding and opening the `LearningHub.Nhs.Models` file.
To build the solution, open the LearningHub.Nhs.Models.sln file in Visual Studio 2022 and build the solution using the standard build process.


# LearningHub.Nhs.Models

## Overview
This repository contains a Visual Studio 2022 solution with two projects that create NuGet packages. 

## Projects
1. elfhHub.Nhs.Models
Description: elfhHub.Nhs.Models is a .NET 6.0 class library that defines a set of models for elfh solution.

2. LearningHub.Nhs.Models
Description: LearningHub.Nhs.Models is a .NET 6.0 class library that defines a set of models for learninghub solution.

Both elfhHub.Nhs.Models and LearningHub.Nhs.Models are configured to create NuGet packages upon build and the version number can be configured in Package settings

## Steps to Create NuGet Packages
	- Build the solution.
	- Navigate to the bin directory of each project.
	- You will find the generated NuGet packages in the Release or Debug folder.

# Publishing NuGet Packages
You can publish the generated NuGet packages to a NuGet feed using the dotnet nuget push command or through Visual Studio's NuGet Package Manager.

# Usage
# Installation
You can install the package via NuGet Package Manager or by running the following command in the Package Manager Console:

```bash
Install-Package elfhHub.Nhs.Models
````

```bash
Install-Package LearningHub.Nhs.Models
````

# Contribute
If you are interested in contributing to the Learning Hub, please contact [support@learninghub.nhs.uk](mailto:support@learninghub.nhs.uk)

# License
This project is licensed under the MIT License. See the LICENSE file for details.
