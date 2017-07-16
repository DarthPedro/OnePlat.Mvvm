# Minimal Implementation

The minimal implementation needed for MVVM on the Windows platforms includes:
* Model classes that are defined as POCOs (Plain Old C# Objects), possibly with DataAnnotations for validation, but no real business logic.
* Model classes should implement INotifyPropertyChanged interface for updates to/from the view.
* View defined in XAML declarative language with databinding to the view-model and model properties.
* View DataContext is set to the corresponding view-model. This is how the view has a reference to its view-model
* View-model implements INotifyPropertyChanged interface for property updates to/from the view.
* View-model collection properties are ObservableCollections (the .NET Framework has an implementation of this).
* View-model exposes commands (implements ICommand) that perform operatoin on its data and the model.

There are frameworks with far richer implementations. Many of those begin managing the application lifecycle, navigation between pages, and the services that applications use. As you advance in your use of MVVM and build richer applications, those services really help you build testable and maintainable code. But those are actually application frameworks with MVVM as their core pattern.

In many frameworks, dependency injection is integrated in the MVVM framework. While that may be helpful in more complex scenarios and usages, it also makes it more difficult to learn the priniciples of MVVM. Not only do you need to learn the concepts of the MVVM pattern, you also need to learn about their dependency injection system.
