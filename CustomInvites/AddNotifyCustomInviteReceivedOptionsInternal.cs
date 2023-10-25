using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.CustomInvites
{
	// Token: 0x020005A1 RID: 1441
	[Token(Token = "0x20005A1")]
	internal struct AddNotifyCustomInviteReceivedOptionsInternal : ISettable<AddNotifyCustomInviteReceivedOptions>, IDisposable
	{
		// Token: 0x0600250C RID: 9484 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600250C")]
		[Address(RVA = "0x4875E0", Offset = "0x485BE0", VA = "0x1804875E0", Slot = "4")]
		public void Set(ref AddNotifyCustomInviteReceivedOptions other)
		{
		}

		// Token: 0x0600250D RID: 9485 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600250D")]
		[Address(RVA = "0x539E00", Offset = "0x538400", VA = "0x180539E00", Slot = "5")]
		public void Set(ref AddNotifyCustomInviteReceivedOptions? other)
		{
		}

		// Token: 0x0600250E RID: 9486 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600250E")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04001071 RID: 4209
		[Token(Token = "0x4001071")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;
	}
}
