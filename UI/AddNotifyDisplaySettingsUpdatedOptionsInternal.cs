using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.UI
{
	// Token: 0x0200005E RID: 94
	[Token(Token = "0x200005E")]
	internal struct AddNotifyDisplaySettingsUpdatedOptionsInternal : ISettable<AddNotifyDisplaySettingsUpdatedOptions>, IDisposable
	{
		// Token: 0x060004BB RID: 1211 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x4875E0", Offset = "0x485BE0", VA = "0x1804875E0", Slot = "4")]
		public void Set(ref AddNotifyDisplaySettingsUpdatedOptions other)
		{
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x4875F0", Offset = "0x485BF0", VA = "0x1804875F0", Slot = "5")]
		public void Set(ref AddNotifyDisplaySettingsUpdatedOptions? other)
		{
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x0400020E RID: 526
		[Token(Token = "0x400020E")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;
	}
}
