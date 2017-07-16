# The Model

The model, also refer to as the domain model, represents the actual data and/or information for your application. An example of a model might be a contact (containing name, phone number, address, etc.) or the attributes of a blog post.

The key design principle with the model is that it holds the information, but not the behaviors or services that manipulate that data. It is not responsible for formatting text for presentation, or knowledge on loading that data from a database. Business logic is typically kept separate from the model, and encapsulated in other classes that act on the model (in this pattern that's typically the ViewModel that acts on the Model). 

The exception to this is that validation rules are many times implemented in the model, especially since .NET has DataValidation attributes to use with validation.
