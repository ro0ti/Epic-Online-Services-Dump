using System;


namespace Epic.OnlineServices.P2P
{
	// Token: 0x02000327 RID: 807
	[Token(Token = "0x2000327")]
	internal struct CloseConnectionsOptionsInternal : ISettable<CloseConnectionsOptions>, IDisposable
	{
		// Token: 0x170005E5 RID: 1509
		// (set) Token: 0x060015C3 RID: 5571 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170005E5")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x60015C3")]
			[Address(RVA = "0x4EE1A0", Offset = "0x4EC7A0", VA = "0x1804EE1A0")]
			set
			{
			}
		}

		// Token: 0x170005E6 RID: 1510
		// (set) Token: 0x060015C4 RID: 5572 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170005E6")]
		public SocketId? SocketId
		{
			[Token(Token = "0x60015C4")]
			[Address(RVA = "0x4EE200", Offset = "0x4EC800", VA = "0x1804EE200")]
			set
			{
			}
		}

		// Token: 0x060015C5 RID: 5573 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60015C5")]
		[Address(RVA = "0x4EDF90", Offset = "0x4EC590", VA = "0x1804EDF90", Slot = "4")]
		public void Set(ref CloseConnectionsOptions other)
		{
		}

		// Token: 0x060015C6 RID: 5574 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60015C6")]
		[Address(RVA = "0x4EE070", Offset = "0x4EC670", VA = "0x1804EE070", Slot = "5")]
		public void Set(ref CloseConnectionsOptions? other)
		{
		}

		// Token: 0x060015C7 RID: 5575 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60015C7")]
		[Address(RVA = "0x4EDF30", Offset = "0x4EC530", VA = "0x1804EDF30", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x040009A2 RID: 2466
		[Token(Token = "0x40009A2")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x040009A3 RID: 2467
		[Token(Token = "0x40009A3")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x040009A4 RID: 2468
		[Token(Token = "0x40009A4")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_SocketId;
	}
}
