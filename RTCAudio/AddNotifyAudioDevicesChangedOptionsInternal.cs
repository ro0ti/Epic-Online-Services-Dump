using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.RTCAudio
{
	// Token: 0x020001B5 RID: 437
	[Token(Token = "0x20001B5")]
	internal struct AddNotifyAudioDevicesChangedOptionsInternal : ISettable<AddNotifyAudioDevicesChangedOptions>, IDisposable
	{
		// Token: 0x06000C73 RID: 3187 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C73")]
		[Address(RVA = "0x4875E0", Offset = "0x485BE0", VA = "0x1804875E0", Slot = "4")]
		public void Set(ref AddNotifyAudioDevicesChangedOptions other)
		{
		}

		// Token: 0x06000C74 RID: 3188 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C74")]
		[Address(RVA = "0x4D3370", Offset = "0x4D1970", VA = "0x1804D3370", Slot = "5")]
		public void Set(ref AddNotifyAudioDevicesChangedOptions? other)
		{
		}

		// Token: 0x06000C75 RID: 3189 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C75")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x040005C8 RID: 1480
		[Token(Token = "0x40005C8")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;
	}
}
