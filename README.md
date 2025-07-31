# NeetCode75_CSharp  C# Practice Solutions

This is a simple, organized C# console app where I’m solving the [LeetCode 75](https://leetcode.com/list/xi4ci4ig/) problems. Each problem is in its own file, and I can run any one of them using the command line or from Visual Studio Code.

The goal is to practice clean, readable C# while building up my problem-solving skills.

---

## 🗂️ Project Structure

```plaintext
NeetCode75_CSharp/
├── Problems/
│   ├── Problem1.cs       # Two Sum
│   ├── Problem2.cs       # Merge Sorted Array
│   └── ...               # Other LeetCode 75 problems
├── Program.cs            # Entry point
├── NeetCode75_CSharp.csproj     # .NET project file
└── README.md             # This file



## How to Run a Specific Problem

You can run any problem by passing its name (like problem1) in the command line.

## Run from Terminal

'''
dotnet run -- problem1
'''

This runs the Run() method inside Problems/Problem1.cs.


## 🐞 Debugging in VS Code

If you're using Visual Studio Code, here's how to debug:

    Open the project folder (LeetCode75/) in VS Code.

    Press F5 to start debugging.

    Make sure your launch.json has the correct problem name in the "args" section.

Example launch config:

"args": ["problem1"]

Set breakpoints in any file and step through the code as needed.