using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.Ecom
{
	// Token: 0x02000579 RID: 1401
	[Token(Token = "0x2000579")]
	public struct QueryEntitlementsOptions
	{
		// Token: 0x17000A64 RID: 2660
		// (get) Token: 0x060023FF RID: 9215 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002400 RID: 9216 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A64")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x60023FF")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002400")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000A65 RID: 2661
		// (get) Token: 0x06002401 RID: 9217 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002402 RID: 9218 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A65")]
		public Utf8String[] EntitlementNames
		{
			[Token(Token = "0x6002401")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002402")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000A66 RID: 2662
		// (get) Token: 0x06002403 RID: 9219 RVA: 0x00009704 File Offset: 0x00007904
		// (set) Token: 0x06002404 RID: 9220 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A66")]
		public bool IncludeRedeemed
		{
			[Token(Token = "0x6002403")]
			[Address(RVA = "0x3D3060", Offset = "0x3D1660", VA = "0x1803D3060")]
			[CompilerGenerated]
			readonly get
			{
				return default(bool);
			}
			[Token(Token = "0x6002404")]
			[Address(RVA = "0x3D3070", Offset = "0x3D1670", VA = "0x1803D3070")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
