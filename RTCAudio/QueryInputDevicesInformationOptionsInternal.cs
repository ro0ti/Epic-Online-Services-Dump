using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.RTCAudio
{
	// Token: 0x02000211 RID: 529
	[Token(Token = "0x2000211")]
	internal struct QueryInputDevicesInformationOptionsInternal : ISettable<QueryInputDevicesInformationOptions>, IDisposable
	{
		// Token: 0x06000E86 RID: 3718 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000E86")]
		[Address(RVA = "0x4875E0", Offset = "0x485BE0", VA = "0x1804875E0", Slot = "4")]
		public void Set(ref QueryInputDevicesInformationOptions other)
		{
		}

		// Token: 0x06000E87 RID: 3719 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000E87")]
		[Address(RVA = "0x4DF6F0", Offset = "0x4DDCF0", VA = "0x1804DF6F0", Slot = "5")]
		public void Set(ref QueryInputDevicesInformationOptions? other)
		{
		}

		// Token: 0x06000E88 RID: 3720 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000E88")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x0400065C RID: 1628
		[Token(Token = "0x400065C")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;
	}
}
