using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.Sessions
{
	// Token: 0x020000E8 RID: 232
	[Token(Token = "0x20000E8")]
	public struct ActiveSessionGetRegisteredPlayerByIndexOptions
	{
		// Token: 0x17000199 RID: 409
		// (get) Token: 0x0600080F RID: 2063 RVA: 0x0000362C File Offset: 0x0000182C
		// (set) Token: 0x06000810 RID: 2064 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000199")]
		public uint PlayerIndex
		{
			[Token(Token = "0x600080F")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return 0U;
			}
			[Token(Token = "0x6000810")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
