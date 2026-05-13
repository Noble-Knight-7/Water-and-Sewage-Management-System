<div align="center">

# 💧 Water & Sewage Management System

![Platform](https://img.shields.io/badge/Platform-Windows%20Forms-0078D4?style=for-the-badge&logo=windows)
![Language](https://img.shields.io/badge/Language-C%23-239120?style=for-the-badge&logo=csharp)
![Database](https://img.shields.io/badge/Database-SQL%20Server-CC2927?style=for-the-badge&logo=microsoftsqlserver)
![Framework](https://img.shields.io/badge/.NET-4.7.2-512BD4?style=for-the-badge&logo=dotnet)
![IDE](https://img.shields.io/badge/IDE-Visual%20Studio-5C2D91?style=for-the-badge&logo=visualstudio)

*A centralized, role-based desktop application for managing water billing, complaints, connections, and maintenance operations.*

---

</div>

## 📋 Table of Contents

- [Overview](#-overview)
- [Course Information](#-course-information)
- [Technology Stack](#️-technology-stack)
- [System Actors](#-system-actors)
- [Features by Role](#-features-by-role)
- [System Modules](#-system-modules)
- [Project Structure](#-project-structure)

---

## 🌊 Overview

Water and sewage service management typically involves billing, complaint handling, maintenance tracking, connection applications, and public notices. In many organizations, these tasks are handled manually or through disconnected systems — causing delays, billing errors, poor complaint tracking, and weak communication.

This project provides a **centralized desktop application** where users log in based on their assigned roles and access only the features relevant to them. It is purpose-built as an academic OOP2 final project — substantial enough to demonstrate real-world OOP principles, yet achievable within a short development period.

---

## 🎓 Course Information

| Field | Details |
|:------|:--------|
| **Course** | Object Oriented Programming 2 |
| **Project Type** | Final Course Project |
| **Platform** | C# Windows Forms Application |
| **Database** | Microsoft SQL Server |
| **IDE** | Microsoft Visual Studio |
| **Database Tool** | SQL Server Management Studio |
| **Version Control** | Git & GitHub |

---

## 🛠️ Technology Stack

| Technology | Purpose |
|:-----------|:--------|
| **C#** | Core application logic |
| **Windows Forms** | Desktop user interface |
| **.NET Framework 4.7.2** | Application runtime |
| **SQL Server** | Relational database management |
| **SQL Server Management Studio** | Database design and testing |
| **Microsoft.Data.SqlClient** | SQL Server connectivity from C# |
| **GitHub** | Team collaboration and version control |

---

## 👥 System Actors

The system is built around **four distinct roles**, each with dedicated access and responsibilities:

```
┌─────────────┐   ┌─────────────┐   ┌──────────────────┐   ┌────────────────────────┐
│    Admin    │   │  Customer   │   │ Service Officer  │   │ Maintenance Engineer   │
│             │   │             │   │                  │   │                        │
│ System-wide │   │ Self-service│   │  Billing &       │   │  Field repairs &       │
│ management  │   │  portal     │   │  connections     │   │  complaint resolution  │
└─────────────┘   └─────────────┘   └──────────────────┘   └────────────────────────┘
```

---

## ✅ Features by Role

<details>
<summary><strong>🔐 Admin</strong></summary>

The Admin oversees the entire system and all user accounts.

- Register, Login, Logout
- View & Update Profile / Change Password
- Manage all users & approve employee accounts
- Deactivate accounts & delete accounts
- View and assign all complaints
- Publish notices and monitor bill disputes
- Generate system-wide reports

</details>

<details>
<summary><strong>🏠 Customer</strong></summary>

Customers manage their own account, bills, and service requests.

- Register, Login, Logout
- View & Update Profile / Change Password
- View current bill & billing history
- Submit and track bill disputes
- Submit and track complaints
- Apply for new water connections
- Track connection application status
- View public notices

</details>

<details>
<summary><strong>📋 Service Officer</strong></summary>

Service Officers handle all billing and connection-related operations.

- Register, Login, Logout
- View & Update Profile / Change Password
- Enter meter readings & generate monthly bills
- Review and correct disputed bills
- Review, approve, or reject connection applications
- Verify documents and schedule installations
- Generate billing reports

</details>

<details>
<summary><strong>🔧 Maintenance Engineer</strong></summary>

Maintenance Engineers handle field-level complaint resolution and repairs.

- Register, Login, Logout
- View & Update Profile / Change Password
- View assigned complaints and maintenance tasks
- Update repair progress and mark complaints as resolved
- Add inspection notes and set expected visit dates
- Report water quality issues
- Submit completion reports and view notices

</details>

---

## 📦 System Modules

| # | Module | Description |
|:--|:-------|:------------|
| 1 | **Authentication** | Login, registration, logout, password change, role-based dashboard routing |
| 2 | **User Management** | Manage users, approve employees, deactivate accounts, update profiles |
| 3 | **Billing Management** | Meter readings, bill generation, billing history, dispute handling |
| 4 | **Complaint Management** | Submit, track, assign, and resolve customer complaints |
| 5 | **Connection Management** | New connection applications, document verification, approval workflow |
| 6 | **Maintenance Management** | Task assignment, repair progress tracking, completion reports |
| 7 | **Notice & Alerts** | Publish and view area-based service notices and announcements |
| 8 | **Reporting** | Billing, complaint, user, and maintenance reports |

---

## 📁 Project Structure

```
WaterSewageManagementSystem/
│
├── 📂 DataAccess/                        # Database interaction layer
│   ├── DbConnection.cs                   # Central DB connection handler
│   ├── UserRepository.cs
│   ├── CustomerRepository.cs
│   ├── BillRepository.cs
│   ├── ComplaintRepository.cs
│   ├── ConnectionRepository.cs
│   ├── MaintenanceRepository.cs
│   ├── NoticeRepository.cs
│   └── ReportRepository.cs
│
├── 📂 Forms/                             # All Windows Forms (UI)
│   ├── 📂 Common/                        # Shared across all roles
│   │   ├── LoginForm.cs
│   │   ├── RegisterForm.cs
│   │   ├── ForgotPasswordForm.cs
│   │   ├── ProfileForm.cs
│   │   └── ChangePasswordForm.cs
│   │
│   ├── 📂 Admin/
│   │   ├── AdminDashboardForm.cs
│   │   ├── ManageUsersForm.cs
│   │   ├── ApproveEmployeesForm.cs
│   │   ├── AssignComplaintsForm.cs
│   │   ├── NoticeManagementForm.cs
│   │   └── SystemReportForm.cs
│   │
│   ├── 📂 Customer/
│   │   ├── CustomerDashboardForm.cs
│   │   ├── CurrentBillForm.cs
│   │   ├── BillHistoryForm.cs
│   │   ├── SubmitBillDisputeForm.cs
│   │   ├── SubmitComplaintForm.cs
│   │   ├── TrackComplaintForm.cs
│   │   ├── ConnectionApplicationForm.cs
│   │   └── TrackApplicationForm.cs
│   │
│   ├── 📂 ServiceOfficer/
│   │   ├── ServiceOfficerDashboardForm.cs
│   │   ├── MeterReadingForm.cs
│   │   ├── GenerateBillForm.cs
│   │   ├── ReviewDisputesForm.cs
│   │   ├── CorrectBillForm.cs
│   │   ├── ReviewConnectionApplicationsForm.cs
│   │   ├── VerifyDocumentsForm.cs
│   │   ├── ScheduleInstallationForm.cs
│   │   └── BillingReportForm.cs
│   │
│   └── 📂 MaintenanceEngineer/
│       ├── MaintenanceDashboardForm.cs
│       ├── AssignedComplaintsForm.cs
│       ├── MaintenanceTasksForm.cs
│       ├── RepairProgressForm.cs
│       ├── InspectionNotesForm.cs
│       ├── VisitDateForm.cs
│       └── CompletionReportForm.cs
│
├── 📂 Models/                            # Data model classes
│   ├── User.cs
│   ├── Customer.cs
│   ├── Bill.cs
│   ├── Payment.cs
│   ├── BillDispute.cs
│   ├── Complaint.cs
│   ├── MaintenanceTask.cs
│   ├── ConnectionApplication.cs
│   ├── Notice.cs
│   └── Report.cs
│
├── 📂 Services/                          # Business logic layer
│   ├── AuthService.cs
│   ├── UserService.cs
│   ├── BillingService.cs
│   ├── ComplaintService.cs
│   ├── ConnectionService.cs
│   ├── MaintenanceService.cs
│   ├── NoticeService.cs
│   └── ReportService.cs
│
├── 📂 Helpers/                           # Utility & shared helpers
│   ├── SessionManager.cs
│   ├── PasswordHelper.cs
│   ├── ValidationHelper.cs
│   ├── MessageHelper.cs
│   └── FormNavigationHelper.cs
│
├── 📂 Resources/                         # Static assets
│   ├── Images/
│   └── Icons/
│
├── 📂 database/                          # SQL scripts
│   ├── WaterSewage_DB_Create.sql
│   ├── WaterSewage_DB_Insert_Sample_Data.sql
│   └── WaterSewage_DB_Procedures.sql
│
├── 📂 docs/                              # Project documentation
│   ├── project-proposal/
│   ├── final-report/
│   ├── diagrams/
│   └── screenshots/
│
├── 📂 team-work/                         # Individual member task breakdown
│   ├── member-1-admin.md
│   ├── member-2-customer.md
│   ├── member-3-service-officer.md
│   └── member-4-maintenance-engineer.md
│
├── App.config
├── Program.cs
├── packages.config
├── WaterSewageManagementSystem.csproj
├── WaterSewageManagementSystem.sln
├── .gitignore
└── README.md
```

---

<div align="center">

*Built with 💙 as a final project for Object Oriented Programming 2*

</div>
