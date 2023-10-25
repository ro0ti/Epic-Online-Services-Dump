using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.CustomInvites
{
	// Token: 0x0200059F RID: 1439
	[Token(Token = "0x200059F")]
	internal struct AddNotifyCustomInviteAcceptedOptionsInternal : ISettable<AddNotifyCustomInviteAcceptedOptions>, IDisposable
	{
		// Token: 0x06002509 RID: 9481 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002509")]
		[Address(RVA = "0x4875E0", Offset = "0x485BE0", VA = "0x1804875E0", Slot = "4")]
		public void Set(ref AddNotifyCustomInviteAcceptedOptions other)
		{
		}

		// Token: 0x0600250A RID: 9482 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600250A")]
		[Address(RVA = "0x539DB0", Offset = "0x5383B0", VA = "0x180539DB0", Slot = "5")]
		public void Set(ref AddNotifyCustomInviteAcceptedOptions? other)
		{
		}

		// Token: 0x0600250B RID: 9483 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600250B")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04001070 RID: 4208
		[Token(Token = "0x4001070")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;
	}
}
