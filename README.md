# Employee-Management-Exercise

## Indeavor - Software Engineer - Code Challenge

Software engineering exercise for Indeavor. <br/>
Employee Management System - NOT COMPLETE

Not included yet:
- REST API
- Ability to add skills to employees in the database (views almost complete though)
- Additional functions like exporting to spreadsheets etc

__Όνομα:__ Χρήστος - Θρασύβουλος <br/>
__Επίθετο:__ Κούλης <br/>
__Κινητό:__ 6973366654

## Implementation
- ASP.NET Core MVC project
- 2 main models+controllers used, one for skills and one for employees. A 3rd model including both a skill and an employee used as a supplementary in a view form.
- CSS and HTML slightly modified so the site is easier for users to navigate.
- Many to Many relationship established between skills and employees. An employee can have many skills, a skill is attainable by many employees (CREATE form not ready yet).
- Creation date of skill model saved by recording the current time, as a new entity is created. Creation date stays unchanged, no matter how many times that entity is modified.
- Search function for surname of employees, sorting by surname and hiring date of employees added.
- ...
