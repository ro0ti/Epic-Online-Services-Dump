using System;


namespace Epic.OnlineServices.RTCAudio
{
	// Token: 0x020001D9 RID: 473
	[Token(Token = "0x20001D9")]
	internal struct GetInputDevicesCountOptionsInternal : ISettable<GetInputDevicesCountOptions>, IDisposable
	{
		// Token: 0x06000D4D RID: 3405 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D4D")]
		[Address(RVA = "0x4875E0", Offset = "0x485BE0", VA = "0x1804875E0", Slot = "4")]
		public void Set(ref GetInputDevicesCountOptions other)
		{
		}

		// Token: 0x06000D4E RID: 3406 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D4E")]
		[Address(RVA = "0x4D95A0", Offset = "0x4D7BA0", VA = "0x1804D95A0", Slot = "5")]
		public void Set(ref GetInputDevicesCountOptions? other)
		{
		}

		// Token: 0x06000D4F RID: 3407 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D4F")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000620 RID: 1568
		[Token(Token = "0x4000620")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;
	}
}
