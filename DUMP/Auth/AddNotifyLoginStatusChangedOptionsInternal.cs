using System;


namespace Epic.OnlineServices.Auth
{
	// Token: 0x0200064C RID: 1612
	[Token(Token = "0x200064C")]
	internal struct AddNotifyLoginStatusChangedOptionsInternal : ISettable<AddNotifyLoginStatusChangedOptions>, IDisposable
	{
		// Token: 0x0600294D RID: 10573 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600294D")]
		[Address(RVA = "0x4875E0", Offset = "0x485BE0", VA = "0x1804875E0", Slot = "4")]
		public void Set(ref AddNotifyLoginStatusChangedOptions other)
		{
		}

		// Token: 0x0600294E RID: 10574 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600294E")]
		[Address(RVA = "0x552EC0", Offset = "0x5514C0", VA = "0x180552EC0", Slot = "5")]
		public void Set(ref AddNotifyLoginStatusChangedOptions? other)
		{
		}

		// Token: 0x0600294F RID: 10575 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600294F")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x040011EF RID: 4591
		[Token(Token = "0x40011EF")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;
	}
}
