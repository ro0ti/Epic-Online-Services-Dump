using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Leaderboards
{
	// Token: 0x02000483 RID: 1155
	[Token(Token = "0x2000483")]
	internal struct CopyLeaderboardRecordByUserIdOptionsInternal : ISettable<CopyLeaderboardRecordByUserIdOptions>, IDisposable
	{
		// Token: 0x1700086A RID: 2154
		// (set) Token: 0x06001DE0 RID: 7648 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700086A")]
		public ProductUserId UserId
		{
			[Token(Token = "0x6001DE0")]
			[Address(RVA = "0x521920", Offset = "0x51FF20", VA = "0x180521920")]
			set
			{
			}
		}

		// Token: 0x06001DE1 RID: 7649 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001DE1")]
		[Address(RVA = "0x521820", Offset = "0x51FE20", VA = "0x180521820", Slot = "4")]
		public void Set(ref CopyLeaderboardRecordByUserIdOptions other)
		{
		}

		// Token: 0x06001DE2 RID: 7650 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001DE2")]
		[Address(RVA = "0x521880", Offset = "0x51FE80", VA = "0x180521880", Slot = "5")]
		public void Set(ref CopyLeaderboardRecordByUserIdOptions? other)
		{
		}

		// Token: 0x06001DE3 RID: 7651 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001DE3")]
		[Address(RVA = "0x5217D0", Offset = "0x51FDD0", VA = "0x1805217D0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000D3D RID: 3389
		[Token(Token = "0x4000D3D")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000D3E RID: 3390
		[Token(Token = "0x4000D3E")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_UserId;
	}
}
