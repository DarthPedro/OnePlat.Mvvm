# The ViewModel

The view-model introduces the concept of separation between the view and the underlying data model. Instead of requiring the model to represent a date in the form that a user expects to see it (the view-model converts the date to the display format), the model simply holds the data. The view will take input from the view and place it on the model, or it will interact with a service/repository to retrieve the model from its data source.

The view-model also exposes methods, commands, and properties that help maintain the state of the view, manipulate the model as the result of commands.

View-models typically expose properties used to databind with views, commands that views call in response to user input, and events that update the view in response to data changes. To update views, view-model must implement IPropertyChanged interface, to which the databinding responds.
