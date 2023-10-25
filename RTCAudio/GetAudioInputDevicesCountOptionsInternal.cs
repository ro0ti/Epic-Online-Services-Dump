using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.RTCAudio
{
	// Token: 0x020001D3 RID: 467
	[Token(Token = "0x20001D3")]
	internal struct GetAudioInputDevicesCountOptionsInternal : ISettable<GetAudioInputDevicesCountOptions>, IDisposable
	{
		// Token: 0x06000D41 RID: 3393 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D41")]
		[Address(RVA = "0x4875E0", Offset = "0x485BE0", VA = "0x1804875E0", Slot = "4")]
		public void Set(ref GetAudioInputDevicesCountOptions other)
		{
		}

		// Token: 0x06000D42 RID: 3394 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D42")]
		[Address(RVA = "0x4D94A0", Offset = "0x4D7AA0", VA = "0x1804D94A0", Slot = "5")]
		public void Set(ref GetAudioInputDevicesCountOptions? other)
		{
		}

		// Token: 0x06000D43 RID: 3395 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D43")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x0400061B RID: 1563
		[Token(Token = "0x400061B")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;
	}
}
