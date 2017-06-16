# 7dtmlib - Dedicated Servers Only
Modding Utility Library for 7 Days to Die Dedicated Server Mods

## Features

- Expanded Modding Events
- Extended Group Based Permissions
- Chat Command Handlers
- Modding Utility Classes

## Extended Events
7dtmlib wraps the existing mod functions using c# events and delegates and adds many new events for you to access within your mods including Entity and player Events, Block and Chunk events and Loot Container Events, among others.

See the [Events](./docs/events.md) doc for more information.

## ExPerm - Node Based Permissions Manager
7dtmlib provides a node based Group and user permissions manager, allowing server administrators fine grained control over the features of your mod.

See the [ExPerm](./docs/experm.md) doc for more information.


## Chat Commands

7dtmlib provides a mechanism for easy construction of chat command handlers.

See the [Chat Commands](./docs/chatcommands.md) docs for more infortmation.

## Modding Utility Classes

7dtmlib wraps many common tasks into handy utility classes for faster mod development.

See the [Utility Classes](./docs/utilityclasses.md) docs for more information.

## Server Installation
1. Download the mod using the links above.
2. Extract the files
3. Copy the Folder containing the DLL and ModInfo.xml into your Server Mods Folder.*
4. Restart your Server

* Some Game Server Providers do not allow you to install mods yourself. You will need to submit a support ticket with the URL of this page, requesting your provider to install the mod for you.

## Using 7dtmlib in your Server Mods
Simply download the .dll file and add a reference to it in your project.

More information can be found in the [Events](./docs/events.md), [ExPerm](./docs/experm.md), [ChatCommands](./docs/chatcommands.md) and [Utility Classes](./docs/utilityclasses.md) documentation.