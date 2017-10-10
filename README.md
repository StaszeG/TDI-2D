**TDI2D** is a simple .NET 2D game engine. It's basing on .NET [SFML](https://www.sfml-dev.org) binding. 

I'm creating it for fun, just because I want to write my own, simple 2D game.

## Main features I want TDI2D to include:
* scenes
* simple colisions detection
* animations
* input handling
* multiplayer API

(list can be changed)

## Steps to use TDI2D in your project:
1. Compile TDI2D project in "Release" mode
2. Create new .NET Framework project
3. In your new project add reference to dll compiled in first step `src\TDI2D\bin\Release\TDI2D.dll`
4. In your new project add references to all dlls from `lib\lib`
4. Copy all dlls from `lib\extlibs` to your project destination folder
5. Now you should be able to use TDI2D in your project