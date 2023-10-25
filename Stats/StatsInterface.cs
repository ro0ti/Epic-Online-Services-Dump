using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Stats
{
	// Token: 0x020000E4 RID: 228
	[Token(Token = "0x20000E4")]
	public sealed class StatsInterface : Handle
	{
		// Token: 0x060007FD RID: 2045 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007FD")]
		[Address(RVA = "0x427FC0", Offset = "0x4265C0", VA = "0x180427FC0")]
		public StatsInterface()
		{
		}

		// Token: 0x060007FE RID: 2046 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007FE")]
		[Address(RVA = "0x4B8FB0", Offset = "0x4B75B0", VA = "0x1804B8FB0")]
		public StatsInterface(IntPtr innerHandle)
		{
		}

		// Token: 0x060007FF RID: 2047 RVA: 0x000035B4 File Offset: 0x000017B4
		[Token(Token = "0x60007FF")]
		[Address(RVA = "0x4D13C0", Offset = "0x4CF9C0", VA = "0x1804D13C0")]
		public Result CopyStatByIndex(ref CopyStatByIndexOptions options, out Stat? outStat)
		{
			return Result.Success;
		}

		// Token: 0x06000800 RID: 2048 RVA: 0x000035CC File Offset: 0x000017CC
		[Token(Token = "0x6000800")]
		[Address(RVA = "0x4D1510", Offset = "0x4CFB10", VA = "0x1804D1510")]
		public Result CopyStatByName(ref CopyStatByNameOptions options, out Stat? outStat)
		{
			return Result.Success;
		}

		// Token: 0x06000801 RID: 2049 RVA: 0x000035E4 File Offset: 0x000017E4
		[Token(Token = "0x6000801")]
		[Address(RVA = "0x4D1610", Offset = "0x4CFC10", VA = "0x1804D1610")]
		public uint GetStatsCount(ref GetStatCountOptions options)
		{
			return 0U;
		}

		// Token: 0x06000802 RID: 2050 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000802")]
		[Address(RVA = "0x4D16F0", Offset = "0x4CFCF0", VA = "0x1804D16F0")]
		public void IngestStat(ref IngestStatOptions options, object clientData, OnIngestStatCompleteCallback completionDelegate)
		{
		}

		// Token: 0x06000803 RID: 2051 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000803")]
		[Address(RVA = "0x4D1A00", Offset = "0x4D0000", VA = "0x1804D1A00")]
		public void QueryStats(ref QueryStatsOptions options, object clientData, OnQueryStatsCompleteCallback completionDelegate)
		{
		}

		// Token: 0x06000804 RID: 2052 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000804")]
		[Address(RVA = "0x4D18C0", Offset = "0x4CFEC0", VA = "0x1804D18C0")]
		[MonoPInvokeCallback(typeof(OnIngestStatCompleteCallbackInternal))]
		internal static void OnIngestStatCompleteCallbackInternalImplementation(ref IngestStatCompleteCallbackInfoInternal data)
		{
		}

		// Token: 0x06000805 RID: 2053 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000805")]
		[Address(RVA = "0x4D1960", Offset = "0x4CFF60", VA = "0x1804D1960")]
		[MonoPInvokeCallback(typeof(OnQueryStatsCompleteCallbackInternal))]
		internal static void OnQueryStatsCompleteCallbackInternalImplementation(ref OnQueryStatsCompleteCallbackInfoInternal data)
		{
		}

		// Token: 0x040003E2 RID: 994
		[Token(Token = "0x40003E2")]
		public const int CopystatbyindexApiLatest = 1;

		// Token: 0x040003E3 RID: 995
		[Token(Token = "0x40003E3")]
		public const int CopystatbynameApiLatest = 1;

		// Token: 0x040003E4 RID: 996
		[Token(Token = "0x40003E4")]
		public const int GetstatcountApiLatest = 1;

		// Token: 0x040003E5 RID: 997
		[Token(Token = "0x40003E5")]
		public const int GetstatscountApiLatest = 1;

		// Token: 0x040003E6 RID: 998
		[Token(Token = "0x40003E6")]
		public const int IngestdataApiLatest = 1;

		// Token: 0x040003E7 RID: 999
		[Token(Token = "0x40003E7")]
		public const int IngeststatApiLatest = 3;

		// Token: 0x040003E8 RID: 1000
		[Token(Token = "0x40003E8")]
		public const int MaxIngestStats = 3000;

		// Token: 0x040003E9 RID: 1001
		[Token(Token = "0x40003E9")]
		public const int MaxQueryStats = 1000;

		// Token: 0x040003EA RID: 1002
		[Token(Token = "0x40003EA")]
		public const int QuerystatsApiLatest = 3;

		// Token: 0x040003EB RID: 1003
		[Token(Token = "0x40003EB")]
		public const int StatApiLatest = 1;

		// Token: 0x040003EC RID: 1004
		[Token(Token = "0x40003EC")]
		public const int TimeUndefined = -1;
	}
}
