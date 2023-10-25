using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.Ecom
{
	// Token: 0x02000550 RID: 1360
	[Token(Token = "0x2000550")]
	public struct GetEntitlementsByNameCountOptions
	{
		// Token: 0x17000A35 RID: 2613
		// (get) Token: 0x06002345 RID: 9029 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002346 RID: 9030 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A35")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x6002345")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002346")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000A36 RID: 2614
		// (get) Token: 0x06002347 RID: 9031 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002348 RID: 9032 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A36")]
		public Utf8String EntitlementName
		{
			[Token(Token = "0x6002347")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002348")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
