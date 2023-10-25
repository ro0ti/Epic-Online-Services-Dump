using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.TitleStorage
{
	// Token: 0x020000AB RID: 171
	[Token(Token = "0x20000AB")]
	public struct FileMetadata
	{
		// Token: 0x17000114 RID: 276
		// (get) Token: 0x06000668 RID: 1640 RVA: 0x00003014 File Offset: 0x00001214
		// (set) Token: 0x06000669 RID: 1641 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000114")]
		public uint FileSizeBytes
		{
			[Token(Token = "0x6000668")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return 0U;
			}
			[Token(Token = "0x6000669")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x0600066A RID: 1642 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600066B RID: 1643 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000115")]
		public Utf8String MD5Hash
		{
			[Token(Token = "0x600066A")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600066B")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x0600066C RID: 1644 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600066D RID: 1645 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000116")]
		public Utf8String Filename
		{
			[Token(Token = "0x600066C")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600066D")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x0600066E RID: 1646 RVA: 0x0000302C File Offset: 0x0000122C
		// (set) Token: 0x0600066F RID: 1647 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000117")]
		public uint UnencryptedDataSizeBytes
		{
			[Token(Token = "0x600066E")]
			[Address(RVA = "0x4447E0", Offset = "0x442DE0", VA = "0x1804447E0")]
			[CompilerGenerated]
			readonly get
			{
				return 0U;
			}
			[Token(Token = "0x600066F")]
			[Address(RVA = "0x444820", Offset = "0x442E20", VA = "0x180444820")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000670 RID: 1648 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000670")]
		[Address(RVA = "0x4A5560", Offset = "0x4A3B60", VA = "0x1804A5560")]
		internal void Set(ref FileMetadataInternal other)
		{
		}
	}
}
