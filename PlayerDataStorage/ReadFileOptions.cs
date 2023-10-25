using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.PlayerDataStorage
{
	// Token: 0x0200030C RID: 780
	[Token(Token = "0x200030C")]
	public struct ReadFileOptions
	{
		// Token: 0x1700059B RID: 1435
		// (get) Token: 0x06001522 RID: 5410 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001523 RID: 5411 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700059B")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6001522")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001523")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700059C RID: 1436
		// (get) Token: 0x06001524 RID: 5412 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001525 RID: 5413 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700059C")]
		public Utf8String Filename
		{
			[Token(Token = "0x6001524")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001525")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700059D RID: 1437
		// (get) Token: 0x06001526 RID: 5414 RVA: 0x0000605C File Offset: 0x0000425C
		// (set) Token: 0x06001527 RID: 5415 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700059D")]
		public uint ReadChunkLengthBytes
		{
			[Token(Token = "0x6001526")]
			[Address(RVA = "0x3D2690", Offset = "0x3D0C90", VA = "0x1803D2690")]
			[CompilerGenerated]
			readonly get
			{
				return 0U;
			}
			[Token(Token = "0x6001527")]
			[Address(RVA = "0x457A40", Offset = "0x456040", VA = "0x180457A40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700059E RID: 1438
		// (get) Token: 0x06001528 RID: 5416 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001529 RID: 5417 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700059E")]
		public OnReadFileDataCallback ReadFileDataCallback
		{
			[Token(Token = "0x6001528")]
			[Address(RVA = "0x3E4B20", Offset = "0x3E3120", VA = "0x1803E4B20")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001529")]
			[Address(RVA = "0x488180", Offset = "0x486780", VA = "0x180488180")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700059F RID: 1439
		// (get) Token: 0x0600152A RID: 5418 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600152B RID: 5419 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700059F")]
		public OnFileTransferProgressCallback FileTransferProgressCallback
		{
			[Token(Token = "0x600152A")]
			[Address(RVA = "0x4447A0", Offset = "0x442DA0", VA = "0x1804447A0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600152B")]
			[Address(RVA = "0x444810", Offset = "0x442E10", VA = "0x180444810")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
