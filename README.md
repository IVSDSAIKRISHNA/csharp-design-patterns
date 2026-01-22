# 🌟 C# Design Patterns Repository

![Languages](https://img.shields.io/github/languages/top/yourusername/csharp-design-patterns)
![Last Commit](https://img.shields.io/github/last-commit/yourusername/csharp-design-patterns)
![License](https://img.shields.io/github/license/yourusername/csharp-design-patterns)

---

## 📖 Overview

Welcome to my **C# Design Patterns repository**! 🖥️✨

This repository is a personal collection of **design pattern implementations in C#**, organized in a clear and structured way.  
The goal is to **explore, understand, and implement each pattern** in code while keeping explanations, notes, and examples together.  

Here, you'll find **Creational, Structural, and Behavioral patterns**, with each pattern implemented in a dedicated folder, along with demo classes and notes.  
This repository serves as a **living reference** for myself to revisit, practice, and experiment with design patterns anytime.

---

## 📂 Repository Structure

csharp-design-patterns/
│
├─ CSharpDesignPatterns.sln        # Main solution file
├─ CSharpDesignPatterns/           # Main project
│   ├─ Creational/                 # Creational patterns
│   │   ├─ Singleton/
│   │   │   ├─ Singleton.cs
│   │   │   └─ SingletonDemo.cs
│   │   ├─ FactoryMethod/
│   │   └─ AbstractFactory/
│   ├─ Structural/                 # Structural patterns
│   │   ├─ Adapter/
│   │   ├─ Decorator/
│   │   └─ Proxy/
│   ├─ Behavioral/                 # Behavioral patterns
│   │   ├─ Strategy/
│   │   ├─ Observer/
│   │   └─ Command/
│   └─ DemoRunner.cs               # Optional runner for testing patterns
├─ Notes/                          # Notes, Word files, diagrams
└─ README.md                       # You are here

✅ Each pattern has its own folder with implementation and demo

✅ Demo classes help run and visualize the pattern in action

✅ Notes folder contains additional explanations, diagrams, and real-world context

🛠️ Features / Patterns Included

Creational Patterns 🌱
Patterns that deal with object creation and help make your code flexible and reusable:

Singleton 🏆 – Ensures a class has only one instance

Factory Method 🏭 – Creates objects without specifying exact class

Abstract Factory 🏗️ – Creates families of related objects

Builder 🛠️ – Step-by-step construction of complex objects

Prototype ⚡ – Creates objects by cloning existing instances

Structural Patterns 🏛️
Patterns that deal with object composition to form larger structures:

Adapter 🔌 – Converts one interface to another

Decorator 🎨 – Adds behavior to objects dynamically

Proxy 🛡️ – Provides a surrogate or placeholder for another object

Facade 🚪 – Simplifies access to a complex subsystem

Composite 🌲 – Treats groups of objects uniformly

Behavioral Patterns 🧠
Patterns that deal with communication between objects and encapsulate behavior:

Strategy 🎯 – Defines a family of algorithms, interchangeable at runtime

Observer 👀 – Notifies dependent objects of state changes

Command 📝 – Encapsulates requests as objects

Template Method 📐 – Defines skeleton of an algorithm, letting subclasses fill in details

State 🔄 – Alters object behavior when its state changes

Patterns will be continuously added as I explore more in-depth examples and real-world use cases.

💡 How to Use / Explore
Clone the repository:

git clone https://github.com/yourusername/csharp-design-patterns.git
Open the solution file in Visual Studio or Rider.

Explore patterns by opening individual folders:

Each folder contains implementation (PatternName.cs)

Demo class (PatternNameDemo.cs) to run the example

Optional README.md for explanations per pattern

(Optional) Use DemoRunner.cs to quickly test a pattern in isolation:

DemoRunner.RunPattern("Singleton");
📝 Notes & Documentation
Notes are stored in the Notes/ folder 🗂️

Includes Word documents, diagrams, and reference materials

Markdown notes are included for quick GitHub viewing

Each pattern folder may also include a small README explaining:

Intent of the pattern

Problem it solves

Example usage

Real-world applications

🌐 Why I Made This
To strengthen my understanding of design patterns in C#

To experiment with code implementations and see patterns in action

To create a reference library I can revisit anytime

To document explanations, UML diagrams, and notes in one place

🚀 Future Plans
Add more design patterns, including rarely-used ones

Include full UML diagrams for each pattern

Add real-world examples and mini projects demonstrating patterns in action

Explore modern .NET features in pattern implementations

🖥️ Tech Stack
Language: C# 11

Framework: .NET 7

IDE: Visual Studio / JetBrains Rider

🤝 Contributions
This is a personal repository, but contributions or suggestions are welcome!
You can submit pull requests to suggest pattern improvements, better demos, or documentation.