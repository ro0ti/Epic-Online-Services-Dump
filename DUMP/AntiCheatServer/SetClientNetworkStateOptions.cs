using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.AntiCheatServer
{
	// Token: 0x020006AC RID: 1708
	[Token(Token = "0x20006AC")]
	public struct SetClientNetworkStateOptions
	{
		// Token: 0x17000CD6 RID: 3286
		// (get) Token: 0x06002BE0 RID: 11232 RVA: 0x0000B0B4 File Offset: 0x000092B4
		// (set) Token: 0x06002BE1 RID: 11233 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000CD6")]
		public IntPtr ClientHandle
		{
			[Token(Token = "0x6002BE0")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return 0;
			}
			[Token(Token = "0x6002BE1")]
			[Address(RVA = "0x4875D0", Offset = "0x485BD0", VA = "0x1804875D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000CD7 RID: 3287
		// (get) Token: 0x06002BE2 RID: 11234 RVA: 0x0000B0CC File Offset: 0x000092CC
		// (set) Token: 0x06002BE3 RID: 11235 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000CD7")]
		public bool IsNetworkActive
		{
			[Token(Token = "0x6002BE2")]
			[Address(RVA = "0x4AB000", Offset = "0x4A9600", VA = "0x1804AB000")]
			[CompilerGenerated]
			readonly get
			{
				return default(bool);
			}
			[Token(Token = "0x6002BE3")]
			[Address(RVA = "0x4AB020", Offset = "0x4A9620", VA = "0x1804AB020")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
