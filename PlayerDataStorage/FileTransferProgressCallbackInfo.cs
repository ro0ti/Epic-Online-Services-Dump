using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.PlayerDataStorage
{
	// Token: 0x020002E6 RID: 742
	[Token(Token = "0x20002E6")]
	public struct FileTransferProgressCallbackInfo : ICallbackInfo
	{
		// Token: 0x17000562 RID: 1378
		// (get) Token: 0x06001426 RID: 5158 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001427 RID: 5159 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000562")]
		public object ClientData
		{
			[Token(Token = "0x6001426")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001427")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000563 RID: 1379
		// (get) Token: 0x06001428 RID: 5160 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001429 RID: 5161 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000563")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6001428")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001429")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000564 RID: 1380
		// (get) Token: 0x0600142A RID: 5162 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600142B RID: 5163 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000564")]
		public Utf8String Filename
		{
			[Token(Token = "0x600142A")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600142B")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000565 RID: 1381
		// (get) Token: 0x0600142C RID: 5164 RVA: 0x00005CE4 File Offset: 0x00003EE4
		// (set) Token: 0x0600142D RID: 5165 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000565")]
		public uint BytesTransferred
		{
			[Token(Token = "0x600142C")]
			[Address(RVA = "0x4447E0", Offset = "0x442DE0", VA = "0x1804447E0")]
			[CompilerGenerated]
			readonly get
			{
				return 0U;
			}
			[Token(Token = "0x600142D")]
			[Address(RVA = "0x444820", Offset = "0x442E20", VA = "0x180444820")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000566 RID: 1382
		// (get) Token: 0x0600142E RID: 5166 RVA: 0x00005CFC File Offset: 0x00003EFC
		// (set) Token: 0x0600142F RID: 5167 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000566")]
		public uint TotalFileSizeBytes
		{
			[Token(Token = "0x600142E")]
			[Address(RVA = "0x4A5AF0", Offset = "0x4A40F0", VA = "0x1804A5AF0")]
			[CompilerGenerated]
			readonly get
			{
				return 0U;
			}
			[Token(Token = "0x600142F")]
			[Address(RVA = "0x4A5CB0", Offset = "0x4A42B0", VA = "0x1804A5CB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001430 RID: 5168 RVA: 0x00005D14 File Offset: 0x00003F14
		[Token(Token = "0x6001430")]
		[Address(RVA = "0x42B2A0", Offset = "0x4298A0", VA = "0x18042B2A0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x06001431 RID: 5169 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001431")]
		[Address(RVA = "0x4F1CF0", Offset = "0x4F02F0", VA = "0x1804F1CF0")]
		internal void Set(ref FileTransferProgressCallbackInfoInternal other)
		{
		}
	}
}
