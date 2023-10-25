using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.Ecom
{
	// Token: 0x0200055C RID: 1372
	[Token(Token = "0x200055C")]
	public struct GetOfferImageInfoCountOptions
	{
		// Token: 0x17000A47 RID: 2631
		// (get) Token: 0x06002372 RID: 9074 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002373 RID: 9075 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A47")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x6002372")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002373")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000A48 RID: 2632
		// (get) Token: 0x06002374 RID: 9076 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002375 RID: 9077 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A48")]
		public Utf8String OfferId
		{
			[Token(Token = "0x6002374")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002375")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
