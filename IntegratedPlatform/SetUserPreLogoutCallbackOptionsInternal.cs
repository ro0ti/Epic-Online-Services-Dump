using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.IntegratedPlatform
{
	// Token: 0x020004EF RID: 1263
	[Token(Token = "0x20004EF")]
	internal struct SetUserPreLogoutCallbackOptionsInternal : ISettable<SetUserPreLogoutCallbackOptions>, IDisposable
	{
		// Token: 0x0600204A RID: 8266 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600204A")]
		[Address(RVA = "0x4875E0", Offset = "0x485BE0", VA = "0x1804875E0", Slot = "4")]
		public void Set(ref SetUserPreLogoutCallbackOptions other)
		{
		}

		// Token: 0x0600204B RID: 8267 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600204B")]
		[Address(RVA = "0x551120", Offset = "0x54F720", VA = "0x180551120", Slot = "5")]
		public void Set(ref SetUserPreLogoutCallbackOptions? other)
		{
		}

		// Token: 0x0600204C RID: 8268 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600204C")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000E49 RID: 3657
		[Token(Token = "0x4000E49")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;
	}
}
