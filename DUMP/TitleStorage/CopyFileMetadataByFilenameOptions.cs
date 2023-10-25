using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.TitleStorage
{
	// Token: 0x020000A5 RID: 165
	[Token(Token = "0x20000A5")]
	public struct CopyFileMetadataByFilenameOptions
	{
		// Token: 0x17000107 RID: 263
		// (get) Token: 0x06000646 RID: 1606 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000647 RID: 1607 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000107")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6000646")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000647")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x06000648 RID: 1608 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000649 RID: 1609 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000108")]
		public Utf8String Filename
		{
			[Token(Token = "0x6000648")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000649")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
