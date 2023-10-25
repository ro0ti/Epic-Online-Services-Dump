using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.TitleStorage
{
	// Token: 0x020000AA RID: 170
	[Token(Token = "0x20000AA")]
	internal struct DeleteCacheOptionsInternal : ISettable<DeleteCacheOptions>, IDisposable
	{
		// Token: 0x17000113 RID: 275
		// (set) Token: 0x06000664 RID: 1636 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000113")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6000664")]
			[Address(RVA = "0x4A1E40", Offset = "0x4A0440", VA = "0x1804A1E40")]
			set
			{
			}
		}

		// Token: 0x06000665 RID: 1637 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000665")]
		[Address(RVA = "0x4A1E20", Offset = "0x4A0420", VA = "0x1804A1E20", Slot = "4")]
		public void Set(ref DeleteCacheOptions other)
		{
		}

		// Token: 0x06000666 RID: 1638 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000666")]
		[Address(RVA = "0x4A1DB0", Offset = "0x4A03B0", VA = "0x1804A1DB0", Slot = "5")]
		public void Set(ref DeleteCacheOptions? other)
		{
		}

		// Token: 0x06000667 RID: 1639 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000667")]
		[Address(RVA = "0x4A1D20", Offset = "0x4A0320", VA = "0x1804A1D20", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x0400033C RID: 828
		[Token(Token = "0x400033C")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x0400033D RID: 829
		[Token(Token = "0x400033D")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;
	}
}
