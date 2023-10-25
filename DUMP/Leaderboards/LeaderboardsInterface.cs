using System;


namespace Epic.OnlineServices.Leaderboards
{
	// Token: 0x02000493 RID: 1171
	[Token(Token = "0x2000493")]
	public sealed class LeaderboardsInterface : Handle
	{
		// Token: 0x06001E30 RID: 7728 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001E30")]
		[Address(RVA = "0x427FC0", Offset = "0x4265C0", VA = "0x180427FC0")]
		public LeaderboardsInterface()
		{
		}

		// Token: 0x06001E31 RID: 7729 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001E31")]
		[Address(RVA = "0x4B8FB0", Offset = "0x4B75B0", VA = "0x1804B8FB0")]
		public LeaderboardsInterface(IntPtr innerHandle)
		{
		}

		// Token: 0x06001E32 RID: 7730 RVA: 0x00008384 File Offset: 0x00006584
		[Token(Token = "0x6001E32")]
		[Address(RVA = "0x526790", Offset = "0x524D90", VA = "0x180526790")]
		public Result CopyLeaderboardDefinitionByIndex(ref CopyLeaderboardDefinitionByIndexOptions options, out Definition? outLeaderboardDefinition)
		{
			return Result.Success;
		}

		// Token: 0x06001E33 RID: 7731 RVA: 0x0000839C File Offset: 0x0000659C
		[Token(Token = "0x6001E33")]
		[Address(RVA = "0x526880", Offset = "0x524E80", VA = "0x180526880")]
		public Result CopyLeaderboardDefinitionByLeaderboardId(ref CopyLeaderboardDefinitionByLeaderboardIdOptions options, out Definition? outLeaderboardDefinition)
		{
			return Result.Success;
		}

		// Token: 0x06001E34 RID: 7732 RVA: 0x000083B4 File Offset: 0x000065B4
		[Token(Token = "0x6001E34")]
		[Address(RVA = "0x5269B0", Offset = "0x524FB0", VA = "0x1805269B0")]
		public Result CopyLeaderboardRecordByIndex(ref CopyLeaderboardRecordByIndexOptions options, out LeaderboardRecord? outLeaderboardRecord)
		{
			return Result.Success;
		}

		// Token: 0x06001E35 RID: 7733 RVA: 0x000083CC File Offset: 0x000065CC
		[Token(Token = "0x6001E35")]
		[Address(RVA = "0x526AA0", Offset = "0x5250A0", VA = "0x180526AA0")]
		public Result CopyLeaderboardRecordByUserId(ref CopyLeaderboardRecordByUserIdOptions options, out LeaderboardRecord? outLeaderboardRecord)
		{
			return Result.Success;
		}

		// Token: 0x06001E36 RID: 7734 RVA: 0x000083E4 File Offset: 0x000065E4
		[Token(Token = "0x6001E36")]
		[Address(RVA = "0x526BD0", Offset = "0x5251D0", VA = "0x180526BD0")]
		public Result CopyLeaderboardUserScoreByIndex(ref CopyLeaderboardUserScoreByIndexOptions options, out LeaderboardUserScore? outLeaderboardUserScore)
		{
			return Result.Success;
		}

		// Token: 0x06001E37 RID: 7735 RVA: 0x000083FC File Offset: 0x000065FC
		[Token(Token = "0x6001E37")]
		[Address(RVA = "0x526D10", Offset = "0x525310", VA = "0x180526D10")]
		public Result CopyLeaderboardUserScoreByUserId(ref CopyLeaderboardUserScoreByUserIdOptions options, out LeaderboardUserScore? outLeaderboardUserScore)
		{
			return Result.Success;
		}

		// Token: 0x06001E38 RID: 7736 RVA: 0x00008414 File Offset: 0x00006614
		[Token(Token = "0x6001E38")]
		[Address(RVA = "0x526E10", Offset = "0x525410", VA = "0x180526E10")]
		public uint GetLeaderboardDefinitionCount(ref GetLeaderboardDefinitionCountOptions options)
		{
			return 0U;
		}

		// Token: 0x06001E39 RID: 7737 RVA: 0x0000842C File Offset: 0x0000662C
		[Token(Token = "0x6001E39")]
		[Address(RVA = "0x526E90", Offset = "0x525490", VA = "0x180526E90")]
		public uint GetLeaderboardRecordCount(ref GetLeaderboardRecordCountOptions options)
		{
			return 0U;
		}

		// Token: 0x06001E3A RID: 7738 RVA: 0x00008444 File Offset: 0x00006644
		[Token(Token = "0x6001E3A")]
		[Address(RVA = "0x526F10", Offset = "0x525510", VA = "0x180526F10")]
		public uint GetLeaderboardUserScoreCount(ref GetLeaderboardUserScoreCountOptions options)
		{
			return 0U;
		}

		// Token: 0x06001E3B RID: 7739 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001E3B")]
		[Address(RVA = "0x5271D0", Offset = "0x5257D0", VA = "0x1805271D0")]
		public void QueryLeaderboardDefinitions(ref QueryLeaderboardDefinitionsOptions options, object clientData, OnQueryLeaderboardDefinitionsCompleteCallback completionDelegate)
		{
		}

