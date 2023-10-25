using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.Ecom
{
	// Token: 0x02000585 RID: 1413
	[Token(Token = "0x2000585")]
	public struct QueryOwnershipBySandboxIdsOptions
	{
		// Token: 0x17000A8B RID: 2699
		// (get) Token: 0x0600245E RID: 9310 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600245F RID: 9311 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A8B")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x600245E")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600245F")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000A8C RID: 2700
		// (get) Token: 0x06002460 RID: 9312 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002461 RID: 9313 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A8C")]
		public Utf8String[] SandboxIds
		{
			[Token(Token = "0x6002460")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002461")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
