using System;
using System.Runtime.InteropServices;
using Epic.OnlineServices.Achievements;
using Epic.OnlineServices.AntiCheatClient;
using Epic.OnlineServices.AntiCheatCommon;
using Epic.OnlineServices.AntiCheatServer;
using Epic.OnlineServices.Auth;
using Epic.OnlineServices.Connect;
using Epic.OnlineServices.CustomInvites;
using Epic.OnlineServices.Ecom;
using Epic.OnlineServices.Friends;
using Epic.OnlineServices.IntegratedPlatform;
using Epic.OnlineServices.KWS;
using Epic.OnlineServices.Leaderboards;
using Epic.OnlineServices.Lobby;
using Epic.OnlineServices.Logging;
using Epic.OnlineServices.Metrics;
using Epic.OnlineServices.Mods;
using Epic.OnlineServices.P2P;
using Epic.OnlineServices.Platform;
using Epic.OnlineServices.PlayerDataStorage;
using Epic.OnlineServices.Presence;
using Epic.OnlineServices.ProgressionSnapshot;
using Epic.OnlineServices.Reports;
using Epic.OnlineServices.RTC;
using Epic.OnlineServices.RTCAdmin;
using Epic.OnlineServices.RTCAudio;
using Epic.OnlineServices.Sanctions;
using Epic.OnlineServices.Sessions;
using Epic.OnlineServices.Stats;
using Epic.OnlineServices.TitleStorage;
using Epic.OnlineServices.UI;
using Epic.OnlineServices.UserInfo;
// Dumped by ro0ti

namespace Epic.OnlineServices
{
	// Token: 0x02000021 RID: 33
	[Token(Token = "0x2000021")]
	public static class Bindings
	{
		// Token: 0x060000DC RID: 220
		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x488260", Offset = "0x486860", VA = "0x180488260")]
		[PreserveSig]
		internal static extern ulong EOS_Achievements_AddNotifyAchievementsUnlocked(IntPtr handle, ref AddNotifyAchievementsUnlockedOptionsInternal options, IntPtr clientData, OnAchievementsUnlockedCallbackInternal notificationFn);

		// Token: 0x060000DD RID: 221
		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x4881B0", Offset = "0x4867B0", VA = "0x1804881B0")]
		[PreserveSig]
		internal static extern ulong EOS_Achievements_AddNotifyAchievementsUnlockedV2(IntPtr handle, ref AddNotifyAchievementsUnlockedV2OptionsInternal options, IntPtr clientData, OnAchievementsUnlockedCallbackV2Internal notificationFn);

		// Token: 0x060000DE RID: 222
		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x488310", Offset = "0x486910", VA = "0x180488310")]
		[PreserveSig]
		internal static extern Result EOS_Achievements_CopyAchievementDefinitionByAchievementId(IntPtr handle, ref CopyAchievementDefinitionByAchievementIdOptionsInternal options, ref IntPtr outDefinition);

		// Token: 0x060000DF RID: 223
		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x4883B0", Offset = "0x4869B0", VA = "0x1804883B0")]
		[PreserveSig]
		internal static extern Result EOS_Achievements_CopyAchievementDefinitionByIndex(IntPtr handle, ref CopyAchievementDefinitionByIndexOptionsInternal options, ref IntPtr outDefinition);

		// Token: 0x060000E0 RID: 224
		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x488450", Offset = "0x486A50", VA = "0x180488450")]
		[PreserveSig]
		internal static extern Result EOS_Achievements_CopyAchievementDefinitionV2ByAchievementId(IntPtr handle, ref CopyAchievementDefinitionV2ByAchievementIdOptionsInternal options, ref IntPtr outDefinition);

		// Token: 0x060000E1 RID: 225
		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x4884F0", Offset = "0x486AF0", VA = "0x1804884F0")]
		[PreserveSig]
		internal static extern Result EOS_Achievements_CopyAchievementDefinitionV2ByIndex(IntPtr handle, ref CopyAchievementDefinitionV2ByIndexOptionsInternal options, ref IntPtr outDefinition);

		// Token: 0x060000E2 RID: 226
		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x488590", Offset = "0x486B90", VA = "0x180488590")]
		[PreserveSig]
		internal static extern Result EOS_Achievements_CopyPlayerAchievementByAchievementId(IntPtr handle, ref CopyPlayerAchievementByAchievementIdOptionsInternal options, ref IntPtr outAchievement);

		// Token: 0x060000E3 RID: 227
		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x488630", Offset = "0x486C30", VA = "0x180488630")]
		[PreserveSig]
		internal static extern Result EOS_Achievements_CopyPlayerAchievementByIndex(IntPtr handle, ref CopyPlayerAchievementByIndexOptionsInternal options, ref IntPtr outAchievement);

		// Token: 0x060000E4 RID: 228
		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x4886D0", Offset = "0x486CD0", VA = "0x1804886D0")]
		[PreserveSig]
		internal static extern Result EOS_Achievements_CopyUnlockedAchievementByAchievementId(IntPtr handle, ref CopyUnlockedAchievementByAchievementIdOptionsInternal options, ref IntPtr outAchievement);

		// Token: 0x060000E5 RID: 229
		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x488770", Offset = "0x486D70", VA = "0x180488770")]
		[PreserveSig]
		internal static extern Result EOS_Achievements_CopyUnlockedAchievementByIndex(IntPtr handle, ref CopyUnlockedAchievementByIndexOptionsInternal options, ref IntPtr outAchievement);

		// Token: 0x060000E6 RID: 230
		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x488810", Offset = "0x486E10", VA = "0x180488810")]
		[PreserveSig]
		internal static extern void EOS_Achievements_DefinitionV2_Release(IntPtr achievementDefinition);

		// Token: 0x060000E7 RID: 231
		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x488890", Offset = "0x486E90", VA = "0x180488890")]
		[PreserveSig]
		internal static extern void EOS_Achievements_Definition_Release(IntPtr achievementDefinition);

		// Token: 0x060000E8 RID: 232
		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x488910", Offset = "0x486F10", VA = "0x180488910")]
		[PreserveSig]
		internal static extern uint EOS_Achievements_GetAchievementDefinitionCount(IntPtr handle, ref GetAchievementDefinitionCountOptionsInternal options);

		// Token: 0x060000E9 RID: 233
		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x4889A0", Offset = "0x486FA0", VA = "0x1804889A0")]
		[PreserveSig]
		internal static extern uint EOS_Achievements_GetPlayerAchievementCount(IntPtr handle, ref GetPlayerAchievementCountOptionsInternal options);

		// Token: 0x060000EA RID: 234
		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x488A30", Offset = "0x487030", VA = "0x180488A30")]
		[PreserveSig]
		internal static extern uint EOS_Achievements_GetUnlockedAchievementCount(IntPtr handle, ref GetUnlockedAchievementCountOptionsInternal options);

		// Token: 0x060000EB RID: 235
		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x488AC0", Offset = "0x4870C0", VA = "0x180488AC0")]
		[PreserveSig]
		internal static extern void EOS_Achievements_PlayerAchievement_Release(IntPtr achievement);

		// Token: 0x060000EC RID: 236
		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x488B40", Offset = "0x487140", VA = "0x180488B40")]
		[PreserveSig]
		internal static extern void EOS_Achievements_QueryDefinitions(IntPtr handle, ref QueryDefinitionsOptionsInternal options, IntPtr clientData, OnQueryDefinitionsCompleteCallbackInternal completionDelegate);

		// Token: 0x060000ED RID: 237
		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x488BF0", Offset = "0x4871F0", VA = "0x180488BF0")]
		[PreserveSig]
		internal static extern void EOS_Achievements_QueryPlayerAchievements(IntPtr handle, ref QueryPlayerAchievementsOptionsInternal options, IntPtr clientData, OnQueryPlayerAchievementsCompleteCallbackInternal completionDelegate);

		// Token: 0x060000EE RID: 238
		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x488CA0", Offset = "0x4872A0", VA = "0x180488CA0")]
		[PreserveSig]
		internal static extern void EOS_Achievements_RemoveNotifyAchievementsUnlocked(IntPtr handle, ulong inId);

		// Token: 0x060000EF RID: 239
		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x488D30", Offset = "0x487330", VA = "0x180488D30")]
		[PreserveSig]
		internal static extern void EOS_Achievements_UnlockAchievements(IntPtr handle, ref UnlockAchievementsOptionsInternal options, IntPtr clientData, OnUnlockAchievementsCompleteCallbackInternal completionDelegate);

		// Token: 0x060000F0 RID: 240
		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x488DE0", Offset = "0x4873E0", VA = "0x180488DE0")]
		[PreserveSig]
		internal static extern void EOS_Achievements_UnlockedAchievement_Release(IntPtr achievement);

		// Token: 0x060000F1 RID: 241
		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x488E60", Offset = "0x487460", VA = "0x180488E60")]
		[PreserveSig]
		internal static extern Result EOS_ActiveSession_CopyInfo(IntPtr handle, ref ActiveSessionCopyInfoOptionsInternal options, ref IntPtr outActiveSessionInfo);

		// Token: 0x060000F2 RID: 242
		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x488F00", Offset = "0x487500", VA = "0x180488F00")]
		[PreserveSig]
		internal static extern IntPtr EOS_ActiveSession_GetRegisteredPlayerByIndex(IntPtr handle, ref ActiveSessionGetRegisteredPlayerByIndexOptionsInternal options);

		// Token: 0x060000F3 RID: 243
		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x488F90", Offset = "0x487590", VA = "0x180488F90")]
		[PreserveSig]
		internal static extern uint EOS_ActiveSession_GetRegisteredPlayerCount(IntPtr handle, ref ActiveSessionGetRegisteredPlayerCountOptionsInternal options);

		// Token: 0x060000F4 RID: 244
		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x489020", Offset = "0x487620", VA = "0x180489020")]
		[PreserveSig]
		internal static extern void EOS_ActiveSession_Info_Release(IntPtr activeSessionInfo);

		// Token: 0x060000F5 RID: 245
		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x4890A0", Offset = "0x4876A0", VA = "0x1804890A0")]
		[PreserveSig]
		internal static extern void EOS_ActiveSession_Release(IntPtr activeSessionHandle);

		// Token: 0x060000F6 RID: 246
		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x489120", Offset = "0x487720", VA = "0x180489120")]
		[PreserveSig]
		internal static extern Result EOS_AntiCheatClient_AddExternalIntegrityCatalog(IntPtr handle, ref AddExternalIntegrityCatalogOptionsInternal options);

		// Token: 0x060000F7 RID: 247
		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x4891B0", Offset = "0x4877B0", VA = "0x1804891B0")]
		[PreserveSig]
		internal static extern ulong EOS_AntiCheatClient_AddNotifyClientIntegrityViolated(IntPtr handle, ref AddNotifyClientIntegrityViolatedOptionsInternal options, IntPtr clientData, OnClientIntegrityViolatedCallbackInternal notificationFn);

		// Token: 0x060000F8 RID: 248
		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x489260", Offset = "0x487860", VA = "0x180489260")]
		[PreserveSig]
		internal static extern ulong EOS_AntiCheatClient_AddNotifyMessageToPeer(IntPtr handle, ref AddNotifyMessageToPeerOptionsInternal options, IntPtr clientData, OnMessageToPeerCallbackInternal notificationFn);

		// Token: 0x060000F9 RID: 249
		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x489310", Offset = "0x487910", VA = "0x180489310")]
		[PreserveSig]
		internal static extern ulong EOS_AntiCheatClient_AddNotifyMessageToServer(IntPtr handle, ref AddNotifyMessageToServerOptionsInternal options, IntPtr clientData, OnMessageToServerCallbackInternal notificationFn);

		// Token: 0x060000FA RID: 250
		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x4893C0", Offset = "0x4879C0", VA = "0x1804893C0")]
		[PreserveSig]
		internal static extern ulong EOS_AntiCheatClient_AddNotifyPeerActionRequired(IntPtr handle, ref AddNotifyPeerActionRequiredOptionsInternal options, IntPtr clientData, OnPeerActionRequiredCallbackInternal notificationFn);

		// Token: 0x060000FB RID: 251
		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x489470", Offset = "0x487A70", VA = "0x180489470")]
		[PreserveSig]
		internal static extern ulong EOS_AntiCheatClient_AddNotifyPeerAuthStatusChanged(IntPtr handle, ref AddNotifyPeerAuthStatusChangedOptionsInternal options, IntPtr clientData, OnPeerAuthStatusChangedCallbackInternal notificationFn);

		// Token: 0x060000FC RID: 252
		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x489520", Offset = "0x487B20", VA = "0x180489520")]
		[PreserveSig]
		internal static extern Result EOS_AntiCheatClient_BeginSession(IntPtr handle, ref Epic.OnlineServices.AntiCheatClient.BeginSessionOptionsInternal options);

		// Token: 0x060000FD RID: 253
		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x4895B0", Offset = "0x487BB0", VA = "0x1804895B0")]
		[PreserveSig]
		internal static extern Result EOS_AntiCheatClient_EndSession(IntPtr handle, ref Epic.OnlineServices.AntiCheatClient.EndSessionOptionsInternal options);

		// Token: 0x060000FE RID: 254
		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x489640", Offset = "0x487C40", VA = "0x180489640")]
		[PreserveSig]
		internal static extern Result EOS_AntiCheatClient_GetProtectMessageOutputLength(IntPtr handle, ref Epic.OnlineServices.AntiCheatClient.GetProtectMessageOutputLengthOptionsInternal options, ref uint outBufferSizeBytes);

		// Token: 0x060000FF RID: 255
		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x4896E0", Offset = "0x487CE0", VA = "0x1804896E0")]
		[PreserveSig]
		internal static extern Result EOS_AntiCheatClient_PollStatus(IntPtr handle, ref PollStatusOptionsInternal options, ref AntiCheatClientViolationType outViolationType, IntPtr outMessage);

		// Token: 0x06000100 RID: 256
		[Token(Token = "0x6000100")]
		[Address(RVA = "0x489790", Offset = "0x487D90", VA = "0x180489790")]
		[PreserveSig]
		internal static extern Result EOS_AntiCheatClient_ProtectMessage(IntPtr handle, ref Epic.OnlineServices.AntiCheatClient.ProtectMessageOptionsInternal options, IntPtr outBuffer, ref uint outBytesWritten);

		// Token: 0x06000101 RID: 257
		[Token(Token = "0x6000101")]
		[Address(RVA = "0x489840", Offset = "0x487E40", VA = "0x180489840")]
		[PreserveSig]
		internal static extern Result EOS_AntiCheatClient_ReceiveMessageFromPeer(IntPtr handle, ref ReceiveMessageFromPeerOptionsInternal options);

		// Token: 0x06000102 RID: 258
		[Token(Token = "0x6000102")]
		[Address(RVA = "0x4898D0", Offset = "0x487ED0", VA = "0x1804898D0")]
		[PreserveSig]
		internal static extern Result EOS_AntiCheatClient_ReceiveMessageFromServer(IntPtr handle, ref ReceiveMessageFromServerOptionsInternal options);

		// Token: 0x06000103 RID: 259
		[Token(Token = "0x6000103")]
		[Address(RVA = "0x489960", Offset = "0x487F60", VA = "0x180489960")]
		[PreserveSig]
		internal static extern Result EOS_AntiCheatClient_RegisterPeer(IntPtr handle, ref RegisterPeerOptionsInternal options);

		// Token: 0x06000104 RID: 260
		[Token(Token = "0x6000104")]
		[Address(RVA = "0x4899F0", Offset = "0x487FF0", VA = "0x1804899F0")]
		[PreserveSig]
		internal static extern void EOS_AntiCheatClient_RemoveNotifyClientIntegrityViolated(IntPtr handle, ulong notificationId);

		// Token: 0x06000105 RID: 261
		[Token(Token = "0x6000105")]
		[Address(RVA = "0x489A80", Offset = "0x488080", VA = "0x180489A80")]
		[PreserveSig]
		internal static extern void EOS_AntiCheatClient_RemoveNotifyMessageToPeer(IntPtr handle, ulong notificationId);

		// Token: 0x06000106 RID: 262
		[Token(Token = "0x6000106")]
		[Address(RVA = "0x489B10", Offset = "0x488110", VA = "0x180489B10")]
		[PreserveSig]
		internal static extern void EOS_AntiCheatClient_RemoveNotifyMessageToServer(IntPtr handle, ulong notificationId);

		// Token: 0x06000107 RID: 263
		[Token(Token = "0x6000107")]
		[Address(RVA = "0x489BA0", Offset = "0x4881A0", VA = "0x180489BA0")]
		[PreserveSig]
		internal static extern void EOS_AntiCheatClient_RemoveNotifyPeerActionRequired(IntPtr handle, ulong notificationId);

		// Token: 0x06000108 RID: 264
		[Token(Token = "0x6000108")]
		[Address(RVA = "0x489C30", Offset = "0x488230", VA = "0x180489C30")]
		[PreserveSig]
		internal static extern void EOS_AntiCheatClient_RemoveNotifyPeerAuthStatusChanged(IntPtr handle, ulong notificationId);

		// Token: 0x06000109 RID: 265
		[Token(Token = "0x6000109")]
		[Address(RVA = "0x489CC0", Offset = "0x4882C0", VA = "0x180489CC0")]
		[PreserveSig]
		internal static extern Result EOS_AntiCheatClient_UnprotectMessage(IntPtr handle, ref Epic.OnlineServices.AntiCheatClient.UnprotectMessageOptionsInternal options, IntPtr outBuffer, ref uint outBytesWritten);

		// Token: 0x0600010A RID: 266
		[Token(Token = "0x600010A")]
		[Address(RVA = "0x489D70", Offset = "0x488370", VA = "0x180489D70")]
		[PreserveSig]
		internal static extern Result EOS_AntiCheatClient_UnregisterPeer(IntPtr handle, ref UnregisterPeerOptionsInternal options);

		// Token: 0x0600010B RID: 267
		[Token(Token = "0x600010B")]
		[Address(RVA = "0x489E00", Offset = "0x488400", VA = "0x180489E00")]
		[PreserveSig]
		internal static extern ulong EOS_AntiCheatServer_AddNotifyClientActionRequired(IntPtr handle, ref AddNotifyClientActionRequiredOptionsInternal options, IntPtr clientData, OnClientActionRequiredCallbackInternal notificationFn);

		// Token: 0x0600010C RID: 268
		[Token(Token = "0x600010C")]
		[Address(RVA = "0x489EB0", Offset = "0x4884B0", VA = "0x180489EB0")]
		[PreserveSig]
		internal static extern ulong EOS_AntiCheatServer_AddNotifyClientAuthStatusChanged(IntPtr handle, ref AddNotifyClientAuthStatusChangedOptionsInternal options, IntPtr clientData, OnClientAuthStatusChangedCallbackInternal notificationFn);

		// Token: 0x0600010D RID: 269
		[Token(Token = "0x600010D")]
		[Address(RVA = "0x489F60", Offset = "0x488560", VA = "0x180489F60")]
		[PreserveSig]
		internal static extern ulong EOS_AntiCheatServer_AddNotifyMessageToClient(IntPtr handle, ref AddNotifyMessageToClientOptionsInternal options, IntPtr clientData, OnMessageToClientCallbackInternal notificationFn);

		// Token: 0x0600010E RID: 270
		[Token(Token = "0x600010E")]
		[Address(RVA = "0x48A010", Offset = "0x488610", VA = "0x18048A010")]
		[PreserveSig]
		internal static extern Result EOS_AntiCheatServer_BeginSession(IntPtr handle, ref Epic.OnlineServices.AntiCheatServer.BeginSessionOptionsInternal options);

		// Token: 0x0600010F RID: 271
		[Token(Token = "0x600010F")]
		[Address(RVA = "0x48A0A0", Offset = "0x4886A0", VA = "0x18048A0A0")]
		[PreserveSig]
		internal static extern Result EOS_AntiCheatServer_EndSession(IntPtr handle, ref Epic.OnlineServices.AntiCheatServer.EndSessionOptionsInternal options);

		// Token: 0x06000110 RID: 272
		[Token(Token = "0x6000110")]
		[Address(RVA = "0x48A130", Offset = "0x488730", VA = "0x18048A130")]
		[PreserveSig]
		internal static extern Result EOS_AntiCheatServer_GetProtectMessageOutputLength(IntPtr handle, ref Epic.OnlineServices.AntiCheatServer.GetProtectMessageOutputLengthOptionsInternal options, ref uint outBufferSizeBytes);

		// Token: 0x06000111 RID: 273
		[Token(Token = "0x6000111")]
		[Address(RVA = "0x48A1D0", Offset = "0x4887D0", VA = "0x18048A1D0")]
		[PreserveSig]
		internal static extern Result EOS_AntiCheatServer_LogEvent(IntPtr handle, ref LogEventOptionsInternal options);

		// Token: 0x06000112 RID: 274
		[Token(Token = "0x6000112")]
		[Address(RVA = "0x48A260", Offset = "0x488860", VA = "0x18048A260")]
		[PreserveSig]
		internal static extern Result EOS_AntiCheatServer_LogGameRoundEnd(IntPtr handle, ref LogGameRoundEndOptionsInternal options);

		// Token: 0x06000113 RID: 275
		[Token(Token = "0x6000113")]
		[Address(RVA = "0x48A2F0", Offset = "0x4888F0", VA = "0x18048A2F0")]
		[PreserveSig]
		internal static extern Result EOS_AntiCheatServer_LogGameRoundStart(IntPtr handle, ref LogGameRoundStartOptionsInternal options);

		// Token: 0x06000114 RID: 276
		[Token(Token = "0x6000114")]
		[Address(RVA = "0x48A380", Offset = "0x488980", VA = "0x18048A380")]
		[PreserveSig]
		internal static extern Result EOS_AntiCheatServer_LogPlayerDespawn(IntPtr handle, ref LogPlayerDespawnOptionsInternal options);

		// Token: 0x06000115 RID: 277
		[Token(Token = "0x6000115")]
		[Address(RVA = "0x48A410", Offset = "0x488A10", VA = "0x18048A410")]
		[PreserveSig]
		internal static extern Result EOS_AntiCheatServer_LogPlayerRevive(IntPtr handle, ref LogPlayerReviveOptionsInternal options);

		// Token: 0x06000116 RID: 278
		[Token(Token = "0x6000116")]
		[Address(RVA = "0x48A4A0", Offset = "0x488AA0", VA = "0x18048A4A0")]
		[PreserveSig]
		internal static extern Result EOS_AntiCheatServer_LogPlayerSpawn(IntPtr handle, ref LogPlayerSpawnOptionsInternal options);

		// Token: 0x06000117 RID: 279
		[Token(Token = "0x6000117")]
		[Address(RVA = "0x48A530", Offset = "0x488B30", VA = "0x18048A530")]
		[PreserveSig]
		internal static extern Result EOS_AntiCheatServer_LogPlayerTakeDamage(IntPtr handle, ref LogPlayerTakeDamageOptionsInternal options);

		// Token: 0x06000118 RID: 280
		[Token(Token = "0x6000118")]
		[Address(RVA = "0x48A5C0", Offset = "0x488BC0", VA = "0x18048A5C0")]
		[PreserveSig]
		internal static extern Result EOS_AntiCheatServer_LogPlayerTick(IntPtr handle, ref LogPlayerTickOptionsInternal options);

		// Token: 0x06000119 RID: 281
		[Token(Token = "0x6000119")]
		[Address(RVA = "0x48A650", Offset = "0x488C50", VA = "0x18048A650")]
		[PreserveSig]
		internal static extern Result EOS_AntiCheatServer_LogPlayerUseAbility(IntPtr handle, ref LogPlayerUseAbilityOptionsInternal options);

		// Token: 0x0600011A RID: 282
		[Token(Token = "0x600011A")]
		[Address(RVA = "0x48A6E0", Offset = "0x488CE0", VA = "0x18048A6E0")]
		[PreserveSig]
		internal static extern Result EOS_AntiCheatServer_LogPlayerUseWeapon(IntPtr handle, ref LogPlayerUseWeaponOptionsInternal options);

		// Token: 0x0600011B RID: 283
		[Token(Token = "0x600011B")]
		[Address(RVA = "0x48A770", Offset = "0x488D70", VA = "0x18048A770")]
		[PreserveSig]
		internal static extern Result EOS_AntiCheatServer_ProtectMessage(IntPtr handle, ref Epic.OnlineServices.AntiCheatServer.ProtectMessageOptionsInternal options, IntPtr outBuffer, ref uint outBytesWritten);

		// Token: 0x0600011C RID: 284
		[Token(Token = "0x600011C")]
		[Address(RVA = "0x48A820", Offset = "0x488E20", VA = "0x18048A820")]
		[PreserveSig]
		internal static extern Result EOS_AntiCheatServer_ReceiveMessageFromClient(IntPtr handle, ref ReceiveMessageFromClientOptionsInternal options);

		// Token: 0x0600011D RID: 285
		[Token(Token = "0x600011D")]
		[Address(RVA = "0x48A8B0", Offset = "0x488EB0", VA = "0x18048A8B0")]
		[PreserveSig]
		internal static extern Result EOS_AntiCheatServer_RegisterClient(IntPtr handle, ref RegisterClientOptionsInternal options);

		// Token: 0x0600011E RID: 286
		[Token(Token = "0x600011E")]
		[Address(RVA = "0x48A940", Offset = "0x488F40", VA = "0x18048A940")]
		[PreserveSig]
		internal static extern Result EOS_AntiCheatServer_RegisterEvent(IntPtr handle, ref RegisterEventOptionsInternal options);

		// Token: 0x0600011F RID: 287
		[Token(Token = "0x600011F")]
		[Address(RVA = "0x48A9D0", Offset = "0x488FD0", VA = "0x18048A9D0")]
		[PreserveSig]
		internal static extern void EOS_AntiCheatServer_RemoveNotifyClientActionRequired(IntPtr handle, ulong notificationId);

		// Token: 0x06000120 RID: 288
		[Token(Token = "0x6000120")]
		[Address(RVA = "0x48AA60", Offset = "0x489060", VA = "0x18048AA60")]
		[PreserveSig]
		internal static extern void EOS_AntiCheatServer_RemoveNotifyClientAuthStatusChanged(IntPtr handle, ulong notificationId);

		// Token: 0x06000121 RID: 289
		[Token(Token = "0x6000121")]
		[Address(RVA = "0x48AAF0", Offset = "0x4890F0", VA = "0x18048AAF0")]
		[PreserveSig]
		internal static extern void EOS_AntiCheatServer_RemoveNotifyMessageToClient(IntPtr handle, ulong notificationId);

		// Token: 0x06000122 RID: 290
		[Token(Token = "0x6000122")]
		[Address(RVA = "0x48AB80", Offset = "0x489180", VA = "0x18048AB80")]
		[PreserveSig]
		internal static extern Result EOS_AntiCheatServer_SetClientDetails(IntPtr handle, ref SetClientDetailsOptionsInternal options);

		// Token: 0x06000123 RID: 291
		[Token(Token = "0x6000123")]
		[Address(RVA = "0x48AC10", Offset = "0x489210", VA = "0x18048AC10")]
		[PreserveSig]
		internal static extern Result EOS_AntiCheatServer_SetClientNetworkState(IntPtr handle, ref SetClientNetworkStateOptionsInternal options);

		// Token: 0x06000124 RID: 292
		[Token(Token = "0x6000124")]
		[Address(RVA = "0x48ACA0", Offset = "0x4892A0", VA = "0x18048ACA0")]
		[PreserveSig]
		internal static extern Result EOS_AntiCheatServer_SetGameSessionId(IntPtr handle, ref SetGameSessionIdOptionsInternal options);

		// Token: 0x06000125 RID: 293
		[Token(Token = "0x6000125")]
		[Address(RVA = "0x48AD30", Offset = "0x489330", VA = "0x18048AD30")]
		[PreserveSig]
		internal static extern Result EOS_AntiCheatServer_UnprotectMessage(IntPtr handle, ref Epic.OnlineServices.AntiCheatServer.UnprotectMessageOptionsInternal options, IntPtr outBuffer, ref uint outBytesWritten);

