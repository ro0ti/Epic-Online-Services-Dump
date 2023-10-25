using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.Ecom
{
	// Token: 0x0200057D RID: 1405
	[Token(Token = "0x200057D")]
	public struct QueryEntitlementTokenOptions
	{
		// Token: 0x17000A73 RID: 2675
		// (get) Token: 0x06002422 RID: 9250 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002423 RID: 9251 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A73")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x6002422")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002423")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000A74 RID: 2676
		// (get) Token: 0x06002424 RID: 9252 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002425 RID: 9253 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A74")]
		public Utf8String[] EntitlementNames
		{
			[Token(Token = "0x6002424")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002425")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
