using System;


namespace Epic.OnlineServices.P2P
{
	// Token: 0x02000323 RID: 803
	[Token(Token = "0x2000323")]
	internal struct ClearPacketQueueOptionsInternal : ISettable<ClearPacketQueueOptions>, IDisposable
	{
		// Token: 0x170005DA RID: 1498
		// (set) Token: 0x060015AD RID: 5549 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170005DA")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x60015AD")]
			[Address(RVA = "0x4ED9C0", Offset = "0x4EBFC0", VA = "0x1804ED9C0")]
			set
			{
			}
		}

		// Token: 0x170005DB RID: 1499
		// (set) Token: 0x060015AE RID: 5550 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170005DB")]
		public ProductUserId RemoteUserId
		{
			[Token(Token = "0x60015AE")]
			[Address(RVA = "0x4EDA20", Offset = "0x4EC020", VA = "0x1804EDA20")]
			set
			{
			}
		}

		// Token: 0x170005DC RID: 1500
		// (set) Token: 0x060015AF RID: 5551 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170005DC")]
		public SocketId? SocketId
		{
			[Token(Token = "0x60015AF")]
			[Address(RVA = "0x4EDA80", Offset = "0x4EC080", VA = "0x1804EDA80")]
			set
			{
			}
		}

		// Token: 0x060015B0 RID: 5552 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60015B0")]
		[Address(RVA = "0x4ED720", Offset = "0x4EBD20", VA = "0x1804ED720", Slot = "4")]
		public void Set(ref ClearPacketQueueOptions other)
		{
		}

		// Token: 0x060015B1 RID: 5553 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60015B1")]
		[Address(RVA = "0x4ED840", Offset = "0x4EBE40", VA = "0x1804ED840", Slot = "5")]
		public void Set(ref ClearPacketQueueOptions? other)
		{
		}

		// Token: 0x060015B2 RID: 5554 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60015B2")]
		[Address(RVA = "0x4ED6B0", Offset = "0x4EBCB0", VA = "0x1804ED6B0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000995 RID: 2453
		[Token(Token = "0x4000995")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000996 RID: 2454
		[Token(Token = "0x4000996")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x04000997 RID: 2455
		[Token(Token = "0x4000997")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_RemoteUserId;

		// Token: 0x04000998 RID: 2456
		[Token(Token = "0x4000998")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_SocketId;
	}
}
