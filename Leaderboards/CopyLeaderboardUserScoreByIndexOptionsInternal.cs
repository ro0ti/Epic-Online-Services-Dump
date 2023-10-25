using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Leaderboards
{
	// Token: 0x02000485 RID: 1157
	[Token(Token = "0x2000485")]
	internal struct CopyLeaderboardUserScoreByIndexOptionsInternal : ISettable<CopyLeaderboardUserScoreByIndexOptions>, IDisposable
	{
		// Token: 0x1700086D RID: 2157
		// (set) Token: 0x06001DE8 RID: 7656 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700086D")]
		public uint LeaderboardUserScoreIndex
		{
			[Token(Token = "0x6001DE8")]
			[Address(RVA = "0x4A4E90", Offset = "0x4A3490", VA = "0x1804A4E90")]
			set
			{
			}
		}

		// Token: 0x1700086E RID: 2158
		// (set) Token: 0x06001DE9 RID: 7657 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700086E")]
		public Utf8String StatName
		{
			[Token(Token = "0x6001DE9")]
			[Address(RVA = "0x521B00", Offset = "0x520100", VA = "0x180521B00")]
			set
			{
			}
		}

		// Token: 0x06001DEA RID: 7658 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001DEA")]
		[Address(RVA = "0x521A90", Offset = "0x520090", VA = "0x180521A90", Slot = "4")]
		public void Set(ref CopyLeaderboardUserScoreByIndexOptions other)
		{
		}

		// Token: 0x06001DEB RID: 7659 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001DEB")]
		[Address(RVA = "0x5219D0", Offset = "0x51FFD0", VA = "0x1805219D0", Slot = "5")]
		public void Set(ref CopyLeaderboardUserScoreByIndexOptions? other)
		{
		}

		// Token: 0x06001DEC RID: 7660 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001DEC")]
		[Address(RVA = "0x521980", Offset = "0x51FF80", VA = "0x180521980", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000D41 RID: 3393
		[Token(Token = "0x4000D41")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000D42 RID: 3394
		[Token(Token = "0x4000D42")]
		[FieldOffset(Offset = "0x4")]
		private uint m_LeaderboardUserScoreIndex;

		// Token: 0x04000D43 RID: 3395
		[Token(Token = "0x4000D43")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_StatName;
	}
}
