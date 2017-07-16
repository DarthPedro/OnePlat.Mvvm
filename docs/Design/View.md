# The View

The view is what the end user interacts with (View, Page, Form, etc). It is the visual presentation of the data. The view is defined in a declarative language that lays out controls (XAML is the typcial use in this pattern, but there are frameworks for HTML/Javascript, Java, etc). The view manages user input (key presses, mouse movements, touch gestures, etc.) and ultimately manipulates properties of the model.

The view in MVVM contains behaviors, events, and data-bindings that ultimately require knowledge of the underlying model and view-model. While these events and behaviors might be mapped to properties, method calls, and commands, the view is still responsible for handling its own events, and forwarding them to the view-model. But using a declarative language like XAML means that it still remains loosely coupled from the model and view-model.

One thing to remember about the view is that it is not responsible for maintaining its state. Instead, it will synchronize this with the view-model.
