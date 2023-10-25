using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Lobby
{
	// Token: 0x0200041B RID: 1051
	[Token(Token = "0x200041B")]
	public sealed class LobbySearch : Handle
	{
		// Token: 0x06001BCD RID: 7117 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001BCD")]
		[Address(RVA = "0x427FC0", Offset = "0x4265C0", VA = "0x180427FC0")]
		public LobbySearch()
		{
		}

		// Token: 0x06001BCE RID: 7118 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001BCE")]
		[Address(RVA = "0x4B8FB0", Offset = "0x4B75B0", VA = "0x1804B8FB0")]
		public LobbySearch(IntPtr innerHandle)
		{
		}

		// Token: 0x06001BCF RID: 7119 RVA: 0x00007D0C File Offset: 0x00005F0C
		[Token(Token = "0x6001BCF")]
		[Address(RVA = "0x52C500", Offset = "0x52AB00", VA = "0x18052C500")]
		public Result CopySearchResultByIndex(ref LobbySearchCopySearchResultByIndexOptions options, out LobbyDetails outLobbyDetailsHandle)
		{
			return Result.Success;
		}

		// Token: 0x06001BD0 RID: 7120 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001BD0")]
		[Address(RVA = "0x52C5D0", Offset = "0x52ABD0", VA = "0x18052C5D0")]
		public void Find(ref LobbySearchFindOptions options, object clientData, LobbySearchOnFindCallback completionDelegate)
		{
		}

		// Token: 0x06001BD1 RID: 7121 RVA: 0x00007D24 File Offset: 0x00005F24
		[Token(Token = "0x6001BD1")]
		[Address(RVA = "0x52C7D0", Offset = "0x52ADD0", VA = "0x18052C7D0")]
		public uint GetSearchResultCount(ref LobbySearchGetSearchResultCountOptions options)
		{
			return 0U;
		}

		// Token: 0x06001BD2 RID: 7122 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001BD2")]
		[Address(RVA = "0x52C8F0", Offset = "0x52AEF0", VA = "0x18052C8F0")]
		public void Release()
		{
		}

		// Token: 0x06001BD3 RID: 7123 RVA: 0x00007D3C File Offset: 0x00005F3C
		[Token(Token = "0x6001BD3")]
		[Address(RVA = "0x52C900", Offset = "0x52AF00", VA = "0x18052C900")]
		public Result RemoveParameter(ref LobbySearchRemoveParameterOptions options)
		{
			return Result.Success;
		}

		// Token: 0x06001BD4 RID: 7124 RVA: 0x00007D54 File Offset: 0x00005F54
		[Token(Token = "0x6001BD4")]
		[Address(RVA = "0x52C9F0", Offset = "0x52AFF0", VA = "0x18052C9F0")]
		public Result SetLobbyId(ref LobbySearchSetLobbyIdOptions options)
		{
			return Result.Success;
		}

		// Token: 0x06001BD5 RID: 7125 RVA: 0x00007D6C File Offset: 0x00005F6C
		[Token(Token = "0x6001BD5")]
		[Address(RVA = "0x52CAD0", Offset = "0x52B0D0", VA = "0x18052CAD0")]
		public Result SetMaxResults(ref LobbySearchSetMaxResultsOptions options)
		{
			return Result.Success;
		}

		// Token: 0x06001BD6 RID: 7126 RVA: 0x00007D84 File Offset: 0x00005F84
		[Token(Token = "0x6001BD6")]
		[Address(RVA = "0x52CB60", Offset = "0x52B160", VA = "0x18052CB60")]
		public Result SetParameter(ref LobbySearchSetParameterOptions options)
		{
			return Result.Success;
		}

		// Token: 0x06001BD7 RID: 7127 RVA: 0x00007D9C File Offset: 0x00005F9C
		[Token(Token = "0x6001BD7")]
		[Address(RVA = "0x52CC90", Offset = "0x52B290", VA = "0x18052CC90")]
		public Result SetTargetUserId(ref LobbySearchSetTargetUserIdOptions options)
		{
			return Result.Success;
		}

		// Token: 0x06001BD8 RID: 7128 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001BD8")]
		[Address(RVA = "0x52C850", Offset = "0x52AE50", VA = "0x18052C850")]
		[MonoPInvokeCallback(typeof(LobbySearchOnFindCallbackInternal))]
		internal static void OnFindCallbackInternalImplementation(ref LobbySearchFindCallbackInfoInternal data)
		{
		}

		// Token: 0x04000CAB RID: 3243
		[Token(Token = "0x4000CAB")]
		public const int LobbysearchCopysearchresultbyindexApiLatest = 1;

		// Token: 0x04000CAC RID: 3244
		[Token(Token = "0x4000CAC")]
		public const int LobbysearchFindApiLatest = 1;

		// Token: 0x04000CAD RID: 3245
		[Token(Token = "0x4000CAD")]
		public const int LobbysearchGetsearchresultcountApiLatest = 1;

		// Token: 0x04000CAE RID: 3246
		[Token(Token = "0x4000CAE")]
		public const int LobbysearchRemoveparameterApiLatest = 1;

		// Token: 0x04000CAF RID: 3247
		[Token(Token = "0x4000CAF")]
		public const int LobbysearchSetlobbyidApiLatest = 1;

		// Token: 0x04000CB0 RID: 3248
		[Token(Token = "0x4000CB0")]
		public const int LobbysearchSetmaxresultsApiLatest = 1;

		// Token: 0x04000CB1 RID: 3249
		[Token(Token = "0x4000CB1")]
		public const int LobbysearchSetparameterApiLatest = 1;

		// Token: 0x04000CB2 RID: 3250
		[Token(Token = "0x4000CB2")]
		public const int LobbysearchSettargetuseridApiLatest = 1;
	}
}
