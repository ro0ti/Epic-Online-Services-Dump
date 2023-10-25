using System;


namespace Epic.OnlineServices.Sessions
{
	// Token: 0x020000EB RID: 235
	[Token(Token = "0x20000EB")]
	internal struct ActiveSessionGetRegisteredPlayerCountOptionsInternal : ISettable<ActiveSessionGetRegisteredPlayerCountOptions>, IDisposable
	{
		// Token: 0x06000815 RID: 2069 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000815")]
		[Address(RVA = "0x4875E0", Offset = "0x485BE0", VA = "0x1804875E0", Slot = "4")]
		public void Set(ref ActiveSessionGetRegisteredPlayerCountOptions other)
		{
		}

		// Token: 0x06000816 RID: 2070 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000816")]
		[Address(RVA = "0x4B84A0", Offset = "0x4B6AA0", VA = "0x1804B84A0", Slot = "5")]
		public void Set(ref ActiveSessionGetRegisteredPlayerCountOptions? other)
		{
		}

		// Token: 0x06000817 RID: 2071 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000817")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x040003F5 RID: 1013
		[Token(Token = "0x40003F5")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;
	}
}
