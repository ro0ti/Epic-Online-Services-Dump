using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.Ecom
{
	// Token: 0x0200053A RID: 1338
	[Token(Token = "0x200053A")]
	public struct CopyItemImageInfoByIndexOptions
	{
		// Token: 0x170009FD RID: 2557
		// (get) Token: 0x060022A3 RID: 8867 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060022A4 RID: 8868 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170009FD")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x60022A3")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60022A4")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170009FE RID: 2558
		// (get) Token: 0x060022A5 RID: 8869 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060022A6 RID: 8870 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170009FE")]
		public Utf8String ItemId
		{
			[Token(Token = "0x60022A5")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60022A6")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170009FF RID: 2559
		// (get) Token: 0x060022A7 RID: 8871 RVA: 0x000092CC File Offset: 0x000074CC
		// (set) Token: 0x060022A8 RID: 8872 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170009FF")]
		public uint ImageInfoIndex
		{
			[Token(Token = "0x60022A7")]
			[Address(RVA = "0x3D2690", Offset = "0x3D0C90", VA = "0x1803D2690")]
			[CompilerGenerated]
			readonly get
			{
				return 0U;
			}
			[Token(Token = "0x60022A8")]
			[Address(RVA = "0x457A40", Offset = "0x456040", VA = "0x180457A40")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
