using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.AntiCheatCommon
{
	// Token: 0x020006E9 RID: 1769
	[Token(Token = "0x20006E9")]
	internal struct SetGameSessionIdOptionsInternal : ISettable<SetGameSessionIdOptions>, IDisposable
	{
		// Token: 0x17000D8B RID: 3467
		// (set) Token: 0x06002D71 RID: 11633 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D8B")]
		public Utf8String GameSessionId
		{
			[Token(Token = "0x6002D71")]
			[Address(RVA = "0x57F170", Offset = "0x57D770", VA = "0x18057F170")]
			set
			{
			}
		}

		// Token: 0x06002D72 RID: 11634 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002D72")]
		[Address(RVA = "0x57F070", Offset = "0x57D670", VA = "0x18057F070", Slot = "4")]
		public void Set(ref SetGameSessionIdOptions other)
		{
		}

		// Token: 0x06002D73 RID: 11635 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002D73")]
		[Address(RVA = "0x57F0D0", Offset = "0x57D6D0", VA = "0x18057F0D0", Slot = "5")]
		public void Set(ref SetGameSessionIdOptions? other)
		{
		}

		// Token: 0x06002D74 RID: 11636 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002D74")]
		[Address(RVA = "0x57F020", Offset = "0x57D620", VA = "0x18057F020", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x0400142E RID: 5166
		[Token(Token = "0x400142E")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x0400142F RID: 5167
		[Token(Token = "0x400142F")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_GameSessionId;
	}
}
