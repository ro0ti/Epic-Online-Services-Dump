using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.TitleStorage
{
	// Token: 0x020000C7 RID: 199
	[Token(Token = "0x20000C7")]
	public struct ReadFileDataCallbackInfo : ICallbackInfo
	{
		// Token: 0x1700014A RID: 330
		// (get) Token: 0x06000721 RID: 1825 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000722 RID: 1826 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700014A")]
		public object ClientData
		{
			[Token(Token = "0x6000721")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000722")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x06000723 RID: 1827 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000724 RID: 1828 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700014B")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6000723")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000724")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x06000725 RID: 1829 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000726 RID: 1830 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700014C")]
		public Utf8String Filename
		{
			[Token(Token = "0x6000725")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000726")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x06000727 RID: 1831 RVA: 0x00003254 File Offset: 0x00001454
		// (set) Token: 0x06000728 RID: 1832 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700014D")]
		public uint TotalFileSizeBytes
		{
			[Token(Token = "0x6000727")]
			[Address(RVA = "0x4447E0", Offset = "0x442DE0", VA = "0x1804447E0")]
			[CompilerGenerated]
			readonly get
			{
				return 0U;
			}
			[Token(Token = "0x6000728")]
			[Address(RVA = "0x444820", Offset = "0x442E20", VA = "0x180444820")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x06000729 RID: 1833 RVA: 0x0000326C File Offset: 0x0000146C
		// (set) Token: 0x0600072A RID: 1834 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700014E")]
		public bool IsLastChunk
		{
			[Token(Token = "0x6000729")]
			[Address(RVA = "0x4C45B0", Offset = "0x4C2BB0", VA = "0x1804C45B0")]
			[CompilerGenerated]
			readonly get
			{
				return default(bool);
			}
			[Token(Token = "0x600072A")]
			[Address(RVA = "0x4C45E0", Offset = "0x4C2BE0", VA = "0x1804C45E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x0600072B RID: 1835 RVA: 0x00003284 File Offset: 0x00001484
		// (set) Token: 0x0600072C RID: 1836 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700014F")]
		public ArraySegment<byte> DataChunk
		{
			[Token(Token = "0x600072B")]
			[Address(RVA = "0x4C45A0", Offset = "0x4C2BA0", VA = "0x1804C45A0")]
			[CompilerGenerated]
			readonly get
			{
				return default(ArraySegment<byte>);
			}
			[Token(Token = "0x600072C")]
			[Address(RVA = "0x4C45C0", Offset = "0x4C2BC0", VA = "0x1804C45C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600072D RID: 1837 RVA: 0x0000329C File Offset: 0x0000149C
		[Token(Token = "0x600072D")]
		[Address(RVA = "0x42B2A0", Offset = "0x4298A0", VA = "0x18042B2A0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x0600072E RID: 1838 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600072E")]
		[Address(RVA = "0x4C43E0", Offset = "0x4C29E0", VA = "0x1804C43E0")]
		internal void Set(ref ReadFileDataCallbackInfoInternal other)
		{
		}
	}
}
