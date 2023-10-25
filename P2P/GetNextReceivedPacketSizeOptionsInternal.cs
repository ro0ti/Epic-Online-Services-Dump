using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.P2P
{
	// Token: 0x0200032D RID: 813
	[Token(Token = "0x200032D")]
	internal struct GetNextReceivedPacketSizeOptionsInternal : ISettable<GetNextReceivedPacketSizeOptions>, IDisposable
	{
		// Token: 0x170005E9 RID: 1513
		// (set) Token: 0x060015CF RID: 5583 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170005E9")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x60015CF")]
			[Address(RVA = "0x4F2500", Offset = "0x4F0B00", VA = "0x1804F2500")]
			set
			{
			}
		}

		// Token: 0x170005EA RID: 1514
		// (set) Token: 0x060015D0 RID: 5584 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170005EA")]
		public byte? RequestedChannel
		{
			[Token(Token = "0x60015D0")]
			[Address(RVA = "0x4F2560", Offset = "0x4F0B60", VA = "0x1804F2560")]
			set
			{
			}
		}

		// Token: 0x060015D1 RID: 5585 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60015D1")]
		[Address(RVA = "0x4F2350", Offset = "0x4F0950", VA = "0x1804F2350", Slot = "4")]
		public void Set(ref GetNextReceivedPacketSizeOptions other)
		{
		}

		// Token: 0x060015D2 RID: 5586 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60015D2")]
		[Address(RVA = "0x4F2420", Offset = "0x4F0A20", VA = "0x1804F2420", Slot = "5")]
		public void Set(ref GetNextReceivedPacketSizeOptions? other)
		{
		}

		// Token: 0x060015D3 RID: 5587 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60015D3")]
		[Address(RVA = "0x4F22F0", Offset = "0x4F08F0", VA = "0x1804F22F0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x040009B7 RID: 2487
		[Token(Token = "0x40009B7")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x040009B8 RID: 2488
		[Token(Token = "0x40009B8")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x040009B9 RID: 2489
		[Token(Token = "0x40009B9")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_RequestedChannel;
	}
}
