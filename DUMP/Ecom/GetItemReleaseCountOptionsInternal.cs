using System;


namespace Epic.OnlineServices.Ecom
{
	// Token: 0x02000557 RID: 1367
	[Token(Token = "0x2000557")]
	internal struct GetItemReleaseCountOptionsInternal : ISettable<GetItemReleaseCountOptions>, IDisposable
	{
		// Token: 0x17000A41 RID: 2625
		// (set) Token: 0x06002361 RID: 9057 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A41")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x6002361")]
			[Address(RVA = "0x547810", Offset = "0x545E10", VA = "0x180547810")]
			set
			{
			}
		}

		// Token: 0x17000A42 RID: 2626
		// (set) Token: 0x06002362 RID: 9058 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A42")]
		public Utf8String ItemId
		{
			[Token(Token = "0x6002362")]
			[Address(RVA = "0x5477B0", Offset = "0x545DB0", VA = "0x1805477B0")]
			set
			{
			}
		}

		// Token: 0x06002363 RID: 9059 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002363")]
		[Address(RVA = "0x5476F0", Offset = "0x545CF0", VA = "0x1805476F0", Slot = "4")]
		public void Set(ref GetItemReleaseCountOptions other)
		{
		}

		// Token: 0x06002364 RID: 9060 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002364")]
		[Address(RVA = "0x5475E0", Offset = "0x545BE0", VA = "0x1805475E0", Slot = "5")]
		public void Set(ref GetItemReleaseCountOptions? other)
		{
		}

		// Token: 0x06002365 RID: 9061 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002365")]
		[Address(RVA = "0x547580", Offset = "0x545B80", VA = "0x180547580", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000FCC RID: 4044
		[Token(Token = "0x4000FCC")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000FCD RID: 4045
		[Token(Token = "0x4000FCD")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x04000FCE RID: 4046
		[Token(Token = "0x4000FCE")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_ItemId;
	}
}
