using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.RTCAudio
{
	// Token: 0x020001CF RID: 463
	[Token(Token = "0x20001CF")]
	internal struct CopyOutputDeviceInformationByIndexOptionsInternal : ISettable<CopyOutputDeviceInformationByIndexOptions>, IDisposable
	{
		// Token: 0x17000330 RID: 816
		// (set) Token: 0x06000D37 RID: 3383 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000330")]
		public uint DeviceIndex
		{
			[Token(Token = "0x6000D37")]
			[Address(RVA = "0x4A4E90", Offset = "0x4A3490", VA = "0x1804A4E90")]
			set
			{
			}
		}

		// Token: 0x06000D38 RID: 3384 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D38")]
		[Address(RVA = "0x4AFC00", Offset = "0x4AE200", VA = "0x1804AFC00", Slot = "4")]
		public void Set(ref CopyOutputDeviceInformationByIndexOptions other)
		{
		}

		// Token: 0x06000D39 RID: 3385 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D39")]
		[Address(RVA = "0x4D8850", Offset = "0x4D6E50", VA = "0x1804D8850", Slot = "5")]
		public void Set(ref CopyOutputDeviceInformationByIndexOptions? other)
		{
		}

		// Token: 0x06000D3A RID: 3386 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D3A")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000616 RID: 1558
		[Token(Token = "0x4000616")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000617 RID: 1559
		[Token(Token = "0x4000617")]
		[FieldOffset(Offset = "0x4")]
		private uint m_DeviceIndex;
	}
}
