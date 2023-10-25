using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.PlayerDataStorage
{
	// Token: 0x020002D4 RID: 724
	[Token(Token = "0x20002D4")]
	public struct CopyFileMetadataAtIndexOptions
	{
		// Token: 0x1700052F RID: 1327
		// (get) Token: 0x060013A7 RID: 5031 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060013A8 RID: 5032 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700052F")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x60013A7")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60013A8")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x060013A9 RID: 5033 RVA: 0x00005B1C File Offset: 0x00003D1C
		// (set) Token: 0x060013AA RID: 5034 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000530")]
		public uint Index
		{
			[Token(Token = "0x60013A9")]
			[Address(RVA = "0x4875A0", Offset = "0x485BA0", VA = "0x1804875A0")]
			[CompilerGenerated]
			readonly get
			{
				return 0U;
			}
			[Token(Token = "0x60013AA")]
			[Address(RVA = "0x4875C0", Offset = "0x485BC0", VA = "0x1804875C0")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
