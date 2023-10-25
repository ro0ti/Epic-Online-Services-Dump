using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.Lobby
{
	// Token: 0x02000426 RID: 1062
	[Token(Token = "0x2000426")]
	public struct LobbySearchRemoveParameterOptions
	{
		// Token: 0x170007F3 RID: 2035
		// (get) Token: 0x06001BFF RID: 7167 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001C00 RID: 7168 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170007F3")]
		public Utf8String Key
		{
			[Token(Token = "0x6001BFF")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001C00")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170007F4 RID: 2036
		// (get) Token: 0x06001C01 RID: 7169 RVA: 0x00007E2C File Offset: 0x0000602C
		// (set) Token: 0x06001C02 RID: 7170 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170007F4")]
		public ComparisonOp ComparisonOp
		{
			[Token(Token = "0x6001C01")]
			[Address(RVA = "0x4875A0", Offset = "0x485BA0", VA = "0x1804875A0")]
			[CompilerGenerated]
			readonly get
			{
				return ComparisonOp.Equal;
			}
			[Token(Token = "0x6001C02")]
			[Address(RVA = "0x4875C0", Offset = "0x485BC0", VA = "0x1804875C0")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
