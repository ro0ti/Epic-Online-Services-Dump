using System;


namespace Epic.OnlineServices.Connect
{
	// Token: 0x02000606 RID: 1542
	[Token(Token = "0x2000606")]
	internal struct DeleteDeviceIdOptionsInternal : ISettable<DeleteDeviceIdOptions>, IDisposable
	{
		// Token: 0x0600278A RID: 10122 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600278A")]
		[Address(RVA = "0x4875E0", Offset = "0x485BE0", VA = "0x1804875E0", Slot = "4")]
		public void Set(ref DeleteDeviceIdOptions other)
		{
		}

		// Token: 0x0600278B RID: 10123 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600278B")]
		[Address(RVA = "0x559C10", Offset = "0x558210", VA = "0x180559C10", Slot = "5")]
		public void Set(ref DeleteDeviceIdOptions? other)
		{
		}

		// Token: 0x0600278C RID: 10124 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600278C")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04001158 RID: 4440
		[Token(Token = "0x4001158")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;
	}
}
