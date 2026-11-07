<div align="center">

<img src="https://capsule-render.vercel.app/api?type=waving&color=0:512BD4,100:00B4DB&height=200&section=header&text=Console%20Calculator&fontSize=52&fontColor=ffffff&animation=fadeIn&fontAlignY=38&desc=A%20menu-driven%20calculator%20built%20with%20C%23%20and%20.NET&descAlignY=60&descSize=18" alt="Console Calculator banner" />

<a href="https://git.io/typing-svg">
  <img src="https://readme-typing-svg.demolab.com?font=Fira+Code&weight=600&size=20&pause=1200&color=512BD4&center=true&vCenter=true&width=620&lines=%E2%9E%95+Add+%7C+%E2%9E%96+Subtract+%7C+%E2%9C%96%EF%B8%8F+Multiply+%7C+%E2%9E%97+Divide;Safe+input+validation+%E2%80%94+no+crashes!;Built+with+C%23+%26+.NET;Clean%2C+simple+and+beginner-friendly" alt="Typing animation" />
</a>

<br/>

![C#](https://img.shields.io/badge/C%23-512BD4?style=for-the-badge&logo=csharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![Console](https://img.shields.io/badge/Console-App-0078D4?style=for-the-badge&logo=windowsterminal&logoColor=white)
![Status](https://img.shields.io/badge/Status-Complete-2ea44f?style=for-the-badge)
![License](https://img.shields.io/badge/License-MIT-yellow?style=for-the-badge)

![Started](https://img.shields.io/badge/Started-30%20Oct%202026-blue?style=for-the-badge&logo=calendar&logoColor=white)
![Last Updated](https://img.shields.io/badge/Last%20Updated-07%20Nov%202026-orange?style=for-the-badge&logo=githubactions&logoColor=white)

</div>

---

## 🧮 About

**Console Calculator** is a menu-driven command-line application written in C#. It performs the four basic arithmetic operations, validates every input, and lets the user stay inside an operation to calculate repeatedly or return to the main menu at any time.

It was built as the Week 1 mini project of my C# learning journey, applying variables, operators, `switch`, loops, and methods in one real program.

### 🗓️ Project Timeline

|     |                  |                  |
| --- | ---------------- | ---------------- |
| 🚀  | **Started**      | 30 October 2026  |
| 🔄  | **Last updated** | 07 November 2026 |
| 📦  | **Version**      | 1.0.0            |

---

## ✨ Features

|     | Feature                   | Description                                              |
| --- | ------------------------- | -------------------------------------------------------- |
| ➕  | **Four operations**       | Addition, subtraction, multiplication and division       |
| 🔁  | **Stay or go home**       | After each result, choose _"again"_ or _"Back to Home"_  |
| 🛡️  | **Input validation**      | Letters, blanks or malformed numbers never crash the app |
| 🚫  | **Divide-by-zero guard**  | Friendly error instead of an exception                   |
| ✅  | **Exit confirmation**     | Asks _"Are you sure?"_ before closing                    |
| 🎯  | **Precise results**       | Uses `decimal`, so `0.1 + 0.2 = 0.3`                     |
| ✂️  | **Clean division output** | Results rounded to 4 decimal places (`10 / 3 = 3.3333`)  |
| 🧱  | **Overflow protection**   | Extremely large results show an error, not a crash       |

---

## 🖥️ Preview

```text
===== Calculator =====
1. Add
2. Subtract
3. Multiply
4. Divide
0. Exit
Choose an option: 4
```

```text
===== Divide =====
Enter first number: 10
Enter second number: 3
Result: 3.3333

1. Divide again
2. Back to Home
Choose an option:
```

<details>
<summary><b>🛡️ See how invalid input is handled (click to expand)</b></summary>

<br/>

**Letters instead of a number**

```text
Enter first number: abc
Invalid number! Please enter a valid number (e.g. 10 or 2.5).
Enter first number:
```

**Division by zero**

```text
Enter first number: 10
Enter second number: 0
Error: Cannot divide by zero.
```

**Wrong menu option**

```text
Choose an option: 9

Invalid choice! Please choose 0, 1, 2, 3 or 4.
Press any key to try again...
```

**Exit confirmation**

```text
Choose an option: 0

Are you sure you want to exit?
1. Yes, exit
2. No, back to Home
Choose an option:
```

</details>

---

## 🔄 Program Flow

```mermaid
flowchart TD
    A([🚀 Start]) --> B[🏠 Home Menu]
    B -->|1 / 2 / 3 / 4| C[Enter two numbers]
    C --> D{Valid numbers?}
    D -- No --> C
    D -- Yes --> E[Calculate & show result]
    E --> F{What next?}
    F -- "1 · Again" --> C
    F -- "2 · Back to Home" --> B
    B -->|0| G{Are you sure?}
    G -- "2 · No" --> B
    G -- "1 · Yes" --> H([👋 Thanks & Exit])
    B -->|Anything else| I[Invalid choice message]
    I --> B
```

---

## 🚀 Getting Started

### Prerequisites

- [.NET SDK 6.0 or later](https://dotnet.microsoft.com/download)

### Run locally

```bash
# 1. Clone the repository
git clone https://github.com/YOUR_USERNAME/csharp-console-calculator.git

# 2. Move into the project folder
cd csharp-console-calculator

# 3. Run the app
dotnet run
```

> 💡 Using Visual Studio? Open the project and press **Ctrl + F5**.

---

## 📁 Project Structure

```text
csharp-console-calculator/
├── Program.cs      # All application logic
└── README.md       # Application documentations
```

<details>
<summary><b>🧩 Key methods in Program.cs (click to expand)</b></summary>

<br/>

| Method                 | Purpose                                                                                                |
| ---------------------- | ------------------------------------------------------------------------------------------------------ |
| `Main()`               | Runs the home menu loop and dispatches to each operation with `switch`                                 |
| `ReadNumber(prompt)`   | Keeps asking until the user enters a valid `decimal` (uses `decimal.TryParse` with `InvariantCulture`) |
| `AskAgain(actionName)` | Shows _"again / Back to Home"_ and validates the choice                                                |
| `ClearScreen()`        | Clears the console safely, even when output is redirected                                              |
| `WaitForKey()`         | Waits for a key press safely, even when input is redirected                                            |

</details>

---

## 📚 Concepts Practiced

<div align="center">

![Variables](https://img.shields.io/badge/Variables-%26%20Data%20Types-512BD4?style=flat-square)
![Operators](https://img.shields.io/badge/Operators-Arithmetic%20%26%20Logical-512BD4?style=flat-square)
![Switch](https://img.shields.io/badge/if%2Felse-%26%20switch-512BD4?style=flat-square)
![Loops](https://img.shields.io/badge/while-Loops-512BD4?style=flat-square)
![Methods](https://img.shields.io/badge/Methods-%26%20Parameters-512BD4?style=flat-square)
![Exceptions](https://img.shields.io/badge/try%2Fcatch-Error%20Handling-512BD4?style=flat-square)

</div>

---

## 🗺️ Roadmap

- [x] Add, subtract, multiply, divide
- [x] Input validation and error handling
- [x] Exit confirmation

---

## 🤝 Contributing

Suggestions and improvements are welcome. Feel free to open an issue or submit a pull request.

1. Fork the project
2. Create your branch: `git checkout -b feature/amazing-feature`
3. Commit your changes: `git commit -m "Add amazing feature"`
4. Push to the branch: `git push origin feature/amazing-feature`
5. Open a Pull Request

---

## 📄 License

Distributed under the MIT License. See `LICENSE` for more information.

---

<div align="center">

**⭐ If you found this project helpful, consider giving it a star!**

Made with ❤️ and C#

<img src="https://capsule-render.vercel.app/api?type=waving&color=0:00B4DB,100:512BD4&height=100&section=footer" alt="Footer wave" />

</div>
