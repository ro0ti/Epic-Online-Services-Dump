using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.Ecom
{
	// Token: 0x02000534 RID: 1332
	[Token(Token = "0x2000534")]
	public struct CopyEntitlementByIndexOptions
	{
		// Token: 0x170009EF RID: 2543
		// (get) Token: 0x06002285 RID: 8837 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002286 RID: 8838 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170009EF")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x6002285")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002286")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170009F0 RID: 2544
		// (get) Token: 0x06002287 RID: 8839 RVA: 0x0000929C File Offset: 0x0000749C
		// (set) Token: 0x06002288 RID: 8840 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170009F0")]
		public uint EntitlementIndex
		{
			[Token(Token = "0x6002287")]
			[Address(RVA = "0x4875A0", Offset = "0x485BA0", VA = "0x1804875A0")]
			[CompilerGenerated]
			readonly get
			{
				return 0U;
			}
			[Token(Token = "0x6002288")]
			[Address(RVA = "0x4875C0", Offset = "0x485BC0", VA = "0x1804875C0")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
