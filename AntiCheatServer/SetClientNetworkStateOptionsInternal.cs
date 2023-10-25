using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.AntiCheatServer
{
	// Token: 0x020006AD RID: 1709
	[Token(Token = "0x20006AD")]
	internal struct SetClientNetworkStateOptionsInternal : ISettable<SetClientNetworkStateOptions>, IDisposable
	{
		// Token: 0x17000CD8 RID: 3288
		// (set) Token: 0x06002BE4 RID: 11236 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000CD8")]
		public IntPtr ClientHandle
		{
			[Token(Token = "0x6002BE4")]
			[Address(RVA = "0x487590", Offset = "0x485B90", VA = "0x180487590")]
			set
			{
			}
		}

		// Token: 0x17000CD9 RID: 3289
		// (set) Token: 0x06002BE5 RID: 11237 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000CD9")]
		public bool IsNetworkActive
		{
			[Token(Token = "0x6002BE5")]
			[Address(RVA = "0x57EFC0", Offset = "0x57D5C0", VA = "0x18057EFC0")]
			set
			{
			}
		}

		// Token: 0x06002BE6 RID: 11238 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002BE6")]
		[Address(RVA = "0x57EE80", Offset = "0x57D480", VA = "0x18057EE80", Slot = "4")]
		public void Set(ref SetClientNetworkStateOptions other)
		{
		}

		// Token: 0x06002BE7 RID: 11239 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002BE7")]
		[Address(RVA = "0x57EEF0", Offset = "0x57D4F0", VA = "0x18057EEF0", Slot = "5")]
		public void Set(ref SetClientNetworkStateOptions? other)
		{
		}

		// Token: 0x06002BE8 RID: 11240 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002BE8")]
		[Address(RVA = "0x57EE30", Offset = "0x57D430", VA = "0x18057EE30", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x0400130B RID: 4875
		[Token(Token = "0x400130B")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x0400130C RID: 4876
		[Token(Token = "0x400130C")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientHandle;

		// Token: 0x0400130D RID: 4877
		[Token(Token = "0x400130D")]
		[FieldOffset(Offset = "0x10")]
		private int m_IsNetworkActive;
	}
}
