using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.Ecom
{
	// Token: 0x0200053C RID: 1340
	[Token(Token = "0x200053C")]
	public struct CopyItemReleaseByIndexOptions
	{
		// Token: 0x17000A03 RID: 2563
		// (get) Token: 0x060022AF RID: 8879 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060022B0 RID: 8880 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A03")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x60022AF")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60022B0")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000A04 RID: 2564
		// (get) Token: 0x060022B1 RID: 8881 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060022B2 RID: 8882 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A04")]
		public Utf8String ItemId
		{
			[Token(Token = "0x60022B1")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60022B2")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000A05 RID: 2565
		// (get) Token: 0x060022B3 RID: 8883 RVA: 0x000092E4 File Offset: 0x000074E4
		// (set) Token: 0x060022B4 RID: 8884 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A05")]
		public uint ReleaseIndex
		{
			[Token(Token = "0x60022B3")]
			[Address(RVA = "0x3D2690", Offset = "0x3D0C90", VA = "0x1803D2690")]
			[CompilerGenerated]
			readonly get
			{
				return 0U;
			}
			[Token(Token = "0x60022B4")]
			[Address(RVA = "0x457A40", Offset = "0x456040", VA = "0x180457A40")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
