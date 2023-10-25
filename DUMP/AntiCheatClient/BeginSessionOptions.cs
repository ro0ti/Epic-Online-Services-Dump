using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.AntiCheatClient
{
	// Token: 0x020006FB RID: 1787
	[Token(Token = "0x20006FB")]
	public struct BeginSessionOptions
	{
		// Token: 0x17000D94 RID: 3476
		// (get) Token: 0x06002DB7 RID: 11703 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002DB8 RID: 11704 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D94")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6002DB7")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002DB8")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000D95 RID: 3477
		// (get) Token: 0x06002DB9 RID: 11705 RVA: 0x0000BDA4 File Offset: 0x00009FA4
		// (set) Token: 0x06002DBA RID: 11706 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D95")]
		public AntiCheatClientMode Mode
		{
			[Token(Token = "0x6002DB9")]
			[Address(RVA = "0x4875A0", Offset = "0x485BA0", VA = "0x1804875A0")]
			[CompilerGenerated]
			readonly get
			{
				return AntiCheatClientMode.Invalid;
			}
			[Token(Token = "0x6002DBA")]
			[Address(RVA = "0x4875C0", Offset = "0x485BC0", VA = "0x1804875C0")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
