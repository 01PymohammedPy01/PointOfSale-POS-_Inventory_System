

https://github.com/user-attachments/assets/f0c7db8b-8049-4ba3-a35f-39780a666884



        Point of Sale(POS) & Inventory Management System A robust, enterprise-grade desktop Point of Sale(POS) and inventory management application built from scratch using C# .NET Windows Forms and Microsoft SQL Server (MSSQL). Designed with a clean 3-tier architecture, this project delivers secure data handling, custom UI components, and streamlined retail operations.

Key Features Secure Authentication & User Management: Role-based access control backed by a dedicated login screen and administrative user management forms(frmAddEditUser).

inventory tracking allowing users to add, update, and manage products, categories, and stock levels through custom product cards(ucProductCard).

(ucSales): An intuitive sales interface optimized for fast transaction processing and cart management.

ucDashboard): monitoring sales summaries, low-stock inventory alerts, and system activity.

This project strictly adheres to separation of concerns utilizing a 3-Tier Architecture:

Presentation Layer: C# Windows Forms (WinForms) featuring custom user controls (ucDashboard, ucSales, ucProduct) and a modern, professional dark-mode UI theme.

Business Logic Layer(BLL): C# class libraries (clsSales, clsProducts, clsUsers, etc.) handling application rules, validation, and data processing workflows.

Data Access Layer(DAL): ADO.NET implementation(clsUsersData, clsProductsData, clsCategoryData) utilizing SQL connections, data adapters, and secure parameterized queries to completely prevent SQL injection vulnerabilities.

Database: Microsoft SQL Server(MSSQL) relational database designed with normalized tables and foreign key constraints to maintain historical data integrity.