		// Token: 0x06000126 RID: 294
		[Token(Token = "0x6000126")]
		[Address(RVA = "0x48ADE0", Offset = "0x4893E0", VA = "0x18048ADE0")]
		[PreserveSig]
		internal static extern Result EOS_AntiCheatServer_UnregisterClient(IntPtr handle, ref UnregisterClientOptionsInternal options);

		// Token: 0x06000127 RID: 295
		[Token(Token = "0x6000127")]
		[Address(RVA = "0x48AE70", Offset = "0x489470", VA = "0x18048AE70")]
		[PreserveSig]
		internal static extern ulong EOS_Auth_AddNotifyLoginStatusChanged(IntPtr handle, ref Epic.OnlineServices.Auth.AddNotifyLoginStatusChangedOptionsInternal options, IntPtr clientData, Epic.OnlineServices.Auth.OnLoginStatusChangedCallbackInternal notification);

		// Token: 0x06000128 RID: 296
		[Token(Token = "0x6000128")]
		[Address(RVA = "0x48AF20", Offset = "0x489520", VA = "0x18048AF20")]
		[PreserveSig]
		internal static extern Result EOS_Auth_CopyIdToken(IntPtr handle, ref Epic.OnlineServices.Auth.CopyIdTokenOptionsInternal options, ref IntPtr outIdToken);

		// Token: 0x06000129 RID: 297
		[Token(Token = "0x6000129")]
		[Address(RVA = "0x48AFC0", Offset = "0x4895C0", VA = "0x18048AFC0")]
		[PreserveSig]
		internal static extern Result EOS_Auth_CopyUserAuthToken(IntPtr handle, ref CopyUserAuthTokenOptionsInternal options, IntPtr localUserId, ref IntPtr outUserAuthToken);

		// Token: 0x0600012A RID: 298
		[Token(Token = "0x600012A")]
		[Address(RVA = "0x48B070", Offset = "0x489670", VA = "0x18048B070")]
		[PreserveSig]
		internal static extern void EOS_Auth_DeletePersistentAuth(IntPtr handle, ref DeletePersistentAuthOptionsInternal options, IntPtr clientData, OnDeletePersistentAuthCallbackInternal completionDelegate);

		// Token: 0x0600012B RID: 299
		[Token(Token = "0x600012B")]
		[Address(RVA = "0x48B120", Offset = "0x489720", VA = "0x18048B120")]
		[PreserveSig]
		internal static extern IntPtr EOS_Auth_GetLoggedInAccountByIndex(IntPtr handle, int index);

		// Token: 0x0600012C RID: 300
		[Token(Token = "0x600012C")]
		[Address(RVA = "0x48B1B0", Offset = "0x4897B0", VA = "0x18048B1B0")]
		[PreserveSig]
		internal static extern int EOS_Auth_GetLoggedInAccountsCount(IntPtr handle);

		// Token: 0x0600012D RID: 301
		[Token(Token = "0x600012D")]
		[Address(RVA = "0x48B230", Offset = "0x489830", VA = "0x18048B230")]
		[PreserveSig]
		internal static extern LoginStatus EOS_Auth_GetLoginStatus(IntPtr handle, IntPtr localUserId);

		// Token: 0x0600012E RID: 302
		[Token(Token = "0x600012E")]
		[Address(RVA = "0x48B2C0", Offset = "0x4898C0", VA = "0x18048B2C0")]
		[PreserveSig]
		internal static extern IntPtr EOS_Auth_GetMergedAccountByIndex(IntPtr handle, IntPtr localUserId, uint index);

		// Token: 0x0600012F RID: 303
		[Token(Token = "0x600012F")]
		[Address(RVA = "0x48B360", Offset = "0x489960", VA = "0x18048B360")]
		[PreserveSig]
		internal static extern uint EOS_Auth_GetMergedAccountsCount(IntPtr handle, IntPtr localUserId);

		// Token: 0x06000130 RID: 304
		[Token(Token = "0x6000130")]
		[Address(RVA = "0x48B3F0", Offset = "0x4899F0", VA = "0x18048B3F0")]
		[PreserveSig]
		internal static extern Result EOS_Auth_GetSelectedAccountId(IntPtr handle, IntPtr localUserId, ref IntPtr outSelectedAccountId);

		// Token: 0x06000131 RID: 305
		[Token(Token = "0x6000131")]
		[Address(RVA = "0x48B490", Offset = "0x489A90", VA = "0x18048B490")]
		[PreserveSig]
		internal static extern void EOS_Auth_IdToken_Release(IntPtr idToken);

		// Token: 0x06000132 RID: 306
		[Token(Token = "0x6000132")]
		[Address(RVA = "0x48B510", Offset = "0x489B10", VA = "0x18048B510")]
		[PreserveSig]
		internal static extern void EOS_Auth_LinkAccount(IntPtr handle, ref Epic.OnlineServices.Auth.LinkAccountOptionsInternal options, IntPtr clientData, Epic.OnlineServices.Auth.OnLinkAccountCallbackInternal completionDelegate);

		// Token: 0x06000133 RID: 307
		[Token(Token = "0x6000133")]
		[Address(RVA = "0x48B5C0", Offset = "0x489BC0", VA = "0x18048B5C0")]
		[PreserveSig]
		internal static extern void EOS_Auth_Login(IntPtr handle, ref Epic.OnlineServices.Auth.LoginOptionsInternal options, IntPtr clientData, Epic.OnlineServices.Auth.OnLoginCallbackInternal completionDelegate);

		// Token: 0x06000134 RID: 308
		[Token(Token = "0x6000134")]
		[Address(RVA = "0x48B670", Offset = "0x489C70", VA = "0x18048B670")]
		[PreserveSig]
		internal static extern void EOS_Auth_Logout(IntPtr handle, ref LogoutOptionsInternal options, IntPtr clientData, OnLogoutCallbackInternal completionDelegate);

		// Token: 0x06000135 RID: 309
		[Token(Token = "0x6000135")]
		[Address(RVA = "0x48B720", Offset = "0x489D20", VA = "0x18048B720")]
		[PreserveSig]
		internal static extern void EOS_Auth_QueryIdToken(IntPtr handle, ref QueryIdTokenOptionsInternal options, IntPtr clientData, OnQueryIdTokenCallbackInternal completionDelegate);

		// Token: 0x06000136 RID: 310
		[Token(Token = "0x6000136")]
		[Address(RVA = "0x48B7D0", Offset = "0x489DD0", VA = "0x18048B7D0")]
		[PreserveSig]
		internal static extern void EOS_Auth_RemoveNotifyLoginStatusChanged(IntPtr handle, ulong inId);

		// Token: 0x06000137 RID: 311
		[Token(Token = "0x6000137")]
		[Address(RVA = "0x48B860", Offset = "0x489E60", VA = "0x18048B860")]
		[PreserveSig]
		internal static extern void EOS_Auth_Token_Release(IntPtr authToken);

		// Token: 0x06000138 RID: 312
		[Token(Token = "0x6000138")]
		[Address(RVA = "0x48B8E0", Offset = "0x489EE0", VA = "0x18048B8E0")]
		[PreserveSig]
		internal static extern void EOS_Auth_VerifyIdToken(IntPtr handle, ref Epic.OnlineServices.Auth.VerifyIdTokenOptionsInternal options, IntPtr clientData, Epic.OnlineServices.Auth.OnVerifyIdTokenCallbackInternal completionDelegate);

		// Token: 0x06000139 RID: 313
		[Token(Token = "0x6000139")]
		[Address(RVA = "0x48B990", Offset = "0x489F90", VA = "0x18048B990")]
		[PreserveSig]
		internal static extern void EOS_Auth_VerifyUserAuth(IntPtr handle, ref VerifyUserAuthOptionsInternal options, IntPtr clientData, OnVerifyUserAuthCallbackInternal completionDelegate);

		// Token: 0x0600013A RID: 314
		[Token(Token = "0x600013A")]
		[Address(RVA = "0x48BA40", Offset = "0x48A040", VA = "0x18048BA40")]
		[PreserveSig]
		internal static extern Result EOS_ByteArray_ToString(IntPtr byteArray, uint length, IntPtr outBuffer, ref uint inOutBufferLength);

		// Token: 0x0600013B RID: 315
		[Token(Token = "0x600013B")]
		[Address(RVA = "0x48BAE0", Offset = "0x48A0E0", VA = "0x18048BAE0")]
		[PreserveSig]
		internal static extern ulong EOS_Connect_AddNotifyAuthExpiration(IntPtr handle, ref AddNotifyAuthExpirationOptionsInternal options, IntPtr clientData, OnAuthExpirationCallbackInternal notification);

		// Token: 0x0600013C RID: 316
		[Token(Token = "0x600013C")]
		[Address(RVA = "0x48BB90", Offset = "0x48A190", VA = "0x18048BB90")]
		[PreserveSig]
		internal static extern ulong EOS_Connect_AddNotifyLoginStatusChanged(IntPtr handle, ref Epic.OnlineServices.Connect.AddNotifyLoginStatusChangedOptionsInternal options, IntPtr clientData, Epic.OnlineServices.Connect.OnLoginStatusChangedCallbackInternal notification);

		// Token: 0x0600013D RID: 317
		[Token(Token = "0x600013D")]
		[Address(RVA = "0x48BC40", Offset = "0x48A240", VA = "0x18048BC40")]
		[PreserveSig]
		internal static extern Result EOS_Connect_CopyIdToken(IntPtr handle, ref Epic.OnlineServices.Connect.CopyIdTokenOptionsInternal options, ref IntPtr outIdToken);

		// Token: 0x0600013E RID: 318
		[Token(Token = "0x600013E")]
		[Address(RVA = "0x48BCE0", Offset = "0x48A2E0", VA = "0x18048BCE0")]
		[PreserveSig]
		internal static extern Result EOS_Connect_CopyProductUserExternalAccountByAccountId(IntPtr handle, ref CopyProductUserExternalAccountByAccountIdOptionsInternal options, ref IntPtr outExternalAccountInfo);

		// Token: 0x0600013F RID: 319
		[Token(Token = "0x600013F")]
		[Address(RVA = "0x48BD80", Offset = "0x48A380", VA = "0x18048BD80")]
		[PreserveSig]
		internal static extern Result EOS_Connect_CopyProductUserExternalAccountByAccountType(IntPtr handle, ref CopyProductUserExternalAccountByAccountTypeOptionsInternal options, ref IntPtr outExternalAccountInfo);

		// Token: 0x06000140 RID: 320
		[Token(Token = "0x6000140")]
		[Address(RVA = "0x48BE20", Offset = "0x48A420", VA = "0x18048BE20")]
		[PreserveSig]
		internal static extern Result EOS_Connect_CopyProductUserExternalAccountByIndex(IntPtr handle, ref CopyProductUserExternalAccountByIndexOptionsInternal options, ref IntPtr outExternalAccountInfo);

		// Token: 0x06000141 RID: 321
		[Token(Token = "0x6000141")]
		[Address(RVA = "0x48BEC0", Offset = "0x48A4C0", VA = "0x18048BEC0")]
		[PreserveSig]
		internal static extern Result EOS_Connect_CopyProductUserInfo(IntPtr handle, ref CopyProductUserInfoOptionsInternal options, ref IntPtr outExternalAccountInfo);

		// Token: 0x06000142 RID: 322
		[Token(Token = "0x6000142")]
		[Address(RVA = "0x48BF60", Offset = "0x48A560", VA = "0x18048BF60")]
		[PreserveSig]
		internal static extern void EOS_Connect_CreateDeviceId(IntPtr handle, ref CreateDeviceIdOptionsInternal options, IntPtr clientData, OnCreateDeviceIdCallbackInternal completionDelegate);

		// Token: 0x06000143 RID: 323
		[Token(Token = "0x6000143")]
		[Address(RVA = "0x48C010", Offset = "0x48A610", VA = "0x18048C010")]
		[PreserveSig]
		internal static extern void EOS_Connect_CreateUser(IntPtr handle, ref Epic.OnlineServices.Connect.CreateUserOptionsInternal options, IntPtr clientData, Epic.OnlineServices.Connect.OnCreateUserCallbackInternal completionDelegate);

		// Token: 0x06000144 RID: 324
		[Token(Token = "0x6000144")]
		[Address(RVA = "0x48C0C0", Offset = "0x48A6C0", VA = "0x18048C0C0")]
		[PreserveSig]
		internal static extern void EOS_Connect_DeleteDeviceId(IntPtr handle, ref DeleteDeviceIdOptionsInternal options, IntPtr clientData, OnDeleteDeviceIdCallbackInternal completionDelegate);

		// Token: 0x06000145 RID: 325
		[Token(Token = "0x6000145")]
		[Address(RVA = "0x48C170", Offset = "0x48A770", VA = "0x18048C170")]
		[PreserveSig]
		internal static extern void EOS_Connect_ExternalAccountInfo_Release(IntPtr externalAccountInfo);

		// Token: 0x06000146 RID: 326
		[Token(Token = "0x6000146")]
		[Address(RVA = "0x48C1F0", Offset = "0x48A7F0", VA = "0x18048C1F0")]
		[PreserveSig]
		internal static extern IntPtr EOS_Connect_GetExternalAccountMapping(IntPtr handle, ref GetExternalAccountMappingsOptionsInternal options);

		// Token: 0x06000147 RID: 327
		[Token(Token = "0x6000147")]
		[Address(RVA = "0x48C280", Offset = "0x48A880", VA = "0x18048C280")]
		[PreserveSig]
		internal static extern IntPtr EOS_Connect_GetLoggedInUserByIndex(IntPtr handle, int index);

		// Token: 0x06000148 RID: 328
		[Token(Token = "0x6000148")]
		[Address(RVA = "0x48C310", Offset = "0x48A910", VA = "0x18048C310")]
		[PreserveSig]
		internal static extern int EOS_Connect_GetLoggedInUsersCount(IntPtr handle);

		// Token: 0x06000149 RID: 329
		[Token(Token = "0x6000149")]
		[Address(RVA = "0x48C390", Offset = "0x48A990", VA = "0x18048C390")]
		[PreserveSig]
		internal static extern LoginStatus EOS_Connect_GetLoginStatus(IntPtr handle, IntPtr localUserId);

		// Token: 0x0600014A RID: 330
		[Token(Token = "0x600014A")]
		[Address(RVA = "0x48C420", Offset = "0x48AA20", VA = "0x18048C420")]
		[PreserveSig]
		internal static extern uint EOS_Connect_GetProductUserExternalAccountCount(IntPtr handle, ref GetProductUserExternalAccountCountOptionsInternal options);

		// Token: 0x0600014B RID: 331
		[Token(Token = "0x600014B")]
		[Address(RVA = "0x48C4B0", Offset = "0x48AAB0", VA = "0x18048C4B0")]
		[PreserveSig]
		internal static extern Result EOS_Connect_GetProductUserIdMapping(IntPtr handle, ref GetProductUserIdMappingOptionsInternal options, IntPtr outBuffer, ref int inOutBufferLength);

		// Token: 0x0600014C RID: 332
		[Token(Token = "0x600014C")]
		[Address(RVA = "0x48C560", Offset = "0x48AB60", VA = "0x18048C560")]
		[PreserveSig]
		internal static extern void EOS_Connect_IdToken_Release(IntPtr idToken);

		// Token: 0x0600014D RID: 333
		[Token(Token = "0x600014D")]
		[Address(RVA = "0x48C5E0", Offset = "0x48ABE0", VA = "0x18048C5E0")]
		[PreserveSig]
		internal static extern void EOS_Connect_LinkAccount(IntPtr handle, ref Epic.OnlineServices.Connect.LinkAccountOptionsInternal options, IntPtr clientData, Epic.OnlineServices.Connect.OnLinkAccountCallbackInternal completionDelegate);

		// Token: 0x0600014E RID: 334
		[Token(Token = "0x600014E")]
		[Address(RVA = "0x48C690", Offset = "0x48AC90", VA = "0x18048C690")]
		[PreserveSig]
		internal static extern void EOS_Connect_Login(IntPtr handle, ref Epic.OnlineServices.Connect.LoginOptionsInternal options, IntPtr clientData, Epic.OnlineServices.Connect.OnLoginCallbackInternal completionDelegate);

		// Token: 0x0600014F RID: 335
		[Token(Token = "0x600014F")]
		[Address(RVA = "0x48C740", Offset = "0x48AD40", VA = "0x18048C740")]
		[PreserveSig]
		internal static extern void EOS_Connect_QueryExternalAccountMappings(IntPtr handle, ref QueryExternalAccountMappingsOptionsInternal options, IntPtr clientData, OnQueryExternalAccountMappingsCallbackInternal completionDelegate);

		// Token: 0x06000150 RID: 336
		[Token(Token = "0x6000150")]
		[Address(RVA = "0x48C7F0", Offset = "0x48ADF0", VA = "0x18048C7F0")]
		[PreserveSig]
		internal static extern void EOS_Connect_QueryProductUserIdMappings(IntPtr handle, ref QueryProductUserIdMappingsOptionsInternal options, IntPtr clientData, OnQueryProductUserIdMappingsCallbackInternal completionDelegate);

		// Token: 0x06000151 RID: 337
		[Token(Token = "0x6000151")]
		[Address(RVA = "0x48C8A0", Offset = "0x48AEA0", VA = "0x18048C8A0")]
		[PreserveSig]
		internal static extern void EOS_Connect_RemoveNotifyAuthExpiration(IntPtr handle, ulong inId);

		// Token: 0x06000152 RID: 338
		[Token(Token = "0x6000152")]
		[Address(RVA = "0x48C930", Offset = "0x48AF30", VA = "0x18048C930")]
		[PreserveSig]
		internal static extern void EOS_Connect_RemoveNotifyLoginStatusChanged(IntPtr handle, ulong inId);

		// Token: 0x06000153 RID: 339
		[Token(Token = "0x6000153")]
		[Address(RVA = "0x48C9C0", Offset = "0x48AFC0", VA = "0x18048C9C0")]
		[PreserveSig]
		internal static extern void EOS_Connect_TransferDeviceIdAccount(IntPtr handle, ref TransferDeviceIdAccountOptionsInternal options, IntPtr clientData, OnTransferDeviceIdAccountCallbackInternal completionDelegate);

		// Token: 0x06000154 RID: 340
		[Token(Token = "0x6000154")]
		[Address(RVA = "0x48CA70", Offset = "0x48B070", VA = "0x18048CA70")]
		[PreserveSig]
		internal static extern void EOS_Connect_UnlinkAccount(IntPtr handle, ref UnlinkAccountOptionsInternal options, IntPtr clientData, OnUnlinkAccountCallbackInternal completionDelegate);

		// Token: 0x06000155 RID: 341
		[Token(Token = "0x6000155")]
		[Address(RVA = "0x48CB20", Offset = "0x48B120", VA = "0x18048CB20")]
		[PreserveSig]
		internal static extern void EOS_Connect_VerifyIdToken(IntPtr handle, ref Epic.OnlineServices.Connect.VerifyIdTokenOptionsInternal options, IntPtr clientData, Epic.OnlineServices.Connect.OnVerifyIdTokenCallbackInternal completionDelegate);

		// Token: 0x06000156 RID: 342
		[Token(Token = "0x6000156")]
		[Address(RVA = "0x48CBD0", Offset = "0x48B1D0", VA = "0x18048CBD0")]
		[PreserveSig]
		internal static extern Result EOS_ContinuanceToken_ToString(IntPtr continuanceToken, IntPtr outBuffer, ref int inOutBufferLength);

		// Token: 0x06000157 RID: 343
		[Token(Token = "0x6000157")]
		[Address(RVA = "0x48CC70", Offset = "0x48B270", VA = "0x18048CC70")]
		[PreserveSig]
		internal static extern void EOS_CustomInvites_AcceptRequestToJoin(IntPtr handle, ref AcceptRequestToJoinOptionsInternal options, IntPtr clientData, OnAcceptRequestToJoinCallbackInternal completionDelegate);

		// Token: 0x06000158 RID: 344
		[Token(Token = "0x6000158")]
		[Address(RVA = "0x48CD20", Offset = "0x48B320", VA = "0x18048CD20")]
		[PreserveSig]
		internal static extern ulong EOS_CustomInvites_AddNotifyCustomInviteAccepted(IntPtr handle, ref AddNotifyCustomInviteAcceptedOptionsInternal options, IntPtr clientData, OnCustomInviteAcceptedCallbackInternal notificationFn);

		// Token: 0x06000159 RID: 345
		[Token(Token = "0x6000159")]
		[Address(RVA = "0x48CDD0", Offset = "0x48B3D0", VA = "0x18048CDD0")]
		[PreserveSig]
		internal static extern ulong EOS_CustomInvites_AddNotifyCustomInviteReceived(IntPtr handle, ref AddNotifyCustomInviteReceivedOptionsInternal options, IntPtr clientData, OnCustomInviteReceivedCallbackInternal notificationFn);

		// Token: 0x0600015A RID: 346
		[Token(Token = "0x600015A")]
		[Address(RVA = "0x48CE80", Offset = "0x48B480", VA = "0x18048CE80")]
		[PreserveSig]
		internal static extern ulong EOS_CustomInvites_AddNotifyCustomInviteRejected(IntPtr handle, ref AddNotifyCustomInviteRejectedOptionsInternal options, IntPtr clientData, OnCustomInviteRejectedCallbackInternal notificationFn);

		// Token: 0x0600015B RID: 347
		[Token(Token = "0x600015B")]
		[Address(RVA = "0x48CF30", Offset = "0x48B530", VA = "0x18048CF30")]
		[PreserveSig]
		internal static extern ulong EOS_CustomInvites_AddNotifyRequestToJoinAccepted(IntPtr handle, ref AddNotifyRequestToJoinAcceptedOptionsInternal options, IntPtr clientData, OnRequestToJoinAcceptedCallbackInternal notificationFn);

		// Token: 0x0600015C RID: 348
		[Token(Token = "0x600015C")]
		[Address(RVA = "0x48CFE0", Offset = "0x48B5E0", VA = "0x18048CFE0")]
		[PreserveSig]
		internal static extern ulong EOS_CustomInvites_AddNotifyRequestToJoinReceived(IntPtr handle, ref AddNotifyRequestToJoinReceivedOptionsInternal options, IntPtr clientData, OnRequestToJoinReceivedCallbackInternal notificationFn);

		// Token: 0x0600015D RID: 349
		[Token(Token = "0x600015D")]
		[Address(RVA = "0x48D090", Offset = "0x48B690", VA = "0x18048D090")]
		[PreserveSig]
		internal static extern ulong EOS_CustomInvites_AddNotifyRequestToJoinRejected(IntPtr handle, ref AddNotifyRequestToJoinRejectedOptionsInternal options, IntPtr clientData, OnRequestToJoinRejectedCallbackInternal notificationFn);

		// Token: 0x0600015E RID: 350
		[Token(Token = "0x600015E")]
		[Address(RVA = "0x48D140", Offset = "0x48B740", VA = "0x18048D140")]
		[PreserveSig]
		internal static extern ulong EOS_CustomInvites_AddNotifyRequestToJoinResponseReceived(IntPtr handle, ref AddNotifyRequestToJoinResponseReceivedOptionsInternal options, IntPtr clientData, OnRequestToJoinResponseReceivedCallbackInternal notificationFn);

		// Token: 0x0600015F RID: 351
		[Token(Token = "0x600015F")]
		[Address(RVA = "0x48D1F0", Offset = "0x48B7F0", VA = "0x18048D1F0")]
		[PreserveSig]
		internal static extern ulong EOS_CustomInvites_AddNotifySendCustomNativeInviteRequested(IntPtr handle, ref AddNotifySendCustomNativeInviteRequestedOptionsInternal options, IntPtr clientData, OnSendCustomNativeInviteRequestedCallbackInternal notificationFn);

		// Token: 0x06000160 RID: 352
		[Token(Token = "0x6000160")]
		[Address(RVA = "0x48D2A0", Offset = "0x48B8A0", VA = "0x18048D2A0")]
		[PreserveSig]
		internal static extern Result EOS_CustomInvites_FinalizeInvite(IntPtr handle, ref FinalizeInviteOptionsInternal options);

		// Token: 0x06000161 RID: 353
		[Token(Token = "0x6000161")]
		[Address(RVA = "0x48D330", Offset = "0x48B930", VA = "0x18048D330")]
		[PreserveSig]
		internal static extern void EOS_CustomInvites_RejectRequestToJoin(IntPtr handle, ref RejectRequestToJoinOptionsInternal options, IntPtr clientData, OnRejectRequestToJoinCallbackInternal completionDelegate);

		// Token: 0x06000162 RID: 354
		[Token(Token = "0x6000162")]
		[Address(RVA = "0x48D3E0", Offset = "0x48B9E0", VA = "0x18048D3E0")]
		[PreserveSig]
		internal static extern void EOS_CustomInvites_RemoveNotifyCustomInviteAccepted(IntPtr handle, ulong inId);

		// Token: 0x06000163 RID: 355
		[Token(Token = "0x6000163")]
		[Address(RVA = "0x48D470", Offset = "0x48BA70", VA = "0x18048D470")]
		[PreserveSig]
		internal static extern void EOS_CustomInvites_RemoveNotifyCustomInviteReceived(IntPtr handle, ulong inId);

		// Token: 0x06000164 RID: 356
		[Token(Token = "0x6000164")]
		[Address(RVA = "0x48D500", Offset = "0x48BB00", VA = "0x18048D500")]
		[PreserveSig]
		internal static extern void EOS_CustomInvites_RemoveNotifyCustomInviteRejected(IntPtr handle, ulong inId);

		// Token: 0x06000165 RID: 357
		[Token(Token = "0x6000165")]
		[Address(RVA = "0x48D590", Offset = "0x48BB90", VA = "0x18048D590")]
		[PreserveSig]
		internal static extern void EOS_CustomInvites_RemoveNotifyRequestToJoinAccepted(IntPtr handle, ulong inId);

		// Token: 0x06000166 RID: 358
		[Token(Token = "0x6000166")]
		[Address(RVA = "0x48D620", Offset = "0x48BC20", VA = "0x18048D620")]
		[PreserveSig]
		internal static extern void EOS_CustomInvites_RemoveNotifyRequestToJoinReceived(IntPtr handle, ulong inId);

		// Token: 0x06000167 RID: 359
		[Token(Token = "0x6000167")]
		[Address(RVA = "0x48D6B0", Offset = "0x48BCB0", VA = "0x18048D6B0")]
		[PreserveSig]
		internal static extern void EOS_CustomInvites_RemoveNotifyRequestToJoinRejected(IntPtr handle, ulong inId);

		// Token: 0x06000168 RID: 360
		[Token(Token = "0x6000168")]
		[Address(RVA = "0x48D740", Offset = "0x48BD40", VA = "0x18048D740")]
		[PreserveSig]
		internal static extern void EOS_CustomInvites_RemoveNotifyRequestToJoinResponseReceived(IntPtr handle, ulong inId);

		// Token: 0x06000169 RID: 361
		[Token(Token = "0x6000169")]
		[Address(RVA = "0x48D7D0", Offset = "0x48BDD0", VA = "0x18048D7D0")]
		[PreserveSig]
		internal static extern void EOS_CustomInvites_RemoveNotifySendCustomNativeInviteRequested(IntPtr handle, ulong inId);

		// Token: 0x0600016A RID: 362
		[Token(Token = "0x600016A")]
		[Address(RVA = "0x48D860", Offset = "0x48BE60", VA = "0x18048D860")]
		[PreserveSig]
		internal static extern void EOS_CustomInvites_SendCustomInvite(IntPtr handle, ref SendCustomInviteOptionsInternal options, IntPtr clientData, OnSendCustomInviteCallbackInternal completionDelegate);

