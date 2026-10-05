# TaskFlow – Simple Task Manager

A simple to-do list app built with **C# Windows Forms** for ITS203 Object-Oriented Design and Programming (Assessment C).

## Description

Students who also work part-time have tasks spread across many places. TaskFlow keeps them in one simple list.

## Features

- Add a task with a title and a category (Study or Work)
- Category starts as Study by default
- Title box clears after adding a task
- Shows an error message if the title is empty
- Mark a task as Done
- Delete a selected task
- Clear all tasks at once

## OOP Concepts Used

| Concept | Where |
|---|---|
| Classes & objects | `MyTask`, `StudyTask`, `WorkTask` |
| Encapsulation | private `title` field with public `Title` property |
| Inheritance | `StudyTask` and `WorkTask` inherit from `MyTask` |
| Polymorphism | each class overrides `GetInfo()` |
| Abstraction | `MyTask` is an abstract class |
| Exception handling | try-catch in the Add button |

## Setup

1. Install **Visual Studio 2022 or newer** with the **.NET desktop development** workload.
2. Clone the repo:
   ```
   git clone https://github.com/paswanadi/TaskFlow.git
   ```
3. Open `TaskFlow.slnx` in Visual Studio.

## How to Run

1. Press **F5**.
2. Type a title, pick a category, click **Add**.
3. Select a task and click **Done** or **Delete**.
4. Click **Clear All** to remove every task.

## Proposal

The Milestone 1 proposal is in the `docs` folder.

## References and Tools Used

- Microsoft Visual Studio
- Git and GitHub
- Microsoft Learn – Windows Forms docs: https://learn.microsoft.com/dotnet/desktop/winforms/
- Claude (Anthropic) – GenAI tool used for planning, step-by-step guidance, explaining OOP concepts, fixing Git errors, and help drafting the milestone documents

## Author

Aditya Paswan – ITS203, NAPS, 2026
