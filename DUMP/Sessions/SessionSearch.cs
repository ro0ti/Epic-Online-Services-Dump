using System;


namespace Epic.OnlineServices.Sessions
{
	// Token: 0x0200017F RID: 383
	[Token(Token = "0x200017F")]
	public sealed class SessionSearch : Handle
	{
		// Token: 0x06000B2E RID: 2862 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B2E")]
		[Address(RVA = "0x427FC0", Offset = "0x4265C0", VA = "0x180427FC0")]
		public SessionSearch()
		{
		}

		// Token: 0x06000B2F RID: 2863 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B2F")]
		[Address(RVA = "0x4B8FB0", Offset = "0x4B75B0", VA = "0x1804B8FB0")]
		public SessionSearch(IntPtr innerHandle)
		{
		}

		// Token: 0x06000B30 RID: 2864 RVA: 0x0000404C File Offset: 0x0000224C
		[Token(Token = "0x6000B30")]
		[Address(RVA = "0x4CCDC0", Offset = "0x4CB3C0", VA = "0x1804CCDC0")]
		public Result CopySearchResultByIndex(ref SessionSearchCopySearchResultByIndexOptions options, out SessionDetails outSessionHandle)
		{
			return Result.Success;
		}

		// Token: 0x06000B31 RID: 2865 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B31")]
		[Address(RVA = "0x4CCE90", Offset = "0x4CB490", VA = "0x1804CCE90")]
		public void Find(ref SessionSearchFindOptions options, object clientData, SessionSearchOnFindCallback completionDelegate)
		{
		}

		// Token: 0x06000B32 RID: 2866 RVA: 0x00004064 File Offset: 0x00002264
		[Token(Token = "0x6000B32")]
		[Address(RVA = "0x4CD090", Offset = "0x4CB690", VA = "0x1804CD090")]
		public uint GetSearchResultCount(ref SessionSearchGetSearchResultCountOptions options)
		{
			return 0U;
		}

		// Token: 0x06000B33 RID: 2867 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B33")]
		[Address(RVA = "0x4CD1B0", Offset = "0x4CB7B0", VA = "0x1804CD1B0")]
		public void Release()
		{
		}

		// Token: 0x06000B34 RID: 2868 RVA: 0x0000407C File Offset: 0x0000227C
		[Token(Token = "0x6000B34")]
		[Address(RVA = "0x4CD1C0", Offset = "0x4CB7C0", VA = "0x1804CD1C0")]
		public Result RemoveParameter(ref SessionSearchRemoveParameterOptions options)
		{
			return Result.Success;
		}

		// Token: 0x06000B35 RID: 2869 RVA: 0x00004094 File Offset: 0x00002294
		[Token(Token = "0x6000B35")]
		[Address(RVA = "0x4CD2B0", Offset = "0x4CB8B0", VA = "0x1804CD2B0")]
		public Result SetMaxResults(ref SessionSearchSetMaxResultsOptions options)
		{
			return Result.Success;
		}

		// Token: 0x06000B36 RID: 2870 RVA: 0x000040AC File Offset: 0x000022AC
		[Token(Token = "0x6000B36")]
		[Address(RVA = "0x4CD340", Offset = "0x4CB940", VA = "0x1804CD340")]
		public Result SetParameter(ref SessionSearchSetParameterOptions options)
		{
			return Result.Success;
		}

		// Token: 0x06000B37 RID: 2871 RVA: 0x000040C4 File Offset: 0x000022C4
		[Token(Token = "0x6000B37")]
		[Address(RVA = "0x4CD470", Offset = "0x4CBA70", VA = "0x1804CD470")]
		public Result SetSessionId(ref SessionSearchSetSessionIdOptions options)
		{
			return Result.Success;
		}

		// Token: 0x06000B38 RID: 2872 RVA: 0x000040DC File Offset: 0x000022DC
		[Token(Token = "0x6000B38")]
		[Address(RVA = "0x4CD550", Offset = "0x4CBB50", VA = "0x1804CD550")]
		public Result SetTargetUserId(ref SessionSearchSetTargetUserIdOptions options)
		{
			return Result.Success;
		}

		// Token: 0x06000B39 RID: 2873 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B39")]
		[Address(RVA = "0x4CD110", Offset = "0x4CB710", VA = "0x1804CD110")]
		[MonoPInvokeCallback(typeof(SessionSearchOnFindCallbackInternal))]
		internal static void OnFindCallbackInternalImplementation(ref SessionSearchFindCallbackInfoInternal data)
		{
		}

		// Token: 0x0400052D RID: 1325
		[Token(Token = "0x400052D")]
		public const int SessionsearchCopysearchresultbyindexApiLatest = 1;

		// Token: 0x0400052E RID: 1326
		[Token(Token = "0x400052E")]
		public const int SessionsearchFindApiLatest = 2;

		// Token: 0x0400052F RID: 1327
		[Token(Token = "0x400052F")]
		public const int SessionsearchGetsearchresultcountApiLatest = 1;

		// Token: 0x04000530 RID: 1328
		[Token(Token = "0x4000530")]
		public const int SessionsearchRemoveparameterApiLatest = 1;

		// Token: 0x04000531 RID: 1329
		[Token(Token = "0x4000531")]
		public const int SessionsearchSetmaxsearchresultsApiLatest = 1;

		// Token: 0x04000532 RID: 1330
		[Token(Token = "0x4000532")]
		public const int SessionsearchSetparameterApiLatest = 1;

		// Token: 0x04000533 RID: 1331
		[Token(Token = "0x4000533")]
		public const int SessionsearchSetsessionidApiLatest = 1;

		// Token: 0x04000534 RID: 1332
		[Token(Token = "0x4000534")]
		public const int SessionsearchSettargetuseridApiLatest = 1;
	}
}
