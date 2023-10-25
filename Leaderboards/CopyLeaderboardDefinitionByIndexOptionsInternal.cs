using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Leaderboards
{
	// Token: 0x0200047D RID: 1149
	[Token(Token = "0x200047D")]
	internal struct CopyLeaderboardDefinitionByIndexOptionsInternal : ISettable<CopyLeaderboardDefinitionByIndexOptions>, IDisposable
	{
		// Token: 0x17000864 RID: 2148
		// (set) Token: 0x06001DCE RID: 7630 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000864")]
		public uint LeaderboardIndex
		{
			[Token(Token = "0x6001DCE")]
			[Address(RVA = "0x4A4E90", Offset = "0x4A3490", VA = "0x1804A4E90")]
			set
			{
			}
		}

		// Token: 0x06001DCF RID: 7631 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001DCF")]
		[Address(RVA = "0x4AFC00", Offset = "0x4AE200", VA = "0x1804AFC00", Slot = "4")]
		public void Set(ref CopyLeaderboardDefinitionByIndexOptions other)
		{
		}

		// Token: 0x06001DD0 RID: 7632 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001DD0")]
		[Address(RVA = "0x521550", Offset = "0x51FB50", VA = "0x180521550", Slot = "5")]
		public void Set(ref CopyLeaderboardDefinitionByIndexOptions? other)
		{
		}

		// Token: 0x06001DD1 RID: 7633 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001DD1")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000D34 RID: 3380
		[Token(Token = "0x4000D34")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000D35 RID: 3381
		[Token(Token = "0x4000D35")]
		[FieldOffset(Offset = "0x4")]
		private uint m_LeaderboardIndex;
	}
}