		// Token: 0x0600016B RID: 363
		[Token(Token = "0x600016B")]
		[Address(RVA = "0x48D910", Offset = "0x48BF10", VA = "0x18048D910")]
		[PreserveSig]
		internal static extern void EOS_CustomInvites_SendRequestToJoin(IntPtr handle, ref SendRequestToJoinOptionsInternal options, IntPtr clientData, OnSendRequestToJoinCallbackInternal completionDelegate);

		// Token: 0x0600016C RID: 364
		[Token(Token = "0x600016C")]
		[Address(RVA = "0x48D9C0", Offset = "0x48BFC0", VA = "0x18048D9C0")]
		[PreserveSig]
		internal static extern Result EOS_CustomInvites_SetCustomInvite(IntPtr handle, ref SetCustomInviteOptionsInternal options);

		// Token: 0x0600016D RID: 365
		[Token(Token = "0x600016D")]
		[Address(RVA = "0x48DA50", Offset = "0x48C050", VA = "0x18048DA50")]
		[PreserveSig]
		internal static extern IntPtr EOS_EApplicationStatus_ToString(ApplicationStatus applicationStatus);

		// Token: 0x0600016E RID: 366
		[Token(Token = "0x600016E")]
		[Address(RVA = "0x48DAD0", Offset = "0x48C0D0", VA = "0x18048DAD0")]
		[PreserveSig]
		internal static extern IntPtr EOS_ENetworkStatus_ToString(NetworkStatus networkStatus);

		// Token: 0x0600016F RID: 367
		[Token(Token = "0x600016F")]
		[Address(RVA = "0x48DB50", Offset = "0x48C150", VA = "0x18048DB50")]
		[PreserveSig]
		internal static extern int EOS_EResult_IsOperationComplete(Result result);

		// Token: 0x06000170 RID: 368
		[Token(Token = "0x6000170")]
		[Address(RVA = "0x48DBD0", Offset = "0x48C1D0", VA = "0x18048DBD0")]
		[PreserveSig]
		internal static extern IntPtr EOS_EResult_ToString(Result result);

		// Token: 0x06000171 RID: 369
		[Token(Token = "0x6000171")]
		[Address(RVA = "0x48DC50", Offset = "0x48C250", VA = "0x18048DC50")]
		[PreserveSig]
		internal static extern void EOS_Ecom_CatalogItem_Release(IntPtr catalogItem);

		// Token: 0x06000172 RID: 370
		[Token(Token = "0x6000172")]
		[Address(RVA = "0x48DCD0", Offset = "0x48C2D0", VA = "0x18048DCD0")]
		[PreserveSig]
		internal static extern void EOS_Ecom_CatalogOffer_Release(IntPtr catalogOffer);

		// Token: 0x06000173 RID: 371
		[Token(Token = "0x6000173")]
		[Address(RVA = "0x48DD50", Offset = "0x48C350", VA = "0x18048DD50")]
		[PreserveSig]
		internal static extern void EOS_Ecom_CatalogRelease_Release(IntPtr catalogRelease);

		// Token: 0x06000174 RID: 372
		[Token(Token = "0x6000174")]
		[Address(RVA = "0x48DDD0", Offset = "0x48C3D0", VA = "0x18048DDD0")]
		[PreserveSig]
		internal static extern void EOS_Ecom_Checkout(IntPtr handle, ref CheckoutOptionsInternal options, IntPtr clientData, OnCheckoutCallbackInternal completionDelegate);

		// Token: 0x06000175 RID: 373
		[Token(Token = "0x6000175")]
		[Address(RVA = "0x48DE80", Offset = "0x48C480", VA = "0x18048DE80")]
		[PreserveSig]
		internal static extern Result EOS_Ecom_CopyEntitlementById(IntPtr handle, ref CopyEntitlementByIdOptionsInternal options, ref IntPtr outEntitlement);

		// Token: 0x06000176 RID: 374
		[Token(Token = "0x6000176")]
		[Address(RVA = "0x48DF20", Offset = "0x48C520", VA = "0x18048DF20")]
		[PreserveSig]
		internal static extern Result EOS_Ecom_CopyEntitlementByIndex(IntPtr handle, ref CopyEntitlementByIndexOptionsInternal options, ref IntPtr outEntitlement);

		// Token: 0x06000177 RID: 375
		[Token(Token = "0x6000177")]
		[Address(RVA = "0x48DFC0", Offset = "0x48C5C0", VA = "0x18048DFC0")]
		[PreserveSig]
		internal static extern Result EOS_Ecom_CopyEntitlementByNameAndIndex(IntPtr handle, ref CopyEntitlementByNameAndIndexOptionsInternal options, ref IntPtr outEntitlement);

		// Token: 0x06000178 RID: 376
		[Token(Token = "0x6000178")]
		[Address(RVA = "0x48E060", Offset = "0x48C660", VA = "0x18048E060")]
		[PreserveSig]
		internal static extern Result EOS_Ecom_CopyItemById(IntPtr handle, ref CopyItemByIdOptionsInternal options, ref IntPtr outItem);

		// Token: 0x06000179 RID: 377
		[Token(Token = "0x6000179")]
		[Address(RVA = "0x48E100", Offset = "0x48C700", VA = "0x18048E100")]
		[PreserveSig]
		internal static extern Result EOS_Ecom_CopyItemImageInfoByIndex(IntPtr handle, ref CopyItemImageInfoByIndexOptionsInternal options, ref IntPtr outImageInfo);

		// Token: 0x0600017A RID: 378
		[Token(Token = "0x600017A")]
		[Address(RVA = "0x48E1A0", Offset = "0x48C7A0", VA = "0x18048E1A0")]
		[PreserveSig]
		internal static extern Result EOS_Ecom_CopyItemReleaseByIndex(IntPtr handle, ref CopyItemReleaseByIndexOptionsInternal options, ref IntPtr outRelease);

		// Token: 0x0600017B RID: 379
		[Token(Token = "0x600017B")]
		[Address(RVA = "0x48E240", Offset = "0x48C840", VA = "0x18048E240")]
		[PreserveSig]
		internal static extern Result EOS_Ecom_CopyLastRedeemedEntitlementByIndex(IntPtr handle, ref CopyLastRedeemedEntitlementByIndexOptionsInternal options, IntPtr outRedeemedEntitlementId, ref int inOutRedeemedEntitlementIdLength);

		// Token: 0x0600017C RID: 380
		[Token(Token = "0x600017C")]
		[Address(RVA = "0x48E2F0", Offset = "0x48C8F0", VA = "0x18048E2F0")]
		[PreserveSig]
		internal static extern Result EOS_Ecom_CopyOfferById(IntPtr handle, ref CopyOfferByIdOptionsInternal options, ref IntPtr outOffer);

		// Token: 0x0600017D RID: 381
		[Token(Token = "0x600017D")]
		[Address(RVA = "0x48E390", Offset = "0x48C990", VA = "0x18048E390")]
		[PreserveSig]
		internal static extern Result EOS_Ecom_CopyOfferByIndex(IntPtr handle, ref CopyOfferByIndexOptionsInternal options, ref IntPtr outOffer);

		// Token: 0x0600017E RID: 382
		[Token(Token = "0x600017E")]
		[Address(RVA = "0x48E430", Offset = "0x48CA30", VA = "0x18048E430")]
		[PreserveSig]
		internal static extern Result EOS_Ecom_CopyOfferImageInfoByIndex(IntPtr handle, ref CopyOfferImageInfoByIndexOptionsInternal options, ref IntPtr outImageInfo);

		// Token: 0x0600017F RID: 383
		[Token(Token = "0x600017F")]
		[Address(RVA = "0x48E4D0", Offset = "0x48CAD0", VA = "0x18048E4D0")]
		[PreserveSig]
		internal static extern Result EOS_Ecom_CopyOfferItemByIndex(IntPtr handle, ref CopyOfferItemByIndexOptionsInternal options, ref IntPtr outItem);

		// Token: 0x06000180 RID: 384
		[Token(Token = "0x6000180")]
		[Address(RVA = "0x48E570", Offset = "0x48CB70", VA = "0x18048E570")]
		[PreserveSig]
		internal static extern Result EOS_Ecom_CopyTransactionById(IntPtr handle, ref CopyTransactionByIdOptionsInternal options, ref IntPtr outTransaction);

		// Token: 0x06000181 RID: 385
		[Token(Token = "0x6000181")]
		[Address(RVA = "0x48E610", Offset = "0x48CC10", VA = "0x18048E610")]
		[PreserveSig]
		internal static extern Result EOS_Ecom_CopyTransactionByIndex(IntPtr handle, ref CopyTransactionByIndexOptionsInternal options, ref IntPtr outTransaction);

		// Token: 0x06000182 RID: 386
		[Token(Token = "0x6000182")]
		[Address(RVA = "0x48E6B0", Offset = "0x48CCB0", VA = "0x18048E6B0")]
		[PreserveSig]
		internal static extern void EOS_Ecom_Entitlement_Release(IntPtr entitlement);

		// Token: 0x06000183 RID: 387
		[Token(Token = "0x6000183")]
		[Address(RVA = "0x48E730", Offset = "0x48CD30", VA = "0x18048E730")]
		[PreserveSig]
		internal static extern uint EOS_Ecom_GetEntitlementsByNameCount(IntPtr handle, ref GetEntitlementsByNameCountOptionsInternal options);

		// Token: 0x06000184 RID: 388
		[Token(Token = "0x6000184")]
		[Address(RVA = "0x48E7C0", Offset = "0x48CDC0", VA = "0x18048E7C0")]
		[PreserveSig]
		internal static extern uint EOS_Ecom_GetEntitlementsCount(IntPtr handle, ref GetEntitlementsCountOptionsInternal options);

		// Token: 0x06000185 RID: 389
		[Token(Token = "0x6000185")]
		[Address(RVA = "0x48E850", Offset = "0x48CE50", VA = "0x18048E850")]
		[PreserveSig]
		internal static extern uint EOS_Ecom_GetItemImageInfoCount(IntPtr handle, ref GetItemImageInfoCountOptionsInternal options);

		// Token: 0x06000186 RID: 390
		[Token(Token = "0x6000186")]
		[Address(RVA = "0x48E8E0", Offset = "0x48CEE0", VA = "0x18048E8E0")]
		[PreserveSig]
		internal static extern uint EOS_Ecom_GetItemReleaseCount(IntPtr handle, ref GetItemReleaseCountOptionsInternal options);

		// Token: 0x06000187 RID: 391
		[Token(Token = "0x6000187")]
		[Address(RVA = "0x48E970", Offset = "0x48CF70", VA = "0x18048E970")]
		[PreserveSig]
		internal static extern uint EOS_Ecom_GetLastRedeemedEntitlementsCount(IntPtr handle, ref GetLastRedeemedEntitlementsCountOptionsInternal options);

		// Token: 0x06000188 RID: 392
		[Token(Token = "0x6000188")]
		[Address(RVA = "0x48EA00", Offset = "0x48D000", VA = "0x18048EA00")]
		[PreserveSig]
		internal static extern uint EOS_Ecom_GetOfferCount(IntPtr handle, ref GetOfferCountOptionsInternal options);

		// Token: 0x06000189 RID: 393
		[Token(Token = "0x6000189")]
		[Address(RVA = "0x48EA90", Offset = "0x48D090", VA = "0x18048EA90")]
		[PreserveSig]
		internal static extern uint EOS_Ecom_GetOfferImageInfoCount(IntPtr handle, ref GetOfferImageInfoCountOptionsInternal options);

		// Token: 0x0600018A RID: 394
		[Token(Token = "0x600018A")]
		[Address(RVA = "0x48EB20", Offset = "0x48D120", VA = "0x18048EB20")]
		[PreserveSig]
		internal static extern uint EOS_Ecom_GetOfferItemCount(IntPtr handle, ref GetOfferItemCountOptionsInternal options);

		// Token: 0x0600018B RID: 395
		[Token(Token = "0x600018B")]
		[Address(RVA = "0x48EBB0", Offset = "0x48D1B0", VA = "0x18048EBB0")]
		[PreserveSig]
		internal static extern uint EOS_Ecom_GetTransactionCount(IntPtr handle, ref GetTransactionCountOptionsInternal options);

		// Token: 0x0600018C RID: 396
		[Token(Token = "0x600018C")]
		[Address(RVA = "0x48EC40", Offset = "0x48D240", VA = "0x18048EC40")]
		[PreserveSig]
		internal static extern void EOS_Ecom_KeyImageInfo_Release(IntPtr keyImageInfo);

		// Token: 0x0600018D RID: 397
		[Token(Token = "0x600018D")]
		[Address(RVA = "0x48ECC0", Offset = "0x48D2C0", VA = "0x18048ECC0")]
		[PreserveSig]
		internal static extern void EOS_Ecom_QueryEntitlementToken(IntPtr handle, ref QueryEntitlementTokenOptionsInternal options, IntPtr clientData, OnQueryEntitlementTokenCallbackInternal completionDelegate);

		// Token: 0x0600018E RID: 398
		[Token(Token = "0x600018E")]
		[Address(RVA = "0x48ED70", Offset = "0x48D370", VA = "0x18048ED70")]
		[PreserveSig]
		internal static extern void EOS_Ecom_QueryEntitlements(IntPtr handle, ref QueryEntitlementsOptionsInternal options, IntPtr clientData, OnQueryEntitlementsCallbackInternal completionDelegate);

		// Token: 0x0600018F RID: 399
		[Token(Token = "0x600018F")]
		[Address(RVA = "0x48EE20", Offset = "0x48D420", VA = "0x18048EE20")]
		[PreserveSig]
		internal static extern void EOS_Ecom_QueryOffers(IntPtr handle, ref QueryOffersOptionsInternal options, IntPtr clientData, OnQueryOffersCallbackInternal completionDelegate);

		// Token: 0x06000190 RID: 400
		[Token(Token = "0x6000190")]
		[Address(RVA = "0x48F030", Offset = "0x48D630", VA = "0x18048F030")]
		[PreserveSig]
		internal static extern void EOS_Ecom_QueryOwnership(IntPtr handle, ref QueryOwnershipOptionsInternal options, IntPtr clientData, OnQueryOwnershipCallbackInternal completionDelegate);

		// Token: 0x06000191 RID: 401
		[Token(Token = "0x6000191")]
		[Address(RVA = "0x48EED0", Offset = "0x48D4D0", VA = "0x18048EED0")]
		[PreserveSig]
		internal static extern void EOS_Ecom_QueryOwnershipBySandboxIds(IntPtr handle, ref QueryOwnershipBySandboxIdsOptionsInternal options, IntPtr clientData, OnQueryOwnershipBySandboxIdsCallbackInternal completionDelegate);

		// Token: 0x06000192 RID: 402
		[Token(Token = "0x6000192")]
		[Address(RVA = "0x48EF80", Offset = "0x48D580", VA = "0x18048EF80")]
		[PreserveSig]
		internal static extern void EOS_Ecom_QueryOwnershipToken(IntPtr handle, ref QueryOwnershipTokenOptionsInternal options, IntPtr clientData, OnQueryOwnershipTokenCallbackInternal completionDelegate);

		// Token: 0x06000193 RID: 403
		[Token(Token = "0x6000193")]
		[Address(RVA = "0x48F0E0", Offset = "0x48D6E0", VA = "0x18048F0E0")]
		[PreserveSig]
		internal static extern void EOS_Ecom_RedeemEntitlements(IntPtr handle, ref RedeemEntitlementsOptionsInternal options, IntPtr clientData, OnRedeemEntitlementsCallbackInternal completionDelegate);

		// Token: 0x06000194 RID: 404
		[Token(Token = "0x6000194")]
		[Address(RVA = "0x48F190", Offset = "0x48D790", VA = "0x18048F190")]
		[PreserveSig]
		internal static extern Result EOS_Ecom_Transaction_CopyEntitlementByIndex(IntPtr handle, ref TransactionCopyEntitlementByIndexOptionsInternal options, ref IntPtr outEntitlement);

		// Token: 0x06000195 RID: 405
		[Token(Token = "0x6000195")]
		[Address(RVA = "0x48F230", Offset = "0x48D830", VA = "0x18048F230")]
		[PreserveSig]
		internal static extern uint EOS_Ecom_Transaction_GetEntitlementsCount(IntPtr handle, ref TransactionGetEntitlementsCountOptionsInternal options);

		// Token: 0x06000196 RID: 406
		[Token(Token = "0x6000196")]
		[Address(RVA = "0x48F2C0", Offset = "0x48D8C0", VA = "0x18048F2C0")]
		[PreserveSig]
		internal static extern Result EOS_Ecom_Transaction_GetTransactionId(IntPtr handle, IntPtr outBuffer, ref int inOutBufferLength);

		// Token: 0x06000197 RID: 407
		[Token(Token = "0x6000197")]
		[Address(RVA = "0x48F360", Offset = "0x48D960", VA = "0x18048F360")]
		[PreserveSig]
		internal static extern void EOS_Ecom_Transaction_Release(IntPtr transaction);

		// Token: 0x06000198 RID: 408
		[Token(Token = "0x6000198")]
		[Address(RVA = "0x48F3E0", Offset = "0x48D9E0", VA = "0x18048F3E0")]
		[PreserveSig]
		internal static extern IntPtr EOS_EpicAccountId_FromString(IntPtr accountIdString);

		// Token: 0x06000199 RID: 409
		[Token(Token = "0x6000199")]
		[Address(RVA = "0x48F460", Offset = "0x48DA60", VA = "0x18048F460")]
		[PreserveSig]
		internal static extern int EOS_EpicAccountId_IsValid(IntPtr accountId);

		// Token: 0x0600019A RID: 410
		[Token(Token = "0x600019A")]
		[Address(RVA = "0x48F4E0", Offset = "0x48DAE0", VA = "0x18048F4E0")]
		[PreserveSig]
		internal static extern Result EOS_EpicAccountId_ToString(IntPtr accountId, IntPtr outBuffer, ref int inOutBufferLength);

		// Token: 0x0600019B RID: 411
		[Token(Token = "0x600019B")]
		[Address(RVA = "0x48F580", Offset = "0x48DB80", VA = "0x18048F580")]
		[PreserveSig]
		internal static extern void EOS_Friends_AcceptInvite(IntPtr handle, ref AcceptInviteOptionsInternal options, IntPtr clientData, OnAcceptInviteCallbackInternal completionDelegate);

		// Token: 0x0600019C RID: 412
		[Token(Token = "0x600019C")]
		[Address(RVA = "0x48F630", Offset = "0x48DC30", VA = "0x18048F630")]
		[PreserveSig]
		internal static extern ulong EOS_Friends_AddNotifyBlockedUsersUpdate(IntPtr handle, ref AddNotifyBlockedUsersUpdateOptionsInternal options, IntPtr clientData, OnBlockedUsersUpdateCallbackInternal blockedUsersUpdateHandler);

		// Token: 0x0600019D RID: 413
		[Token(Token = "0x600019D")]
		[Address(RVA = "0x48F6E0", Offset = "0x48DCE0", VA = "0x18048F6E0")]
		[PreserveSig]
		internal static extern ulong EOS_Friends_AddNotifyFriendsUpdate(IntPtr handle, ref AddNotifyFriendsUpdateOptionsInternal options, IntPtr clientData, OnFriendsUpdateCallbackInternal friendsUpdateHandler);

		// Token: 0x0600019E RID: 414
		[Token(Token = "0x600019E")]
		[Address(RVA = "0x48F790", Offset = "0x48DD90", VA = "0x18048F790")]
		[PreserveSig]
		internal static extern IntPtr EOS_Friends_GetBlockedUserAtIndex(IntPtr handle, ref GetBlockedUserAtIndexOptionsInternal options);

		// Token: 0x0600019F RID: 415
		[Token(Token = "0x600019F")]
		[Address(RVA = "0x48F820", Offset = "0x48DE20", VA = "0x18048F820")]
		[PreserveSig]
		internal static extern int EOS_Friends_GetBlockedUsersCount(IntPtr handle, ref GetBlockedUsersCountOptionsInternal options);

		// Token: 0x060001A0 RID: 416
		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x48F8B0", Offset = "0x48DEB0", VA = "0x18048F8B0")]
		[PreserveSig]
		internal static extern IntPtr EOS_Friends_GetFriendAtIndex(IntPtr handle, ref GetFriendAtIndexOptionsInternal options);

		// Token: 0x060001A1 RID: 417
		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x48F940", Offset = "0x48DF40", VA = "0x18048F940")]
		[PreserveSig]
		internal static extern int EOS_Friends_GetFriendsCount(IntPtr handle, ref GetFriendsCountOptionsInternal options);

		// Token: 0x060001A2 RID: 418
		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x48F9D0", Offset = "0x48DFD0", VA = "0x18048F9D0")]
		[PreserveSig]
		internal static extern FriendsStatus EOS_Friends_GetStatus(IntPtr handle, ref GetStatusOptionsInternal options);

		// Token: 0x060001A3 RID: 419
		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x48FA60", Offset = "0x48E060", VA = "0x18048FA60")]
		[PreserveSig]
		internal static extern void EOS_Friends_QueryFriends(IntPtr handle, ref QueryFriendsOptionsInternal options, IntPtr clientData, OnQueryFriendsCallbackInternal completionDelegate);

		// Token: 0x060001A4 RID: 420
		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x48FB10", Offset = "0x48E110", VA = "0x18048FB10")]
		[PreserveSig]
		internal static extern void EOS_Friends_RejectInvite(IntPtr handle, ref Epic.OnlineServices.Friends.RejectInviteOptionsInternal options, IntPtr clientData, Epic.OnlineServices.Friends.OnRejectInviteCallbackInternal completionDelegate);

		// Token: 0x060001A5 RID: 421
		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x48FBC0", Offset = "0x48E1C0", VA = "0x18048FBC0")]
		[PreserveSig]
		internal static extern void EOS_Friends_RemoveNotifyBlockedUsersUpdate(IntPtr handle, ulong notificationId);

		// Token: 0x060001A6 RID: 422
		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x48FC50", Offset = "0x48E250", VA = "0x18048FC50")]
		[PreserveSig]
		internal static extern void EOS_Friends_RemoveNotifyFriendsUpdate(IntPtr handle, ulong notificationId);

		// Token: 0x060001A7 RID: 423
		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x48FCE0", Offset = "0x48E2E0", VA = "0x18048FCE0")]
		[PreserveSig]
		internal static extern void EOS_Friends_SendInvite(IntPtr handle, ref Epic.OnlineServices.Friends.SendInviteOptionsInternal options, IntPtr clientData, Epic.OnlineServices.Friends.OnSendInviteCallbackInternal completionDelegate);

		// Token: 0x060001A8 RID: 424
		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x48FD90", Offset = "0x48E390", VA = "0x18048FD90")]
		[PreserveSig]
		internal static extern IntPtr EOS_GetVersion();

		// Token: 0x060001A9 RID: 425
		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x48FE00", Offset = "0x48E400", VA = "0x18048FE00")]
		[PreserveSig]
		internal static extern Result EOS_Initialize(ref InitializeOptionsInternal options);

		// Token: 0x060001AA RID: 426
		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x48FE80", Offset = "0x48E480", VA = "0x18048FE80")]
		[PreserveSig]
		internal static extern Result EOS_IntegratedPlatformOptionsContainer_Add(IntPtr handle, ref IntegratedPlatformOptionsContainerAddOptionsInternal inOptions);

		// Token: 0x060001AB RID: 427
		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x48FF10", Offset = "0x48E510", VA = "0x18048FF10")]
		[PreserveSig]
		internal static extern void EOS_IntegratedPlatformOptionsContainer_Release(IntPtr integratedPlatformOptionsContainerHandle);

		// Token: 0x060001AC RID: 428
		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x48FF90", Offset = "0x48E590", VA = "0x18048FF90")]
		[PreserveSig]
		internal static extern ulong EOS_IntegratedPlatform_AddNotifyUserLoginStatusChanged(IntPtr handle, ref AddNotifyUserLoginStatusChangedOptionsInternal options, IntPtr clientData, OnUserLoginStatusChangedCallbackInternal callbackFunction);

		// Token: 0x060001AD RID: 429
		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x490040", Offset = "0x48E640", VA = "0x180490040")]
		[PreserveSig]
		internal static extern void EOS_IntegratedPlatform_ClearUserPreLogoutCallback(IntPtr handle, ref ClearUserPreLogoutCallbackOptionsInternal options);

		// Token: 0x060001AE RID: 430
		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x4900D0", Offset = "0x48E6D0", VA = "0x1804900D0")]
		[PreserveSig]
		internal static extern Result EOS_IntegratedPlatform_CreateIntegratedPlatformOptionsContainer(ref CreateIntegratedPlatformOptionsContainerOptionsInternal options, ref IntPtr outIntegratedPlatformOptionsContainerHandle);

		// Token: 0x060001AF RID: 431
		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x490160", Offset = "0x48E760", VA = "0x180490160")]
		[PreserveSig]
		internal static extern Result EOS_IntegratedPlatform_FinalizeDeferredUserLogout(IntPtr handle, ref FinalizeDeferredUserLogoutOptionsInternal options);

		// Token: 0x060001B0 RID: 432
		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x4901F0", Offset = "0x48E7F0", VA = "0x1804901F0")]
		[PreserveSig]
		internal static extern void EOS_IntegratedPlatform_RemoveNotifyUserLoginStatusChanged(IntPtr handle, ulong notificationId);

		// Token: 0x060001B1 RID: 433
		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x490280", Offset = "0x48E880", VA = "0x180490280")]
		[PreserveSig]
		internal static extern Result EOS_IntegratedPlatform_SetUserLoginStatus(IntPtr handle, ref SetUserLoginStatusOptionsInternal options);

		// Token: 0x060001B2 RID: 434
		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x490310", Offset = "0x48E910", VA = "0x180490310")]
		[PreserveSig]
		internal static extern Result EOS_IntegratedPlatform_SetUserPreLogoutCallback(IntPtr handle, ref SetUserPreLogoutCallbackOptionsInternal options, IntPtr clientData, OnUserPreLogoutCallbackInternal callbackFunction);

		// Token: 0x060001B3 RID: 435
		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x4903C0", Offset = "0x48E9C0", VA = "0x1804903C0")]
		[PreserveSig]
		internal static extern ulong EOS_KWS_AddNotifyPermissionsUpdateReceived(IntPtr handle, ref AddNotifyPermissionsUpdateReceivedOptionsInternal options, IntPtr clientData, OnPermissionsUpdateReceivedCallbackInternal notificationFn);

		// Token: 0x060001B4 RID: 436
		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x490470", Offset = "0x48EA70", VA = "0x180490470")]
		[PreserveSig]
		internal static extern Result EOS_KWS_CopyPermissionByIndex(IntPtr handle, ref CopyPermissionByIndexOptionsInternal options, ref IntPtr outPermission);

		// Token: 0x060001B5 RID: 437
		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x490510", Offset = "0x48EB10", VA = "0x180490510")]
		[PreserveSig]
		internal static extern void EOS_KWS_CreateUser(IntPtr handle, ref Epic.OnlineServices.KWS.CreateUserOptionsInternal options, IntPtr clientData, Epic.OnlineServices.KWS.OnCreateUserCallbackInternal completionDelegate);

		// Token: 0x060001B6 RID: 438
		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x4905C0", Offset = "0x48EBC0", VA = "0x1804905C0")]
		[PreserveSig]
		internal static extern Result EOS_KWS_GetPermissionByKey(IntPtr handle, ref GetPermissionByKeyOptionsInternal options, ref KWSPermissionStatus outPermission);

		// Token: 0x060001B7 RID: 439
		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x490660", Offset = "0x48EC60", VA = "0x180490660")]
		[PreserveSig]
		internal static extern int EOS_KWS_GetPermissionsCount(IntPtr handle, ref GetPermissionsCountOptionsInternal options);

