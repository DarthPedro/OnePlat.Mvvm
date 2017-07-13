# Model-View-ViewModel Defined

Model-View-ViewModel (or MVVM) is a design pattern that facilitates a separation of concern between the graphical user interface – be it via a markup language or GUI code – and the development of the business logic or back-end data model.

The MVVM pattern supports two-way data binding between view and View model. This enables automatic propagation of changes, within the state of view model to the View. Typically, the view model uses the observer pattern to notify changes in the view model to model. 

### Model
The Model represents a set of classes that describes the business logic and data. It also defines business rules for data means how the data can be changed and manipulated.

### View
The View represents the UI components like XAML, CSS, jQuery, html etc. It is only responsible for displaying the data that is received from the controller as the result. This also transforms the model(s) into UI..

### View Model
The View Model is responsible for exposing methods, commands, and other properties that helps to maintain the state of the view, manipulate the model as the result of actions on the view, and trigger events in the view itself.

#### Key Characteristics of Pattern:
1. User interacts with the View.
2. There is many-to-one relationship between View and ViewModel means many View can be mapped to one ViewModel.
3. View has a reference to ViewModel but View Model has no information about the View.
4. Supports two-way data binding between View and ViewModel.

