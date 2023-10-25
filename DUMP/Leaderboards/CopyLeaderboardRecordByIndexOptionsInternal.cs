using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Leaderboards
{
	// Token: 0x02000481 RID: 1153
	[Token(Token = "0x2000481")]
	internal struct CopyLeaderboardRecordByIndexOptionsInternal : ISettable<CopyLeaderboardRecordByIndexOptions>, IDisposable
	{
		// Token: 0x17000868 RID: 2152
		// (set) Token: 0x06001DDA RID: 7642 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000868")]
		public uint LeaderboardRecordIndex
		{
			[Token(Token = "0x6001DDA")]
			[Address(RVA = "0x4A4E90", Offset = "0x4A3490", VA = "0x1804A4E90")]
			set
			{
			}
		}

		// Token: 0x06001DDB RID: 7643 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001DDB")]
		[Address(RVA = "0x521760", Offset = "0x51FD60", VA = "0x180521760", Slot = "4")]
		public void Set(ref CopyLeaderboardRecordByIndexOptions other)
		{
		}

		// Token: 0x06001DDC RID: 7644 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001DDC")]
		[Address(RVA = "0x521770", Offset = "0x51FD70", VA = "0x180521770", Slot = "5")]
		public void Set(ref CopyLeaderboardRecordByIndexOptions? other)
		{
		}

		// Token: 0x06001DDD RID: 7645 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001DDD")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000D3A RID: 3386
		[Token(Token = "0x4000D3A")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000D3B RID: 3387
		[Token(Token = "0x4000D3B")]
		[FieldOffset(Offset = "0x4")]
		private uint m_LeaderboardRecordIndex;
	}
}
