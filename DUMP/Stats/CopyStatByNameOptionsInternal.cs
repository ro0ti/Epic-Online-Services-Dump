using System;


namespace Epic.OnlineServices.Stats
{
	// Token: 0x020000D1 RID: 209
	[Token(Token = "0x20000D1")]
	internal struct CopyStatByNameOptionsInternal : ISettable<CopyStatByNameOptions>, IDisposable
	{
		// Token: 0x17000167 RID: 359
		// (set) Token: 0x06000774 RID: 1908 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000167")]
		public ProductUserId TargetUserId
		{
			[Token(Token = "0x6000774")]
			[Address(RVA = "0x4BB630", Offset = "0x4B9C30", VA = "0x1804BB630")]
			set
			{
			}
		}

		// Token: 0x17000168 RID: 360
		// (set) Token: 0x06000775 RID: 1909 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000168")]
		public Utf8String Name
		{
			[Token(Token = "0x6000775")]
			[Address(RVA = "0x4BB5D0", Offset = "0x4B9BD0", VA = "0x1804BB5D0")]
			set
			{
			}
		}

		// Token: 0x06000776 RID: 1910 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000776")]
		[Address(RVA = "0x4BB400", Offset = "0x4B9A00", VA = "0x1804BB400", Slot = "4")]
		public void Set(ref CopyStatByNameOptions other)
		{
		}

		// Token: 0x06000777 RID: 1911 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000777")]
		[Address(RVA = "0x4BB4C0", Offset = "0x4B9AC0", VA = "0x1804BB4C0", Slot = "5")]
		public void Set(ref CopyStatByNameOptions? other)
		{
		}

		// Token: 0x06000778 RID: 1912 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000778")]
		[Address(RVA = "0x4BB3A0", Offset = "0x4B99A0", VA = "0x1804BB3A0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x040003AA RID: 938
		[Token(Token = "0x40003AA")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x040003AB RID: 939
		[Token(Token = "0x40003AB")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_TargetUserId;

		// Token: 0x040003AC RID: 940
		[Token(Token = "0x40003AC")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_Name;
	}
}
