using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.P2P
{
	// Token: 0x0200031F RID: 799
	[Token(Token = "0x200031F")]
	internal struct AddNotifyPeerConnectionInterruptedOptionsInternal : ISettable<AddNotifyPeerConnectionInterruptedOptions>, IDisposable
	{
		// Token: 0x170005D1 RID: 1489
		// (set) Token: 0x06001599 RID: 5529 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170005D1")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6001599")]
			[Address(RVA = "0x4ECDD0", Offset = "0x4EB3D0", VA = "0x1804ECDD0")]
			set
			{
			}
		}

		// Token: 0x170005D2 RID: 1490
		// (set) Token: 0x0600159A RID: 5530 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170005D2")]
		public SocketId? SocketId
		{
			[Token(Token = "0x600159A")]
			[Address(RVA = "0x4ECE30", Offset = "0x4EB430", VA = "0x1804ECE30")]
			set
			{
			}
		}

		// Token: 0x0600159B RID: 5531 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600159B")]
		[Address(RVA = "0x4ECBC0", Offset = "0x4EB1C0", VA = "0x1804ECBC0", Slot = "4")]
		public void Set(ref AddNotifyPeerConnectionInterruptedOptions other)
		{
		}

		// Token: 0x0600159C RID: 5532 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600159C")]
		[Address(RVA = "0x4ECCA0", Offset = "0x4EB2A0", VA = "0x1804ECCA0", Slot = "5")]
		public void Set(ref AddNotifyPeerConnectionInterruptedOptions? other)
		{
		}

		// Token: 0x0600159D RID: 5533 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600159D")]
		[Address(RVA = "0x4ECB60", Offset = "0x4EB160", VA = "0x1804ECB60", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x0400098A RID: 2442
		[Token(Token = "0x400098A")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x0400098B RID: 2443
		[Token(Token = "0x400098B")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x0400098C RID: 2444
		[Token(Token = "0x400098C")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_SocketId;
	}
}
