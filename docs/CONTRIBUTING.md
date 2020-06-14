# Contribute

# Issues, questions and improvements
If you have an issue, question or have any ideas please follow the templates in the issue section provided by this project.

# Coding guidelines
This project follow the [C# Coding Conventions](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/inside-a-program/coding-conventions) provided by Microsoft. All projects are written in C# Version 8 and have turned on the [Nullable reference types](https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-8#nullable-reference-types) language feature.

# Architecture and design
The project is build on the [Clean Architecture](https://blog.cleancoder.com/uncle-bob/2012/08/13/the-clean-architecture.html) by Robert C. Martin (Uncle Bob). The design follows the [Domain-driven design (DDD)](https://en.wikipedia.org/wiki/Domain-driven_design).

To ensure the architecture of the project is kept clean and true [NetArchTest](https://github.com/BenMorris/NetArchTest) is used.

# Test
Each change of the application has to be covered by unit test. Meaning that changes which do not have either new or adapted unit tests will not be accepted by the reviewers.

# Branches
There are two main branches in this project
- master
- development

These two branches are protected and can only be updated by pull request. Each feature, improvement, fix, etc has to be done on its own feature branch which will than be opened against the *development* branch. Pull requests against the master branch are only allowed through the development branch.