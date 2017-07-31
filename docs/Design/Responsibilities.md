# MVVM Responsibilities

Each layer in the MVVM pattern has very clear responsibilities. They are:

### Model Responsibilities
In general, model is the simplest one to understand. It is the client side data model that supports the views in the application.
* It is composed of objects with properties and some variables to contain data in memory.
* Some of those properties may reference other model objects and create the object graph which as a whole is the model objects.
* Model objects should raise property change notifications which in WPF means data binding.
* The last responsibility is validation which is optional, but you can embed the validation information on the model objects by using the data binding validation features via interfaces like INotifyDataErrorInfo/IDataErrorInfo

### View Responsibilities
The main purpose and responsibilities of views is to define the structure of what the user sees on the screen. The structure can contain static and dynamic parts.
* Static parts are the XAML hierarchy that defines the controls and layout of controls that a view is composed of.
* Dynamic part is like animations or state changes that are defined as part of the View.
* The primary goal of MVVM is that there should be no code behind in the view.
* It’s impossible that there is no code behind in view. In view you at least need the constructor and a call to initialize component.
* The idea is that the event handling, action and data manipulation logic code shouldn’t be in the code behind in View.
* There are also other kinds of code that have to go in the code behind any code that's required to have a reference to UI element is inherently view code.

### ViewModel Responsibilities
ViewModel is the main point of MVVM application. 
* The primary responsibility of the ViewModel is to provide data to the view, so that view can put that data on the screen.
* It also allows the user to interact with data and change the data.
* The other key responsibility of a ViewModel is to encapsulate the interaction logic for a view, but it does not mean that all of the logic of the application should go into ViewModel.
* It should be able to handle the appropriate sequencing of calls to make the right thing happen based on user or any changes on the view.
* ViewModel should also manage any navigation logic like deciding when it is time to navigate to a different view.
