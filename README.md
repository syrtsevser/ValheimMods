# Mugnum's Valheim mods
- Mute on minimize.

## Build instructions
1. Create folder \ValheimMods\Libraries\ in root folder.
2. Copy following files into the folder:
   - Valheim\BepInEx\core\0Harmony.dll
   - Valheim\BepInEx\core\BepInEx.dll
   - Valheim\valheim_Data\Managed\assembly_valheim.dll
   - Valheim\valheim_Data\Managed\UnityEngine.dll
   - Valheim\valheim_Data\Managed\UnityEngine.AudioModule.dll
3. Load solution.
4. When game updates, you might need to update files in "Libraries" folder, then specify References to these assemblies.
5. Build "Release" version.
6. Copy resulting .dll file from \ValheimMods\mod\bin\Release\ to \Valheim\BepInEx\plugins\.
