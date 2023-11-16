# EmbedAssemlyTest

## Description

This repository showcases a comparative study of Xamarin.Android applications and libraries, focusing on the transition from .NET Standard 2.1 to .NET 7.0 and the adaptation to .NET MAUI. It contains two main folders: `BeforeWithNetStandard2.1` and `AfterMigrationToNet7.0`, each illustrating the project's state before and after the migration, respectively.

## Folder Structure

### BeforeWithNetStandard2.1

This folder represents the projects' state before the migration to .NET 7.0 and MAUI. It includes:

- **EmbedAssemlyTestOld (App Project)**: A Xamarin.Android App Project using .NET Standard 2.1.
  - **EmbedTestOld.AndroidLibrary1**: Directly referenced with `var androidClass1 = new AndroidClass1();`
  - **EmbedTestOld.AndroidLibrary2**: Not directly referenced.
  - **EmbedTestOld.ClassLibrary1**: Directly referenced with `var class1 = new Class1();`
  - **EmbedTestOld.ClassLibrary2**: Not directly referenced.

### AfterMigrationToNet7.0

This folder contains the projects after migration to .NET 7.0, aligning with the new .NET MAUI framework.
- **EmbedAssemlyTestNew (App Project)**: A .NET 7.0 App Project post-migration.
  - **EmbedTestNew.AndroidLibrary1**: Directly referenced with `var androidClass1 = new AndroidClass1();`
  - **EmbedTestNew.AndroidLibrary2**: Not directly referenced.
  - **EmbedTestNew.ClassLibrary1**: Directly referenced with `var class1 = new Class1();`
  - **EmbedTestNew.ClassLibrary2**: Not directly referenced.

## Core Issue

A key focus of this repository is the investigation of assembly loading behavior in both versions of the app project. In `EmbedAssemlyTestOld`, all four projects are loaded into the assembly, despite only two being directly referenced. Conversely, in `EmbedAssemlyTestNew`, only the two directly referenced projects are loaded into the assembly. This difference highlights a significant change in assembly loading behavior between .NET Standard 2.1 and .NET 7.0.
