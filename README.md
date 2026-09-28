# SedapMakan Restaurant Management System — IOOP Project

**Module:** CT044-3-1-IOOP — Introduction to Object Oriented Programming
**University:** Asia Pacific University (APU)
**Language:** C# (.NET Framework) with SQL Server Database
**Year:** 2025

---

## Project Overview

SedapMakan is a restaurant management system for a restaurant chain in Bukit Jalil. The system serves four user roles — Administrator, Manager, Chef, and Customer — with features spanning user management, order processing, e-wallet top-ups, feedback, and refund requests.

## Assignment Brief Summary

- **System:** SedapMakan restaurant management system
- **Users:** System Admin, Manager, Chef, Customer
- **Requirements:**
  - C# with OOP concepts (classes, methods, objects)
  - GUI using Windows Forms
  - SQL Server database for data storage
  - Input validation for all entries
  - Standalone application

### Customer Functional Requirements

From the IOOP assignment brief, the Customer role must support:
1. Browse menu and order item and pay to confirm
2. View order status
3. Cancel order, request refund
4. Send feedback
5. Check refund status
6. Update own profile

### General Requirements

- Program must compile without errors using Visual Studio
- Use C# features and OOP concepts
- GUI for user interface
- Document code with comments
- Use meaningful names for identifiers
- Store all data in a database (SQL Server)
- Input validation for all entries

## System Architecture

- **Frontend:** Windows Forms (C#) with multiple UserControls per role
- **Backend:** SQL Server database with normalized tables
- **Roles:** Administrator, Manager, Chef, Customer

### Features by Role

| Role | Features |
|------|----------|
| Administrator | User CRUD, Sales Report, E-Wallet, Login |
| Manager | Feedback viewing/replying, Customer Top-up, Discount Management, Refund Requests |
| Chef | Restaurant Menu (view/add/edit items), Login, Orders, Order Status |
| **Customer** | **Browse Menu & Order, Order Status, Cancel Order/Refund, Send Feedback, Update Profile** |

## 🎯 MY CONTRIBUTION: Customer Module & Design Elements

**I implemented the Customer part and design elements** of the SedapMakan system.

### What I built:

- **CustomerMainForm.cs** — Customer dashboard with sidebar navigation (Welcome, Browse Orders, Order Status & Refunds, Cancel Order, Send Feedback, Update Profile)
- **BrowseOrderControl.cs** — Menu browsing and ordering interface
- **OrderStatusControl.cs** — View order status and history
- **CancelOrderControl.cs** — Cancel orders and request refunds
- **SendFeedbackControl.cs** — Submit feedback messages
- **UpdateProfileControl.cs** — Edit profile information
- **CustomerSQL.sql** — Database schema: Customers, MenuItems, Orders, Feedback, RefundRequests, EWalletTransactions tables with sample data

### Design Elements:

- Consistent UI layout with sidebar navigation
- Visual feedback for order status
- Form validation and user-friendly prompts
- Responsive dashboard layout

## Database Schema

```
Customers ──→ Orders ──→ MenuItems
   │                    │
   ├─→ Feedback         └─→ RefundRequests
   └─→ EWalletTransactions
```

## Group Work Note

This is a **group project** for CT044-3-1-IOOP (4 members):
- Admin Menu, Loading Screen, Login Menu Design — Tauedea Arehui Gabi
- Manager part, Sign Up page, compiling & design — Her Cheng En
- **Customer part and design elements — Me (Ibrahim Bin Mohd Ezman, TP081387)**
- Chef part, Restaurant Menu, compiling, Conclusion — Mohammad Amin Abdalla Yahya

---

*Repository created for academic portfolio purposes.*
