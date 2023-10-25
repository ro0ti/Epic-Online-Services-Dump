using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.Ecom
{
	// Token: 0x02000556 RID: 1366
	[Token(Token = "0x2000556")]
	public struct GetItemReleaseCountOptions
	{
		// Token: 0x17000A3F RID: 2623
		// (get) Token: 0x0600235D RID: 9053 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600235E RID: 9054 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A3F")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x600235D")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600235E")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000A40 RID: 2624
		// (get) Token: 0x0600235F RID: 9055 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002360 RID: 9056 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A40")]
		public Utf8String ItemId
		{
			[Token(Token = "0x600235F")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002360")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
