using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.RTCAudio
{
	// Token: 0x020001D1 RID: 465
	[Token(Token = "0x20001D1")]
	internal struct GetAudioInputDeviceByIndexOptionsInternal : ISettable<GetAudioInputDeviceByIndexOptions>, IDisposable
	{
		// Token: 0x17000332 RID: 818
		// (set) Token: 0x06000D3D RID: 3389 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000332")]
		public uint DeviceInfoIndex
		{
			[Token(Token = "0x6000D3D")]
			[Address(RVA = "0x4A4E90", Offset = "0x4A3490", VA = "0x1804A4E90")]
			set
			{
			}
		}

		// Token: 0x06000D3E RID: 3390 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D3E")]
		[Address(RVA = "0x4AFC00", Offset = "0x4AE200", VA = "0x1804AFC00", Slot = "4")]
		public void Set(ref GetAudioInputDeviceByIndexOptions other)
		{
		}

		// Token: 0x06000D3F RID: 3391 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D3F")]
		[Address(RVA = "0x4D9440", Offset = "0x4D7A40", VA = "0x1804D9440", Slot = "5")]
		public void Set(ref GetAudioInputDeviceByIndexOptions? other)
		{
		}

		// Token: 0x06000D40 RID: 3392 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D40")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000619 RID: 1561
		[Token(Token = "0x4000619")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x0400061A RID: 1562
		[Token(Token = "0x400061A")]
		[FieldOffset(Offset = "0x4")]
		private uint m_DeviceInfoIndex;
	}
}
