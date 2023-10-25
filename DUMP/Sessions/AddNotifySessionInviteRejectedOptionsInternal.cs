using System;


namespace Epic.OnlineServices.Sessions
{
	// Token: 0x020000F9 RID: 249
	[Token(Token = "0x20000F9")]
	internal struct AddNotifySessionInviteRejectedOptionsInternal : ISettable<AddNotifySessionInviteRejectedOptions>, IDisposable
	{
		// Token: 0x0600083C RID: 2108 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600083C")]
		[Address(RVA = "0x4875E0", Offset = "0x485BE0", VA = "0x1804875E0", Slot = "4")]
		public void Set(ref AddNotifySessionInviteRejectedOptions other)
		{
		}

		// Token: 0x0600083D RID: 2109 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600083D")]
		[Address(RVA = "0x4B9150", Offset = "0x4B7750", VA = "0x1804B9150", Slot = "5")]
		public void Set(ref AddNotifySessionInviteRejectedOptions? other)
		{
		}

		// Token: 0x0600083E RID: 2110 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600083E")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000404 RID: 1028
		[Token(Token = "0x4000404")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;
	}
}
