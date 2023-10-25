using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.PlayerDataStorage
{
	// Token: 0x020002D5 RID: 725
	[Token(Token = "0x20002D5")]
	internal struct CopyFileMetadataAtIndexOptionsInternal : ISettable<CopyFileMetadataAtIndexOptions>, IDisposable
	{
		// Token: 0x17000531 RID: 1329
		// (set) Token: 0x060013AB RID: 5035 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000531")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x60013AB")]
			[Address(RVA = "0x4EE410", Offset = "0x4ECA10", VA = "0x1804EE410")]
			set
			{
			}
		}

		// Token: 0x17000532 RID: 1330
		// (set) Token: 0x060013AC RID: 5036 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000532")]
		public uint Index
		{
			[Token(Token = "0x60013AC")]
			[Address(RVA = "0x457A40", Offset = "0x456040", VA = "0x180457A40")]
			set
			{
			}
		}

		// Token: 0x060013AD RID: 5037 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013AD")]
		[Address(RVA = "0x4EE2C0", Offset = "0x4EC8C0", VA = "0x1804EE2C0", Slot = "4")]
		public void Set(ref CopyFileMetadataAtIndexOptions other)
		{
		}

		// Token: 0x060013AE RID: 5038 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013AE")]
		[Address(RVA = "0x4EE340", Offset = "0x4EC940", VA = "0x1804EE340", Slot = "5")]
		public void Set(ref CopyFileMetadataAtIndexOptions? other)
		{
		}

		// Token: 0x060013AF RID: 5039 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013AF")]
		[Address(RVA = "0x4EE270", Offset = "0x4EC870", VA = "0x1804EE270", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x040008C0 RID: 2240
		[Token(Token = "0x40008C0")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x040008C1 RID: 2241
		[Token(Token = "0x40008C1")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x040008C2 RID: 2242
		[Token(Token = "0x40008C2")]
		[FieldOffset(Offset = "0x10")]
		private uint m_Index;
	}
}
