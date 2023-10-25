using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.P2P
{
	// Token: 0x0200031B RID: 795
	[Token(Token = "0x200031B")]
	internal struct AddNotifyPeerConnectionClosedOptionsInternal : ISettable<AddNotifyPeerConnectionClosedOptions>, IDisposable
	{
		// Token: 0x170005C9 RID: 1481
		// (set) Token: 0x06001587 RID: 5511 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170005C9")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6001587")]
			[Address(RVA = "0x4EC720", Offset = "0x4EAD20", VA = "0x1804EC720")]
			set
			{
			}
		}

		// Token: 0x170005CA RID: 1482
		// (set) Token: 0x06001588 RID: 5512 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170005CA")]
		public SocketId? SocketId
		{
			[Token(Token = "0x6001588")]
			[Address(RVA = "0x4EC780", Offset = "0x4EAD80", VA = "0x1804EC780")]
			set
			{
			}
		}

		// Token: 0x06001589 RID: 5513 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001589")]
		[Address(RVA = "0x4EC640", Offset = "0x4EAC40", VA = "0x1804EC640", Slot = "4")]
		public void Set(ref AddNotifyPeerConnectionClosedOptions other)
		{
		}

		// Token: 0x0600158A RID: 5514 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600158A")]
		[Address(RVA = "0x4EC510", Offset = "0x4EAB10", VA = "0x1804EC510", Slot = "5")]
		public void Set(ref AddNotifyPeerConnectionClosedOptions? other)
		{
		}

		// Token: 0x0600158B RID: 5515 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600158B")]
		[Address(RVA = "0x4EC4B0", Offset = "0x4EAAB0", VA = "0x1804EC4B0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000980 RID: 2432
		[Token(Token = "0x4000980")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000981 RID: 2433
		[Token(Token = "0x4000981")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x04000982 RID: 2434
		[Token(Token = "0x4000982")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_SocketId;
	}
}
