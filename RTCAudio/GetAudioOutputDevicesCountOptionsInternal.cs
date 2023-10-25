using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.RTCAudio
{
	// Token: 0x020001D7 RID: 471
	[Token(Token = "0x20001D7")]
	internal struct GetAudioOutputDevicesCountOptionsInternal : ISettable<GetAudioOutputDevicesCountOptions>, IDisposable
	{
		// Token: 0x06000D4A RID: 3402 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D4A")]
		[Address(RVA = "0x4875E0", Offset = "0x485BE0", VA = "0x1804875E0", Slot = "4")]
		public void Set(ref GetAudioOutputDevicesCountOptions other)
		{
		}

		// Token: 0x06000D4B RID: 3403 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D4B")]
		[Address(RVA = "0x4D9550", Offset = "0x4D7B50", VA = "0x1804D9550", Slot = "5")]
		public void Set(ref GetAudioOutputDevicesCountOptions? other)
		{
		}

		// Token: 0x06000D4C RID: 3404 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D4C")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x0400061F RID: 1567
		[Token(Token = "0x400061F")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;
	}
}
