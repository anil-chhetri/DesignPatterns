# Implementating CQRS with MediatR

## CQRS: 
CQRS stands for *Command and Query Responsibility Segregation*, a patterns that separates read and update operation from a data store. In CQRS design pattern, a command writes data to a data source. A query readds data from data source. CQRS addresses the problem of data access performance degradation when application running at web-scale have too much burden placed on the physical database and the network on which it resides.

## Mediator Pattern:
Mediator pattern is used to reduce communication complexity between multiple objects or classes. This pattern provides a mediator class which normally handles all the communication between different classes and supports easy maintenance of the code by loose coupling. Mediator pattern falls under behavioral pattern category due to the way it can alter the program's running behavior. <br\>
With mediator pattern, communication between objects is encapsulated within a mediator object. Objects no longer communicate directly with each other, but instead communicate through the mediator. This reuce the dependencies between communicating objects, thereby reducing coupling.

