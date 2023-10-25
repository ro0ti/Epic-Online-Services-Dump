using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.TitleStorage
{
	// Token: 0x020000C9 RID: 201
	[Token(Token = "0x20000C9")]
	public struct ReadFileOptions
	{
		// Token: 0x17000157 RID: 343
		// (get) Token: 0x06000740 RID: 1856 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000741 RID: 1857 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000157")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6000740")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000741")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x06000742 RID: 1858 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000743 RID: 1859 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000158")]
		public Utf8String Filename
		{
			[Token(Token = "0x6000742")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000743")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x06000744 RID: 1860 RVA: 0x00003314 File Offset: 0x00001514
		// (set) Token: 0x06000745 RID: 1861 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000159")]
		public uint ReadChunkLengthBytes
		{
			[Token(Token = "0x6000744")]
			[Address(RVA = "0x3D2690", Offset = "0x3D0C90", VA = "0x1803D2690")]
			[CompilerGenerated]
			readonly get
			{
				return 0U;
			}
			[Token(Token = "0x6000745")]
			[Address(RVA = "0x457A40", Offset = "0x456040", VA = "0x180457A40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x06000746 RID: 1862 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000747 RID: 1863 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700015A")]
		public OnReadFileDataCallback ReadFileDataCallback
		{
			[Token(Token = "0x6000746")]
			[Address(RVA = "0x3E4B20", Offset = "0x3E3120", VA = "0x1803E4B20")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000747")]
			[Address(RVA = "0x488180", Offset = "0x486780", VA = "0x180488180")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x06000748 RID: 1864 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000749 RID: 1865 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700015B")]
		public OnFileTransferProgressCallback FileTransferProgressCallback
		{
			[Token(Token = "0x6000748")]
			[Address(RVA = "0x4447A0", Offset = "0x442DA0", VA = "0x1804447A0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000749")]
			[Address(RVA = "0x444810", Offset = "0x442E10", VA = "0x180444810")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
