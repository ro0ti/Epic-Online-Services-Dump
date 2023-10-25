using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.PlayerDataStorage
{
	// Token: 0x020002E4 RID: 740
	[Token(Token = "0x20002E4")]
	public struct FileMetadata
	{
		// Token: 0x17000558 RID: 1368
		// (get) Token: 0x0600140D RID: 5133 RVA: 0x00005C54 File Offset: 0x00003E54
		// (set) Token: 0x0600140E RID: 5134 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000558")]
		public uint FileSizeBytes
		{
			[Token(Token = "0x600140D")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return 0U;
			}
			[Token(Token = "0x600140E")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000559 RID: 1369
		// (get) Token: 0x0600140F RID: 5135 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001410 RID: 5136 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000559")]
		public Utf8String MD5Hash
		{
			[Token(Token = "0x600140F")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001410")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700055A RID: 1370
		// (get) Token: 0x06001411 RID: 5137 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001412 RID: 5138 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700055A")]
		public Utf8String Filename
		{
			[Token(Token = "0x6001411")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001412")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700055B RID: 1371
		// (get) Token: 0x06001413 RID: 5139 RVA: 0x00005C6C File Offset: 0x00003E6C
		// (set) Token: 0x06001414 RID: 5140 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700055B")]
		public DateTimeOffset? LastModifiedTime
		{
			[Token(Token = "0x6001413")]
			[Address(RVA = "0x4D4FF0", Offset = "0x4D35F0", VA = "0x1804D4FF0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001414")]
			[Address(RVA = "0x4F1720", Offset = "0x4EFD20", VA = "0x1804F1720")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700055C RID: 1372
		// (get) Token: 0x06001415 RID: 5141 RVA: 0x00005C84 File Offset: 0x00003E84
		// (set) Token: 0x06001416 RID: 5142 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700055C")]
		public uint UnencryptedDataSizeBytes
		{
			[Token(Token = "0x6001415")]
			[Address(RVA = "0x3D2E80", Offset = "0x3D1480", VA = "0x1803D2E80")]
			[CompilerGenerated]
			readonly get
			{
				return 0U;
			}
			[Token(Token = "0x6001416")]
			[Address(RVA = "0x3D2EB0", Offset = "0x3D14B0", VA = "0x1803D2EB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001417 RID: 5143 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001417")]
		[Address(RVA = "0x4F15C0", Offset = "0x4EFBC0", VA = "0x1804F15C0")]
		internal void Set(ref FileMetadataInternal other)
		{
		}
	}
}
