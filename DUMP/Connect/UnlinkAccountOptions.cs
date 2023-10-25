using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.Connect
{
	// Token: 0x02000641 RID: 1601
	[Token(Token = "0x2000641")]
	public struct UnlinkAccountOptions
	{
		// Token: 0x17000BE5 RID: 3045
		// (get) Token: 0x060028F4 RID: 10484 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060028F5 RID: 10485 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BE5")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x60028F4")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60028F5")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
