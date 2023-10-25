using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.Ecom
{
	// Token: 0x02000589 RID: 1417
	[Token(Token = "0x2000589")]
	public struct QueryOwnershipOptions
	{
		// Token: 0x17000A98 RID: 2712
		// (get) Token: 0x0600247E RID: 9342 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600247F RID: 9343 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A98")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x600247E")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600247F")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000A99 RID: 2713
		// (get) Token: 0x06002480 RID: 9344 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002481 RID: 9345 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A99")]
		public Utf8String[] CatalogItemIds
		{
			[Token(Token = "0x6002480")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002481")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000A9A RID: 2714
		// (get) Token: 0x06002482 RID: 9346 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002483 RID: 9347 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A9A")]
		public Utf8String CatalogNamespace
		{
			[Token(Token = "0x6002482")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002483")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