		// Token: 0x060001B8 RID: 440
		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x4906F0", Offset = "0x48ECF0", VA = "0x1804906F0")]
		[PreserveSig]
		internal static extern void EOS_KWS_PermissionStatus_Release(IntPtr permissionStatus);

		// Token: 0x060001B9 RID: 441
		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x490770", Offset = "0x48ED70", VA = "0x180490770")]
		[PreserveSig]
		internal static extern void EOS_KWS_QueryAgeGate(IntPtr handle, ref QueryAgeGateOptionsInternal options, IntPtr clientData, OnQueryAgeGateCallbackInternal completionDelegate);

		// Token: 0x060001BA RID: 442
		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x490820", Offset = "0x48EE20", VA = "0x180490820")]
		[PreserveSig]
		internal static extern void EOS_KWS_QueryPermissions(IntPtr handle, ref QueryPermissionsOptionsInternal options, IntPtr clientData, OnQueryPermissionsCallbackInternal completionDelegate);

		// Token: 0x060001BB RID: 443
		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x4908D0", Offset = "0x48EED0", VA = "0x1804908D0")]
		[PreserveSig]
		internal static extern void EOS_KWS_RemoveNotifyPermissionsUpdateReceived(IntPtr handle, ulong inId);

		// Token: 0x060001BC RID: 444
		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x490960", Offset = "0x48EF60", VA = "0x180490960")]
		[PreserveSig]
		internal static extern void EOS_KWS_RequestPermissions(IntPtr handle, ref RequestPermissionsOptionsInternal options, IntPtr clientData, OnRequestPermissionsCallbackInternal completionDelegate);

		// Token: 0x060001BD RID: 445
		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x490A10", Offset = "0x48F010", VA = "0x180490A10")]
		[PreserveSig]
		internal static extern void EOS_KWS_UpdateParentEmail(IntPtr handle, ref UpdateParentEmailOptionsInternal options, IntPtr clientData, OnUpdateParentEmailCallbackInternal completionDelegate);

		// Token: 0x060001BE RID: 446
		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x490AC0", Offset = "0x48F0C0", VA = "0x180490AC0")]
		[PreserveSig]
		internal static extern Result EOS_Leaderboards_CopyLeaderboardDefinitionByIndex(IntPtr handle, ref CopyLeaderboardDefinitionByIndexOptionsInternal options, ref IntPtr outLeaderboardDefinition);

		// Token: 0x060001BF RID: 447
		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x490B60", Offset = "0x48F160", VA = "0x180490B60")]
		[PreserveSig]
		internal static extern Result EOS_Leaderboards_CopyLeaderboardDefinitionByLeaderboardId(IntPtr handle, ref CopyLeaderboardDefinitionByLeaderboardIdOptionsInternal options, ref IntPtr outLeaderboardDefinition);

		// Token: 0x060001C0 RID: 448
		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x490C00", Offset = "0x48F200", VA = "0x180490C00")]
		[PreserveSig]
		internal static extern Result EOS_Leaderboards_CopyLeaderboardRecordByIndex(IntPtr handle, ref CopyLeaderboardRecordByIndexOptionsInternal options, ref IntPtr outLeaderboardRecord);

		// Token: 0x060001C1 RID: 449
		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x490CA0", Offset = "0x48F2A0", VA = "0x180490CA0")]
		[PreserveSig]
		internal static extern Result EOS_Leaderboards_CopyLeaderboardRecordByUserId(IntPtr handle, ref CopyLeaderboardRecordByUserIdOptionsInternal options, ref IntPtr outLeaderboardRecord);

		// Token: 0x060001C2 RID: 450
		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x490D40", Offset = "0x48F340", VA = "0x180490D40")]
		[PreserveSig]
		internal static extern Result EOS_Leaderboards_CopyLeaderboardUserScoreByIndex(IntPtr handle, ref CopyLeaderboardUserScoreByIndexOptionsInternal options, ref IntPtr outLeaderboardUserScore);

		// Token: 0x060001C3 RID: 451
		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x490DE0", Offset = "0x48F3E0", VA = "0x180490DE0")]
		[PreserveSig]
		internal static extern Result EOS_Leaderboards_CopyLeaderboardUserScoreByUserId(IntPtr handle, ref CopyLeaderboardUserScoreByUserIdOptionsInternal options, ref IntPtr outLeaderboardUserScore);

		// Token: 0x060001C4 RID: 452
		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x490E80", Offset = "0x48F480", VA = "0x180490E80")]
		[PreserveSig]
		internal static extern void EOS_Leaderboards_Definition_Release(IntPtr leaderboardDefinition);

		// Token: 0x060001C5 RID: 453
		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x490F00", Offset = "0x48F500", VA = "0x180490F00")]
		[PreserveSig]
		internal static extern uint EOS_Leaderboards_GetLeaderboardDefinitionCount(IntPtr handle, ref GetLeaderboardDefinitionCountOptionsInternal options);

		// Token: 0x060001C6 RID: 454
		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x490F90", Offset = "0x48F590", VA = "0x180490F90")]
		[PreserveSig]
		internal static extern uint EOS_Leaderboards_GetLeaderboardRecordCount(IntPtr handle, ref GetLeaderboardRecordCountOptionsInternal options);

		// Token: 0x060001C7 RID: 455
		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x491020", Offset = "0x48F620", VA = "0x180491020")]
		[PreserveSig]
		internal static extern uint EOS_Leaderboards_GetLeaderboardUserScoreCount(IntPtr handle, ref GetLeaderboardUserScoreCountOptionsInternal options);

		// Token: 0x060001C8 RID: 456
		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x4910B0", Offset = "0x48F6B0", VA = "0x1804910B0")]
		[PreserveSig]
		internal static extern void EOS_Leaderboards_LeaderboardDefinition_Release(IntPtr leaderboardDefinition);

		// Token: 0x060001C9 RID: 457
		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x491130", Offset = "0x48F730", VA = "0x180491130")]
		[PreserveSig]
		internal static extern void EOS_Leaderboards_LeaderboardRecord_Release(IntPtr leaderboardRecord);

		// Token: 0x060001CA RID: 458
		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x4911B0", Offset = "0x48F7B0", VA = "0x1804911B0")]
		[PreserveSig]
		internal static extern void EOS_Leaderboards_LeaderboardUserScore_Release(IntPtr leaderboardUserScore);

		// Token: 0x060001CB RID: 459
		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x491230", Offset = "0x48F830", VA = "0x180491230")]
		[PreserveSig]
		internal static extern void EOS_Leaderboards_QueryLeaderboardDefinitions(IntPtr handle, ref QueryLeaderboardDefinitionsOptionsInternal options, IntPtr clientData, OnQueryLeaderboardDefinitionsCompleteCallbackInternal completionDelegate);

		// Token: 0x060001CC RID: 460
		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x4912E0", Offset = "0x48F8E0", VA = "0x1804912E0")]
		[PreserveSig]
		internal static extern void EOS_Leaderboards_QueryLeaderboardRanks(IntPtr handle, ref QueryLeaderboardRanksOptionsInternal options, IntPtr clientData, OnQueryLeaderboardRanksCompleteCallbackInternal completionDelegate);

		// Token: 0x060001CD RID: 461
		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x491390", Offset = "0x48F990", VA = "0x180491390")]
		[PreserveSig]
		internal static extern void EOS_Leaderboards_QueryLeaderboardUserScores(IntPtr handle, ref QueryLeaderboardUserScoresOptionsInternal options, IntPtr clientData, OnQueryLeaderboardUserScoresCompleteCallbackInternal completionDelegate);

		// Token: 0x060001CE RID: 462
		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x491440", Offset = "0x48FA40", VA = "0x180491440")]
		[PreserveSig]
		internal static extern Result EOS_LobbyDetails_CopyAttributeByIndex(IntPtr handle, ref LobbyDetailsCopyAttributeByIndexOptionsInternal options, ref IntPtr outAttribute);

		// Token: 0x060001CF RID: 463
		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x4914E0", Offset = "0x48FAE0", VA = "0x1804914E0")]
		[PreserveSig]
		internal static extern Result EOS_LobbyDetails_CopyAttributeByKey(IntPtr handle, ref LobbyDetailsCopyAttributeByKeyOptionsInternal options, ref IntPtr outAttribute);

		// Token: 0x060001D0 RID: 464
		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x491580", Offset = "0x48FB80", VA = "0x180491580")]
		[PreserveSig]
		internal static extern Result EOS_LobbyDetails_CopyInfo(IntPtr handle, ref LobbyDetailsCopyInfoOptionsInternal options, ref IntPtr outLobbyDetailsInfo);

		// Token: 0x060001D1 RID: 465
		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x491620", Offset = "0x48FC20", VA = "0x180491620")]
		[PreserveSig]
		internal static extern Result EOS_LobbyDetails_CopyMemberAttributeByIndex(IntPtr handle, ref LobbyDetailsCopyMemberAttributeByIndexOptionsInternal options, ref IntPtr outAttribute);

		// Token: 0x060001D2 RID: 466
		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x4916C0", Offset = "0x48FCC0", VA = "0x1804916C0")]
		[PreserveSig]
		internal static extern Result EOS_LobbyDetails_CopyMemberAttributeByKey(IntPtr handle, ref LobbyDetailsCopyMemberAttributeByKeyOptionsInternal options, ref IntPtr outAttribute);

		// Token: 0x060001D3 RID: 467
		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x491760", Offset = "0x48FD60", VA = "0x180491760")]
		[PreserveSig]
		internal static extern Result EOS_LobbyDetails_CopyMemberInfo(IntPtr handle, ref LobbyDetailsCopyMemberInfoOptionsInternal options, ref IntPtr outLobbyDetailsMemberInfo);

		// Token: 0x060001D4 RID: 468
		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x491800", Offset = "0x48FE00", VA = "0x180491800")]
		[PreserveSig]
		internal static extern uint EOS_LobbyDetails_GetAttributeCount(IntPtr handle, ref LobbyDetailsGetAttributeCountOptionsInternal options);

		// Token: 0x060001D5 RID: 469
		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x491890", Offset = "0x48FE90", VA = "0x180491890")]
		[PreserveSig]
		internal static extern IntPtr EOS_LobbyDetails_GetLobbyOwner(IntPtr handle, ref LobbyDetailsGetLobbyOwnerOptionsInternal options);

		// Token: 0x060001D6 RID: 470
		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x491920", Offset = "0x48FF20", VA = "0x180491920")]
		[PreserveSig]
		internal static extern uint EOS_LobbyDetails_GetMemberAttributeCount(IntPtr handle, ref LobbyDetailsGetMemberAttributeCountOptionsInternal options);

		// Token: 0x060001D7 RID: 471
		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x4919B0", Offset = "0x48FFB0", VA = "0x1804919B0")]
		[PreserveSig]
		internal static extern IntPtr EOS_LobbyDetails_GetMemberByIndex(IntPtr handle, ref LobbyDetailsGetMemberByIndexOptionsInternal options);

		// Token: 0x060001D8 RID: 472
		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x491A40", Offset = "0x490040", VA = "0x180491A40")]
		[PreserveSig]
		internal static extern uint EOS_LobbyDetails_GetMemberCount(IntPtr handle, ref LobbyDetailsGetMemberCountOptionsInternal options);

		// Token: 0x060001D9 RID: 473
		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x491AD0", Offset = "0x4900D0", VA = "0x180491AD0")]
		[PreserveSig]
		internal static extern void EOS_LobbyDetails_Info_Release(IntPtr lobbyDetailsInfo);

		// Token: 0x060001DA RID: 474
		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x491B50", Offset = "0x490150", VA = "0x180491B50")]
		[PreserveSig]
		internal static extern void EOS_LobbyDetails_MemberInfo_Release(IntPtr lobbyDetailsMemberInfo);

		// Token: 0x060001DB RID: 475
		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x491BD0", Offset = "0x4901D0", VA = "0x180491BD0")]
		[PreserveSig]
		internal static extern void EOS_LobbyDetails_Release(IntPtr lobbyHandle);

		// Token: 0x060001DC RID: 476
		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x491C50", Offset = "0x490250", VA = "0x180491C50")]
		[PreserveSig]
		internal static extern Result EOS_LobbyModification_AddAttribute(IntPtr handle, ref LobbyModificationAddAttributeOptionsInternal options);

		// Token: 0x060001DD RID: 477
		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x491CE0", Offset = "0x4902E0", VA = "0x180491CE0")]
		[PreserveSig]
		internal static extern Result EOS_LobbyModification_AddMemberAttribute(IntPtr handle, ref LobbyModificationAddMemberAttributeOptionsInternal options);

		// Token: 0x060001DE RID: 478
		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x491D70", Offset = "0x490370", VA = "0x180491D70")]
		[PreserveSig]
		internal static extern void EOS_LobbyModification_Release(IntPtr lobbyModificationHandle);

		// Token: 0x060001DF RID: 479
		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x491DF0", Offset = "0x4903F0", VA = "0x180491DF0")]
		[PreserveSig]
		internal static extern Result EOS_LobbyModification_RemoveAttribute(IntPtr handle, ref LobbyModificationRemoveAttributeOptionsInternal options);

		// Token: 0x060001E0 RID: 480
		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x491E80", Offset = "0x490480", VA = "0x180491E80")]
		[PreserveSig]
		internal static extern Result EOS_LobbyModification_RemoveMemberAttribute(IntPtr handle, ref LobbyModificationRemoveMemberAttributeOptionsInternal options);

		// Token: 0x060001E1 RID: 481
		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x491F10", Offset = "0x490510", VA = "0x180491F10")]
		[PreserveSig]
		internal static extern Result EOS_LobbyModification_SetAllowedPlatformIds(IntPtr handle, ref LobbyModificationSetAllowedPlatformIdsOptionsInternal options);

		// Token: 0x060001E2 RID: 482
		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x491FA0", Offset = "0x4905A0", VA = "0x180491FA0")]
		[PreserveSig]
		internal static extern Result EOS_LobbyModification_SetBucketId(IntPtr handle, ref LobbyModificationSetBucketIdOptionsInternal options);

		// Token: 0x060001E3 RID: 483
		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x492030", Offset = "0x490630", VA = "0x180492030")]
		[PreserveSig]
		internal static extern Result EOS_LobbyModification_SetInvitesAllowed(IntPtr handle, ref LobbyModificationSetInvitesAllowedOptionsInternal options);

		// Token: 0x060001E4 RID: 484
		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x4920C0", Offset = "0x4906C0", VA = "0x1804920C0")]
		[PreserveSig]
		internal static extern Result EOS_LobbyModification_SetMaxMembers(IntPtr handle, ref LobbyModificationSetMaxMembersOptionsInternal options);

		// Token: 0x060001E5 RID: 485
		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x492150", Offset = "0x490750", VA = "0x180492150")]
		[PreserveSig]
		internal static extern Result EOS_LobbyModification_SetPermissionLevel(IntPtr handle, ref LobbyModificationSetPermissionLevelOptionsInternal options);

		// Token: 0x060001E6 RID: 486
		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x4921E0", Offset = "0x4907E0", VA = "0x1804921E0")]
		[PreserveSig]
		internal static extern Result EOS_LobbySearch_CopySearchResultByIndex(IntPtr handle, ref LobbySearchCopySearchResultByIndexOptionsInternal options, ref IntPtr outLobbyDetailsHandle);

		// Token: 0x060001E7 RID: 487
		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x492280", Offset = "0x490880", VA = "0x180492280")]
		[PreserveSig]
		internal static extern void EOS_LobbySearch_Find(IntPtr handle, ref LobbySearchFindOptionsInternal options, IntPtr clientData, LobbySearchOnFindCallbackInternal completionDelegate);

		// Token: 0x060001E8 RID: 488
		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x492330", Offset = "0x490930", VA = "0x180492330")]
		[PreserveSig]
		internal static extern uint EOS_LobbySearch_GetSearchResultCount(IntPtr handle, ref LobbySearchGetSearchResultCountOptionsInternal options);

		// Token: 0x060001E9 RID: 489
		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x4923C0", Offset = "0x4909C0", VA = "0x1804923C0")]
		[PreserveSig]
		internal static extern void EOS_LobbySearch_Release(IntPtr lobbySearchHandle);

		// Token: 0x060001EA RID: 490
		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x492440", Offset = "0x490A40", VA = "0x180492440")]
		[PreserveSig]
		internal static extern Result EOS_LobbySearch_RemoveParameter(IntPtr handle, ref LobbySearchRemoveParameterOptionsInternal options);

		// Token: 0x060001EB RID: 491
		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x4924D0", Offset = "0x490AD0", VA = "0x1804924D0")]
		[PreserveSig]
		internal static extern Result EOS_LobbySearch_SetLobbyId(IntPtr handle, ref LobbySearchSetLobbyIdOptionsInternal options);

		// Token: 0x060001EC RID: 492
		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x492560", Offset = "0x490B60", VA = "0x180492560")]
		[PreserveSig]
		internal static extern Result EOS_LobbySearch_SetMaxResults(IntPtr handle, ref LobbySearchSetMaxResultsOptionsInternal options);

		// Token: 0x060001ED RID: 493
		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x4925F0", Offset = "0x490BF0", VA = "0x1804925F0")]
		[PreserveSig]
		internal static extern Result EOS_LobbySearch_SetParameter(IntPtr handle, ref LobbySearchSetParameterOptionsInternal options);

		// Token: 0x060001EE RID: 494
		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x492680", Offset = "0x490C80", VA = "0x180492680")]
		[PreserveSig]
		internal static extern Result EOS_LobbySearch_SetTargetUserId(IntPtr handle, ref LobbySearchSetTargetUserIdOptionsInternal options);

		// Token: 0x060001EF RID: 495
		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x492710", Offset = "0x490D10", VA = "0x180492710")]
		[PreserveSig]
		internal static extern ulong EOS_Lobby_AddNotifyJoinLobbyAccepted(IntPtr handle, ref AddNotifyJoinLobbyAcceptedOptionsInternal options, IntPtr clientData, OnJoinLobbyAcceptedCallbackInternal notificationFn);

		// Token: 0x060001F0 RID: 496
		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x4927C0", Offset = "0x490DC0", VA = "0x1804927C0")]
		[PreserveSig]
		internal static extern ulong EOS_Lobby_AddNotifyLeaveLobbyRequested(IntPtr handle, ref AddNotifyLeaveLobbyRequestedOptionsInternal options, IntPtr clientData, OnLeaveLobbyRequestedCallbackInternal notificationFn);

		// Token: 0x060001F1 RID: 497
		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x492870", Offset = "0x490E70", VA = "0x180492870")]
		[PreserveSig]
		internal static extern ulong EOS_Lobby_AddNotifyLobbyInviteAccepted(IntPtr handle, ref AddNotifyLobbyInviteAcceptedOptionsInternal options, IntPtr clientData, OnLobbyInviteAcceptedCallbackInternal notificationFn);

		// Token: 0x060001F2 RID: 498
		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x492920", Offset = "0x490F20", VA = "0x180492920")]
		[PreserveSig]
		internal static extern ulong EOS_Lobby_AddNotifyLobbyInviteReceived(IntPtr handle, ref AddNotifyLobbyInviteReceivedOptionsInternal options, IntPtr clientData, OnLobbyInviteReceivedCallbackInternal notificationFn);

		// Token: 0x060001F3 RID: 499
		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x4929D0", Offset = "0x490FD0", VA = "0x1804929D0")]
		[PreserveSig]
		internal static extern ulong EOS_Lobby_AddNotifyLobbyInviteRejected(IntPtr handle, ref AddNotifyLobbyInviteRejectedOptionsInternal options, IntPtr clientData, OnLobbyInviteRejectedCallbackInternal notificationFn);

		// Token: 0x060001F4 RID: 500
		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x492A80", Offset = "0x491080", VA = "0x180492A80")]
		[PreserveSig]
		internal static extern ulong EOS_Lobby_AddNotifyLobbyMemberStatusReceived(IntPtr handle, ref AddNotifyLobbyMemberStatusReceivedOptionsInternal options, IntPtr clientData, OnLobbyMemberStatusReceivedCallbackInternal notificationFn);

		// Token: 0x060001F5 RID: 501
		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x492B30", Offset = "0x491130", VA = "0x180492B30")]
		[PreserveSig]
		internal static extern ulong EOS_Lobby_AddNotifyLobbyMemberUpdateReceived(IntPtr handle, ref AddNotifyLobbyMemberUpdateReceivedOptionsInternal options, IntPtr clientData, OnLobbyMemberUpdateReceivedCallbackInternal notificationFn);

		// Token: 0x060001F6 RID: 502
		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x492BE0", Offset = "0x4911E0", VA = "0x180492BE0")]
		[PreserveSig]
		internal static extern ulong EOS_Lobby_AddNotifyLobbyUpdateReceived(IntPtr handle, ref AddNotifyLobbyUpdateReceivedOptionsInternal options, IntPtr clientData, OnLobbyUpdateReceivedCallbackInternal notificationFn);

		// Token: 0x060001F7 RID: 503
		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x492C90", Offset = "0x491290", VA = "0x180492C90")]
		[PreserveSig]
		internal static extern ulong EOS_Lobby_AddNotifyRTCRoomConnectionChanged(IntPtr handle, ref AddNotifyRTCRoomConnectionChangedOptionsInternal options, IntPtr clientData, OnRTCRoomConnectionChangedCallbackInternal notificationFn);

		// Token: 0x060001F8 RID: 504
		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x492D40", Offset = "0x491340", VA = "0x180492D40")]
		[PreserveSig]
		internal static extern ulong EOS_Lobby_AddNotifySendLobbyNativeInviteRequested(IntPtr handle, ref AddNotifySendLobbyNativeInviteRequestedOptionsInternal options, IntPtr clientData, OnSendLobbyNativeInviteRequestedCallbackInternal notificationFn);

		// Token: 0x060001F9 RID: 505
		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x492DF0", Offset = "0x4913F0", VA = "0x180492DF0")]
		[PreserveSig]
		internal static extern void EOS_Lobby_Attribute_Release(IntPtr lobbyAttribute);

		// Token: 0x060001FA RID: 506
		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x492FB0", Offset = "0x4915B0", VA = "0x180492FB0")]
		[PreserveSig]
		internal static extern Result EOS_Lobby_CopyLobbyDetailsHandle(IntPtr handle, ref CopyLobbyDetailsHandleOptionsInternal options, ref IntPtr outLobbyDetailsHandle);

		// Token: 0x060001FB RID: 507
		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x492E70", Offset = "0x491470", VA = "0x180492E70")]
		[PreserveSig]
		internal static extern Result EOS_Lobby_CopyLobbyDetailsHandleByInviteId(IntPtr handle, ref CopyLobbyDetailsHandleByInviteIdOptionsInternal options, ref IntPtr outLobbyDetailsHandle);

		// Token: 0x060001FC RID: 508
		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x492F10", Offset = "0x491510", VA = "0x180492F10")]
		[PreserveSig]
		internal static extern Result EOS_Lobby_CopyLobbyDetailsHandleByUiEventId(IntPtr handle, ref CopyLobbyDetailsHandleByUiEventIdOptionsInternal options, ref IntPtr outLobbyDetailsHandle);

		// Token: 0x060001FD RID: 509
		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x4930F0", Offset = "0x4916F0", VA = "0x1804930F0")]
		[PreserveSig]
		internal static extern void EOS_Lobby_CreateLobby(IntPtr handle, ref CreateLobbyOptionsInternal options, IntPtr clientData, OnCreateLobbyCallbackInternal completionDelegate);

		// Token: 0x060001FE RID: 510
		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x493050", Offset = "0x491650", VA = "0x180493050")]
		[PreserveSig]
		internal static extern Result EOS_Lobby_CreateLobbySearch(IntPtr handle, ref CreateLobbySearchOptionsInternal options, ref IntPtr outLobbySearchHandle);

		// Token: 0x060001FF RID: 511
		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x4931A0", Offset = "0x4917A0", VA = "0x1804931A0")]
		[PreserveSig]
		internal static extern void EOS_Lobby_DestroyLobby(IntPtr handle, ref DestroyLobbyOptionsInternal options, IntPtr clientData, OnDestroyLobbyCallbackInternal completionDelegate);

		// Token: 0x06000200 RID: 512
		[Token(Token = "0x6000200")]
		[Address(RVA = "0x493250", Offset = "0x491850", VA = "0x180493250")]
		[PreserveSig]
		internal static extern Result EOS_Lobby_GetConnectString(IntPtr handle, ref GetConnectStringOptionsInternal options, IntPtr outBuffer, ref uint inOutBufferLength);

		// Token: 0x06000201 RID: 513
		[Token(Token = "0x6000201")]
		[Address(RVA = "0x493300", Offset = "0x491900", VA = "0x180493300")]
		[PreserveSig]
		internal static extern uint EOS_Lobby_GetInviteCount(IntPtr handle, ref Epic.OnlineServices.Lobby.GetInviteCountOptionsInternal options);

		// Token: 0x06000202 RID: 514
		[Token(Token = "0x6000202")]
		[Address(RVA = "0x493390", Offset = "0x491990", VA = "0x180493390")]
		[PreserveSig]
		internal static extern Result EOS_Lobby_GetInviteIdByIndex(IntPtr handle, ref Epic.OnlineServices.Lobby.GetInviteIdByIndexOptionsInternal options, IntPtr outBuffer, ref int inOutBufferLength);

		// Token: 0x06000203 RID: 515
		[Token(Token = "0x6000203")]
		[Address(RVA = "0x493440", Offset = "0x491A40", VA = "0x180493440")]
		[PreserveSig]
		internal static extern Result EOS_Lobby_GetRTCRoomName(IntPtr handle, ref GetRTCRoomNameOptionsInternal options, IntPtr outBuffer, ref uint inOutBufferLength);

		// Token: 0x06000204 RID: 516
		[Token(Token = "0x6000204")]
		[Address(RVA = "0x4934F0", Offset = "0x491AF0", VA = "0x1804934F0")]
		[PreserveSig]
		internal static extern void EOS_Lobby_HardMuteMember(IntPtr handle, ref HardMuteMemberOptionsInternal options, IntPtr clientData, OnHardMuteMemberCallbackInternal completionDelegate);

		// Token: 0x06000205 RID: 517
		[Token(Token = "0x6000205")]
		[Address(RVA = "0x4935A0", Offset = "0x491BA0", VA = "0x1804935A0")]
		[PreserveSig]
		internal static extern Result EOS_Lobby_IsRTCRoomConnected(IntPtr handle, ref IsRTCRoomConnectedOptionsInternal options, ref int bOutIsConnected);

		// Token: 0x06000206 RID: 518
		[Token(Token = "0x6000206")]
		[Address(RVA = "0x4936F0", Offset = "0x491CF0", VA = "0x1804936F0")]
		[PreserveSig]
		internal static extern void EOS_Lobby_JoinLobby(IntPtr handle, ref JoinLobbyOptionsInternal options, IntPtr clientData, OnJoinLobbyCallbackInternal completionDelegate);

		// Token: 0x06000207 RID: 519
		[Token(Token = "0x6000207")]
		[Address(RVA = "0x493640", Offset = "0x491C40", VA = "0x180493640")]
		[PreserveSig]
		internal static extern void EOS_Lobby_JoinLobbyById(IntPtr handle, ref JoinLobbyByIdOptionsInternal options, IntPtr clientData, OnJoinLobbyByIdCallbackInternal completionDelegate);

		// Token: 0x06000208 RID: 520
		[Token(Token = "0x6000208")]
		[Address(RVA = "0x4937A0", Offset = "0x491DA0", VA = "0x1804937A0")]
		[PreserveSig]
		internal static extern void EOS_Lobby_KickMember(IntPtr handle, ref KickMemberOptionsInternal options, IntPtr clientData, OnKickMemberCallbackInternal completionDelegate);

		// Token: 0x06000209 RID: 521
		[Token(Token = "0x6000209")]
		[Address(RVA = "0x493850", Offset = "0x491E50", VA = "0x180493850")]
		[PreserveSig]
		internal static extern void EOS_Lobby_LeaveLobby(IntPtr handle, ref LeaveLobbyOptionsInternal options, IntPtr clientData, OnLeaveLobbyCallbackInternal completionDelegate);

