WriteMemory(WVALUE,MADDRESS,PROGRAM)
{
winget, pid, PID, %PROGRAM%

ProcessHandle := DllCall("OpenProcess", "int", 2035711, "char", 0, "UInt", PID, "UInt")
DllCall("WriteProcessMemory", "UInt", ProcessHandle, "UInt", MADDRESS, "Uint*", WVALUE, "Uint", 4, "Uint *", 0)

DllCall("CloseHandle", "int", ProcessHandle)
return
}