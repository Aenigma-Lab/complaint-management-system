# ComplaintManagementSystem

# Overview
The Complaint Management System is a comprehensive web application designed to handle customer complaints efficiently. Built with ASP.NET Core 6.0, Identity Core, C#, and EF Code First approach, this application offers a robust solution for managing and reporting customer issues. It features a modern, responsive UI, and includes functionalities for complaint management, reporting, and user management.

# Features
Complaint/Issue Management: Create, update, delete, and manage complaints with an intuitive interface.
User Management: Admin users can manage and monitor all users and their complaints.
Reporting: Generate detailed reports including Complaint Status Summary and Assigned To Summary.
Role-Based Access Control: Different access levels for Admin and Complaint Raise Users.
Notifications: Receive updates and notifications for complaint status changes.
File Attachments: Attach and manage files related to complaints.
PDF Export: Print or download complaints as PDF files.
Dynamic UI: Responsive design with modern UI elements.
User Login History: Track user login and logout history.
SMTP Configuration: Manage email notifications through the admin panel.
Technologies
Frontend: AdminLTE 3.0.5, JavaScript, jQuery, Bootstrap 4, SweetAlert, Toastr, FontAwesome
Backend: ASP.NET Core 6.0, C#, Entity Framework Core (Code First)
Database: Microsoft SQL Server 2017
Development Environment: Microsoft Visual Studio Community 2022 or later
Prerequisites
Microsoft Visual Studio Community 2022 or later
.NET Core 6.0
Microsoft SQL Server 2017
IIS
Chrome or Edge Browser
Getting Started
Step 1: Setup
Unzip the downloaded file (ComplaintMngSys.zip).
Open the solution file (Sln.ComplaintMngSys.sln) with Visual Studio 2022.
Step 2: Configure Database Connection
Open appsettings.json.

# Update the database connection string with your SQL Server details:

json
Copy code
"connMSSQL": "Server=YOUR_SQL_SERVER_NAME;Database=ComplaintMngSys;User ID=YOUR_SQL_SERVER_USER_NAME;Password=YOUR_SQL_SERVER_USER_PASSWORD;MultipleActiveResultSets=true"
Step 3: Build and Run
Build the application by pressing F6.

Run the application by pressing F5.

Access the application at https://localhost:44374/.

The necessary tables and initial data will be created dynamically as the application runs.

Step 4: Browse the Application
Explore the application and familiarize yourself with its features and modules.

# Modules
Complaint/Issue Management Module
Application Setting Module
Reporting Module
User Roles
Admin User: Full access to manage and configure the system, including complaint categories, status, priorities, user management, and reporting.
Complaint Raise User: Ability to create, manage, and track complaints, including file attachments, comments, and status updates.
Key Features
Dynamic Complaint Management: Create and manage complaints with attachments and comments.
Reporting: Generate detailed reports for ongoing issues and user assignments.
User Management: Admin can monitor and manage user activities and complaints.
Responsive UI: Modern and user-friendly interface.
Role-Based Access: Controlled access based on user roles.
File Management: Attach and manage files related to complaints.
Notifications: Receive updates on complaint status changes.
PDF Export: Print or download complaints as PDF files.
Customizable Settings: Manage company branding and SMTP settings from the admin panel.
Login History: Track user login and logout history.
DB Migration
Run database migration tools via NuGet Package Manager to update the database schema.

# Sample PDF Report
Demo Video Preview

App Screenshot

Support
For any issues or support requests, please contact the system administrator or refer to the documentation.
