# IWRA

IWRA is a web application that allows the creation and tracking of work requests. It is designed to be used by a team of people who need to track work requests and their status. The application is built using C# and the Blazor framework.

This project is currently under development.

### Seeding the initial data

The project contains the initial data for the database. To create the database and seed the data, run

`Update-Database -context AppDbContext`

in the Package Manager Console (Tools / NuGet Package Manager / Package Manager Console).

**Note:** This project assumes the existence of the SQL database `(localdb)\MSSQLLocalDB`
