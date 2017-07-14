# Model-View-ViewModel Defined

Once an application begins growing in complexity, it’s usually a good idea to impose some kind of structure or architecture on the code. Experience with this process suggests that it’s often best to start thinking about the design perhaps before any code is written at all. In most cases, a well designed program structure strives for a “separation of concerns” where different pieces of the code focus on different tasks.

Model-View-ViewModel (or MVVM) is a design pattern that facilitates the separation of concerns between the graphical user interface – be it via a markup language or GUI code – and the development of the business logic or back-end data model for client applications. There are MVVM models for various platforms, but for .NET we take advantage of XAML and databinding to implement this pattern.

MVVM divides an application into three layers: 

### Model
The Model represents a set of classes that describes the business logic and data. It usually involves loading data from files, database, or web services. In many applications the domain model is defined by those systems.

### View
The View is the user interface or presentation layer, generally implemented in XAML.

### View Model
The View Model is responsible for exposing methods, commands, and other properties that help to maintain the state of the view, manipulate the model as the result of actions on the view, and trigger events in the View itself.

The Model is ignorant of the ViewModel. In other words, the Model knows nothing about the public properties and methods of the ViewModel, and has no reference to it. Similarly, the ViewModel is ignorant of the View. The View only makes calls into the ViewModel or accesses properties of the ViewModel, and the ViewModel similarly only makes calls into the Model or accesses Model properties.

Any communication back from the Model or ViewModel out is done via XAML databindings or events. Event allow the communication to happen but the components remain decoupled. The fullest extent of this principle is the Messenger pattern that is used in MVVM.
 
#### Key Characteristics of Pattern:
1. User interacts with the View.
2. There is many-to-one relationship between View and ViewModel means many View can be mapped to one ViewModel.
3. View has a reference to ViewModel but View Model has no information about the View.
4. Supports two-way data binding between View and ViewModel.

Developers who are passionate about MVVM often expound upon the goal of expressing all interactions between the View and the ViewModel via XAML-based data bindings, and have no code in the page’s code-behind file. While that may be an excellent goal of many developers, it's not an express tenet of MVVM, so if you find you have to write some code there because there isn't a better solution, then do so and move on.

This is the definition of the MVVM design pattern. It's a simple concept that allows developers to build complex applications that are testable and maintainable. The complexity of how to follow this pattern is what we'll discuss in detail in other pages.
