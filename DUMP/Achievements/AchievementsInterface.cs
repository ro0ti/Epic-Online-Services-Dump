using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Achievements
{
	// Token: 0x0200073E RID: 1854
	[Token(Token = "0x200073E")]
	public sealed class AchievementsInterface : Handle
	{
		// Token: 0x06002F9B RID: 12187 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002F9B")]
		[Address(RVA = "0x427FC0", Offset = "0x4265C0", VA = "0x180427FC0")]
		public AchievementsInterface()
		{
		}

		// Token: 0x06002F9C RID: 12188 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002F9C")]
		[Address(RVA = "0x4B8FB0", Offset = "0x4B75B0", VA = "0x1804B8FB0")]
		public AchievementsInterface(IntPtr innerHandle)
		{
		}

		// Token: 0x06002F9D RID: 12189 RVA: 0x0000C614 File Offset: 0x0000A814
		[Token(Token = "0x6002F9D")]
		[Address(RVA = "0x583560", Offset = "0x581B60", VA = "0x180583560")]
		public ulong AddNotifyAchievementsUnlocked(ref AddNotifyAchievementsUnlockedOptions options, object clientData, OnAchievementsUnlockedCallback notificationFn)
		{
			return 0UL;
		}

		// Token: 0x06002F9E RID: 12190 RVA: 0x0000C62C File Offset: 0x0000A82C
		[Token(Token = "0x6002F9E")]
		[Address(RVA = "0x5833A0", Offset = "0x5819A0", VA = "0x1805833A0")]
		public ulong AddNotifyAchievementsUnlockedV2(ref AddNotifyAchievementsUnlockedV2Options options, object clientData, OnAchievementsUnlockedCallbackV2 notificationFn)
		{
			return 0UL;
		}

		// Token: 0x06002F9F RID: 12191 RVA: 0x0000C644 File Offset: 0x0000A844
		[Token(Token = "0x6002F9F")]
		[Address(RVA = "0x583720", Offset = "0x581D20", VA = "0x180583720")]
		public Result CopyAchievementDefinitionByAchievementId(ref CopyAchievementDefinitionByAchievementIdOptions options, out Definition? outDefinition)
		{
			return Result.Success;
		}

		// Token: 0x06002FA0 RID: 12192 RVA: 0x0000C65C File Offset: 0x0000A85C
		[Token(Token = "0x6002FA0")]
		[Address(RVA = "0x583850", Offset = "0x581E50", VA = "0x180583850")]
		public Result CopyAchievementDefinitionByIndex(ref CopyAchievementDefinitionByIndexOptions options, out Definition? outDefinition)
		{
			return Result.Success;
		}

		// Token: 0x06002FA1 RID: 12193 RVA: 0x0000C674 File Offset: 0x0000A874
		[Token(Token = "0x6002FA1")]
		[Address(RVA = "0x583940", Offset = "0x581F40", VA = "0x180583940")]
		public Result CopyAchievementDefinitionV2ByAchievementId(ref CopyAchievementDefinitionV2ByAchievementIdOptions options, out DefinitionV2? outDefinition)
		{
			return Result.Success;
		}

		// Token: 0x06002FA2 RID: 12194 RVA: 0x0000C68C File Offset: 0x0000A88C
		[Token(Token = "0x6002FA2")]
		[Address(RVA = "0x583A70", Offset = "0x582070", VA = "0x180583A70")]
		public Result CopyAchievementDefinitionV2ByIndex(ref CopyAchievementDefinitionV2ByIndexOptions options, out DefinitionV2? outDefinition)
		{
			return Result.Success;
		}

		// Token: 0x06002FA3 RID: 12195 RVA: 0x0000C6A4 File Offset: 0x0000A8A4
		[Token(Token = "0x6002FA3")]
		[Address(RVA = "0x583B60", Offset = "0x582160", VA = "0x180583B60")]
		public Result CopyPlayerAchievementByAchievementId(ref CopyPlayerAchievementByAchievementIdOptions options, out PlayerAchievement? outAchievement)
		{
			return Result.Success;
		}

		// Token: 0x06002FA4 RID: 12196 RVA: 0x0000C6BC File Offset: 0x0000A8BC
		[Token(Token = "0x6002FA4")]
		[Address(RVA = "0x583C60", Offset = "0x582260", VA = "0x180583C60")]
		public Result CopyPlayerAchievementByIndex(ref CopyPlayerAchievementByIndexOptions options, out PlayerAchievement? outAchievement)
		{
			return Result.Success;
		}

		// Token: 0x06002FA5 RID: 12197 RVA: 0x0000C6D4 File Offset: 0x0000A8D4
		[Token(Token = "0x6002FA5")]
		[Address(RVA = "0x583D60", Offset = "0x582360", VA = "0x180583D60")]
		public Result CopyUnlockedAchievementByAchievementId(ref CopyUnlockedAchievementByAchievementIdOptions options, out UnlockedAchievement? outAchievement)
		{
			return Result.Success;
		}

		// Token: 0x06002FA6 RID: 12198 RVA: 0x0000C6EC File Offset: 0x0000A8EC
		[Token(Token = "0x6002FA6")]
		[Address(RVA = "0x583E60", Offset = "0x582460", VA = "0x180583E60")]
		public Result CopyUnlockedAchievementByIndex(ref CopyUnlockedAchievementByIndexOptions options, out UnlockedAchievement? outAchievement)
		{
			return Result.Success;
		}

		// Token: 0x06002FA7 RID: 12199 RVA: 0x0000C704 File Offset: 0x0000A904
		[Token(Token = "0x6002FA7")]
		[Address(RVA = "0x583FB0", Offset = "0x5825B0", VA = "0x180583FB0")]
		public uint GetAchievementDefinitionCount(ref GetAchievementDefinitionCountOptions options)
		{
			return 0U;
		}

		// Token: 0x06002FA8 RID: 12200 RVA: 0x0000C71C File Offset: 0x0000A91C
		[Token(Token = "0x6002FA8")]
		[Address(RVA = "0x584030", Offset = "0x582630", VA = "0x180584030")]
		public uint GetPlayerAchievementCount(ref GetPlayerAchievementCountOptions options)
		{
			return 0U;
		}

		// Token: 0x06002FA9 RID: 12201 RVA: 0x0000C734 File Offset: 0x0000A934
		[Token(Token = "0x6002FA9")]
		[Address(RVA = "0x584110", Offset = "0x582710", VA = "0x180584110")]
		public uint GetUnlockedAchievementCount(ref GetUnlockedAchievementCountOptions options)
		{
			return 0U;
		}

		// Token: 0x06002FAA RID: 12202 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002FAA")]
		[Address(RVA = "0x584520", Offset = "0x582B20", VA = "0x180584520")]
		public void QueryDefinitions(ref QueryDefinitionsOptions options, object clientData, OnQueryDefinitionsCompleteCallback completionDelegate)
		{
		}

		// Token: 0x06002FAB RID: 12203 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002FAB")]
		[Address(RVA = "0x5846F0", Offset = "0x582CF0", VA = "0x1805846F0")]
		public void QueryPlayerAchievements(ref QueryPlayerAchievementsOptions options, object clientData, OnQueryPlayerAchievementsCompleteCallback completionDelegate)
		{
		}

		// Token: 0x06002FAC RID: 12204 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002FAC")]
		[Address(RVA = "0x5848C0", Offset = "0x582EC0", VA = "0x1805848C0")]
		public void RemoveNotifyAchievementsUnlocked(ulong inId)
		{
		}

		// Token: 0x06002FAD RID: 12205 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002FAD")]
		[Address(RVA = "0x584930", Offset = "0x582F30", VA = "0x180584930")]
		public void UnlockAchievements(ref UnlockAchievementsOptions options, object clientData, OnUnlockAchievementsCompleteCallback completionDelegate)
		{
		}

		// Token: 0x06002FAE RID: 12206 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002FAE")]
		[Address(RVA = "0x5841F0", Offset = "0x5827F0", VA = "0x1805841F0")]
		[MonoPInvokeCallback(typeof(OnAchievementsUnlockedCallbackInternal))]
		internal static void OnAchievementsUnlockedCallbackInternalImplementation(ref OnAchievementsUnlockedCallbackInfoInternal data)
		{
		}

		// Token: 0x06002FAF RID: 12207 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002FAF")]
		[Address(RVA = "0x584290", Offset = "0x582890", VA = "0x180584290")]
		[MonoPInvokeCallback(typeof(OnAchievementsUnlockedCallbackV2Internal))]
		internal static void OnAchievementsUnlockedCallbackV2InternalImplementation(ref OnAchievementsUnlockedCallbackV2InfoInternal data)
		{
		}

		// Token: 0x06002FB0 RID: 12208 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002FB0")]
		[Address(RVA = "0x584340", Offset = "0x582940", VA = "0x180584340")]
		[MonoPInvokeCallback(typeof(OnQueryDefinitionsCompleteCallbackInternal))]
		internal static void OnQueryDefinitionsCompleteCallbackInternalImplementation(ref OnQueryDefinitionsCompleteCallbackInfoInternal data)
		{
		}

		// Token: 0x06002FB1 RID: 12209 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002FB1")]
		[Address(RVA = "0x5843E0", Offset = "0x5829E0", VA = "0x1805843E0")]
		[MonoPInvokeCallback(typeof(OnQueryPlayerAchievementsCompleteCallbackInternal))]
		internal static void OnQueryPlayerAchievementsCompleteCallbackInternalImplementation(ref OnQueryPlayerAchievementsCompleteCallbackInfoInternal data)
		{
		}

		// Token: 0x06002FB2 RID: 12210 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002FB2")]
		[Address(RVA = "0x584480", Offset = "0x582A80", VA = "0x180584480")]
		[MonoPInvokeCallback(typeof(OnUnlockAchievementsCompleteCallbackInternal))]
		internal static void OnUnlockAchievementsCompleteCallbackInternalImplementation(ref OnUnlockAchievementsCompleteCallbackInfoInternal data)
		{
		}

		// Token: 0x04001563 RID: 5475
		[Token(Token = "0x4001563")]
		public const int AchievementUnlocktimeUndefined = -1;

		// Token: 0x04001564 RID: 5476
		[Token(Token = "0x4001564")]
		public const int AddnotifyachievementsunlockedApiLatest = 1;

		// Token: 0x04001565 RID: 5477
		[Token(Token = "0x4001565")]
		public const int Addnotifyachievementsunlockedv2ApiLatest = 2;

		// Token: 0x04001566 RID: 5478
		[Token(Token = "0x4001566")]
		public const int Copyachievementdefinitionv2ByachievementidApiLatest = 2;

		// Token: 0x04001567 RID: 5479
		[Token(Token = "0x4001567")]
		public const int Copyachievementdefinitionv2ByindexApiLatest = 2;

		// Token: 0x04001568 RID: 5480
		[Token(Token = "0x4001568")]
		public const int CopydefinitionbyachievementidApiLatest = 1;

		// Token: 0x04001569 RID: 5481
		[Token(Token = "0x4001569")]
		public const int CopydefinitionbyindexApiLatest = 1;

		// Token: 0x0400156A RID: 5482
		[Token(Token = "0x400156A")]
		public const int Copydefinitionv2ByachievementidApiLatest = 2;

		// Token: 0x0400156B RID: 5483
		[Token(Token = "0x400156B")]
		public const int Copydefinitionv2ByindexApiLatest = 2;

		// Token: 0x0400156C RID: 5484
		[Token(Token = "0x400156C")]
		public const int CopyplayerachievementbyachievementidApiLatest = 2;

		// Token: 0x0400156D RID: 5485
		[Token(Token = "0x400156D")]
		public const int CopyplayerachievementbyindexApiLatest = 2;

		// Token: 0x0400156E RID: 5486
		[Token(Token = "0x400156E")]
		public const int CopyunlockedachievementbyachievementidApiLatest = 1;

		// Token: 0x0400156F RID: 5487
		[Token(Token = "0x400156F")]
		public const int CopyunlockedachievementbyindexApiLatest = 1;

		// Token: 0x04001570 RID: 5488
		[Token(Token = "0x4001570")]
		public const int DefinitionApiLatest = 1;

		// Token: 0x04001571 RID: 5489
		[Token(Token = "0x4001571")]
		public const int Definitionv2ApiLatest = 2;

		// Token: 0x04001572 RID: 5490
		[Token(Token = "0x4001572")]
		public const int GetachievementdefinitioncountApiLatest = 1;

		// Token: 0x04001573 RID: 5491
		[Token(Token = "0x4001573")]
		public const int GetplayerachievementcountApiLatest = 1;

		// Token: 0x04001574 RID: 5492
		[Token(Token = "0x4001574")]
		public const int GetunlockedachievementcountApiLatest = 1;

		// Token: 0x04001575 RID: 5493
		[Token(Token = "0x4001575")]
		public const int PlayerachievementApiLatest = 2;

		// Token: 0x04001576 RID: 5494
		[Token(Token = "0x4001576")]
		public const int PlayerstatinfoApiLatest = 1;

		// Token: 0x04001577 RID: 5495
		[Token(Token = "0x4001577")]
		public const int QuerydefinitionsApiLatest = 3;

		// Token: 0x04001578 RID: 5496
		[Token(Token = "0x4001578")]
		public const int QueryplayerachievementsApiLatest = 2;

		// Token: 0x04001579 RID: 5497
		[Token(Token = "0x4001579")]
		public const int StatthresholdApiLatest = 1;

		// Token: 0x0400157A RID: 5498
		[Token(Token = "0x400157A")]
		public const int StatthresholdsApiLatest = 1;

		// Token: 0x0400157B RID: 5499
		[Token(Token = "0x400157B")]
		public const int UnlockachievementsApiLatest = 1;

		// Token: 0x0400157C RID: 5500
		[Token(Token = "0x400157C")]
		public const int UnlockedachievementApiLatest = 1;
	}
}
