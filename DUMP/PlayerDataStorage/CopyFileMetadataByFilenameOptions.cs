using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.PlayerDataStorage
{
	// Token: 0x020002D6 RID: 726
	[Token(Token = "0x20002D6")]
	public struct CopyFileMetadataByFilenameOptions
	{
		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x060013B0 RID: 5040 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060013B1 RID: 5041 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000533")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x60013B0")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60013B1")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x060013B2 RID: 5042 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060013B3 RID: 5043 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000534")]
		public Utf8String Filename
		{
			[Token(Token = "0x60013B2")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60013B3")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
