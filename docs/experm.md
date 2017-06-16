# ExPerm

ExPerm provides a node based group and user permission manager for mod developers to provide server administrators with fine grained control over the features of their mods.

## How are the nodes applied?

Permissions can be applied to groups or users.  Any permission for a specific user overrides the value provided for the group.

For Example, let's say we have a permission node "mymods.custom.permission".  We can deny access to that permission to an entire group, and then grant access to select members of that group.

Server commands:

```
experm group setperm mycustomgroup mymods.custom.permission false
experm user setperm myusername

```

## ExPerm for Server Administrators
ExPerm adds a few server commands for administration of permissions.  The permissions only apply to mods that implement the ExPerm permissions Manager.

### expermad
Toggles the current user's membership in the Super Admin group.  A user in the Super Admin group will always return true from any call to isAllowed, effectively bypassing the Experm system.  This group is temporary and will be reset on each server start.

```
expermad
```

### experm 

The experm command allows a server administrator to view and modify the permission information.

__experm, experm help__ Get additional information about ExPerm commands

__experm nodes__ List all of the permission nodes registered with the ExPerm permission manager

__experm user__ List all users registered with the ExPerm Manager

__experm user info &lt;SteamIdOrUsername&gt;__ Show ExPerm information for the user with &lt;SteamIdOrUsername&gt;

__experm user group &lt;SteamIdOrUserName&gt; &lt;GroupName&gt;__  Set the group for the user with &lt;SteamIdOrUserName&gt; to &lt;GroupName&gt;

__experm user setperm &lt;SteamIdOrUserName&gt; &lt;PermissionNode&gt; &lt;allowed&gt;__ Set the permission &lt;PermissionNode&gt; for &lt;SteamIdOrUsername&gt; to the true/false value supplied in &lt;allowed&gt;

__experm group__ List all groups registered with the ExPerm Manager

__experm group info &lt;GroupName&gt;__ Show ExPerm information for the group with &lt;GroupName&gt;

__experm group setperm &lt;GroupName&gt; &lt;PermissionNode&gt; &lt;allowed&gt;__ Set the permission &lt;PermissionNode&gt; for &lt;GroupName&gt; to the true/false value supplied in &lt;allowed&gt;


## ExPerm for Dedicated Server Mod Developers

ExPerm provides a framework for mod developers to add fine grained control of the features of their mods.

## Registering Permissions

```
//Register your custom permission with the PermissionManager
SDTM.API.Permissions.RegisterPermission ("mymod.custom.permission");

```

## Checking Permissions

```
//Check the permission of the current user
SDTM.API.Permissions.isAllowed (_clientInfo, "mymod.custom.permission"); //specific permission
SDTM.API.Permissions.isAllowed (_clientInfo, "mymod.custom.*"); //wildcard permission
```
