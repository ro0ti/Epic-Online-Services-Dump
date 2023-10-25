using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.Sessions
{
	// Token: 0x02000118 RID: 280
	[Token(Token = "0x2000118")]
	public struct IsUserInSessionOptions
	{
		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x060008E0 RID: 2272 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060008E1 RID: 2273 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001E0")]
		public Utf8String SessionName
		{
			[Token(Token = "0x60008E0")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60008E1")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x060008E2 RID: 2274 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060008E3 RID: 2275 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001E1")]
		public ProductUserId TargetUserId
		{
			[Token(Token = "0x60008E2")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60008E3")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
