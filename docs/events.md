# Events
7dtmlib wraps the existing API Methods into an expanded event system.

More detailed information will be available soon

__Example__

```
namespace MyCustomMod
{
	public class MyCustomMod: ModApiAbstract
	{
		SDTM.API.Events.OnGameMinute += MyGameMinuteHandler;
	}
	
	public void MyGameMinuteHandler(int day, int hour, int minute){
		Log.Out(String.Format("Game Time: Day {0}, {1}:{2}", day, hour, minute));
	}
}
```

## Server Events
- OnGameStarted()
- OnGameStopped()
- OnGameStartDone()
- OnGameUpdate()
- OnGameStatsChanged(string StateName, object NewValue)
- OnGamePrefsChanged(EnumGamePrefs GamePref)

## Chunk Events
- OnChunkColorsDone(Chunk chunk)
- OnChunkAdded(Chunk chunk)
- OnBeforeChunkRemoved(Chunk chunk)
- OnBeforeChunkSaved(Chunk chunk)

## Game Time Events
- OnLibTick()
- OnGameMinute(int day, int hour, int minute)
- OnGameHour(int day, int hour);

## Player Events
- OnPlayerLogin(ClientInfo cInfo, string compatibilityVersion)
- OnPlayerSpawning(EntityPlayer player)
- OnPlayerSpawned(ClientInfo cInfo, RespawnType respawnReason)
- OnPlayerDisconnected(EntityPlayer player)
- OnPlayerDataSaved(ClientInfo cInfo, PlayerDataFile playerDataFile)
- OnPlayerDroppedItem(EntityPlayer player, EntityItem item)
- OnPlayerCollectedItem(EntityPlayer player, ItemStack itemStack)
- OnPlayerBuffAdded(EntityPlayer player, Buff buff)
- OnPlayerBuffRemoved(EntityPlayer player, Buff buff)
- OnPlayerWellnessChanged(EntityPlayer player, float amount)
- OnPlayerKilledByPlayer(EntityPlayer player, EntityPlayer killer)
- OnPersistentPlayerDataEvent(PersistentPlayerData player, PersistentPlayerData otherPlayer, EnumPersistentPlayerDataReason reason)
- OnPlayerACLInviteSent(PersistentPlayerData player, PersistentPlayerData invitedPlayer)
- OnPlayerACLInviteAccepted(PersistentPlayerData player, PersistentPlayerData invitedPlayer)
- OnPlayerACLInviteDeclined(PersistentPlayerData player, PersistentPlayerData invitedPlayer)
- OnPlayerACLRemoved(PersistentPlayerData player, PersistentPlayerData invitedPlayer)


## Entity Events
- OnEntityLoaded(Entity entity)
- OnEntityUnloaded(Entity entity, string reason)
- OnNPCLoaded(EntityNPC entity)
- OnNPCUnloaded(EntityNPC entity, string reason)
- OnNPCBanditLoaded(EntityBandit entity)
- OnNPCBanditUnloaded(EntityBandit entity, string reason)
- OnNPCSurvivorLoaded(EntitySurvivor entity)
- OnNPCSurvivorUnloaded(EntitySurvivor entity, string reason)
- OnTraderPrimaryInventoryChanged(EntityNPC entity, List<ItemStack> previousInventory)
- OnTraderSecretStashChanged(EntityNPC entity, List<ItemStack[]> previousStash)

## Block Events
- OnBlockChanged(Vector3i pos, BlockValue oldBlock, BlockValue newBlock)
- OnBlockDamaged(Vector3i blockPos, BlockValue blockValue, int damage, int attackerEntityId) //this does not fire when a player damages a block

## LootContainer Events
- OnLootContainerTouchChanged(TileEntityLootContainer container, ulong oldValue, ulong newValue);
- OnLootContainerOpenedTimeChanged(TileEntityLootContainer container, float oldValue, float newValue)
- OnLootContainerItemChanged(TileEntityLootContainer container, int slot, ItemStack oldStack, ItemStack newStack)

		
## Chat Command Events
- OnChatCommand(ClientInfo playerCI, string command, string params)