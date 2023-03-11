# Event Driven Architecture


Messaging utility example in C#

* Producer defines a `CustomerGiftCardCreated` class represent the event details.
* The event is modeled to represent the business domain.
* Does not include **Metadata**

[CustomerGiftCardCreated](./Code/CustomerGiftCardCreated.cs)


Create a utility library that provides helper classes to send domain events across a message broker:

[IEventMessageBroker](./Code/IEventMessageBroker.cs)

Create generic class that represent the json payload on the message broker:

[Detail](./Code/Detail.cs)

Create a class that represent the metadata:

[Metadata](./Code/Metadata.cs)

You can now implement the IEventMessageBroker interface using these two classes above:

[EventMessageBroker](./Code/EventMessageBroker.cs)


