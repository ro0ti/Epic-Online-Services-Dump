using System;


namespace Epic.OnlineServices.RTCAudio
{
	// Token: 0x020001DB RID: 475
	[Token(Token = "0x20001DB")]
	internal struct GetOutputDevicesCountOptionsInternal : ISettable<GetOutputDevicesCountOptions>, IDisposable
	{
		// Token: 0x06000D50 RID: 3408 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D50")]
		[Address(RVA = "0x4875E0", Offset = "0x485BE0", VA = "0x1804875E0", Slot = "4")]
		public void Set(ref GetOutputDevicesCountOptions other)
		{
		}

		// Token: 0x06000D51 RID: 3409 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D51")]
		[Address(RVA = "0x4D95F0", Offset = "0x4D7BF0", VA = "0x1804D95F0", Slot = "5")]
		public void Set(ref GetOutputDevicesCountOptions? other)
		{
		}

		// Token: 0x06000D52 RID: 3410 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D52")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000621 RID: 1569
		[Token(Token = "0x4000621")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;
	}
}
