using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Ecom
{
	// Token: 0x02000530 RID: 1328
	[Token(Token = "0x2000530")]
	public struct CheckoutOptions
	{
		// Token: 0x170009E5 RID: 2533
		// (get) Token: 0x06002270 RID: 8816 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002271 RID: 8817 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170009E5")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x6002270")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002271")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170009E6 RID: 2534
		// (get) Token: 0x06002272 RID: 8818 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002273 RID: 8819 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170009E6")]
		public Utf8String OverrideCatalogNamespace
		{
			[Token(Token = "0x6002272")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002273")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170009E7 RID: 2535
		// (get) Token: 0x06002274 RID: 8820 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002275 RID: 8821 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170009E7")]
		public CheckoutEntry[] Entries
		{
			[Token(Token = "0x6002274")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002275")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
