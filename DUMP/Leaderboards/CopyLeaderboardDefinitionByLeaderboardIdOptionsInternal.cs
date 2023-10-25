using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Leaderboards
{
	// Token: 0x0200047F RID: 1151
	[Token(Token = "0x200047F")]
	internal struct CopyLeaderboardDefinitionByLeaderboardIdOptionsInternal : ISettable<CopyLeaderboardDefinitionByLeaderboardIdOptions>, IDisposable
	{
		// Token: 0x17000866 RID: 2150
		// (set) Token: 0x06001DD4 RID: 7636 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000866")]
		public Utf8String LeaderboardId
		{
			[Token(Token = "0x6001DD4")]
			[Address(RVA = "0x521700", Offset = "0x51FD00", VA = "0x180521700")]
			set
			{
			}
		}

		// Token: 0x06001DD5 RID: 7637 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001DD5")]
		[Address(RVA = "0x5216A0", Offset = "0x51FCA0", VA = "0x1805216A0", Slot = "4")]
		public void Set(ref CopyLeaderboardDefinitionByLeaderboardIdOptions other)
		{
		}

		// Token: 0x06001DD6 RID: 7638 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001DD6")]
		[Address(RVA = "0x521600", Offset = "0x51FC00", VA = "0x180521600", Slot = "5")]
		public void Set(ref CopyLeaderboardDefinitionByLeaderboardIdOptions? other)
		{
		}

		// Token: 0x06001DD7 RID: 7639 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001DD7")]
		[Address(RVA = "0x5215B0", Offset = "0x51FBB0", VA = "0x1805215B0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000D37 RID: 3383
		[Token(Token = "0x4000D37")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000D38 RID: 3384
		[Token(Token = "0x4000D38")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LeaderboardId;
	}
}