		// Token: 0x06001E3C RID: 7740 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001E3C")]
		[Address(RVA = "0x5273A0", Offset = "0x5259A0", VA = "0x1805273A0")]
		public void QueryLeaderboardRanks(ref QueryLeaderboardRanksOptions options, object clientData, OnQueryLeaderboardRanksCompleteCallback completionDelegate)
		{
		}

		// Token: 0x06001E3D RID: 7741 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001E3D")]
		[Address(RVA = "0x527570", Offset = "0x525B70", VA = "0x180527570")]
		public void QueryLeaderboardUserScores(ref QueryLeaderboardUserScoresOptions options, object clientData, OnQueryLeaderboardUserScoresCompleteCallback completionDelegate)
		{
		}

		// Token: 0x06001E3E RID: 7742 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001E3E")]
		[Address(RVA = "0x526FF0", Offset = "0x5255F0", VA = "0x180526FF0")]
		[MonoPInvokeCallback(typeof(OnQueryLeaderboardDefinitionsCompleteCallbackInternal))]
		internal static void OnQueryLeaderboardDefinitionsCompleteCallbackInternalImplementation(ref OnQueryLeaderboardDefinitionsCompleteCallbackInfoInternal data)
		{
		}

		// Token: 0x06001E3F RID: 7743 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001E3F")]
		[Address(RVA = "0x527090", Offset = "0x525690", VA = "0x180527090")]
		[MonoPInvokeCallback(typeof(OnQueryLeaderboardRanksCompleteCallbackInternal))]
		internal static void OnQueryLeaderboardRanksCompleteCallbackInternalImplementation(ref OnQueryLeaderboardRanksCompleteCallbackInfoInternal data)
		{
		}

		// Token: 0x06001E40 RID: 7744 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001E40")]
		[Address(RVA = "0x527130", Offset = "0x525730", VA = "0x180527130")]
		[MonoPInvokeCallback(typeof(OnQueryLeaderboardUserScoresCompleteCallbackInternal))]
		internal static void OnQueryLeaderboardUserScoresCompleteCallbackInternalImplementation(ref OnQueryLeaderboardUserScoresCompleteCallbackInfoInternal data)
		{
		}

		// Token: 0x04000D67 RID: 3431
		[Token(Token = "0x4000D67")]
		public const int CopyleaderboarddefinitionbyindexApiLatest = 1;

		// Token: 0x04000D68 RID: 3432
		[Token(Token = "0x4000D68")]
		public const int CopyleaderboarddefinitionbyleaderboardidApiLatest = 1;

		// Token: 0x04000D69 RID: 3433
		[Token(Token = "0x4000D69")]
		public const int CopyleaderboardrecordbyindexApiLatest = 2;

		// Token: 0x04000D6A RID: 3434
		[Token(Token = "0x4000D6A")]
		public const int CopyleaderboardrecordbyuseridApiLatest = 2;

		// Token: 0x04000D6B RID: 3435
		[Token(Token = "0x4000D6B")]
		public const int CopyleaderboarduserscorebyindexApiLatest = 1;

		// Token: 0x04000D6C RID: 3436
		[Token(Token = "0x4000D6C")]
		public const int CopyleaderboarduserscorebyuseridApiLatest = 1;

		// Token: 0x04000D6D RID: 3437
		[Token(Token = "0x4000D6D")]
		public const int DefinitionApiLatest = 1;

		// Token: 0x04000D6E RID: 3438
		[Token(Token = "0x4000D6E")]
		public const int GetleaderboarddefinitioncountApiLatest = 1;

		// Token: 0x04000D6F RID: 3439
		[Token(Token = "0x4000D6F")]
		public const int GetleaderboardrecordcountApiLatest = 1;

		// Token: 0x04000D70 RID: 3440
		[Token(Token = "0x4000D70")]
		public const int GetleaderboarduserscorecountApiLatest = 1;

		// Token: 0x04000D71 RID: 3441
		[Token(Token = "0x4000D71")]
		public const int LeaderboardrecordApiLatest = 2;

		// Token: 0x04000D72 RID: 3442
		[Token(Token = "0x4000D72")]
		public const int LeaderboarduserscoreApiLatest = 1;

		// Token: 0x04000D73 RID: 3443
		[Token(Token = "0x4000D73")]
		public const int QueryleaderboarddefinitionsApiLatest = 2;

		// Token: 0x04000D74 RID: 3444
		[Token(Token = "0x4000D74")]
		public const int QueryleaderboardranksApiLatest = 2;

		// Token: 0x04000D75 RID: 3445
		[Token(Token = "0x4000D75")]
		public const int QueryleaderboarduserscoresApiLatest = 2;

		// Token: 0x04000D76 RID: 3446
		[Token(Token = "0x4000D76")]
		public const int TimeUndefined = -1;

		// Token: 0x04000D77 RID: 3447
		[Token(Token = "0x4000D77")]
		public const int UserscoresquerystatinfoApiLatest = 1;
	}
}
