# MVVM Advantages

The MVVM pattern is ultimately the modern interpretation of the MVC pattern, so the main goal is still the same to provide a clear separation between domain logic and presentation layer. Here are some of the advantages of MVVM pattern.

The key benefit is allowing true separation between the View and Model beyond achieving separation and the efficiency that you gain from having that. What that means is that when your model needs to change, it can be changed easily without the view needing to and vice-versa.

There are three important key:

### Maintainability
* A clean separation of different kinds of code should make it easier to go into one or several of those more granular and focused parts and make changes without worrying.
* That means you can remain agile and keep moving out to new releases quickly.

### Testability
* With MVVM each piece of code is more granular and if it is implemented right your external and internal dependences are in separate pieces of code from the parts with the core logic that you would like to test.
* That makes it a lot easier to write unit tests against a core logic.
* Make sure it works right when written and keeps working even when things change in maintenance.

### Extensibility
* It sometimes overlaps with maintainability, because of the clean separation boundaries and more granular pieces of code.
* You have a better chance of making any of those parts more reusable.
* It has also the ability to replace or add new pieces of code that do similar things into the right places in the architecture.
