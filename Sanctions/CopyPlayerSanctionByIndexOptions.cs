using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.Sanctions
{
	// Token: 0x020001A3 RID: 419
	[Token(Token = "0x20001A3")]
	public struct CopyPlayerSanctionByIndexOptions
	{
		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x06000C0C RID: 3084 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000C0D RID: 3085 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170002C1")]
		public ProductUserId TargetUserId
		{
			[Token(Token = "0x6000C0C")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000C0D")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x06000C0E RID: 3086 RVA: 0x00004484 File Offset: 0x00002684
		// (set) Token: 0x06000C0F RID: 3087 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170002C2")]
		public uint SanctionIndex
		{
			[Token(Token = "0x6000C0E")]
			[Address(RVA = "0x4875A0", Offset = "0x485BA0", VA = "0x1804875A0")]
			[CompilerGenerated]
			readonly get
			{
				return 0U;
			}
			[Token(Token = "0x6000C0F")]
			[Address(RVA = "0x4875C0", Offset = "0x485BC0", VA = "0x1804875C0")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
