using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.TitleStorage
{
	// Token: 0x020000AD RID: 173
	[Token(Token = "0x20000AD")]
	public struct FileTransferProgressCallbackInfo : ICallbackInfo
	{
		// Token: 0x1700011C RID: 284
		// (get) Token: 0x0600067D RID: 1661 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600067E RID: 1662 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700011C")]
		public object ClientData
		{
			[Token(Token = "0x600067D")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600067E")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x0600067F RID: 1663 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000680 RID: 1664 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700011D")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x600067F")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000680")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000681 RID: 1665 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000682 RID: 1666 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700011E")]
		public Utf8String Filename
		{
			[Token(Token = "0x6000681")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000682")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x06000683 RID: 1667 RVA: 0x00003074 File Offset: 0x00001274
		// (set) Token: 0x06000684 RID: 1668 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700011F")]
		public uint BytesTransferred
		{
			[Token(Token = "0x6000683")]
			[Address(RVA = "0x4447E0", Offset = "0x442DE0", VA = "0x1804447E0")]
			[CompilerGenerated]
			readonly get
			{
				return 0U;
			}
			[Token(Token = "0x6000684")]
			[Address(RVA = "0x444820", Offset = "0x442E20", VA = "0x180444820")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x06000685 RID: 1669 RVA: 0x0000308C File Offset: 0x0000128C
		// (set) Token: 0x06000686 RID: 1670 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000120")]
		public uint TotalFileSizeBytes
		{
			[Token(Token = "0x6000685")]
			[Address(RVA = "0x4A5AF0", Offset = "0x4A40F0", VA = "0x1804A5AF0")]
			[CompilerGenerated]
			readonly get
			{
				return 0U;
			}
			[Token(Token = "0x6000686")]
			[Address(RVA = "0x4A5CB0", Offset = "0x4A42B0", VA = "0x1804A5CB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000687 RID: 1671 RVA: 0x000030A4 File Offset: 0x000012A4
		[Token(Token = "0x6000687")]
		[Address(RVA = "0x42B2A0", Offset = "0x4298A0", VA = "0x18042B2A0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x06000688 RID: 1672 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000688")]
		[Address(RVA = "0x4A5CC0", Offset = "0x4A42C0", VA = "0x1804A5CC0")]
		internal void Set(ref FileTransferProgressCallbackInfoInternal other)
		{
		}
	}
}
