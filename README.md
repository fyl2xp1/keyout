# \[k\]eyout
Convenience tool to externally customize keybindings for Redout

Should work with `QWERTY`, `QWERTZ` and `AZERTY`.

# Usage

 1. Start the application (a precompiled version resides in [bin/Debug/keyout.exe])
![\[k\]eyout Screenshot](docs/keyout.png)
 2. Click the action you want to rebind (the field will be highlighted in black)
 3. Press the key you want to assign to the selected action
 4. Use the **scroll-lock key to enable/disable** the bindings (the associated LED on your keyboard can be used as an indicator whether the bindings are currently enabled or disabled)
 5. Closing the application will automatically save your bindings
 
Hint: you can **reset the bindings** to their original values by double-clicking the field in question.

# Internals

The bindings are stored in the registry at `HKEY_CURRENT_USER\\Software\\fyl2xp1\\keyout\\bindings\\`
