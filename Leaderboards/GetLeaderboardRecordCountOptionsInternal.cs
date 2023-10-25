using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Leaderboards
{
	// Token: 0x0200048D RID: 1165
	[Token(Token = "0x200048D")]
	internal struct GetLeaderboardRecordCountOptionsInternal : ISettable<GetLeaderboardRecordCountOptions>, IDisposable
	{
		// Token: 0x06001E12 RID: 7698 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001E12")]
		[Address(RVA = "0x4875E0", Offset = "0x485BE0", VA = "0x1804875E0", Slot = "4")]
		public void Set(ref GetLeaderboardRecordCountOptions other)
		{
		}

		// Token: 0x06001E13 RID: 7699 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001E13")]
		[Address(RVA = "0x523A50", Offset = "0x522050", VA = "0x180523A50", Slot = "5")]
		public void Set(ref GetLeaderboardRecordCountOptions? other)
		{
		}

		// Token: 0x06001E14 RID: 7700 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001E14")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000D55 RID: 3413
		[Token(Token = "0x4000D55")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;
	}
}
