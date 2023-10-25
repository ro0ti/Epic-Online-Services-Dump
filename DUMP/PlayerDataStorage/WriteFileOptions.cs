using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.PlayerDataStorage
{
	// Token: 0x02000313 RID: 787
	[Token(Token = "0x2000313")]
	public struct WriteFileOptions
	{
		// Token: 0x170005B7 RID: 1463
		// (get) Token: 0x06001562 RID: 5474 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001563 RID: 5475 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170005B7")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6001562")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001563")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170005B8 RID: 1464
		// (get) Token: 0x06001564 RID: 5476 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001565 RID: 5477 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170005B8")]
		public Utf8String Filename
		{
			[Token(Token = "0x6001564")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001565")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170005B9 RID: 1465
		// (get) Token: 0x06001566 RID: 5478 RVA: 0x00006134 File Offset: 0x00004334
		// (set) Token: 0x06001567 RID: 5479 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170005B9")]
		public uint ChunkLengthBytes
		{
			[Token(Token = "0x6001566")]
			[Address(RVA = "0x3D2690", Offset = "0x3D0C90", VA = "0x1803D2690")]
			[CompilerGenerated]
			readonly get
			{
				return 0U;
			}
			[Token(Token = "0x6001567")]
			[Address(RVA = "0x457A40", Offset = "0x456040", VA = "0x180457A40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170005BA RID: 1466
		// (get) Token: 0x06001568 RID: 5480 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001569 RID: 5481 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170005BA")]
		public OnWriteFileDataCallback WriteFileDataCallback
		{
			[Token(Token = "0x6001568")]
			[Address(RVA = "0x3E4B20", Offset = "0x3E3120", VA = "0x1803E4B20")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001569")]
			[Address(RVA = "0x488180", Offset = "0x486780", VA = "0x180488180")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170005BB RID: 1467
		// (get) Token: 0x0600156A RID: 5482 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600156B RID: 5483 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170005BB")]
		public OnFileTransferProgressCallback FileTransferProgressCallback
		{
			[Token(Token = "0x600156A")]
			[Address(RVA = "0x4447A0", Offset = "0x442DA0", VA = "0x1804447A0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600156B")]
			[Address(RVA = "0x444810", Offset = "0x442E10", VA = "0x180444810")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
