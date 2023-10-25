using System;


namespace Epic.OnlineServices.PlayerDataStorage
{
	// Token: 0x020002DB RID: 731
	[Token(Token = "0x20002DB")]
	internal struct DeleteCacheOptionsInternal : ISettable<DeleteCacheOptions>, IDisposable
	{
		// Token: 0x1700053F RID: 1343
		// (set) Token: 0x060013CE RID: 5070 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700053F")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x60013CE")]
			[Address(RVA = "0x4EF740", Offset = "0x4EDD40", VA = "0x1804EF740")]
			set
			{
			}
		}

		// Token: 0x060013CF RID: 5071 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013CF")]
		[Address(RVA = "0x4EF640", Offset = "0x4EDC40", VA = "0x1804EF640", Slot = "4")]
		public void Set(ref DeleteCacheOptions other)
		{
		}

		// Token: 0x060013D0 RID: 5072 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013D0")]
		[Address(RVA = "0x4EF6A0", Offset = "0x4EDCA0", VA = "0x1804EF6A0", Slot = "5")]
		public void Set(ref DeleteCacheOptions? other)
		{
		}

		// Token: 0x060013D1 RID: 5073 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013D1")]
		[Address(RVA = "0x4EF5F0", Offset = "0x4EDBF0", VA = "0x1804EF5F0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x040008CF RID: 2255
		[Token(Token = "0x40008CF")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x040008D0 RID: 2256
		[Token(Token = "0x40008D0")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;
	}
}
