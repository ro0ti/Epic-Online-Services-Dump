using System;


namespace Epic.OnlineServices.P2P
{
	// Token: 0x02000353 RID: 851
	[Token(Token = "0x2000353")]
	internal struct QueryNATTypeOptionsInternal : ISettable<QueryNATTypeOptions>, IDisposable
	{
		// Token: 0x060016E5 RID: 5861 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60016E5")]
		[Address(RVA = "0x4875E0", Offset = "0x485BE0", VA = "0x1804875E0", Slot = "4")]
		public void Set(ref QueryNATTypeOptions other)
		{
		}

		// Token: 0x060016E6 RID: 5862 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60016E6")]
		[Address(RVA = "0x51EDE0", Offset = "0x51D3E0", VA = "0x18051EDE0", Slot = "5")]
		public void Set(ref QueryNATTypeOptions? other)
		{
		}

		// Token: 0x060016E7 RID: 5863 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60016E7")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000A27 RID: 2599
		[Token(Token = "0x4000A27")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;
	}
}
