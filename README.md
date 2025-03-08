# OldPhoneKeypadApp

Description:

This program simulates the behavior of an old mobile phone keypad, converting a sequence of button presses into the corresponding text message. The logic follows the traditional multi-tap input method used in early mobile phones.

Features:

- Supports all number keys (1-9, 0 for space).
- Handles backspace (`*`) for character deletion.
- Processes pauses (` `) to allow repeated key usage.
- Recognizes the send key (`#`) to end input processing.

How It Works:

1. Numbers correspond to letters (e.g., `2 -> ABC`, `3 -> DEF`).
2. Pressing a number multiple times cycles through its letters.
3. A pause (" ") finalizes the last letter and moves to the next.
4. The backspace key (*) removes the last typed character.
5. The send button (#) marks the end of input.

Implementation:

The program is built in C# using:
- Dictionary Mapping for key-letter pairs.
- StringBuilder for efficient string handling.
- Iterative Parsing for input processing.

How to run:

Compile and run the program:
```sh
dotnet run
