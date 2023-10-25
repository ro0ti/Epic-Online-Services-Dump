using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.KWS
{
	// Token: 0x020004AD RID: 1197
	[Token(Token = "0x20004AD")]
	internal struct CopyPermissionByIndexOptionsInternal : ISettable<CopyPermissionByIndexOptions>, IDisposable
	{
		// Token: 0x170008B4 RID: 2228
		// (set) Token: 0x06001ECE RID: 7886 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170008B4")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6001ECE")]
			[Address(RVA = "0x521FF0", Offset = "0x5205F0", VA = "0x180521FF0")]
			set
			{
			}
		}

		// Token: 0x170008B5 RID: 2229
		// (set) Token: 0x06001ECF RID: 7887 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170008B5")]
		public uint Index
		{
			[Token(Token = "0x6001ECF")]
			[Address(RVA = "0x457A40", Offset = "0x456040", VA = "0x180457A40")]
			set
			{
			}
		}

		// Token: 0x06001ED0 RID: 7888 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001ED0")]
		[Address(RVA = "0x521F70", Offset = "0x520570", VA = "0x180521F70", Slot = "4")]
		public void Set(ref CopyPermissionByIndexOptions other)
		{
		}

		// Token: 0x06001ED1 RID: 7889 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001ED1")]
		[Address(RVA = "0x521EA0", Offset = "0x5204A0", VA = "0x180521EA0", Slot = "5")]
		public void Set(ref CopyPermissionByIndexOptions? other)
		{
		}

		// Token: 0x06001ED2 RID: 7890 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001ED2")]
		[Address(RVA = "0x521E50", Offset = "0x520450", VA = "0x180521E50", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000DAA RID: 3498
		[Token(Token = "0x4000DAA")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000DAB RID: 3499
		[Token(Token = "0x4000DAB")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x04000DAC RID: 3500
		[Token(Token = "0x4000DAC")]
		[FieldOffset(Offset = "0x10")]
		private uint m_Index;
	}
}
