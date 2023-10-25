using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.Ecom
{
	// Token: 0x02000538 RID: 1336
	[Token(Token = "0x2000538")]
	public struct CopyItemByIdOptions
	{
		// Token: 0x170009F9 RID: 2553
		// (get) Token: 0x0600229A RID: 8858 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600229B RID: 8859 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170009F9")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x600229A")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600229B")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170009FA RID: 2554
		// (get) Token: 0x0600229C RID: 8860 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600229D RID: 8861 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170009FA")]
		public Utf8String ItemId
		{
			[Token(Token = "0x600229C")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600229D")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
