using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.AntiCheatCommon
{
	// Token: 0x020006C7 RID: 1735
	[Token(Token = "0x20006C7")]
	internal struct LogGameRoundEndOptionsInternal : ISettable<LogGameRoundEndOptions>, IDisposable
	{
		// Token: 0x17000CFC RID: 3324
		// (set) Token: 0x06002C43 RID: 11331 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000CFC")]
		public uint WinningTeamId
		{
			[Token(Token = "0x6002C43")]
			[Address(RVA = "0x4A4E90", Offset = "0x4A3490", VA = "0x1804A4E90")]
			set
			{
			}
		}

		// Token: 0x06002C44 RID: 11332 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002C44")]
		[Address(RVA = "0x4AFC00", Offset = "0x4AE200", VA = "0x1804AFC00", Slot = "4")]
		public void Set(ref LogGameRoundEndOptions other)
		{
		}

		// Token: 0x06002C45 RID: 11333 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002C45")]
		[Address(RVA = "0x574850", Offset = "0x572E50", VA = "0x180574850", Slot = "5")]
		public void Set(ref LogGameRoundEndOptions? other)
		{
		}

		// Token: 0x06002C46 RID: 11334 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002C46")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04001395 RID: 5013
		[Token(Token = "0x4001395")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04001396 RID: 5014
		[Token(Token = "0x4001396")]
		[FieldOffset(Offset = "0x4")]
		private uint m_WinningTeamId;
	}
}
