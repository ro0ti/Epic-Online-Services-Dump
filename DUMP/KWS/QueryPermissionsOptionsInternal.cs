using System;


namespace Epic.OnlineServices.KWS
{
	// Token: 0x020004CF RID: 1231
	[Token(Token = "0x20004CF")]
	internal struct QueryPermissionsOptionsInternal : ISettable<QueryPermissionsOptions>, IDisposable
	{
		// Token: 0x170008F7 RID: 2295
		// (set) Token: 0x06001FB6 RID: 8118 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170008F7")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6001FB6")]
			[Address(RVA = "0x534920", Offset = "0x532F20", VA = "0x180534920")]
			set
			{
			}
		}

		// Token: 0x06001FB7 RID: 8119 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001FB7")]
		[Address(RVA = "0x5348C0", Offset = "0x532EC0", VA = "0x1805348C0", Slot = "4")]
		public void Set(ref QueryPermissionsOptions other)
		{
		}

		// Token: 0x06001FB8 RID: 8120 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001FB8")]
		[Address(RVA = "0x534820", Offset = "0x532E20", VA = "0x180534820", Slot = "5")]
		public void Set(ref QueryPermissionsOptions? other)
		{
		}

		// Token: 0x06001FB9 RID: 8121 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001FB9")]
		[Address(RVA = "0x5347D0", Offset = "0x532DD0", VA = "0x1805347D0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000DFF RID: 3583
		[Token(Token = "0x4000DFF")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000E00 RID: 3584
		[Token(Token = "0x4000E00")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;
	}
}
