# Avalonia Application: Database Connection Simulation

## Overview

This Avalonia application demonstrates a simulation of connecting to and disconnecting from a database. The interface includes a `TextBox` for displaying messages and two buttons for user interaction:

- **Connect to Database:** Simulates connecting to a database with a delay of 3-5 seconds. It also starts a timer that periodically logs messages to the `TextBox`.
- **Disconnect from Database:** Simulates disconnecting from a database with a similar delay and stops the timer.

## Features

- **Asynchronous Operations:** Uses `async/await` to simulate delays without freezing the UI.
- **Periodic Updates:** A `Timer` generates periodic messages while the database is "connected."
- **Clean Resource Management:** Ensures proper handling of resources by disposing of the timer when it is no longer needed.

## How to Run

1. Clone the repository or download the project files.
2. Open the project in your preferred IDE (e.g., Visual Studio, JetBrains Rider, or VS Code).
3. Build the solution to restore dependencies.
4. Run the application with `dotnet run`.

## Expected Behavior

- When you click **"Connect to Database":**
  - The message "Connecting to the database..." is displayed.
  - After a delay, the message "Connected to the database." is displayed.
  - A timer starts, and "Data received." messages appear every 2 seconds.

- When you click **"Disconnect from Database":**
  - The message "Disconnecting from the database..." is displayed.
  - After a delay, the message "Disconnected from the database." is displayed.
  - The timer stops, and no further "Data received." messages appear.

## Dependencies

- .NET SDK (6.0 or later)
- Avalonia UI Framework

## Notes

- This application is built with Avalonia, making it cross-platform and suitable for Windows, macOS, and Linux.
- Ensure that your environment supports Avalonia applications.
- Modify the `Timer` interval or delay duration in the code as needed.
- This application is a simulation and does not connect to an actual database.
