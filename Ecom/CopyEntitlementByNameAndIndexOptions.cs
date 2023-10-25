using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.Ecom
{
	// Token: 0x02000536 RID: 1334
	[Token(Token = "0x2000536")]
	public struct CopyEntitlementByNameAndIndexOptions
	{
		// Token: 0x170009F3 RID: 2547
		// (get) Token: 0x0600228E RID: 8846 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600228F RID: 8847 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170009F3")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x600228E")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600228F")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170009F4 RID: 2548
		// (get) Token: 0x06002290 RID: 8848 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002291 RID: 8849 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170009F4")]
		public Utf8String EntitlementName
		{
			[Token(Token = "0x6002290")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002291")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170009F5 RID: 2549
		// (get) Token: 0x06002292 RID: 8850 RVA: 0x000092B4 File Offset: 0x000074B4
		// (set) Token: 0x06002293 RID: 8851 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170009F5")]
		public uint Index
		{
			[Token(Token = "0x6002292")]
			[Address(RVA = "0x3D2690", Offset = "0x3D0C90", VA = "0x1803D2690")]
			[CompilerGenerated]
			readonly get
			{
				return 0U;
			}
			[Token(Token = "0x6002293")]
			[Address(RVA = "0x457A40", Offset = "0x456040", VA = "0x180457A40")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