		// Token: 0x0600020A RID: 522
		[Token(Token = "0x600020A")]
		[Address(RVA = "0x493900", Offset = "0x491F00", VA = "0x180493900")]
		[PreserveSig]
		internal static extern Result EOS_Lobby_ParseConnectString(IntPtr handle, ref ParseConnectStringOptionsInternal options, IntPtr outBuffer, ref uint inOutBufferLength);

		// Token: 0x0600020B RID: 523
		[Token(Token = "0x600020B")]
		[Address(RVA = "0x4939B0", Offset = "0x491FB0", VA = "0x1804939B0")]
		[PreserveSig]
		internal static extern void EOS_Lobby_PromoteMember(IntPtr handle, ref PromoteMemberOptionsInternal options, IntPtr clientData, OnPromoteMemberCallbackInternal completionDelegate);

		// Token: 0x0600020C RID: 524
		[Token(Token = "0x600020C")]
		[Address(RVA = "0x493A60", Offset = "0x492060", VA = "0x180493A60")]
		[PreserveSig]
		internal static extern void EOS_Lobby_QueryInvites(IntPtr handle, ref Epic.OnlineServices.Lobby.QueryInvitesOptionsInternal options, IntPtr clientData, Epic.OnlineServices.Lobby.OnQueryInvitesCallbackInternal completionDelegate);

		// Token: 0x0600020D RID: 525
		[Token(Token = "0x600020D")]
		[Address(RVA = "0x493B10", Offset = "0x492110", VA = "0x180493B10")]
		[PreserveSig]
		internal static extern void EOS_Lobby_RejectInvite(IntPtr handle, ref Epic.OnlineServices.Lobby.RejectInviteOptionsInternal options, IntPtr clientData, Epic.OnlineServices.Lobby.OnRejectInviteCallbackInternal completionDelegate);

		// Token: 0x0600020E RID: 526
		[Token(Token = "0x600020E")]
		[Address(RVA = "0x493BC0", Offset = "0x4921C0", VA = "0x180493BC0")]
		[PreserveSig]
		internal static extern void EOS_Lobby_RemoveNotifyJoinLobbyAccepted(IntPtr handle, ulong inId);

		// Token: 0x0600020F RID: 527
		[Token(Token = "0x600020F")]
		[Address(RVA = "0x493C50", Offset = "0x492250", VA = "0x180493C50")]
		[PreserveSig]
		internal static extern void EOS_Lobby_RemoveNotifyLeaveLobbyRequested(IntPtr handle, ulong inId);

		// Token: 0x06000210 RID: 528
		[Token(Token = "0x6000210")]
		[Address(RVA = "0x493CE0", Offset = "0x4922E0", VA = "0x180493CE0")]
		[PreserveSig]
		internal static extern void EOS_Lobby_RemoveNotifyLobbyInviteAccepted(IntPtr handle, ulong inId);

		// Token: 0x06000211 RID: 529
		[Token(Token = "0x6000211")]
		[Address(RVA = "0x493D70", Offset = "0x492370", VA = "0x180493D70")]
		[PreserveSig]
		internal static extern void EOS_Lobby_RemoveNotifyLobbyInviteReceived(IntPtr handle, ulong inId);

		// Token: 0x06000212 RID: 530
		[Token(Token = "0x6000212")]
		[Address(RVA = "0x493E00", Offset = "0x492400", VA = "0x180493E00")]
		[PreserveSig]
		internal static extern void EOS_Lobby_RemoveNotifyLobbyInviteRejected(IntPtr handle, ulong inId);

		// Token: 0x06000213 RID: 531
		[Token(Token = "0x6000213")]
		[Address(RVA = "0x493E90", Offset = "0x492490", VA = "0x180493E90")]
		[PreserveSig]
		internal static extern void EOS_Lobby_RemoveNotifyLobbyMemberStatusReceived(IntPtr handle, ulong inId);

		// Token: 0x06000214 RID: 532
		[Token(Token = "0x6000214")]
		[Address(RVA = "0x493F20", Offset = "0x492520", VA = "0x180493F20")]
		[PreserveSig]
		internal static extern void EOS_Lobby_RemoveNotifyLobbyMemberUpdateReceived(IntPtr handle, ulong inId);

		// Token: 0x06000215 RID: 533
		[Token(Token = "0x6000215")]
		[Address(RVA = "0x493FB0", Offset = "0x4925B0", VA = "0x180493FB0")]
		[PreserveSig]
		internal static extern void EOS_Lobby_RemoveNotifyLobbyUpdateReceived(IntPtr handle, ulong inId);

		// Token: 0x06000216 RID: 534
		[Token(Token = "0x6000216")]
		[Address(RVA = "0x494040", Offset = "0x492640", VA = "0x180494040")]
		[PreserveSig]
		internal static extern void EOS_Lobby_RemoveNotifyRTCRoomConnectionChanged(IntPtr handle, ulong inId);

		// Token: 0x06000217 RID: 535
		[Token(Token = "0x6000217")]
		[Address(RVA = "0x4940D0", Offset = "0x4926D0", VA = "0x1804940D0")]
		[PreserveSig]
		internal static extern void EOS_Lobby_RemoveNotifySendLobbyNativeInviteRequested(IntPtr handle, ulong inId);

		// Token: 0x06000218 RID: 536
		[Token(Token = "0x6000218")]
		[Address(RVA = "0x494160", Offset = "0x492760", VA = "0x180494160")]
		[PreserveSig]
		internal static extern void EOS_Lobby_SendInvite(IntPtr handle, ref Epic.OnlineServices.Lobby.SendInviteOptionsInternal options, IntPtr clientData, Epic.OnlineServices.Lobby.OnSendInviteCallbackInternal completionDelegate);

		// Token: 0x06000219 RID: 537
		[Token(Token = "0x6000219")]
		[Address(RVA = "0x4942B0", Offset = "0x4928B0", VA = "0x1804942B0")]
		[PreserveSig]
		internal static extern void EOS_Lobby_UpdateLobby(IntPtr handle, ref UpdateLobbyOptionsInternal options, IntPtr clientData, OnUpdateLobbyCallbackInternal completionDelegate);

		// Token: 0x0600021A RID: 538
		[Token(Token = "0x600021A")]
		[Address(RVA = "0x494210", Offset = "0x492810", VA = "0x180494210")]
		[PreserveSig]
		internal static extern Result EOS_Lobby_UpdateLobbyModification(IntPtr handle, ref UpdateLobbyModificationOptionsInternal options, ref IntPtr outLobbyModificationHandle);

		// Token: 0x0600021B RID: 539
		[Token(Token = "0x600021B")]
		[Address(RVA = "0x494360", Offset = "0x492960", VA = "0x180494360")]
		[PreserveSig]
		internal static extern Result EOS_Logging_SetCallback(LogMessageFuncInternal callback);

		// Token: 0x0600021C RID: 540
		[Token(Token = "0x600021C")]
		[Address(RVA = "0x4943F0", Offset = "0x4929F0", VA = "0x1804943F0")]
		[PreserveSig]
		internal static extern Result EOS_Logging_SetLogLevel(LogCategory logCategory, LogLevel logLevel);

		// Token: 0x0600021D RID: 541
		[Token(Token = "0x600021D")]
		[Address(RVA = "0x494480", Offset = "0x492A80", VA = "0x180494480")]
		[PreserveSig]
		internal static extern Result EOS_Metrics_BeginPlayerSession(IntPtr handle, ref BeginPlayerSessionOptionsInternal options);

		// Token: 0x0600021E RID: 542
		[Token(Token = "0x600021E")]
		[Address(RVA = "0x494510", Offset = "0x492B10", VA = "0x180494510")]
		[PreserveSig]
		internal static extern Result EOS_Metrics_EndPlayerSession(IntPtr handle, ref EndPlayerSessionOptionsInternal options);

		// Token: 0x0600021F RID: 543
		[Token(Token = "0x600021F")]
		[Address(RVA = "0x4945A0", Offset = "0x492BA0", VA = "0x1804945A0")]
		[PreserveSig]
		internal static extern Result EOS_Mods_CopyModInfo(IntPtr handle, ref CopyModInfoOptionsInternal options, ref IntPtr outEnumeratedMods);

		// Token: 0x06000220 RID: 544
		[Token(Token = "0x6000220")]
		[Address(RVA = "0x494640", Offset = "0x492C40", VA = "0x180494640")]
		[PreserveSig]
		internal static extern void EOS_Mods_EnumerateMods(IntPtr handle, ref EnumerateModsOptionsInternal options, IntPtr clientData, OnEnumerateModsCallbackInternal completionDelegate);

		// Token: 0x06000221 RID: 545
		[Token(Token = "0x6000221")]
		[Address(RVA = "0x4946F0", Offset = "0x492CF0", VA = "0x1804946F0")]
		[PreserveSig]
		internal static extern void EOS_Mods_InstallMod(IntPtr handle, ref InstallModOptionsInternal options, IntPtr clientData, OnInstallModCallbackInternal completionDelegate);

		// Token: 0x06000222 RID: 546
		[Token(Token = "0x6000222")]
		[Address(RVA = "0x4947A0", Offset = "0x492DA0", VA = "0x1804947A0")]
		[PreserveSig]
		internal static extern void EOS_Mods_ModInfo_Release(IntPtr modInfo);

		// Token: 0x06000223 RID: 547
		[Token(Token = "0x6000223")]
		[Address(RVA = "0x494820", Offset = "0x492E20", VA = "0x180494820")]
		[PreserveSig]
		internal static extern void EOS_Mods_UninstallMod(IntPtr handle, ref UninstallModOptionsInternal options, IntPtr clientData, OnUninstallModCallbackInternal completionDelegate);

		// Token: 0x06000224 RID: 548
		[Token(Token = "0x6000224")]
		[Address(RVA = "0x4948D0", Offset = "0x492ED0", VA = "0x1804948D0")]
		[PreserveSig]
		internal static extern void EOS_Mods_UpdateMod(IntPtr handle, ref UpdateModOptionsInternal options, IntPtr clientData, OnUpdateModCallbackInternal completionDelegate);

		// Token: 0x06000225 RID: 549
		[Token(Token = "0x6000225")]
		[Address(RVA = "0x494980", Offset = "0x492F80", VA = "0x180494980")]
		[PreserveSig]
		internal static extern Result EOS_P2P_AcceptConnection(IntPtr handle, ref AcceptConnectionOptionsInternal options);

		// Token: 0x06000226 RID: 550
		[Token(Token = "0x6000226")]
		[Address(RVA = "0x494A10", Offset = "0x493010", VA = "0x180494A10")]
		[PreserveSig]
		internal static extern ulong EOS_P2P_AddNotifyIncomingPacketQueueFull(IntPtr handle, ref AddNotifyIncomingPacketQueueFullOptionsInternal options, IntPtr clientData, OnIncomingPacketQueueFullCallbackInternal incomingPacketQueueFullHandler);

		// Token: 0x06000227 RID: 551
		[Token(Token = "0x6000227")]
		[Address(RVA = "0x494AC0", Offset = "0x4930C0", VA = "0x180494AC0")]
		[PreserveSig]
		internal static extern ulong EOS_P2P_AddNotifyPeerConnectionClosed(IntPtr handle, ref AddNotifyPeerConnectionClosedOptionsInternal options, IntPtr clientData, OnRemoteConnectionClosedCallbackInternal connectionClosedHandler);

		// Token: 0x06000228 RID: 552
		[Token(Token = "0x6000228")]
		[Address(RVA = "0x494B70", Offset = "0x493170", VA = "0x180494B70")]
		[PreserveSig]
		internal static extern ulong EOS_P2P_AddNotifyPeerConnectionEstablished(IntPtr handle, ref AddNotifyPeerConnectionEstablishedOptionsInternal options, IntPtr clientData, OnPeerConnectionEstablishedCallbackInternal connectionEstablishedHandler);

		// Token: 0x06000229 RID: 553
		[Token(Token = "0x6000229")]
		[Address(RVA = "0x494C20", Offset = "0x493220", VA = "0x180494C20")]
		[PreserveSig]
		internal static extern ulong EOS_P2P_AddNotifyPeerConnectionInterrupted(IntPtr handle, ref AddNotifyPeerConnectionInterruptedOptionsInternal options, IntPtr clientData, OnPeerConnectionInterruptedCallbackInternal connectionInterruptedHandler);

		// Token: 0x0600022A RID: 554
		[Token(Token = "0x600022A")]
		[Address(RVA = "0x494CD0", Offset = "0x4932D0", VA = "0x180494CD0")]
		[PreserveSig]
		internal static extern ulong EOS_P2P_AddNotifyPeerConnectionRequest(IntPtr handle, ref AddNotifyPeerConnectionRequestOptionsInternal options, IntPtr clientData, OnIncomingConnectionRequestCallbackInternal connectionRequestHandler);

		// Token: 0x0600022B RID: 555
		[Token(Token = "0x600022B")]
		[Address(RVA = "0x494D80", Offset = "0x493380", VA = "0x180494D80")]
		[PreserveSig]
		internal static extern Result EOS_P2P_ClearPacketQueue(IntPtr handle, ref ClearPacketQueueOptionsInternal options);

		// Token: 0x0600022C RID: 556
		[Token(Token = "0x600022C")]
		[Address(RVA = "0x494E10", Offset = "0x493410", VA = "0x180494E10")]
		[PreserveSig]
		internal static extern Result EOS_P2P_CloseConnection(IntPtr handle, ref CloseConnectionOptionsInternal options);

		// Token: 0x0600022D RID: 557
		[Token(Token = "0x600022D")]
		[Address(RVA = "0x494EA0", Offset = "0x4934A0", VA = "0x180494EA0")]
		[PreserveSig]
		internal static extern Result EOS_P2P_CloseConnections(IntPtr handle, ref CloseConnectionsOptionsInternal options);

		// Token: 0x0600022E RID: 558
		[Token(Token = "0x600022E")]
		[Address(RVA = "0x494F30", Offset = "0x493530", VA = "0x180494F30")]
		[PreserveSig]
		internal static extern Result EOS_P2P_GetNATType(IntPtr handle, ref GetNATTypeOptionsInternal options, ref NATType outNATType);

		// Token: 0x0600022F RID: 559
		[Token(Token = "0x600022F")]
		[Address(RVA = "0x494FD0", Offset = "0x4935D0", VA = "0x180494FD0")]
		[PreserveSig]
		internal static extern Result EOS_P2P_GetNextReceivedPacketSize(IntPtr handle, ref GetNextReceivedPacketSizeOptionsInternal options, ref uint outPacketSizeBytes);

		// Token: 0x06000230 RID: 560
		[Token(Token = "0x6000230")]
		[Address(RVA = "0x495070", Offset = "0x493670", VA = "0x180495070")]
		[PreserveSig]
		internal static extern Result EOS_P2P_GetPacketQueueInfo(IntPtr handle, ref GetPacketQueueInfoOptionsInternal options, ref PacketQueueInfoInternal outPacketQueueInfo);

		// Token: 0x06000231 RID: 561
		[Token(Token = "0x6000231")]
		[Address(RVA = "0x495110", Offset = "0x493710", VA = "0x180495110")]
		[PreserveSig]
		internal static extern Result EOS_P2P_GetPortRange(IntPtr handle, ref GetPortRangeOptionsInternal options, ref ushort outPort, ref ushort outNumAdditionalPortsToTry);

		// Token: 0x06000232 RID: 562
		[Token(Token = "0x6000232")]
		[Address(RVA = "0x4951C0", Offset = "0x4937C0", VA = "0x1804951C0")]
		[PreserveSig]
		internal static extern Result EOS_P2P_GetRelayControl(IntPtr handle, ref GetRelayControlOptionsInternal options, ref RelayControl outRelayControl);

		// Token: 0x06000233 RID: 563
		[Token(Token = "0x6000233")]
		[Address(RVA = "0x495260", Offset = "0x493860", VA = "0x180495260")]
		[PreserveSig]
		internal static extern void EOS_P2P_QueryNATType(IntPtr handle, ref QueryNATTypeOptionsInternal options, IntPtr clientData, OnQueryNATTypeCompleteCallbackInternal completionDelegate);

		// Token: 0x06000234 RID: 564
		[Token(Token = "0x6000234")]
		[Address(RVA = "0x495310", Offset = "0x493910", VA = "0x180495310")]
		[PreserveSig]
		internal static extern Result EOS_P2P_ReceivePacket(IntPtr handle, ref ReceivePacketOptionsInternal options, ref IntPtr outPeerId, ref SocketIdInternal outSocketId, ref byte outChannel, IntPtr outData, ref uint outBytesWritten);

		// Token: 0x06000235 RID: 565
		[Token(Token = "0x6000235")]
		[Address(RVA = "0x495440", Offset = "0x493A40", VA = "0x180495440")]
		[PreserveSig]
		internal static extern void EOS_P2P_RemoveNotifyIncomingPacketQueueFull(IntPtr handle, ulong notificationId);

		// Token: 0x06000236 RID: 566
		[Token(Token = "0x6000236")]
		[Address(RVA = "0x4954D0", Offset = "0x493AD0", VA = "0x1804954D0")]
		[PreserveSig]
		internal static extern void EOS_P2P_RemoveNotifyPeerConnectionClosed(IntPtr handle, ulong notificationId);

		// Token: 0x06000237 RID: 567
		[Token(Token = "0x6000237")]
		[Address(RVA = "0x495560", Offset = "0x493B60", VA = "0x180495560")]
		[PreserveSig]
		internal static extern void EOS_P2P_RemoveNotifyPeerConnectionEstablished(IntPtr handle, ulong notificationId);

		// Token: 0x06000238 RID: 568
		[Token(Token = "0x6000238")]
		[Address(RVA = "0x4955F0", Offset = "0x493BF0", VA = "0x1804955F0")]
		[PreserveSig]
		internal static extern void EOS_P2P_RemoveNotifyPeerConnectionInterrupted(IntPtr handle, ulong notificationId);

		// Token: 0x06000239 RID: 569
		[Token(Token = "0x6000239")]
		[Address(RVA = "0x495680", Offset = "0x493C80", VA = "0x180495680")]
		[PreserveSig]
		internal static extern void EOS_P2P_RemoveNotifyPeerConnectionRequest(IntPtr handle, ulong notificationId);

		// Token: 0x0600023A RID: 570
		[Token(Token = "0x600023A")]
		[Address(RVA = "0x495710", Offset = "0x493D10", VA = "0x180495710")]
		[PreserveSig]
		internal static extern Result EOS_P2P_SendPacket(IntPtr handle, ref SendPacketOptionsInternal options);

		// Token: 0x0600023B RID: 571
		[Token(Token = "0x600023B")]
		[Address(RVA = "0x4957A0", Offset = "0x493DA0", VA = "0x1804957A0")]
		[PreserveSig]
		internal static extern Result EOS_P2P_SetPacketQueueSize(IntPtr handle, ref SetPacketQueueSizeOptionsInternal options);

		// Token: 0x0600023C RID: 572
		[Token(Token = "0x600023C")]
		[Address(RVA = "0x495830", Offset = "0x493E30", VA = "0x180495830")]
		[PreserveSig]
		internal static extern Result EOS_P2P_SetPortRange(IntPtr handle, ref SetPortRangeOptionsInternal options);

		// Token: 0x0600023D RID: 573
		[Token(Token = "0x600023D")]
		[Address(RVA = "0x4958C0", Offset = "0x493EC0", VA = "0x1804958C0")]
		[PreserveSig]
		internal static extern Result EOS_P2P_SetRelayControl(IntPtr handle, ref SetRelayControlOptionsInternal options);

		// Token: 0x0600023E RID: 574
		[Token(Token = "0x600023E")]
		[Address(RVA = "0x495950", Offset = "0x493F50", VA = "0x180495950")]
		[PreserveSig]
		internal static extern Result EOS_Platform_CheckForLauncherAndRestart(IntPtr handle);

		// Token: 0x0600023F RID: 575
		[Token(Token = "0x600023F")]
		[Address(RVA = "0x4959D0", Offset = "0x493FD0", VA = "0x1804959D0")]
		[PreserveSig]
		internal static extern IntPtr EOS_Platform_Create(ref Epic.OnlineServices.Platform.OptionsInternal options);

		// Token: 0x06000240 RID: 576
		[Token(Token = "0x6000240")]
		[Address(RVA = "0x495A50", Offset = "0x494050", VA = "0x180495A50")]
		[PreserveSig]
		internal static extern IntPtr EOS_Platform_GetAchievementsInterface(IntPtr handle);

		// Token: 0x06000241 RID: 577
		[Token(Token = "0x6000241")]
		[Address(RVA = "0x495AD0", Offset = "0x4940D0", VA = "0x180495AD0")]
		[PreserveSig]
		internal static extern Result EOS_Platform_GetActiveCountryCode(IntPtr handle, IntPtr localUserId, IntPtr outBuffer, ref int inOutBufferLength);

		// Token: 0x06000242 RID: 578
		[Token(Token = "0x6000242")]
		[Address(RVA = "0x495B80", Offset = "0x494180", VA = "0x180495B80")]
		[PreserveSig]
		internal static extern Result EOS_Platform_GetActiveLocaleCode(IntPtr handle, IntPtr localUserId, IntPtr outBuffer, ref int inOutBufferLength);

		// Token: 0x06000243 RID: 579
		[Token(Token = "0x6000243")]
		[Address(RVA = "0x495C30", Offset = "0x494230", VA = "0x180495C30")]
		[PreserveSig]
		internal static extern IntPtr EOS_Platform_GetAntiCheatClientInterface(IntPtr handle);

		// Token: 0x06000244 RID: 580
		[Token(Token = "0x6000244")]
		[Address(RVA = "0x495CB0", Offset = "0x4942B0", VA = "0x180495CB0")]
		[PreserveSig]
		internal static extern IntPtr EOS_Platform_GetAntiCheatServerInterface(IntPtr handle);

		// Token: 0x06000245 RID: 581
		[Token(Token = "0x6000245")]
		[Address(RVA = "0x495D30", Offset = "0x494330", VA = "0x180495D30")]
		[PreserveSig]
		internal static extern ApplicationStatus EOS_Platform_GetApplicationStatus(IntPtr handle);

		// Token: 0x06000246 RID: 582
		[Token(Token = "0x6000246")]
		[Address(RVA = "0x495DB0", Offset = "0x4943B0", VA = "0x180495DB0")]
		[PreserveSig]
		internal static extern IntPtr EOS_Platform_GetAuthInterface(IntPtr handle);

		// Token: 0x06000247 RID: 583
		[Token(Token = "0x6000247")]
		[Address(RVA = "0x495E30", Offset = "0x494430", VA = "0x180495E30")]
		[PreserveSig]
		internal static extern IntPtr EOS_Platform_GetConnectInterface(IntPtr handle);

		// Token: 0x06000248 RID: 584
		[Token(Token = "0x6000248")]
		[Address(RVA = "0x495EB0", Offset = "0x4944B0", VA = "0x180495EB0")]
		[PreserveSig]
		internal static extern IntPtr EOS_Platform_GetCustomInvitesInterface(IntPtr handle);

		// Token: 0x06000249 RID: 585
		[Token(Token = "0x6000249")]
		[Address(RVA = "0x495F30", Offset = "0x494530", VA = "0x180495F30")]
		[PreserveSig]
		internal static extern Result EOS_Platform_GetDesktopCrossplayStatus(IntPtr handle, ref GetDesktopCrossplayStatusOptionsInternal options, ref DesktopCrossplayStatusInfoInternal outDesktopCrossplayStatusInfo);

		// Token: 0x0600024A RID: 586
		[Token(Token = "0x600024A")]
		[Address(RVA = "0x495FD0", Offset = "0x4945D0", VA = "0x180495FD0")]
		[PreserveSig]
		internal static extern IntPtr EOS_Platform_GetEcomInterface(IntPtr handle);

		// Token: 0x0600024B RID: 587
		[Token(Token = "0x600024B")]
		[Address(RVA = "0x496050", Offset = "0x494650", VA = "0x180496050")]
		[PreserveSig]
		internal static extern IntPtr EOS_Platform_GetFriendsInterface(IntPtr handle);

		// Token: 0x0600024C RID: 588
		[Token(Token = "0x600024C")]
		[Address(RVA = "0x4960D0", Offset = "0x4946D0", VA = "0x1804960D0")]
		[PreserveSig]
		internal static extern IntPtr EOS_Platform_GetIntegratedPlatformInterface(IntPtr handle);

		// Token: 0x0600024D RID: 589
		[Token(Token = "0x600024D")]
		[Address(RVA = "0x496150", Offset = "0x494750", VA = "0x180496150")]
		[PreserveSig]
		internal static extern IntPtr EOS_Platform_GetKWSInterface(IntPtr handle);

		// Token: 0x0600024E RID: 590
		[Token(Token = "0x600024E")]
		[Address(RVA = "0x4961D0", Offset = "0x4947D0", VA = "0x1804961D0")]
		[PreserveSig]
		internal static extern IntPtr EOS_Platform_GetLeaderboardsInterface(IntPtr handle);

		// Token: 0x0600024F RID: 591
		[Token(Token = "0x600024F")]
		[Address(RVA = "0x496250", Offset = "0x494850", VA = "0x180496250")]
		[PreserveSig]
		internal static extern IntPtr EOS_Platform_GetLobbyInterface(IntPtr handle);

		// Token: 0x06000250 RID: 592
		[Token(Token = "0x6000250")]
		[Address(RVA = "0x4962D0", Offset = "0x4948D0", VA = "0x1804962D0")]
		[PreserveSig]
		internal static extern IntPtr EOS_Platform_GetMetricsInterface(IntPtr handle);

		// Token: 0x06000251 RID: 593
		[Token(Token = "0x6000251")]
		[Address(RVA = "0x496350", Offset = "0x494950", VA = "0x180496350")]
		[PreserveSig]
		internal static extern IntPtr EOS_Platform_GetModsInterface(IntPtr handle);

		// Token: 0x06000252 RID: 594
		[Token(Token = "0x6000252")]
		[Address(RVA = "0x4963D0", Offset = "0x4949D0", VA = "0x1804963D0")]
		[PreserveSig]
		internal static extern NetworkStatus EOS_Platform_GetNetworkStatus(IntPtr handle);

		// Token: 0x06000253 RID: 595
		[Token(Token = "0x6000253")]
		[Address(RVA = "0x496450", Offset = "0x494A50", VA = "0x180496450")]
		[PreserveSig]
		internal static extern Result EOS_Platform_GetOverrideCountryCode(IntPtr handle, IntPtr outBuffer, ref int inOutBufferLength);

		// Token: 0x06000254 RID: 596
		[Token(Token = "0x6000254")]
		[Address(RVA = "0x4964F0", Offset = "0x494AF0", VA = "0x1804964F0")]
		[PreserveSig]
		internal static extern Result EOS_Platform_GetOverrideLocaleCode(IntPtr handle, IntPtr outBuffer, ref int inOutBufferLength);

		// Token: 0x06000255 RID: 597
		[Token(Token = "0x6000255")]
		[Address(RVA = "0x496590", Offset = "0x494B90", VA = "0x180496590")]
		[PreserveSig]
		internal static extern IntPtr EOS_Platform_GetP2PInterface(IntPtr handle);

		// Token: 0x06000256 RID: 598
		[Token(Token = "0x6000256")]
		[Address(RVA = "0x496610", Offset = "0x494C10", VA = "0x180496610")]
		[PreserveSig]
		internal static extern IntPtr EOS_Platform_GetPlayerDataStorageInterface(IntPtr handle);

		// Token: 0x06000257 RID: 599
		[Token(Token = "0x6000257")]
		[Address(RVA = "0x496690", Offset = "0x494C90", VA = "0x180496690")]
		[PreserveSig]
		internal static extern IntPtr EOS_Platform_GetPresenceInterface(IntPtr handle);

