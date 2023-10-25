using System;


namespace Epic.OnlineServices.CustomInvites
{
	// Token: 0x020005AD RID: 1453
	[Token(Token = "0x20005AD")]
	internal struct AddNotifySendCustomNativeInviteRequestedOptionsInternal : ISettable<AddNotifySendCustomNativeInviteRequestedOptions>, IDisposable
	{
		// Token: 0x0600251E RID: 9502 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600251E")]
		[Address(RVA = "0x4875E0", Offset = "0x485BE0", VA = "0x1804875E0", Slot = "4")]
		public void Set(ref AddNotifySendCustomNativeInviteRequestedOptions other)
		{
		}

		// Token: 0x0600251F RID: 9503 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600251F")]
		[Address(RVA = "0x53A030", Offset = "0x538630", VA = "0x18053A030", Slot = "5")]
		public void Set(ref AddNotifySendCustomNativeInviteRequestedOptions? other)
		{
		}

		// Token: 0x06002520 RID: 9504 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002520")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04001077 RID: 4215
		[Token(Token = "0x4001077")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;
	}
}
