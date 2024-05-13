# Crystal Sharp - Read Model Store with MongoDB Example
Crystal Sharp framework - `Read Model Store` integration code example with `MongoDB`.


### About This Example
This example uses `Microsoft SQL Server` for storing events and `MongoDB` for storing read models.

`Command Handlers` have been used to store the data in the event store.

`Event Handlers` have been used to store, update, and delete the data in the read model store.

`Query Handlers` have been used to retrieve the data from the read model store.


### How to Run

* Database for the event store must exist in `Microsoft SQL Server`.
* Change the event store connectionstring in `appsettings.json` file.
* Change the read model store connectionstring in `appsettings.json` file and database name in `Program.cs` file.
* Run the `WebAPI` project.