		// Token: 0x06000258 RID: 600
		[Token(Token = "0x6000258")]
		[Address(RVA = "0x496710", Offset = "0x494D10", VA = "0x180496710")]
		[PreserveSig]
		internal static extern IntPtr EOS_Platform_GetProgressionSnapshotInterface(IntPtr handle);

		// Token: 0x06000259 RID: 601
		[Token(Token = "0x6000259")]
		[Address(RVA = "0x496790", Offset = "0x494D90", VA = "0x180496790")]
		[PreserveSig]
		internal static extern IntPtr EOS_Platform_GetRTCAdminInterface(IntPtr handle);

		// Token: 0x0600025A RID: 602
		[Token(Token = "0x600025A")]
		[Address(RVA = "0x496810", Offset = "0x494E10", VA = "0x180496810")]
		[PreserveSig]
		internal static extern IntPtr EOS_Platform_GetRTCInterface(IntPtr handle);

		// Token: 0x0600025B RID: 603
		[Token(Token = "0x600025B")]
		[Address(RVA = "0x496890", Offset = "0x494E90", VA = "0x180496890")]
		[PreserveSig]
		internal static extern IntPtr EOS_Platform_GetReportsInterface(IntPtr handle);

		// Token: 0x0600025C RID: 604
		[Token(Token = "0x600025C")]
		[Address(RVA = "0x496910", Offset = "0x494F10", VA = "0x180496910")]
		[PreserveSig]
		internal static extern IntPtr EOS_Platform_GetSanctionsInterface(IntPtr handle);

		// Token: 0x0600025D RID: 605
		[Token(Token = "0x600025D")]
		[Address(RVA = "0x496990", Offset = "0x494F90", VA = "0x180496990")]
		[PreserveSig]
		internal static extern IntPtr EOS_Platform_GetSessionsInterface(IntPtr handle);

		// Token: 0x0600025E RID: 606
		[Token(Token = "0x600025E")]
		[Address(RVA = "0x496A10", Offset = "0x495010", VA = "0x180496A10")]
		[PreserveSig]
		internal static extern IntPtr EOS_Platform_GetStatsInterface(IntPtr handle);

		// Token: 0x0600025F RID: 607
		[Token(Token = "0x600025F")]
		[Address(RVA = "0x496A90", Offset = "0x495090", VA = "0x180496A90")]
		[PreserveSig]
		internal static extern IntPtr EOS_Platform_GetTitleStorageInterface(IntPtr handle);

		// Token: 0x06000260 RID: 608
		[Token(Token = "0x6000260")]
		[Address(RVA = "0x496B10", Offset = "0x495110", VA = "0x180496B10")]
		[PreserveSig]
		internal static extern IntPtr EOS_Platform_GetUIInterface(IntPtr handle);

		// Token: 0x06000261 RID: 609
		[Token(Token = "0x6000261")]
		[Address(RVA = "0x496B90", Offset = "0x495190", VA = "0x180496B90")]
		[PreserveSig]
		internal static extern IntPtr EOS_Platform_GetUserInfoInterface(IntPtr handle);

		// Token: 0x06000262 RID: 610
		[Token(Token = "0x6000262")]
		[Address(RVA = "0x496C10", Offset = "0x495210", VA = "0x180496C10")]
		[PreserveSig]
		internal static extern void EOS_Platform_Release(IntPtr handle);

		// Token: 0x06000263 RID: 611
		[Token(Token = "0x6000263")]
		[Address(RVA = "0x496C90", Offset = "0x495290", VA = "0x180496C90")]
		[PreserveSig]
		internal static extern Result EOS_Platform_SetApplicationStatus(IntPtr handle, ApplicationStatus newStatus);

		// Token: 0x06000264 RID: 612
		[Token(Token = "0x6000264")]
		[Address(RVA = "0x496D20", Offset = "0x495320", VA = "0x180496D20")]
		[PreserveSig]
		internal static extern Result EOS_Platform_SetNetworkStatus(IntPtr handle, NetworkStatus newStatus);

		// Token: 0x06000265 RID: 613
		[Token(Token = "0x6000265")]
		[Address(RVA = "0x496DB0", Offset = "0x4953B0", VA = "0x180496DB0")]
		[PreserveSig]
		internal static extern Result EOS_Platform_SetOverrideCountryCode(IntPtr handle, IntPtr newCountryCode);

		// Token: 0x06000266 RID: 614
		[Token(Token = "0x6000266")]
		[Address(RVA = "0x496E40", Offset = "0x495440", VA = "0x180496E40")]
		[PreserveSig]
		internal static extern Result EOS_Platform_SetOverrideLocaleCode(IntPtr handle, IntPtr newLocaleCode);

		// Token: 0x06000267 RID: 615
		[Token(Token = "0x6000267")]
		[Address(RVA = "0x496ED0", Offset = "0x4954D0", VA = "0x180496ED0")]
		[PreserveSig]
		internal static extern void EOS_Platform_Tick(IntPtr handle);

		// Token: 0x06000268 RID: 616
		[Token(Token = "0x6000268")]
		[Address(RVA = "0x496F50", Offset = "0x495550", VA = "0x180496F50")]
		[PreserveSig]
		internal static extern Result EOS_PlayerDataStorageFileTransferRequest_CancelRequest(IntPtr handle);

		// Token: 0x06000269 RID: 617
		[Token(Token = "0x6000269")]
		[Address(RVA = "0x496FD0", Offset = "0x4955D0", VA = "0x180496FD0")]
		[PreserveSig]
		internal static extern Result EOS_PlayerDataStorageFileTransferRequest_GetFileRequestState(IntPtr handle);

		// Token: 0x0600026A RID: 618
		[Token(Token = "0x600026A")]
		[Address(RVA = "0x497050", Offset = "0x495650", VA = "0x180497050")]
		[PreserveSig]
		internal static extern Result EOS_PlayerDataStorageFileTransferRequest_GetFilename(IntPtr handle, uint filenameStringBufferSizeBytes, IntPtr outStringBuffer, ref int outStringLength);

		// Token: 0x0600026B RID: 619
		[Token(Token = "0x600026B")]
		[Address(RVA = "0x4970F0", Offset = "0x4956F0", VA = "0x1804970F0")]
		[PreserveSig]
		internal static extern void EOS_PlayerDataStorageFileTransferRequest_Release(IntPtr playerDataStorageFileTransferHandle);

		// Token: 0x0600026C RID: 620
		[Token(Token = "0x600026C")]
		[Address(RVA = "0x497170", Offset = "0x495770", VA = "0x180497170")]
		[PreserveSig]
		internal static extern Result EOS_PlayerDataStorage_CopyFileMetadataAtIndex(IntPtr handle, ref Epic.OnlineServices.PlayerDataStorage.CopyFileMetadataAtIndexOptionsInternal copyFileMetadataOptions, ref IntPtr outMetadata);

		// Token: 0x0600026D RID: 621
		[Token(Token = "0x600026D")]
		[Address(RVA = "0x497210", Offset = "0x495810", VA = "0x180497210")]
		[PreserveSig]
		internal static extern Result EOS_PlayerDataStorage_CopyFileMetadataByFilename(IntPtr handle, ref Epic.OnlineServices.PlayerDataStorage.CopyFileMetadataByFilenameOptionsInternal copyFileMetadataOptions, ref IntPtr outMetadata);

		// Token: 0x0600026E RID: 622
		[Token(Token = "0x600026E")]
		[Address(RVA = "0x4972B0", Offset = "0x4958B0", VA = "0x1804972B0")]
		[PreserveSig]
		internal static extern Result EOS_PlayerDataStorage_DeleteCache(IntPtr handle, ref Epic.OnlineServices.PlayerDataStorage.DeleteCacheOptionsInternal options, IntPtr clientData, Epic.OnlineServices.PlayerDataStorage.OnDeleteCacheCompleteCallbackInternal completionCallback);

		// Token: 0x0600026F RID: 623
		[Token(Token = "0x600026F")]
		[Address(RVA = "0x497360", Offset = "0x495960", VA = "0x180497360")]
		[PreserveSig]
		internal static extern void EOS_PlayerDataStorage_DeleteFile(IntPtr handle, ref DeleteFileOptionsInternal deleteOptions, IntPtr clientData, OnDeleteFileCompleteCallbackInternal completionCallback);

		// Token: 0x06000270 RID: 624
		[Token(Token = "0x6000270")]
		[Address(RVA = "0x497410", Offset = "0x495A10", VA = "0x180497410")]
		[PreserveSig]
		internal static extern void EOS_PlayerDataStorage_DuplicateFile(IntPtr handle, ref DuplicateFileOptionsInternal duplicateOptions, IntPtr clientData, OnDuplicateFileCompleteCallbackInternal completionCallback);

		// Token: 0x06000271 RID: 625
		[Token(Token = "0x6000271")]
		[Address(RVA = "0x4974C0", Offset = "0x495AC0", VA = "0x1804974C0")]
		[PreserveSig]
		internal static extern void EOS_PlayerDataStorage_FileMetadata_Release(IntPtr fileMetadata);

		// Token: 0x06000272 RID: 626
		[Token(Token = "0x6000272")]
		[Address(RVA = "0x497540", Offset = "0x495B40", VA = "0x180497540")]
		[PreserveSig]
		internal static extern Result EOS_PlayerDataStorage_GetFileMetadataCount(IntPtr handle, ref Epic.OnlineServices.PlayerDataStorage.GetFileMetadataCountOptionsInternal getFileMetadataCountOptions, ref int outFileMetadataCount);

		// Token: 0x06000273 RID: 627
		[Token(Token = "0x6000273")]
		[Address(RVA = "0x497690", Offset = "0x495C90", VA = "0x180497690")]
		[PreserveSig]
		internal static extern void EOS_PlayerDataStorage_QueryFile(IntPtr handle, ref Epic.OnlineServices.PlayerDataStorage.QueryFileOptionsInternal queryFileOptions, IntPtr clientData, Epic.OnlineServices.PlayerDataStorage.OnQueryFileCompleteCallbackInternal completionCallback);

		// Token: 0x06000274 RID: 628
		[Token(Token = "0x6000274")]
		[Address(RVA = "0x4975E0", Offset = "0x495BE0", VA = "0x1804975E0")]
		[PreserveSig]
		internal static extern void EOS_PlayerDataStorage_QueryFileList(IntPtr handle, ref Epic.OnlineServices.PlayerDataStorage.QueryFileListOptionsInternal queryFileListOptions, IntPtr clientData, Epic.OnlineServices.PlayerDataStorage.OnQueryFileListCompleteCallbackInternal completionCallback);

		// Token: 0x06000275 RID: 629
		[Token(Token = "0x6000275")]
		[Address(RVA = "0x497740", Offset = "0x495D40", VA = "0x180497740")]
		[PreserveSig]
		internal static extern IntPtr EOS_PlayerDataStorage_ReadFile(IntPtr handle, ref Epic.OnlineServices.PlayerDataStorage.ReadFileOptionsInternal readOptions, IntPtr clientData, Epic.OnlineServices.PlayerDataStorage.OnReadFileCompleteCallbackInternal completionCallback);

		// Token: 0x06000276 RID: 630
		[Token(Token = "0x6000276")]
		[Address(RVA = "0x4977F0", Offset = "0x495DF0", VA = "0x1804977F0")]
		[PreserveSig]
		internal static extern IntPtr EOS_PlayerDataStorage_WriteFile(IntPtr handle, ref WriteFileOptionsInternal writeOptions, IntPtr clientData, OnWriteFileCompleteCallbackInternal completionCallback);

		// Token: 0x06000277 RID: 631
		[Token(Token = "0x6000277")]
		[Address(RVA = "0x4978A0", Offset = "0x495EA0", VA = "0x1804978A0")]
		[PreserveSig]
		internal static extern Result EOS_PresenceModification_DeleteData(IntPtr handle, ref PresenceModificationDeleteDataOptionsInternal options);

		// Token: 0x06000278 RID: 632
		[Token(Token = "0x6000278")]
		[Address(RVA = "0x497930", Offset = "0x495F30", VA = "0x180497930")]
		[PreserveSig]
		internal static extern void EOS_PresenceModification_Release(IntPtr presenceModificationHandle);

		// Token: 0x06000279 RID: 633
		[Token(Token = "0x6000279")]
		[Address(RVA = "0x4979B0", Offset = "0x495FB0", VA = "0x1804979B0")]
		[PreserveSig]
		internal static extern Result EOS_PresenceModification_SetData(IntPtr handle, ref PresenceModificationSetDataOptionsInternal options);

		// Token: 0x0600027A RID: 634
		[Token(Token = "0x600027A")]
		[Address(RVA = "0x497A40", Offset = "0x496040", VA = "0x180497A40")]
		[PreserveSig]
		internal static extern Result EOS_PresenceModification_SetJoinInfo(IntPtr handle, ref PresenceModificationSetJoinInfoOptionsInternal options);

		// Token: 0x0600027B RID: 635
		[Token(Token = "0x600027B")]
		[Address(RVA = "0x497AD0", Offset = "0x4960D0", VA = "0x180497AD0")]
		[PreserveSig]
		internal static extern Result EOS_PresenceModification_SetRawRichText(IntPtr handle, ref PresenceModificationSetRawRichTextOptionsInternal options);

		// Token: 0x0600027C RID: 636
		[Token(Token = "0x600027C")]
		[Address(RVA = "0x497B60", Offset = "0x496160", VA = "0x180497B60")]
		[PreserveSig]
		internal static extern Result EOS_PresenceModification_SetStatus(IntPtr handle, ref PresenceModificationSetStatusOptionsInternal options);

		// Token: 0x0600027D RID: 637
		[Token(Token = "0x600027D")]
		[Address(RVA = "0x497BF0", Offset = "0x4961F0", VA = "0x180497BF0")]
		[PreserveSig]
		internal static extern ulong EOS_Presence_AddNotifyJoinGameAccepted(IntPtr handle, ref AddNotifyJoinGameAcceptedOptionsInternal options, IntPtr clientData, OnJoinGameAcceptedCallbackInternal notificationFn);

		// Token: 0x0600027E RID: 638
		[Token(Token = "0x600027E")]
		[Address(RVA = "0x497CA0", Offset = "0x4962A0", VA = "0x180497CA0")]
		[PreserveSig]
		internal static extern ulong EOS_Presence_AddNotifyOnPresenceChanged(IntPtr handle, ref AddNotifyOnPresenceChangedOptionsInternal options, IntPtr clientData, OnPresenceChangedCallbackInternal notificationHandler);

		// Token: 0x0600027F RID: 639
		[Token(Token = "0x600027F")]
		[Address(RVA = "0x497D50", Offset = "0x496350", VA = "0x180497D50")]
		[PreserveSig]
		internal static extern Result EOS_Presence_CopyPresence(IntPtr handle, ref CopyPresenceOptionsInternal options, ref IntPtr outPresence);

		// Token: 0x06000280 RID: 640
		[Token(Token = "0x6000280")]
		[Address(RVA = "0x497DF0", Offset = "0x4963F0", VA = "0x180497DF0")]
		[PreserveSig]
		internal static extern Result EOS_Presence_CreatePresenceModification(IntPtr handle, ref CreatePresenceModificationOptionsInternal options, ref IntPtr outPresenceModificationHandle);

		// Token: 0x06000281 RID: 641
		[Token(Token = "0x6000281")]
		[Address(RVA = "0x497E90", Offset = "0x496490", VA = "0x180497E90")]
		[PreserveSig]
		internal static extern Result EOS_Presence_GetJoinInfo(IntPtr handle, ref GetJoinInfoOptionsInternal options, IntPtr outBuffer, ref int inOutBufferLength);

		// Token: 0x06000282 RID: 642
		[Token(Token = "0x6000282")]
		[Address(RVA = "0x497F40", Offset = "0x496540", VA = "0x180497F40")]
		[PreserveSig]
		internal static extern int EOS_Presence_HasPresence(IntPtr handle, ref HasPresenceOptionsInternal options);

		// Token: 0x06000283 RID: 643
		[Token(Token = "0x6000283")]
		[Address(RVA = "0x497FD0", Offset = "0x4965D0", VA = "0x180497FD0")]
		[PreserveSig]
		internal static extern void EOS_Presence_Info_Release(IntPtr presenceInfo);

		// Token: 0x06000284 RID: 644
		[Token(Token = "0x6000284")]
		[Address(RVA = "0x498050", Offset = "0x496650", VA = "0x180498050")]
		[PreserveSig]
		internal static extern void EOS_Presence_QueryPresence(IntPtr handle, ref QueryPresenceOptionsInternal options, IntPtr clientData, OnQueryPresenceCompleteCallbackInternal completionDelegate);

		// Token: 0x06000285 RID: 645
		[Token(Token = "0x6000285")]
		[Address(RVA = "0x498100", Offset = "0x496700", VA = "0x180498100")]
		[PreserveSig]
		internal static extern void EOS_Presence_RemoveNotifyJoinGameAccepted(IntPtr handle, ulong inId);

		// Token: 0x06000286 RID: 646
		[Token(Token = "0x6000286")]
		[Address(RVA = "0x498190", Offset = "0x496790", VA = "0x180498190")]
		[PreserveSig]
		internal static extern void EOS_Presence_RemoveNotifyOnPresenceChanged(IntPtr handle, ulong notificationId);

		// Token: 0x06000287 RID: 647
		[Token(Token = "0x6000287")]
		[Address(RVA = "0x498220", Offset = "0x496820", VA = "0x180498220")]
		[PreserveSig]
		internal static extern void EOS_Presence_SetPresence(IntPtr handle, ref SetPresenceOptionsInternal options, IntPtr clientData, SetPresenceCompleteCallbackInternal completionDelegate);

		// Token: 0x06000288 RID: 648
		[Token(Token = "0x6000288")]
		[Address(RVA = "0x4982D0", Offset = "0x4968D0", VA = "0x1804982D0")]
		[PreserveSig]
		internal static extern IntPtr EOS_ProductUserId_FromString(IntPtr productUserIdString);

		// Token: 0x06000289 RID: 649
		[Token(Token = "0x6000289")]
		[Address(RVA = "0x498350", Offset = "0x496950", VA = "0x180498350")]
		[PreserveSig]
		internal static extern int EOS_ProductUserId_IsValid(IntPtr accountId);

		// Token: 0x0600028A RID: 650
		[Token(Token = "0x600028A")]
		[Address(RVA = "0x4983D0", Offset = "0x4969D0", VA = "0x1804983D0")]
		[PreserveSig]
		internal static extern Result EOS_ProductUserId_ToString(IntPtr accountId, IntPtr outBuffer, ref int inOutBufferLength);

		// Token: 0x0600028B RID: 651
		[Token(Token = "0x600028B")]
		[Address(RVA = "0x498470", Offset = "0x496A70", VA = "0x180498470")]
		[PreserveSig]
		internal static extern Result EOS_ProgressionSnapshot_AddProgression(IntPtr handle, ref AddProgressionOptionsInternal options);

		// Token: 0x0600028C RID: 652
		[Token(Token = "0x600028C")]
		[Address(RVA = "0x498500", Offset = "0x496B00", VA = "0x180498500")]
		[PreserveSig]
		internal static extern Result EOS_ProgressionSnapshot_BeginSnapshot(IntPtr handle, ref BeginSnapshotOptionsInternal options, ref uint outSnapshotId);

		// Token: 0x0600028D RID: 653
		[Token(Token = "0x600028D")]
		[Address(RVA = "0x4985A0", Offset = "0x496BA0", VA = "0x1804985A0")]
		[PreserveSig]
		internal static extern void EOS_ProgressionSnapshot_DeleteSnapshot(IntPtr handle, ref DeleteSnapshotOptionsInternal options, IntPtr clientData, OnDeleteSnapshotCallbackInternal completionDelegate);

		// Token: 0x0600028E RID: 654
		[Token(Token = "0x600028E")]
		[Address(RVA = "0x498650", Offset = "0x496C50", VA = "0x180498650")]
		[PreserveSig]
		internal static extern Result EOS_ProgressionSnapshot_EndSnapshot(IntPtr handle, ref EndSnapshotOptionsInternal options);

		// Token: 0x0600028F RID: 655
		[Token(Token = "0x600028F")]
		[Address(RVA = "0x4986E0", Offset = "0x496CE0", VA = "0x1804986E0")]
		[PreserveSig]
		internal static extern void EOS_ProgressionSnapshot_SubmitSnapshot(IntPtr handle, ref SubmitSnapshotOptionsInternal options, IntPtr clientData, OnSubmitSnapshotCallbackInternal completionDelegate);

		// Token: 0x06000290 RID: 656
		[Token(Token = "0x6000290")]
		[Address(RVA = "0x498790", Offset = "0x496D90", VA = "0x180498790")]
		[PreserveSig]
		internal static extern Result EOS_RTCAdmin_CopyUserTokenByIndex(IntPtr handle, ref CopyUserTokenByIndexOptionsInternal options, ref IntPtr outUserToken);

		// Token: 0x06000291 RID: 657
		[Token(Token = "0x6000291")]
		[Address(RVA = "0x498830", Offset = "0x496E30", VA = "0x180498830")]
		[PreserveSig]
		internal static extern Result EOS_RTCAdmin_CopyUserTokenByUserId(IntPtr handle, ref CopyUserTokenByUserIdOptionsInternal options, ref IntPtr outUserToken);

		// Token: 0x06000292 RID: 658
		[Token(Token = "0x6000292")]
		[Address(RVA = "0x4988D0", Offset = "0x496ED0", VA = "0x1804988D0")]
		[PreserveSig]
		internal static extern void EOS_RTCAdmin_Kick(IntPtr handle, ref KickOptionsInternal options, IntPtr clientData, OnKickCompleteCallbackInternal completionDelegate);

		// Token: 0x06000293 RID: 659
		[Token(Token = "0x6000293")]
		[Address(RVA = "0x498980", Offset = "0x496F80", VA = "0x180498980")]
		[PreserveSig]
		internal static extern void EOS_RTCAdmin_QueryJoinRoomToken(IntPtr handle, ref QueryJoinRoomTokenOptionsInternal options, IntPtr clientData, OnQueryJoinRoomTokenCompleteCallbackInternal completionDelegate);

		// Token: 0x06000294 RID: 660
		[Token(Token = "0x6000294")]
		[Address(RVA = "0x498A30", Offset = "0x497030", VA = "0x180498A30")]
		[PreserveSig]
		internal static extern void EOS_RTCAdmin_SetParticipantHardMute(IntPtr handle, ref SetParticipantHardMuteOptionsInternal options, IntPtr clientData, OnSetParticipantHardMuteCompleteCallbackInternal completionDelegate);

		// Token: 0x06000295 RID: 661
		[Token(Token = "0x6000295")]
		[Address(RVA = "0x498AE0", Offset = "0x4970E0", VA = "0x180498AE0")]
		[PreserveSig]
		internal static extern void EOS_RTCAdmin_UserToken_Release(IntPtr userToken);

		// Token: 0x06000296 RID: 662
		[Token(Token = "0x6000296")]
		[Address(RVA = "0x498B60", Offset = "0x497160", VA = "0x180498B60")]
		[PreserveSig]
		internal static extern ulong EOS_RTCAudio_AddNotifyAudioBeforeRender(IntPtr handle, ref AddNotifyAudioBeforeRenderOptionsInternal options, IntPtr clientData, OnAudioBeforeRenderCallbackInternal completionDelegate);

		// Token: 0x06000297 RID: 663
		[Token(Token = "0x6000297")]
		[Address(RVA = "0x498C10", Offset = "0x497210", VA = "0x180498C10")]
		[PreserveSig]
		internal static extern ulong EOS_RTCAudio_AddNotifyAudioBeforeSend(IntPtr handle, ref AddNotifyAudioBeforeSendOptionsInternal options, IntPtr clientData, OnAudioBeforeSendCallbackInternal completionDelegate);

		// Token: 0x06000298 RID: 664
		[Token(Token = "0x6000298")]
		[Address(RVA = "0x498CC0", Offset = "0x4972C0", VA = "0x180498CC0")]
		[PreserveSig]
		internal static extern ulong EOS_RTCAudio_AddNotifyAudioDevicesChanged(IntPtr handle, ref AddNotifyAudioDevicesChangedOptionsInternal options, IntPtr clientData, OnAudioDevicesChangedCallbackInternal completionDelegate);

		// Token: 0x06000299 RID: 665
		[Token(Token = "0x6000299")]
		[Address(RVA = "0x498D70", Offset = "0x497370", VA = "0x180498D70")]
		[PreserveSig]
		internal static extern ulong EOS_RTCAudio_AddNotifyAudioInputState(IntPtr handle, ref AddNotifyAudioInputStateOptionsInternal options, IntPtr clientData, OnAudioInputStateCallbackInternal completionDelegate);

		// Token: 0x0600029A RID: 666
		[Token(Token = "0x600029A")]
		[Address(RVA = "0x498E20", Offset = "0x497420", VA = "0x180498E20")]
		[PreserveSig]
		internal static extern ulong EOS_RTCAudio_AddNotifyAudioOutputState(IntPtr handle, ref AddNotifyAudioOutputStateOptionsInternal options, IntPtr clientData, OnAudioOutputStateCallbackInternal completionDelegate);

		// Token: 0x0600029B RID: 667
		[Token(Token = "0x600029B")]
		[Address(RVA = "0x498ED0", Offset = "0x4974D0", VA = "0x180498ED0")]
		[PreserveSig]
		internal static extern ulong EOS_RTCAudio_AddNotifyParticipantUpdated(IntPtr handle, ref AddNotifyParticipantUpdatedOptionsInternal options, IntPtr clientData, OnParticipantUpdatedCallbackInternal completionDelegate);

		// Token: 0x0600029C RID: 668
		[Token(Token = "0x600029C")]
		[Address(RVA = "0x498F80", Offset = "0x497580", VA = "0x180498F80")]
		[PreserveSig]
		internal static extern Result EOS_RTCAudio_CopyInputDeviceInformationByIndex(IntPtr handle, ref CopyInputDeviceInformationByIndexOptionsInternal options, ref IntPtr outInputDeviceInformation);

		// Token: 0x0600029D RID: 669
		[Token(Token = "0x600029D")]
		[Address(RVA = "0x499020", Offset = "0x497620", VA = "0x180499020")]
		[PreserveSig]
		internal static extern Result EOS_RTCAudio_CopyOutputDeviceInformationByIndex(IntPtr handle, ref CopyOutputDeviceInformationByIndexOptionsInternal options, ref IntPtr outOutputDeviceInformation);

		// Token: 0x0600029E RID: 670
		[Token(Token = "0x600029E")]
		[Address(RVA = "0x4990C0", Offset = "0x4976C0", VA = "0x1804990C0")]
		[PreserveSig]
		internal static extern IntPtr EOS_RTCAudio_GetAudioInputDeviceByIndex(IntPtr handle, ref GetAudioInputDeviceByIndexOptionsInternal options);

		// Token: 0x0600029F RID: 671
		[Token(Token = "0x600029F")]
		[Address(RVA = "0x499150", Offset = "0x497750", VA = "0x180499150")]
		[PreserveSig]
		internal static extern uint EOS_RTCAudio_GetAudioInputDevicesCount(IntPtr handle, ref GetAudioInputDevicesCountOptionsInternal options);

		// Token: 0x060002A0 RID: 672
		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x4991E0", Offset = "0x4977E0", VA = "0x1804991E0")]
		[PreserveSig]
		internal static extern IntPtr EOS_RTCAudio_GetAudioOutputDeviceByIndex(IntPtr handle, ref GetAudioOutputDeviceByIndexOptionsInternal options);

		// Token: 0x060002A1 RID: 673
		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x499270", Offset = "0x497870", VA = "0x180499270")]
		[PreserveSig]
		internal static extern uint EOS_RTCAudio_GetAudioOutputDevicesCount(IntPtr handle, ref GetAudioOutputDevicesCountOptionsInternal options);

