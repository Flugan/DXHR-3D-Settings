x = 1

^z:: x = 1

Mbutton::
if x {
	convergence = 0x00000000
	x--
} else {
	convergence = 0x42F00000
	x++
}
; Window names
; "Deus Ex: Human Revolution - Director's Cut"
; "Deus Ex: Human Revolution"
WriteMemory(convergence, 0x01A7C698,"Deus Ex: Human Revolution - Director's Cut")
WriteMemory(convergence, 0x01AA9EB0,"Deus Ex: Human Revolution - Director's Cut")
WriteMemory(convergence, 0x10F51DAC,"Deus Ex: Human Revolution - Director's Cut")
WriteMemory(convergence, 0x11085E18,"Deus Ex: Human Revolution - Director's Cut")
WriteMemory(convergence, 0x11385E28,"Deus Ex: Human Revolution - Director's Cut")
return