using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.RTCAudio
{
	// Token: 0x020001CD RID: 461
	[Token(Token = "0x20001CD")]
	internal struct CopyInputDeviceInformationByIndexOptionsInternal : ISettable<CopyInputDeviceInformationByIndexOptions>, IDisposable
	{
		// Token: 0x1700032E RID: 814
		// (set) Token: 0x06000D31 RID: 3377 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700032E")]
		public uint DeviceIndex
		{
			[Token(Token = "0x6000D31")]
			[Address(RVA = "0x4A4E90", Offset = "0x4A3490", VA = "0x1804A4E90")]
			set
			{
			}
		}

		// Token: 0x06000D32 RID: 3378 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D32")]
		[Address(RVA = "0x4AFC00", Offset = "0x4AE200", VA = "0x1804AFC00", Slot = "4")]
		public void Set(ref CopyInputDeviceInformationByIndexOptions other)
		{
		}

		// Token: 0x06000D33 RID: 3379 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D33")]
		[Address(RVA = "0x4D87F0", Offset = "0x4D6DF0", VA = "0x1804D87F0", Slot = "5")]
		public void Set(ref CopyInputDeviceInformationByIndexOptions? other)
		{
		}

		// Token: 0x06000D34 RID: 3380 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D34")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000613 RID: 1555
		[Token(Token = "0x4000613")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000614 RID: 1556
		[Token(Token = "0x4000614")]
		[FieldOffset(Offset = "0x4")]
		private uint m_DeviceIndex;
	}
}