		// Token: 0x060002A2 RID: 674
		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x499300", Offset = "0x497900", VA = "0x180499300")]
		[PreserveSig]
		internal static extern uint EOS_RTCAudio_GetInputDevicesCount(IntPtr handle, ref GetInputDevicesCountOptionsInternal options);

		// Token: 0x060002A3 RID: 675
		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x499390", Offset = "0x497990", VA = "0x180499390")]
		[PreserveSig]
		internal static extern uint EOS_RTCAudio_GetOutputDevicesCount(IntPtr handle, ref GetOutputDevicesCountOptionsInternal options);

		// Token: 0x060002A4 RID: 676
		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x499420", Offset = "0x497A20", VA = "0x180499420")]
		[PreserveSig]
		internal static extern void EOS_RTCAudio_InputDeviceInformation_Release(IntPtr deviceInformation);

		// Token: 0x060002A5 RID: 677
		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x4994A0", Offset = "0x497AA0", VA = "0x1804994A0")]
		[PreserveSig]
		internal static extern void EOS_RTCAudio_OutputDeviceInformation_Release(IntPtr deviceInformation);

		// Token: 0x060002A6 RID: 678
		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x499520", Offset = "0x497B20", VA = "0x180499520")]
		[PreserveSig]
		internal static extern void EOS_RTCAudio_QueryInputDevicesInformation(IntPtr handle, ref QueryInputDevicesInformationOptionsInternal options, IntPtr clientData, OnQueryInputDevicesInformationCallbackInternal completionDelegate);

		// Token: 0x060002A7 RID: 679
		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x4995D0", Offset = "0x497BD0", VA = "0x1804995D0")]
		[PreserveSig]
		internal static extern void EOS_RTCAudio_QueryOutputDevicesInformation(IntPtr handle, ref QueryOutputDevicesInformationOptionsInternal options, IntPtr clientData, OnQueryOutputDevicesInformationCallbackInternal completionDelegate);

		// Token: 0x060002A8 RID: 680
		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x499680", Offset = "0x497C80", VA = "0x180499680")]
		[PreserveSig]
		internal static extern Result EOS_RTCAudio_RegisterPlatformAudioUser(IntPtr handle, ref RegisterPlatformAudioUserOptionsInternal options);

		// Token: 0x060002A9 RID: 681
		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x499710", Offset = "0x497D10", VA = "0x180499710")]
		[PreserveSig]
		internal static extern void EOS_RTCAudio_RegisterPlatformUser(IntPtr handle, ref RegisterPlatformUserOptionsInternal options, IntPtr clientData, OnRegisterPlatformUserCallbackInternal completionDelegate);

		// Token: 0x060002AA RID: 682
		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x4997C0", Offset = "0x497DC0", VA = "0x1804997C0")]
		[PreserveSig]
		internal static extern void EOS_RTCAudio_RemoveNotifyAudioBeforeRender(IntPtr handle, ulong notificationId);

		// Token: 0x060002AB RID: 683
		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x499850", Offset = "0x497E50", VA = "0x180499850")]
		[PreserveSig]
		internal static extern void EOS_RTCAudio_RemoveNotifyAudioBeforeSend(IntPtr handle, ulong notificationId);

		// Token: 0x060002AC RID: 684
		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x4998E0", Offset = "0x497EE0", VA = "0x1804998E0")]
		[PreserveSig]
		internal static extern void EOS_RTCAudio_RemoveNotifyAudioDevicesChanged(IntPtr handle, ulong notificationId);

		// Token: 0x060002AD RID: 685
		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x499970", Offset = "0x497F70", VA = "0x180499970")]
		[PreserveSig]
		internal static extern void EOS_RTCAudio_RemoveNotifyAudioInputState(IntPtr handle, ulong notificationId);

		// Token: 0x060002AE RID: 686
		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x499A00", Offset = "0x498000", VA = "0x180499A00")]
		[PreserveSig]
		internal static extern void EOS_RTCAudio_RemoveNotifyAudioOutputState(IntPtr handle, ulong notificationId);

		// Token: 0x060002AF RID: 687
		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x499A90", Offset = "0x498090", VA = "0x180499A90")]
		[PreserveSig]
		internal static extern void EOS_RTCAudio_RemoveNotifyParticipantUpdated(IntPtr handle, ulong notificationId);

		// Token: 0x060002B0 RID: 688
		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x499B20", Offset = "0x498120", VA = "0x180499B20")]
		[PreserveSig]
		internal static extern Result EOS_RTCAudio_SendAudio(IntPtr handle, ref SendAudioOptionsInternal options);

		// Token: 0x060002B1 RID: 689
		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x499BB0", Offset = "0x4981B0", VA = "0x180499BB0")]
		[PreserveSig]
		internal static extern Result EOS_RTCAudio_SetAudioInputSettings(IntPtr handle, ref SetAudioInputSettingsOptionsInternal options);

		// Token: 0x060002B2 RID: 690
		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x499C40", Offset = "0x498240", VA = "0x180499C40")]
		[PreserveSig]
		internal static extern Result EOS_RTCAudio_SetAudioOutputSettings(IntPtr handle, ref SetAudioOutputSettingsOptionsInternal options);

		// Token: 0x060002B3 RID: 691
		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x499CD0", Offset = "0x4982D0", VA = "0x180499CD0")]
		[PreserveSig]
		internal static extern void EOS_RTCAudio_SetInputDeviceSettings(IntPtr handle, ref SetInputDeviceSettingsOptionsInternal options, IntPtr clientData, OnSetInputDeviceSettingsCallbackInternal completionDelegate);

		// Token: 0x060002B4 RID: 692
		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x499D80", Offset = "0x498380", VA = "0x180499D80")]
		[PreserveSig]
		internal static extern void EOS_RTCAudio_SetOutputDeviceSettings(IntPtr handle, ref SetOutputDeviceSettingsOptionsInternal options, IntPtr clientData, OnSetOutputDeviceSettingsCallbackInternal completionDelegate);

		// Token: 0x060002B5 RID: 693
		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x499E30", Offset = "0x498430", VA = "0x180499E30")]
		[PreserveSig]
		internal static extern Result EOS_RTCAudio_UnregisterPlatformAudioUser(IntPtr handle, ref UnregisterPlatformAudioUserOptionsInternal options);

		// Token: 0x060002B6 RID: 694
		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x499EC0", Offset = "0x4984C0", VA = "0x180499EC0")]
		[PreserveSig]
		internal static extern void EOS_RTCAudio_UnregisterPlatformUser(IntPtr handle, ref UnregisterPlatformUserOptionsInternal options, IntPtr clientData, OnUnregisterPlatformUserCallbackInternal completionDelegate);

		// Token: 0x060002B7 RID: 695
		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x499F70", Offset = "0x498570", VA = "0x180499F70")]
		[PreserveSig]
		internal static extern void EOS_RTCAudio_UpdateParticipantVolume(IntPtr handle, ref UpdateParticipantVolumeOptionsInternal options, IntPtr clientData, OnUpdateParticipantVolumeCallbackInternal completionDelegate);

		// Token: 0x060002B8 RID: 696
		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x49A0D0", Offset = "0x4986D0", VA = "0x18049A0D0")]
		[PreserveSig]
		internal static extern void EOS_RTCAudio_UpdateReceiving(IntPtr handle, ref UpdateReceivingOptionsInternal options, IntPtr clientData, OnUpdateReceivingCallbackInternal completionDelegate);

		// Token: 0x060002B9 RID: 697
		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x49A020", Offset = "0x498620", VA = "0x18049A020")]
		[PreserveSig]
		internal static extern void EOS_RTCAudio_UpdateReceivingVolume(IntPtr handle, ref UpdateReceivingVolumeOptionsInternal options, IntPtr clientData, OnUpdateReceivingVolumeCallbackInternal completionDelegate);

		// Token: 0x060002BA RID: 698
		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x49A230", Offset = "0x498830", VA = "0x18049A230")]
		[PreserveSig]
		internal static extern void EOS_RTCAudio_UpdateSending(IntPtr handle, ref UpdateSendingOptionsInternal options, IntPtr clientData, OnUpdateSendingCallbackInternal completionDelegate);

		// Token: 0x060002BB RID: 699
		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x49A180", Offset = "0x498780", VA = "0x18049A180")]
		[PreserveSig]
		internal static extern void EOS_RTCAudio_UpdateSendingVolume(IntPtr handle, ref UpdateSendingVolumeOptionsInternal options, IntPtr clientData, OnUpdateSendingVolumeCallbackInternal completionDelegate);

		// Token: 0x060002BC RID: 700
		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x49A2E0", Offset = "0x4988E0", VA = "0x18049A2E0")]
		[PreserveSig]
		internal static extern ulong EOS_RTC_AddNotifyDisconnected(IntPtr handle, ref AddNotifyDisconnectedOptionsInternal options, IntPtr clientData, OnDisconnectedCallbackInternal completionDelegate);

		// Token: 0x060002BD RID: 701
		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x49A390", Offset = "0x498990", VA = "0x18049A390")]
		[PreserveSig]
		internal static extern ulong EOS_RTC_AddNotifyParticipantStatusChanged(IntPtr handle, ref AddNotifyParticipantStatusChangedOptionsInternal options, IntPtr clientData, OnParticipantStatusChangedCallbackInternal completionDelegate);

		// Token: 0x060002BE RID: 702
		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x49A440", Offset = "0x498A40", VA = "0x18049A440")]
		[PreserveSig]
		internal static extern ulong EOS_RTC_AddNotifyRoomStatisticsUpdated(IntPtr handle, ref AddNotifyRoomStatisticsUpdatedOptionsInternal options, IntPtr clientData, OnRoomStatisticsUpdatedCallbackInternal statisticsUpdateHandler);

		// Token: 0x060002BF RID: 703
		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x49A4F0", Offset = "0x498AF0", VA = "0x18049A4F0")]
		[PreserveSig]
		internal static extern void EOS_RTC_BlockParticipant(IntPtr handle, ref BlockParticipantOptionsInternal options, IntPtr clientData, OnBlockParticipantCallbackInternal completionDelegate);

		// Token: 0x060002C0 RID: 704
		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x49A5A0", Offset = "0x498BA0", VA = "0x18049A5A0")]
		[PreserveSig]
		internal static extern IntPtr EOS_RTC_GetAudioInterface(IntPtr handle);

		// Token: 0x060002C1 RID: 705
		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x49A620", Offset = "0x498C20", VA = "0x18049A620")]
		[PreserveSig]
		internal static extern void EOS_RTC_JoinRoom(IntPtr handle, ref JoinRoomOptionsInternal options, IntPtr clientData, OnJoinRoomCallbackInternal completionDelegate);

		// Token: 0x060002C2 RID: 706
		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x49A6D0", Offset = "0x498CD0", VA = "0x18049A6D0")]
		[PreserveSig]
		internal static extern void EOS_RTC_LeaveRoom(IntPtr handle, ref LeaveRoomOptionsInternal options, IntPtr clientData, OnLeaveRoomCallbackInternal completionDelegate);

		// Token: 0x060002C3 RID: 707
		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x49A780", Offset = "0x498D80", VA = "0x18049A780")]
		[PreserveSig]
		internal static extern void EOS_RTC_RemoveNotifyDisconnected(IntPtr handle, ulong notificationId);

		// Token: 0x060002C4 RID: 708
		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x49A810", Offset = "0x498E10", VA = "0x18049A810")]
		[PreserveSig]
		internal static extern void EOS_RTC_RemoveNotifyParticipantStatusChanged(IntPtr handle, ulong notificationId);

		// Token: 0x060002C5 RID: 709
		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x49A8A0", Offset = "0x498EA0", VA = "0x18049A8A0")]
		[PreserveSig]
		internal static extern void EOS_RTC_RemoveNotifyRoomStatisticsUpdated(IntPtr handle, ulong notificationId);

		// Token: 0x060002C6 RID: 710
		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x49A930", Offset = "0x498F30", VA = "0x18049A930")]
		[PreserveSig]
		internal static extern Result EOS_RTC_SetRoomSetting(IntPtr handle, ref SetRoomSettingOptionsInternal options);

		// Token: 0x060002C7 RID: 711
		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x49A9C0", Offset = "0x498FC0", VA = "0x18049A9C0")]
		[PreserveSig]
		internal static extern Result EOS_RTC_SetSetting(IntPtr handle, ref SetSettingOptionsInternal options);

		// Token: 0x060002C8 RID: 712
		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x49AA50", Offset = "0x499050", VA = "0x18049AA50")]
		[PreserveSig]
		internal static extern void EOS_Reports_SendPlayerBehaviorReport(IntPtr handle, ref SendPlayerBehaviorReportOptionsInternal options, IntPtr clientData, OnSendPlayerBehaviorReportCompleteCallbackInternal completionDelegate);

		// Token: 0x060002C9 RID: 713
		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x49AB00", Offset = "0x499100", VA = "0x18049AB00")]
		[PreserveSig]
		internal static extern Result EOS_Sanctions_CopyPlayerSanctionByIndex(IntPtr handle, ref CopyPlayerSanctionByIndexOptionsInternal options, ref IntPtr outSanction);

		// Token: 0x060002CA RID: 714
		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x49ABA0", Offset = "0x4991A0", VA = "0x18049ABA0")]
		[PreserveSig]
		internal static extern uint EOS_Sanctions_GetPlayerSanctionCount(IntPtr handle, ref GetPlayerSanctionCountOptionsInternal options);

		// Token: 0x060002CB RID: 715
		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x49AC30", Offset = "0x499230", VA = "0x18049AC30")]
		[PreserveSig]
		internal static extern void EOS_Sanctions_PlayerSanction_Release(IntPtr sanction);

		// Token: 0x060002CC RID: 716
		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x49ACB0", Offset = "0x4992B0", VA = "0x18049ACB0")]
		[PreserveSig]
		internal static extern void EOS_Sanctions_QueryActivePlayerSanctions(IntPtr handle, ref QueryActivePlayerSanctionsOptionsInternal options, IntPtr clientData, OnQueryActivePlayerSanctionsCallbackInternal completionDelegate);

		// Token: 0x060002CD RID: 717
		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x49AD60", Offset = "0x499360", VA = "0x18049AD60")]
		[PreserveSig]
		internal static extern void EOS_SessionDetails_Attribute_Release(IntPtr sessionAttribute);

		// Token: 0x060002CE RID: 718
		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x49ADE0", Offset = "0x4993E0", VA = "0x18049ADE0")]
		[PreserveSig]
		internal static extern Result EOS_SessionDetails_CopyInfo(IntPtr handle, ref SessionDetailsCopyInfoOptionsInternal options, ref IntPtr outSessionInfo);

		// Token: 0x060002CF RID: 719
		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x49AE80", Offset = "0x499480", VA = "0x18049AE80")]
		[PreserveSig]
		internal static extern Result EOS_SessionDetails_CopySessionAttributeByIndex(IntPtr handle, ref SessionDetailsCopySessionAttributeByIndexOptionsInternal options, ref IntPtr outSessionAttribute);

		// Token: 0x060002D0 RID: 720
		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x49AF20", Offset = "0x499520", VA = "0x18049AF20")]
		[PreserveSig]
		internal static extern Result EOS_SessionDetails_CopySessionAttributeByKey(IntPtr handle, ref SessionDetailsCopySessionAttributeByKeyOptionsInternal options, ref IntPtr outSessionAttribute);

		// Token: 0x060002D1 RID: 721
		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x49AFC0", Offset = "0x4995C0", VA = "0x18049AFC0")]
		[PreserveSig]
		internal static extern uint EOS_SessionDetails_GetSessionAttributeCount(IntPtr handle, ref SessionDetailsGetSessionAttributeCountOptionsInternal options);

		// Token: 0x060002D2 RID: 722
		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x49B050", Offset = "0x499650", VA = "0x18049B050")]
		[PreserveSig]
		internal static extern void EOS_SessionDetails_Info_Release(IntPtr sessionInfo);

		// Token: 0x060002D3 RID: 723
		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x49B0D0", Offset = "0x4996D0", VA = "0x18049B0D0")]
		[PreserveSig]
		internal static extern void EOS_SessionDetails_Release(IntPtr sessionHandle);

		// Token: 0x060002D4 RID: 724
		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x49B150", Offset = "0x499750", VA = "0x18049B150")]
		[PreserveSig]
		internal static extern Result EOS_SessionModification_AddAttribute(IntPtr handle, ref SessionModificationAddAttributeOptionsInternal options);

		// Token: 0x060002D5 RID: 725
		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x49B1E0", Offset = "0x4997E0", VA = "0x18049B1E0")]
		[PreserveSig]
		internal static extern void EOS_SessionModification_Release(IntPtr sessionModificationHandle);

		// Token: 0x060002D6 RID: 726
		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x49B260", Offset = "0x499860", VA = "0x18049B260")]
		[PreserveSig]
		internal static extern Result EOS_SessionModification_RemoveAttribute(IntPtr handle, ref SessionModificationRemoveAttributeOptionsInternal options);

		// Token: 0x060002D7 RID: 727
		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x49B2F0", Offset = "0x4998F0", VA = "0x18049B2F0")]
		[PreserveSig]
		internal static extern Result EOS_SessionModification_SetAllowedPlatformIds(IntPtr handle, ref SessionModificationSetAllowedPlatformIdsOptionsInternal options);

		// Token: 0x060002D8 RID: 728
		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x49B380", Offset = "0x499980", VA = "0x18049B380")]
		[PreserveSig]
		internal static extern Result EOS_SessionModification_SetBucketId(IntPtr handle, ref SessionModificationSetBucketIdOptionsInternal options);

		// Token: 0x060002D9 RID: 729
		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x49B410", Offset = "0x499A10", VA = "0x18049B410")]
		[PreserveSig]
		internal static extern Result EOS_SessionModification_SetHostAddress(IntPtr handle, ref SessionModificationSetHostAddressOptionsInternal options);

		// Token: 0x060002DA RID: 730
		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x49B4A0", Offset = "0x499AA0", VA = "0x18049B4A0")]
		[PreserveSig]
		internal static extern Result EOS_SessionModification_SetInvitesAllowed(IntPtr handle, ref SessionModificationSetInvitesAllowedOptionsInternal options);

		// Token: 0x060002DB RID: 731
		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x49B530", Offset = "0x499B30", VA = "0x18049B530")]
		[PreserveSig]
		internal static extern Result EOS_SessionModification_SetJoinInProgressAllowed(IntPtr handle, ref SessionModificationSetJoinInProgressAllowedOptionsInternal options);

		// Token: 0x060002DC RID: 732
		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x49B5C0", Offset = "0x499BC0", VA = "0x18049B5C0")]
		[PreserveSig]
		internal static extern Result EOS_SessionModification_SetMaxPlayers(IntPtr handle, ref SessionModificationSetMaxPlayersOptionsInternal options);

		// Token: 0x060002DD RID: 733
		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x49B650", Offset = "0x499C50", VA = "0x18049B650")]
		[PreserveSig]
		internal static extern Result EOS_SessionModification_SetPermissionLevel(IntPtr handle, ref SessionModificationSetPermissionLevelOptionsInternal options);

		// Token: 0x060002DE RID: 734
		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x49B6E0", Offset = "0x499CE0", VA = "0x18049B6E0")]
		[PreserveSig]
		internal static extern Result EOS_SessionSearch_CopySearchResultByIndex(IntPtr handle, ref SessionSearchCopySearchResultByIndexOptionsInternal options, ref IntPtr outSessionHandle);

		// Token: 0x060002DF RID: 735
		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x49B780", Offset = "0x499D80", VA = "0x18049B780")]
		[PreserveSig]
		internal static extern void EOS_SessionSearch_Find(IntPtr handle, ref SessionSearchFindOptionsInternal options, IntPtr clientData, SessionSearchOnFindCallbackInternal completionDelegate);

		// Token: 0x060002E0 RID: 736
		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x49B830", Offset = "0x499E30", VA = "0x18049B830")]
		[PreserveSig]
		internal static extern uint EOS_SessionSearch_GetSearchResultCount(IntPtr handle, ref SessionSearchGetSearchResultCountOptionsInternal options);

		// Token: 0x060002E1 RID: 737
		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x49B8C0", Offset = "0x499EC0", VA = "0x18049B8C0")]
		[PreserveSig]
		internal static extern void EOS_SessionSearch_Release(IntPtr sessionSearchHandle);

		// Token: 0x060002E2 RID: 738
		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x49B940", Offset = "0x499F40", VA = "0x18049B940")]
		[PreserveSig]
		internal static extern Result EOS_SessionSearch_RemoveParameter(IntPtr handle, ref SessionSearchRemoveParameterOptionsInternal options);

		// Token: 0x060002E3 RID: 739
		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x49B9D0", Offset = "0x499FD0", VA = "0x18049B9D0")]
		[PreserveSig]
		internal static extern Result EOS_SessionSearch_SetMaxResults(IntPtr handle, ref SessionSearchSetMaxResultsOptionsInternal options);

		// Token: 0x060002E4 RID: 740
		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x49BA60", Offset = "0x49A060", VA = "0x18049BA60")]
		[PreserveSig]
		internal static extern Result EOS_SessionSearch_SetParameter(IntPtr handle, ref SessionSearchSetParameterOptionsInternal options);

		// Token: 0x060002E5 RID: 741
		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x49BAF0", Offset = "0x49A0F0", VA = "0x18049BAF0")]
		[PreserveSig]
		internal static extern Result EOS_SessionSearch_SetSessionId(IntPtr handle, ref SessionSearchSetSessionIdOptionsInternal options);

		// Token: 0x060002E6 RID: 742
		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x49BB80", Offset = "0x49A180", VA = "0x18049BB80")]
		[PreserveSig]
		internal static extern Result EOS_SessionSearch_SetTargetUserId(IntPtr handle, ref SessionSearchSetTargetUserIdOptionsInternal options);

		// Token: 0x060002E7 RID: 743
		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x49BC10", Offset = "0x49A210", VA = "0x18049BC10")]
		[PreserveSig]
		internal static extern ulong EOS_Sessions_AddNotifyJoinSessionAccepted(IntPtr handle, ref AddNotifyJoinSessionAcceptedOptionsInternal options, IntPtr clientData, OnJoinSessionAcceptedCallbackInternal notificationFn);

		// Token: 0x060002E8 RID: 744
		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x49BCC0", Offset = "0x49A2C0", VA = "0x18049BCC0")]
		[PreserveSig]
		internal static extern ulong EOS_Sessions_AddNotifyLeaveSessionRequested(IntPtr handle, ref AddNotifyLeaveSessionRequestedOptionsInternal options, IntPtr clientData, OnLeaveSessionRequestedCallbackInternal notificationFn);

		// Token: 0x060002E9 RID: 745
		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x49BD70", Offset = "0x49A370", VA = "0x18049BD70")]
		[PreserveSig]
		internal static extern ulong EOS_Sessions_AddNotifySendSessionNativeInviteRequested(IntPtr handle, ref AddNotifySendSessionNativeInviteRequestedOptionsInternal options, IntPtr clientData, OnSendSessionNativeInviteRequestedCallbackInternal notificationFn);

		// Token: 0x060002EA RID: 746
		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x49BE20", Offset = "0x49A420", VA = "0x18049BE20")]
		[PreserveSig]
		internal static extern ulong EOS_Sessions_AddNotifySessionInviteAccepted(IntPtr handle, ref AddNotifySessionInviteAcceptedOptionsInternal options, IntPtr clientData, OnSessionInviteAcceptedCallbackInternal notificationFn);

		// Token: 0x060002EB RID: 747
		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x49BED0", Offset = "0x49A4D0", VA = "0x18049BED0")]
		[PreserveSig]
		internal static extern ulong EOS_Sessions_AddNotifySessionInviteReceived(IntPtr handle, ref AddNotifySessionInviteReceivedOptionsInternal options, IntPtr clientData, OnSessionInviteReceivedCallbackInternal notificationFn);

		// Token: 0x060002EC RID: 748
		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x49BF80", Offset = "0x49A580", VA = "0x18049BF80")]
		[PreserveSig]
		internal static extern ulong EOS_Sessions_AddNotifySessionInviteRejected(IntPtr handle, ref AddNotifySessionInviteRejectedOptionsInternal options, IntPtr clientData, OnSessionInviteRejectedCallbackInternal notificationFn);

		// Token: 0x060002ED RID: 749
		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x49C030", Offset = "0x49A630", VA = "0x18049C030")]
		[PreserveSig]
		internal static extern Result EOS_Sessions_CopyActiveSessionHandle(IntPtr handle, ref CopyActiveSessionHandleOptionsInternal options, ref IntPtr outSessionHandle);

		// Token: 0x060002EE RID: 750
		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x49C0D0", Offset = "0x49A6D0", VA = "0x18049C0D0")]
		[PreserveSig]
		internal static extern Result EOS_Sessions_CopySessionHandleByInviteId(IntPtr handle, ref CopySessionHandleByInviteIdOptionsInternal options, ref IntPtr outSessionHandle);

		// Token: 0x060002EF RID: 751
		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x49C170", Offset = "0x49A770", VA = "0x18049C170")]
		[PreserveSig]
		internal static extern Result EOS_Sessions_CopySessionHandleByUiEventId(IntPtr handle, ref CopySessionHandleByUiEventIdOptionsInternal options, ref IntPtr outSessionHandle);

		// Token: 0x060002F0 RID: 752
		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x49C210", Offset = "0x49A810", VA = "0x18049C210")]
		[PreserveSig]
		internal static extern Result EOS_Sessions_CopySessionHandleForPresence(IntPtr handle, ref CopySessionHandleForPresenceOptionsInternal options, ref IntPtr outSessionHandle);

		// Token: 0x060002F1 RID: 753
		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x49C2B0", Offset = "0x49A8B0", VA = "0x18049C2B0")]
		[PreserveSig]
		internal static extern Result EOS_Sessions_CreateSessionModification(IntPtr handle, ref CreateSessionModificationOptionsInternal options, ref IntPtr outSessionModificationHandle);

		// Token: 0x060002F2 RID: 754
		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x49C350", Offset = "0x49A950", VA = "0x18049C350")]
		[PreserveSig]
		internal static extern Result EOS_Sessions_CreateSessionSearch(IntPtr handle, ref CreateSessionSearchOptionsInternal options, ref IntPtr outSessionSearchHandle);

		// Token: 0x060002F3 RID: 755
		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x49C3F0", Offset = "0x49A9F0", VA = "0x18049C3F0")]
		[PreserveSig]
		internal static extern void EOS_Sessions_DestroySession(IntPtr handle, ref DestroySessionOptionsInternal options, IntPtr clientData, OnDestroySessionCallbackInternal completionDelegate);

		// Token: 0x060002F4 RID: 756
		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x49C4A0", Offset = "0x49AAA0", VA = "0x18049C4A0")]
		[PreserveSig]
		internal static extern Result EOS_Sessions_DumpSessionState(IntPtr handle, ref DumpSessionStateOptionsInternal options);

		// Token: 0x060002F5 RID: 757
		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x49C530", Offset = "0x49AB30", VA = "0x18049C530")]
		[PreserveSig]
		internal static extern void EOS_Sessions_EndSession(IntPtr handle, ref Epic.OnlineServices.Sessions.EndSessionOptionsInternal options, IntPtr clientData, OnEndSessionCallbackInternal completionDelegate);

		// Token: 0x060002F6 RID: 758
		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x49C5E0", Offset = "0x49ABE0", VA = "0x18049C5E0")]
		[PreserveSig]
		internal static extern uint EOS_Sessions_GetInviteCount(IntPtr handle, ref Epic.OnlineServices.Sessions.GetInviteCountOptionsInternal options);

		// Token: 0x060002F7 RID: 759
		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x49C670", Offset = "0x49AC70", VA = "0x18049C670")]
		[PreserveSig]
		internal static extern Result EOS_Sessions_GetInviteIdByIndex(IntPtr handle, ref Epic.OnlineServices.Sessions.GetInviteIdByIndexOptionsInternal options, IntPtr outBuffer, ref int inOutBufferLength);

