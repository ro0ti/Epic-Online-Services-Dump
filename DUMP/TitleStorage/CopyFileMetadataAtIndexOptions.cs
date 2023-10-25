using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.TitleStorage
{
	// Token: 0x020000A3 RID: 163
	[Token(Token = "0x20000A3")]
	public struct CopyFileMetadataAtIndexOptions
	{
		// Token: 0x17000103 RID: 259
		// (get) Token: 0x0600063D RID: 1597 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600063E RID: 1598 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000103")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x600063D")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600063E")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x0600063F RID: 1599 RVA: 0x00002F9C File Offset: 0x0000119C
		// (set) Token: 0x06000640 RID: 1600 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000104")]
		public uint Index
		{
			[Token(Token = "0x600063F")]
			[Address(RVA = "0x4875A0", Offset = "0x485BA0", VA = "0x1804875A0")]
			[CompilerGenerated]
			readonly get
			{
				return 0U;
			}
			[Token(Token = "0x6000640")]
			[Address(RVA = "0x4875C0", Offset = "0x485BC0", VA = "0x1804875C0")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
