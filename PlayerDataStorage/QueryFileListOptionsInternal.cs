using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.PlayerDataStorage
{
	// Token: 0x02000305 RID: 773
	[Token(Token = "0x2000305")]
	internal struct QueryFileListOptionsInternal : ISettable<QueryFileListOptions>, IDisposable
	{
		// Token: 0x17000580 RID: 1408
		// (set) Token: 0x060014DF RID: 5343 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000580")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x60014DF")]
			[Address(RVA = "0x4FDE30", Offset = "0x4FC430", VA = "0x1804FDE30")]
			set
			{
			}
		}

		// Token: 0x060014E0 RID: 5344 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60014E0")]
		[Address(RVA = "0x4FDD30", Offset = "0x4FC330", VA = "0x1804FDD30", Slot = "4")]
		public void Set(ref QueryFileListOptions other)
		{
		}

		// Token: 0x060014E1 RID: 5345 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60014E1")]
		[Address(RVA = "0x4FDD90", Offset = "0x4FC390", VA = "0x1804FDD90", Slot = "5")]
		public void Set(ref QueryFileListOptions? other)
		{
		}

		// Token: 0x060014E2 RID: 5346 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60014E2")]
		[Address(RVA = "0x4FDCE0", Offset = "0x4FC2E0", VA = "0x1804FDCE0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000927 RID: 2343
		[Token(Token = "0x4000927")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000928 RID: 2344
		[Token(Token = "0x4000928")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;
	}
}
