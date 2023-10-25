using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.RTCAudio
{
	// Token: 0x020001D5 RID: 469
	[Token(Token = "0x20001D5")]
	internal struct GetAudioOutputDeviceByIndexOptionsInternal : ISettable<GetAudioOutputDeviceByIndexOptions>, IDisposable
	{
		// Token: 0x17000334 RID: 820
		// (set) Token: 0x06000D46 RID: 3398 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000334")]
		public uint DeviceInfoIndex
		{
			[Token(Token = "0x6000D46")]
			[Address(RVA = "0x4A4E90", Offset = "0x4A3490", VA = "0x1804A4E90")]
			set
			{
			}
		}

		// Token: 0x06000D47 RID: 3399 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D47")]
		[Address(RVA = "0x4AFC00", Offset = "0x4AE200", VA = "0x1804AFC00", Slot = "4")]
		public void Set(ref GetAudioOutputDeviceByIndexOptions other)
		{
		}

		// Token: 0x06000D48 RID: 3400 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D48")]
		[Address(RVA = "0x4D94F0", Offset = "0x4D7AF0", VA = "0x1804D94F0", Slot = "5")]
		public void Set(ref GetAudioOutputDeviceByIndexOptions? other)
		{
		}

		// Token: 0x06000D49 RID: 3401 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D49")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x0400061D RID: 1565
		[Token(Token = "0x400061D")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x0400061E RID: 1566
		[Token(Token = "0x400061E")]
		[FieldOffset(Offset = "0x4")]
		private uint m_DeviceInfoIndex;
	}
}
