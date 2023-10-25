using System;


namespace Epic.OnlineServices.Sessions
{
	// Token: 0x020000F7 RID: 247
	[Token(Token = "0x20000F7")]
	internal struct AddNotifySessionInviteReceivedOptionsInternal : ISettable<AddNotifySessionInviteReceivedOptions>, IDisposable
	{
		// Token: 0x06000839 RID: 2105 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000839")]
		[Address(RVA = "0x4875E0", Offset = "0x485BE0", VA = "0x1804875E0", Slot = "4")]
		public void Set(ref AddNotifySessionInviteReceivedOptions other)
		{
		}

		// Token: 0x0600083A RID: 2106 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600083A")]
		[Address(RVA = "0x4B9100", Offset = "0x4B7700", VA = "0x1804B9100", Slot = "5")]
		public void Set(ref AddNotifySessionInviteReceivedOptions? other)
		{
		}

		// Token: 0x0600083B RID: 2107 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600083B")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000403 RID: 1027
		[Token(Token = "0x4000403")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;
	}
}
