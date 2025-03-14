# 📒 Digital Notes Manager – Windows Forms Application  

## 🌟 Introduction  

### 🎯 Purpose  
**Digital Notes Manager** is a feature-rich Windows Forms application designed to help users **create, edit, organize, and manage** personal notes efficiently. It incorporates **modern software architecture**, ensuring scalability and maintainability.  

### 📌 Key Features  
✔ **Multi-Document Interface (MDI)** – Work with multiple notes simultaneously.  
✔ **Authentication & Authorization** – Secured with **ASP.NET Core Identity**.  
✔ **SOLID Design Principles** – Ensuring clean, maintainable, and scalable code.  
✔ **Background Service for Reminders** – Uses `BackgroundService` to trigger note reminders.  
✔ **Custom Controls & Events** – Includes a **Category Selector** with a custom event.  
✔ **Rich Text Editing** – Supports **bold, italic, and underline** formatting.  
✔ **File Operations** – Save and load notes using **FileDialog**.  
✔ **DataGridView for Note Management** – View, sort, and filter notes efficiently.  
✔ **Reminder Notifications** – Alerts users when a note's reminder is due.  
✔ **Search & Organization** – Find notes by **title, content, or category**.  

---

## 🔑 Authentication & Security  

- Implemented **user authentication** using **ASP.NET Core Identity**, ensuring secure access to notes.  
- Users must **log in** to create, edit, or delete notes.  
- Role-based access control (RBAC) is enforced to protect sensitive operations.  

---

## 🚀 System Architecture  

### 🏗️ Design Principles  
This project strictly follows **SOLID principles** to enhance **maintainability, scalability, and testability**.  

- **S**ingle Responsibility: Each class has a well-defined responsibility.  
- **O**pen/Closed: The system is **extensible** without modifying existing code.  
- **L**iskov Substitution: Base classes can be replaced by derived classes without issues.  
- **I**nterface Segregation: Small, specific interfaces are used.  
- **D**ependency Inversion: Dependency Injection (`IServiceProvider`) is used extensively.  

### ⚡ Background Service for Reminders  
- A **`BackgroundService`** runs asynchronously to monitor note reminders.  
- Notifications are sent when a reminder is due.  
- Ensures reminders are handled **even when the UI is inactive**.  

---

## 🎨 UI Components  

### **🖥️ Main Form (MDI Parent)**  
- **MDI container** that hosts multiple child forms.  
- **MenuStrip & ToolStrip** for easy navigation.  

### **📝 Note Editor (MDI Child Form)**  
- **RichTextBox** for content editing.  
- **ComboBox** for category selection.  
- **DateTimePicker** for reminders.  

### **📌 Category Selector (Custom Control)**  
- Allows users to assign a **category** to each note.  
- Implements a **custom event** (`CategoryChanged`) to notify the main form.  

### **📊 Notes List (DataGridView)**  
- Displays all saved notes with columns:  
  - **Title**  
  - **Category**  
  - **Creation Date**  
  - **Reminder Date**  
- Supports **sorting & filtering**.  
- **Double-click** opens the note in an MDI Child form.  

---

## 💾 File Operations  

- **OpenFileDialog** – Load saved notes from a `.txt` file.  
- **SaveFileDialog** – Save notes for later access.  

---

## 🔍 Search & Organization  

- **Filter notes** by title, content, or category.  
- **Search box** for quick retrieval.  

---

## 🔔 Reminder Notifications  

- **DateTimePicker** allows users to set **reminders** for notes.  
- The **`BackgroundService`** checks for due reminders and sends alerts.  
- Toast notifications are displayed using **Windows UWP notifications**.  

---

## 🏗️ System Design  

### **🗄️ Database Schema (SQL Server)**  
- **Users Table**  
  - `UserID`, `Username`, `PasswordHash`  
- **Notes Table**  
  - `NoteID`, `Title`, `Content`, `Category`, `CreationDate`, `ReminderDate`, `UserID (FK)`  

---

## 🎯 Conclusion  

**Digital Notes Manager** is a powerful and user-friendly note management system built with **ASP.NET Core Identity, Windows Forms, and SOLID principles**. It ensures **security, scalability, and maintainability**, making it a **robust solution** for note organization.  

