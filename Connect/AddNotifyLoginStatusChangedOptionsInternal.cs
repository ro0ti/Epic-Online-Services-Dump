using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Connect
{
	// Token: 0x020005EB RID: 1515
	[Token(Token = "0x20005EB")]
	internal struct AddNotifyLoginStatusChangedOptionsInternal : ISettable<AddNotifyLoginStatusChangedOptions>, IDisposable
	{
		// Token: 0x060026E0 RID: 9952 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60026E0")]
		[Address(RVA = "0x4875E0", Offset = "0x485BE0", VA = "0x1804875E0", Slot = "4")]
		public void Set(ref AddNotifyLoginStatusChangedOptions other)
		{
		}

		// Token: 0x060026E1 RID: 9953 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60026E1")]
		[Address(RVA = "0x552F10", Offset = "0x551510", VA = "0x180552F10", Slot = "5")]
		public void Set(ref AddNotifyLoginStatusChangedOptions? other)
		{
		}

		// Token: 0x060026E2 RID: 9954 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60026E2")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04001106 RID: 4358
		[Token(Token = "0x4001106")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;
	}
}