		// Token: 0x060002F8 RID: 760
		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x49C720", Offset = "0x49AD20", VA = "0x18049C720")]
		[PreserveSig]
		internal static extern Result EOS_Sessions_IsUserInSession(IntPtr handle, ref IsUserInSessionOptionsInternal options);

		// Token: 0x060002F9 RID: 761
		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x49C7B0", Offset = "0x49ADB0", VA = "0x18049C7B0")]
		[PreserveSig]
		internal static extern void EOS_Sessions_JoinSession(IntPtr handle, ref JoinSessionOptionsInternal options, IntPtr clientData, OnJoinSessionCallbackInternal completionDelegate);

		// Token: 0x060002FA RID: 762
		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x49C860", Offset = "0x49AE60", VA = "0x18049C860")]
		[PreserveSig]
		internal static extern void EOS_Sessions_QueryInvites(IntPtr handle, ref Epic.OnlineServices.Sessions.QueryInvitesOptionsInternal options, IntPtr clientData, Epic.OnlineServices.Sessions.OnQueryInvitesCallbackInternal completionDelegate);

		// Token: 0x060002FB RID: 763
		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x49C910", Offset = "0x49AF10", VA = "0x18049C910")]
		[PreserveSig]
		internal static extern void EOS_Sessions_RegisterPlayers(IntPtr handle, ref RegisterPlayersOptionsInternal options, IntPtr clientData, OnRegisterPlayersCallbackInternal completionDelegate);

		// Token: 0x060002FC RID: 764
		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x49C9C0", Offset = "0x49AFC0", VA = "0x18049C9C0")]
		[PreserveSig]
		internal static extern void EOS_Sessions_RejectInvite(IntPtr handle, ref Epic.OnlineServices.Sessions.RejectInviteOptionsInternal options, IntPtr clientData, Epic.OnlineServices.Sessions.OnRejectInviteCallbackInternal completionDelegate);

		// Token: 0x060002FD RID: 765
		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x49CA70", Offset = "0x49B070", VA = "0x18049CA70")]
		[PreserveSig]
		internal static extern void EOS_Sessions_RemoveNotifyJoinSessionAccepted(IntPtr handle, ulong inId);

		// Token: 0x060002FE RID: 766
		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x49CB00", Offset = "0x49B100", VA = "0x18049CB00")]
		[PreserveSig]
		internal static extern void EOS_Sessions_RemoveNotifyLeaveSessionRequested(IntPtr handle, ulong inId);

		// Token: 0x060002FF RID: 767
		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x49CB90", Offset = "0x49B190", VA = "0x18049CB90")]
		[PreserveSig]
		internal static extern void EOS_Sessions_RemoveNotifySendSessionNativeInviteRequested(IntPtr handle, ulong inId);

		// Token: 0x06000300 RID: 768
		[Token(Token = "0x6000300")]
		[Address(RVA = "0x49CC20", Offset = "0x49B220", VA = "0x18049CC20")]
		[PreserveSig]
		internal static extern void EOS_Sessions_RemoveNotifySessionInviteAccepted(IntPtr handle, ulong inId);

		// Token: 0x06000301 RID: 769
		[Token(Token = "0x6000301")]
		[Address(RVA = "0x49CCB0", Offset = "0x49B2B0", VA = "0x18049CCB0")]
		[PreserveSig]
		internal static extern void EOS_Sessions_RemoveNotifySessionInviteReceived(IntPtr handle, ulong inId);

		// Token: 0x06000302 RID: 770
		[Token(Token = "0x6000302")]
		[Address(RVA = "0x49CD40", Offset = "0x49B340", VA = "0x18049CD40")]
		[PreserveSig]
		internal static extern void EOS_Sessions_RemoveNotifySessionInviteRejected(IntPtr handle, ulong inId);

		// Token: 0x06000303 RID: 771
		[Token(Token = "0x6000303")]
		[Address(RVA = "0x49CDD0", Offset = "0x49B3D0", VA = "0x18049CDD0")]
		[PreserveSig]
		internal static extern void EOS_Sessions_SendInvite(IntPtr handle, ref Epic.OnlineServices.Sessions.SendInviteOptionsInternal options, IntPtr clientData, Epic.OnlineServices.Sessions.OnSendInviteCallbackInternal completionDelegate);

		// Token: 0x06000304 RID: 772
		[Token(Token = "0x6000304")]
		[Address(RVA = "0x49CE80", Offset = "0x49B480", VA = "0x18049CE80")]
		[PreserveSig]
		internal static extern void EOS_Sessions_StartSession(IntPtr handle, ref StartSessionOptionsInternal options, IntPtr clientData, OnStartSessionCallbackInternal completionDelegate);

		// Token: 0x06000305 RID: 773
		[Token(Token = "0x6000305")]
		[Address(RVA = "0x49CF30", Offset = "0x49B530", VA = "0x18049CF30")]
		[PreserveSig]
		internal static extern void EOS_Sessions_UnregisterPlayers(IntPtr handle, ref UnregisterPlayersOptionsInternal options, IntPtr clientData, OnUnregisterPlayersCallbackInternal completionDelegate);

		// Token: 0x06000306 RID: 774
		[Token(Token = "0x6000306")]
		[Address(RVA = "0x49D080", Offset = "0x49B680", VA = "0x18049D080")]
		[PreserveSig]
		internal static extern void EOS_Sessions_UpdateSession(IntPtr handle, ref UpdateSessionOptionsInternal options, IntPtr clientData, OnUpdateSessionCallbackInternal completionDelegate);

		// Token: 0x06000307 RID: 775
		[Token(Token = "0x6000307")]
		[Address(RVA = "0x49CFE0", Offset = "0x49B5E0", VA = "0x18049CFE0")]
		[PreserveSig]
		internal static extern Result EOS_Sessions_UpdateSessionModification(IntPtr handle, ref UpdateSessionModificationOptionsInternal options, ref IntPtr outSessionModificationHandle);

		// Token: 0x06000308 RID: 776
		[Token(Token = "0x6000308")]
		[Address(RVA = "0x49D130", Offset = "0x49B730", VA = "0x18049D130")]
		[PreserveSig]
		internal static extern Result EOS_Shutdown();

		// Token: 0x06000309 RID: 777
		[Token(Token = "0x6000309")]
		[Address(RVA = "0x49D1A0", Offset = "0x49B7A0", VA = "0x18049D1A0")]
		[PreserveSig]
		internal static extern Result EOS_Stats_CopyStatByIndex(IntPtr handle, ref CopyStatByIndexOptionsInternal options, ref IntPtr outStat);

		// Token: 0x0600030A RID: 778
		[Token(Token = "0x600030A")]
		[Address(RVA = "0x49D240", Offset = "0x49B840", VA = "0x18049D240")]
		[PreserveSig]
		internal static extern Result EOS_Stats_CopyStatByName(IntPtr handle, ref CopyStatByNameOptionsInternal options, ref IntPtr outStat);

		// Token: 0x0600030B RID: 779
		[Token(Token = "0x600030B")]
		[Address(RVA = "0x49D2E0", Offset = "0x49B8E0", VA = "0x18049D2E0")]
		[PreserveSig]
		internal static extern uint EOS_Stats_GetStatsCount(IntPtr handle, ref GetStatCountOptionsInternal options);

		// Token: 0x0600030C RID: 780
		[Token(Token = "0x600030C")]
		[Address(RVA = "0x49D370", Offset = "0x49B970", VA = "0x18049D370")]
		[PreserveSig]
		internal static extern void EOS_Stats_IngestStat(IntPtr handle, ref IngestStatOptionsInternal options, IntPtr clientData, OnIngestStatCompleteCallbackInternal completionDelegate);

		// Token: 0x0600030D RID: 781
		[Token(Token = "0x600030D")]
		[Address(RVA = "0x49D420", Offset = "0x49BA20", VA = "0x18049D420")]
		[PreserveSig]
		internal static extern void EOS_Stats_QueryStats(IntPtr handle, ref QueryStatsOptionsInternal options, IntPtr clientData, OnQueryStatsCompleteCallbackInternal completionDelegate);

		// Token: 0x0600030E RID: 782
		[Token(Token = "0x600030E")]
		[Address(RVA = "0x49D4D0", Offset = "0x49BAD0", VA = "0x18049D4D0")]
		[PreserveSig]
		internal static extern void EOS_Stats_Stat_Release(IntPtr stat);

		// Token: 0x0600030F RID: 783
		[Token(Token = "0x600030F")]
		[Address(RVA = "0x49D550", Offset = "0x49BB50", VA = "0x18049D550")]
		[PreserveSig]
		internal static extern Result EOS_TitleStorageFileTransferRequest_CancelRequest(IntPtr handle);

		// Token: 0x06000310 RID: 784
		[Token(Token = "0x6000310")]
		[Address(RVA = "0x49D5D0", Offset = "0x49BBD0", VA = "0x18049D5D0")]
		[PreserveSig]
		internal static extern Result EOS_TitleStorageFileTransferRequest_GetFileRequestState(IntPtr handle);

		// Token: 0x06000311 RID: 785
		[Token(Token = "0x6000311")]
		[Address(RVA = "0x49D650", Offset = "0x49BC50", VA = "0x18049D650")]
		[PreserveSig]
		internal static extern Result EOS_TitleStorageFileTransferRequest_GetFilename(IntPtr handle, uint filenameStringBufferSizeBytes, IntPtr outStringBuffer, ref int outStringLength);

		// Token: 0x06000312 RID: 786
		[Token(Token = "0x6000312")]
		[Address(RVA = "0x49D6F0", Offset = "0x49BCF0", VA = "0x18049D6F0")]
		[PreserveSig]
		internal static extern void EOS_TitleStorageFileTransferRequest_Release(IntPtr titleStorageFileTransferHandle);

		// Token: 0x06000313 RID: 787
		[Token(Token = "0x6000313")]
		[Address(RVA = "0x49D770", Offset = "0x49BD70", VA = "0x18049D770")]
		[PreserveSig]
		internal static extern Result EOS_TitleStorage_CopyFileMetadataAtIndex(IntPtr handle, ref Epic.OnlineServices.TitleStorage.CopyFileMetadataAtIndexOptionsInternal options, ref IntPtr outMetadata);

		// Token: 0x06000314 RID: 788
		[Token(Token = "0x6000314")]
		[Address(RVA = "0x49D810", Offset = "0x49BE10", VA = "0x18049D810")]
		[PreserveSig]
		internal static extern Result EOS_TitleStorage_CopyFileMetadataByFilename(IntPtr handle, ref Epic.OnlineServices.TitleStorage.CopyFileMetadataByFilenameOptionsInternal options, ref IntPtr outMetadata);

		// Token: 0x06000315 RID: 789
		[Token(Token = "0x6000315")]
		[Address(RVA = "0x49D8B0", Offset = "0x49BEB0", VA = "0x18049D8B0")]
		[PreserveSig]
		internal static extern Result EOS_TitleStorage_DeleteCache(IntPtr handle, ref Epic.OnlineServices.TitleStorage.DeleteCacheOptionsInternal options, IntPtr clientData, Epic.OnlineServices.TitleStorage.OnDeleteCacheCompleteCallbackInternal completionCallback);

		// Token: 0x06000316 RID: 790
		[Token(Token = "0x6000316")]
		[Address(RVA = "0x49D960", Offset = "0x49BF60", VA = "0x18049D960")]
		[PreserveSig]
		internal static extern void EOS_TitleStorage_FileMetadata_Release(IntPtr fileMetadata);

		// Token: 0x06000317 RID: 791
		[Token(Token = "0x6000317")]
		[Address(RVA = "0x49D9E0", Offset = "0x49BFE0", VA = "0x18049D9E0")]
		[PreserveSig]
		internal static extern uint EOS_TitleStorage_GetFileMetadataCount(IntPtr handle, ref Epic.OnlineServices.TitleStorage.GetFileMetadataCountOptionsInternal options);

		// Token: 0x06000318 RID: 792
		[Token(Token = "0x6000318")]
		[Address(RVA = "0x49DB20", Offset = "0x49C120", VA = "0x18049DB20")]
		[PreserveSig]
		internal static extern void EOS_TitleStorage_QueryFile(IntPtr handle, ref Epic.OnlineServices.TitleStorage.QueryFileOptionsInternal options, IntPtr clientData, Epic.OnlineServices.TitleStorage.OnQueryFileCompleteCallbackInternal completionCallback);

		// Token: 0x06000319 RID: 793
		[Token(Token = "0x6000319")]
		[Address(RVA = "0x49DA70", Offset = "0x49C070", VA = "0x18049DA70")]
		[PreserveSig]
		internal static extern void EOS_TitleStorage_QueryFileList(IntPtr handle, ref Epic.OnlineServices.TitleStorage.QueryFileListOptionsInternal options, IntPtr clientData, Epic.OnlineServices.TitleStorage.OnQueryFileListCompleteCallbackInternal completionCallback);

		// Token: 0x0600031A RID: 794
		[Token(Token = "0x600031A")]
		[Address(RVA = "0x49DBD0", Offset = "0x49C1D0", VA = "0x18049DBD0")]
		[PreserveSig]
		internal static extern IntPtr EOS_TitleStorage_ReadFile(IntPtr handle, ref Epic.OnlineServices.TitleStorage.ReadFileOptionsInternal options, IntPtr clientData, Epic.OnlineServices.TitleStorage.OnReadFileCompleteCallbackInternal completionCallback);

		// Token: 0x0600031B RID: 795
		[Token(Token = "0x600031B")]
		[Address(RVA = "0x49DC80", Offset = "0x49C280", VA = "0x18049DC80")]
		[PreserveSig]
		internal static extern Result EOS_UI_AcknowledgeEventId(IntPtr handle, ref AcknowledgeEventIdOptionsInternal options);

		// Token: 0x0600031C RID: 796
		[Token(Token = "0x600031C")]
		[Address(RVA = "0x49DD10", Offset = "0x49C310", VA = "0x18049DD10")]
		[PreserveSig]
		internal static extern ulong EOS_UI_AddNotifyDisplaySettingsUpdated(IntPtr handle, ref AddNotifyDisplaySettingsUpdatedOptionsInternal options, IntPtr clientData, OnDisplaySettingsUpdatedCallbackInternal notificationFn);

		// Token: 0x0600031D RID: 797
		[Token(Token = "0x600031D")]
		[Address(RVA = "0x49DDC0", Offset = "0x49C3C0", VA = "0x18049DDC0")]
		[PreserveSig]
		internal static extern ulong EOS_UI_AddNotifyMemoryMonitor(IntPtr handle, ref AddNotifyMemoryMonitorOptionsInternal options, IntPtr clientData, OnMemoryMonitorCallbackInternal notificationFn);

		// Token: 0x0600031E RID: 798
		[Token(Token = "0x600031E")]
		[Address(RVA = "0x49DE70", Offset = "0x49C470", VA = "0x18049DE70")]
		[PreserveSig]
		internal static extern int EOS_UI_GetFriendsExclusiveInput(IntPtr handle, ref GetFriendsExclusiveInputOptionsInternal options);

		// Token: 0x0600031F RID: 799
		[Token(Token = "0x600031F")]
		[Address(RVA = "0x49DF00", Offset = "0x49C500", VA = "0x18049DF00")]
		[PreserveSig]
		internal static extern int EOS_UI_GetFriendsVisible(IntPtr handle, ref GetFriendsVisibleOptionsInternal options);

		// Token: 0x06000320 RID: 800
		[Token(Token = "0x6000320")]
		[Address(RVA = "0x49DF90", Offset = "0x49C590", VA = "0x18049DF90")]
		[PreserveSig]
		internal static extern NotificationLocation EOS_UI_GetNotificationLocationPreference(IntPtr handle);

		// Token: 0x06000321 RID: 801
		[Token(Token = "0x6000321")]
		[Address(RVA = "0x49E010", Offset = "0x49C610", VA = "0x18049E010")]
		[PreserveSig]
		internal static extern InputStateButtonFlags EOS_UI_GetToggleFriendsButton(IntPtr handle, ref GetToggleFriendsButtonOptionsInternal options);

		// Token: 0x06000322 RID: 802
		[Token(Token = "0x6000322")]
		[Address(RVA = "0x49E0A0", Offset = "0x49C6A0", VA = "0x18049E0A0")]
		[PreserveSig]
		internal static extern KeyCombination EOS_UI_GetToggleFriendsKey(IntPtr handle, ref GetToggleFriendsKeyOptionsInternal options);

		// Token: 0x06000323 RID: 803
		[Token(Token = "0x6000323")]
		[Address(RVA = "0x49E130", Offset = "0x49C730", VA = "0x18049E130")]
		[PreserveSig]
		internal static extern void EOS_UI_HideFriends(IntPtr handle, ref HideFriendsOptionsInternal options, IntPtr clientData, OnHideFriendsCallbackInternal completionDelegate);

		// Token: 0x06000324 RID: 804
		[Token(Token = "0x6000324")]
		[Address(RVA = "0x49E1E0", Offset = "0x49C7E0", VA = "0x18049E1E0")]
		[PreserveSig]
		internal static extern int EOS_UI_IsSocialOverlayPaused(IntPtr handle, ref IsSocialOverlayPausedOptionsInternal options);

		// Token: 0x06000325 RID: 805
		[Token(Token = "0x6000325")]
		[Address(RVA = "0x49E270", Offset = "0x49C870", VA = "0x18049E270")]
		[PreserveSig]
		internal static extern int EOS_UI_IsValidButtonCombination(IntPtr handle, InputStateButtonFlags buttonCombination);

		// Token: 0x06000326 RID: 806
		[Token(Token = "0x6000326")]
		[Address(RVA = "0x49E300", Offset = "0x49C900", VA = "0x18049E300")]
		[PreserveSig]
		internal static extern int EOS_UI_IsValidKeyCombination(IntPtr handle, KeyCombination keyCombination);

		// Token: 0x06000327 RID: 807
		[Token(Token = "0x6000327")]
		[Address(RVA = "0x49E390", Offset = "0x49C990", VA = "0x18049E390")]
		[PreserveSig]
		internal static extern Result EOS_UI_PauseSocialOverlay(IntPtr handle, ref PauseSocialOverlayOptionsInternal options);

		// Token: 0x06000328 RID: 808
		[Token(Token = "0x6000328")]
		[Address(RVA = "0x49E420", Offset = "0x49CA20", VA = "0x18049E420")]
		[PreserveSig]
		internal static extern Result EOS_UI_PrePresent(IntPtr handle, ref PrePresentOptionsInternal options);

		// Token: 0x06000329 RID: 809
		[Token(Token = "0x6000329")]
		[Address(RVA = "0x49E4B0", Offset = "0x49CAB0", VA = "0x18049E4B0")]
		[PreserveSig]
		internal static extern void EOS_UI_RemoveNotifyDisplaySettingsUpdated(IntPtr handle, ulong id);

		// Token: 0x0600032A RID: 810
		[Token(Token = "0x600032A")]
		[Address(RVA = "0x49E540", Offset = "0x49CB40", VA = "0x18049E540")]
		[PreserveSig]
		internal static extern void EOS_UI_RemoveNotifyMemoryMonitor(IntPtr handle, ulong id);

		// Token: 0x0600032B RID: 811
		[Token(Token = "0x600032B")]
		[Address(RVA = "0x49E5D0", Offset = "0x49CBD0", VA = "0x18049E5D0")]
		[PreserveSig]
		internal static extern Result EOS_UI_ReportInputState(IntPtr handle, ref ReportInputStateOptionsInternal options);

		// Token: 0x0600032C RID: 812
		[Token(Token = "0x600032C")]
		[Address(RVA = "0x49E660", Offset = "0x49CC60", VA = "0x18049E660")]
		[PreserveSig]
		internal static extern Result EOS_UI_SetDisplayPreference(IntPtr handle, ref SetDisplayPreferenceOptionsInternal options);

		// Token: 0x0600032D RID: 813
		[Token(Token = "0x600032D")]
		[Address(RVA = "0x49E6F0", Offset = "0x49CCF0", VA = "0x18049E6F0")]
		[PreserveSig]
		internal static extern Result EOS_UI_SetToggleFriendsButton(IntPtr handle, ref SetToggleFriendsButtonOptionsInternal options);

		// Token: 0x0600032E RID: 814
		[Token(Token = "0x600032E")]
		[Address(RVA = "0x49E780", Offset = "0x49CD80", VA = "0x18049E780")]
		[PreserveSig]
		internal static extern Result EOS_UI_SetToggleFriendsKey(IntPtr handle, ref SetToggleFriendsKeyOptionsInternal options);

		// Token: 0x0600032F RID: 815
		[Token(Token = "0x600032F")]
		[Address(RVA = "0x49E810", Offset = "0x49CE10", VA = "0x18049E810")]
		[PreserveSig]
		internal static extern void EOS_UI_ShowBlockPlayer(IntPtr handle, ref ShowBlockPlayerOptionsInternal options, IntPtr clientData, OnShowBlockPlayerCallbackInternal completionDelegate);

		// Token: 0x06000330 RID: 816
		[Token(Token = "0x6000330")]
		[Address(RVA = "0x49E8C0", Offset = "0x49CEC0", VA = "0x18049E8C0")]
		[PreserveSig]
		internal static extern void EOS_UI_ShowFriends(IntPtr handle, ref ShowFriendsOptionsInternal options, IntPtr clientData, OnShowFriendsCallbackInternal completionDelegate);

		// Token: 0x06000331 RID: 817
		[Token(Token = "0x6000331")]
		[Address(RVA = "0x49E970", Offset = "0x49CF70", VA = "0x18049E970")]
		[PreserveSig]
		internal static extern void EOS_UI_ShowNativeProfile(IntPtr handle, ref ShowNativeProfileOptionsInternal options, IntPtr clientData, OnShowNativeProfileCallbackInternal completionDelegate);

		// Token: 0x06000332 RID: 818
		[Token(Token = "0x6000332")]
		[Address(RVA = "0x49EA20", Offset = "0x49D020", VA = "0x18049EA20")]
		[PreserveSig]
		internal static extern void EOS_UI_ShowReportPlayer(IntPtr handle, ref ShowReportPlayerOptionsInternal options, IntPtr clientData, OnShowReportPlayerCallbackInternal completionDelegate);

		// Token: 0x06000333 RID: 819
		[Token(Token = "0x6000333")]
		[Address(RVA = "0x49EAD0", Offset = "0x49D0D0", VA = "0x18049EAD0")]
		[PreserveSig]
		internal static extern void EOS_UserInfo_BestDisplayName_Release(IntPtr bestDisplayName);

		// Token: 0x06000334 RID: 820
		[Token(Token = "0x6000334")]
		[Address(RVA = "0x49EBF0", Offset = "0x49D1F0", VA = "0x18049EBF0")]
		[PreserveSig]
		internal static extern Result EOS_UserInfo_CopyBestDisplayName(IntPtr handle, ref CopyBestDisplayNameOptionsInternal options, ref IntPtr outBestDisplayName);

		// Token: 0x06000335 RID: 821
		[Token(Token = "0x6000335")]
		[Address(RVA = "0x49EB50", Offset = "0x49D150", VA = "0x18049EB50")]
		[PreserveSig]
		internal static extern Result EOS_UserInfo_CopyBestDisplayNameWithPlatform(IntPtr handle, ref CopyBestDisplayNameWithPlatformOptionsInternal options, ref IntPtr outBestDisplayName);

		// Token: 0x06000336 RID: 822
		[Token(Token = "0x6000336")]
		[Address(RVA = "0x49EC90", Offset = "0x49D290", VA = "0x18049EC90")]
		[PreserveSig]
		internal static extern Result EOS_UserInfo_CopyExternalUserInfoByAccountId(IntPtr handle, ref CopyExternalUserInfoByAccountIdOptionsInternal options, ref IntPtr outExternalUserInfo);

		// Token: 0x06000337 RID: 823
		[Token(Token = "0x6000337")]
		[Address(RVA = "0x49ED30", Offset = "0x49D330", VA = "0x18049ED30")]
		[PreserveSig]
		internal static extern Result EOS_UserInfo_CopyExternalUserInfoByAccountType(IntPtr handle, ref CopyExternalUserInfoByAccountTypeOptionsInternal options, ref IntPtr outExternalUserInfo);

		// Token: 0x06000338 RID: 824
		[Token(Token = "0x6000338")]
		[Address(RVA = "0x49EDD0", Offset = "0x49D3D0", VA = "0x18049EDD0")]
		[PreserveSig]
		internal static extern Result EOS_UserInfo_CopyExternalUserInfoByIndex(IntPtr handle, ref CopyExternalUserInfoByIndexOptionsInternal options, ref IntPtr outExternalUserInfo);

		// Token: 0x06000339 RID: 825
		[Token(Token = "0x6000339")]
		[Address(RVA = "0x49EE70", Offset = "0x49D470", VA = "0x18049EE70")]
		[PreserveSig]
		internal static extern Result EOS_UserInfo_CopyUserInfo(IntPtr handle, ref CopyUserInfoOptionsInternal options, ref IntPtr outUserInfo);

		// Token: 0x0600033A RID: 826
		[Token(Token = "0x600033A")]
		[Address(RVA = "0x49EF10", Offset = "0x49D510", VA = "0x18049EF10")]
		[PreserveSig]
		internal static extern void EOS_UserInfo_ExternalUserInfo_Release(IntPtr externalUserInfo);

		// Token: 0x0600033B RID: 827
		[Token(Token = "0x600033B")]
		[Address(RVA = "0x49EF90", Offset = "0x49D590", VA = "0x18049EF90")]
		[PreserveSig]
		internal static extern uint EOS_UserInfo_GetExternalUserInfoCount(IntPtr handle, ref GetExternalUserInfoCountOptionsInternal options);

		// Token: 0x0600033C RID: 828
		[Token(Token = "0x600033C")]
		[Address(RVA = "0x49F020", Offset = "0x49D620", VA = "0x18049F020")]
		[PreserveSig]
		internal static extern uint EOS_UserInfo_GetLocalPlatformType(IntPtr handle, ref GetLocalPlatformTypeOptionsInternal options);

		// Token: 0x0600033D RID: 829
		[Token(Token = "0x600033D")]
		[Address(RVA = "0x49F210", Offset = "0x49D810", VA = "0x18049F210")]
		[PreserveSig]
		internal static extern void EOS_UserInfo_QueryUserInfo(IntPtr handle, ref QueryUserInfoOptionsInternal options, IntPtr clientData, OnQueryUserInfoCallbackInternal completionDelegate);

		// Token: 0x0600033E RID: 830
		[Token(Token = "0x600033E")]
		[Address(RVA = "0x49F0B0", Offset = "0x49D6B0", VA = "0x18049F0B0")]
		[PreserveSig]
		internal static extern void EOS_UserInfo_QueryUserInfoByDisplayName(IntPtr handle, ref QueryUserInfoByDisplayNameOptionsInternal options, IntPtr clientData, OnQueryUserInfoByDisplayNameCallbackInternal completionDelegate);

		// Token: 0x0600033F RID: 831
		[Token(Token = "0x600033F")]
		[Address(RVA = "0x49F160", Offset = "0x49D760", VA = "0x18049F160")]
		[PreserveSig]
		internal static extern void EOS_UserInfo_QueryUserInfoByExternalAccount(IntPtr handle, ref QueryUserInfoByExternalAccountOptionsInternal options, IntPtr clientData, OnQueryUserInfoByExternalAccountCallbackInternal completionDelegate);

		// Token: 0x06000340 RID: 832
		[Token(Token = "0x6000340")]
		[Address(RVA = "0x49F2C0", Offset = "0x49D8C0", VA = "0x18049F2C0")]
		[PreserveSig]
		internal static extern void EOS_UserInfo_Release(IntPtr userInfo);
	}
}
