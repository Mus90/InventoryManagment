# InventoryManagment

This is a simple application developed using Microsoft .Net core for an online product management. 
The system allows three types of users with different roles to interact using various API endpoints. These are:
*	User: With Basic access to CRUD  
*	Admin: CRUD users.
*	Manager: With superior access to reporting

# Application
The users are able log invoices, which contain:
 * Date the invoice was created
 * The user created the invoice
 * The total of the invoice
The user is able to create and edit an invoice. 
The user is able to create an invoice and add items to the invoice.
The total will be updated as items are added to the invoice, no server communication allowed.

The manager is able to view and edit all invoices. 
The manager will have several reports:
* The number of Items sold per product.
* The number of products.
* The number of products sold. 
* The number of products in stock.
* The number of products in stock vs sold. 

# Technology
Following libraries were used during the development of this Application :
*	.Net Core   -  free web framework developed by microsoft
*	C#   -  Programming Language
*	MsSql server	- relational database management system 
*	Entity framework - object–relational mapping framework
*	Swagger  - API documentation
*	JWT   - Authentication mechanism for REST APIs

