using System;
using System.Collections.Generic;

using SDTM;

namespace MyCustomMod
{
	public class MyCustomMod: ModApiAbstract
	{
		public static API Instance {
			get {
				Mod mod = ModManager.GetMod ("MyCustomMod");
				return mod.ApiInstance as API;
			}
		}

		public API ()
		{
			RegisterPermissions ();
			RegisterChatCommands();

			SDTM.API.Events.OnGameStartDone += OnMyGameStartDone;
		}

		public void RegisterPermissions(){
			SDTM.API.Permissions.RegisterPermission ("mymod.custom.permission");
		}

		public void RegisterChatCommands(){
			SDTM.API sdtmAPI = SDTM.API.Instance;
			//RegisterChatCommand("commandname", "description", "usage example", commandMethod, "permission node");
			sdtmAPI.RegisterChatCommand ("mychatcommand", "A Custom Chat command", "!mychatcommand", MyChatCommandHandler, "mymod.custom.permission");
		}

		public static void MyChatCommandHandler(List<string> _params, ClientInfo _cInfo){
			PlayerUtils.SendChatMessageAs (_cInfo, "You ran the custom ChatCommand", "MyCustomModName");
		}
	}
}