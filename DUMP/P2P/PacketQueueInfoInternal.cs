using System;


namespace Epic.OnlineServices.P2P
{
	// Token: 0x02000350 RID: 848
	[Token(Token = "0x2000350")]
	internal struct PacketQueueInfoInternal : IGettable<PacketQueueInfo>, ISettable<PacketQueueInfo>, IDisposable
	{
		// Token: 0x1700062F RID: 1583
		// (get) Token: 0x060016D5 RID: 5845 RVA: 0x0000680C File Offset: 0x00004A0C
		// (set) Token: 0x060016D6 RID: 5846 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700062F")]
		public ulong IncomingPacketQueueMaxSizeBytes
		{
			[Token(Token = "0x60016D5")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x60016D6")]
			[Address(RVA = "0x4875D0", Offset = "0x485BD0", VA = "0x1804875D0")]
			set
			{
			}
		}

		// Token: 0x17000630 RID: 1584
		// (get) Token: 0x060016D7 RID: 5847 RVA: 0x00006824 File Offset: 0x00004A24
		// (set) Token: 0x060016D8 RID: 5848 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000630")]
		public ulong IncomingPacketQueueCurrentSizeBytes
		{
			[Token(Token = "0x60016D7")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x60016D8")]
			[Address(RVA = "0x487590", Offset = "0x485B90", VA = "0x180487590")]
			set
			{
			}
		}

		// Token: 0x17000631 RID: 1585
		// (get) Token: 0x060016D9 RID: 5849 RVA: 0x0000683C File Offset: 0x00004A3C
		// (set) Token: 0x060016DA RID: 5850 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000631")]
		public ulong IncomingPacketQueueCurrentPacketCount
		{
			[Token(Token = "0x60016D9")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x60016DA")]
			[Address(RVA = "0x4A6940", Offset = "0x4A4F40", VA = "0x1804A6940")]
			set
			{
			}
		}

		// Token: 0x17000632 RID: 1586
		// (get) Token: 0x060016DB RID: 5851 RVA: 0x00006854 File Offset: 0x00004A54
		// (set) Token: 0x060016DC RID: 5852 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000632")]
		public ulong OutgoingPacketQueueMaxSizeBytes
		{
			[Token(Token = "0x60016DB")]
			[Address(RVA = "0x3E4B20", Offset = "0x3E3120", VA = "0x1803E4B20")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x60016DC")]
			[Address(RVA = "0x4DEC40", Offset = "0x4DD240", VA = "0x1804DEC40")]
			set
			{
			}
		}

		// Token: 0x17000633 RID: 1587
		// (get) Token: 0x060016DD RID: 5853 RVA: 0x0000686C File Offset: 0x00004A6C
		// (set) Token: 0x060016DE RID: 5854 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000633")]
		public ulong OutgoingPacketQueueCurrentSizeBytes
		{
			[Token(Token = "0x60016DD")]
			[Address(RVA = "0x4447A0", Offset = "0x442DA0", VA = "0x1804447A0")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x60016DE")]
			[Address(RVA = "0x4F4050", Offset = "0x4F2650", VA = "0x1804F4050")]
			set
			{
			}
		}

		// Token: 0x17000634 RID: 1588
		// (get) Token: 0x060016DF RID: 5855 RVA: 0x00006884 File Offset: 0x00004A84
		// (set) Token: 0x060016E0 RID: 5856 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000634")]
		public ulong OutgoingPacketQueueCurrentPacketCount
		{
			[Token(Token = "0x60016DF")]
			[Address(RVA = "0x444770", Offset = "0x442D70", VA = "0x180444770")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x60016E0")]
			[Address(RVA = "0x458B00", Offset = "0x457100", VA = "0x180458B00")]
			set
			{
			}
		}

		// Token: 0x060016E1 RID: 5857 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60016E1")]
		[Address(RVA = "0x51ECB0", Offset = "0x51D2B0", VA = "0x18051ECB0", Slot = "5")]
		public void Set(ref PacketQueueInfo other)
		{
		}

		// Token: 0x060016E2 RID: 5858 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60016E2")]
		[Address(RVA = "0x51ECE0", Offset = "0x51D2E0", VA = "0x18051ECE0", Slot = "6")]
		public void Set(ref PacketQueueInfo? other)
		{
		}

		// Token: 0x060016E3 RID: 5859 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60016E3")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "7")]
		public void Dispose()
		{
		}

		// Token: 0x060016E4 RID: 5860 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60016E4")]
		[Address(RVA = "0x51EC70", Offset = "0x51D270", VA = "0x18051EC70", Slot = "4")]
		public void Get(out PacketQueueInfo output)
		{
		}

		// Token: 0x04000A1D RID: 2589
		[Token(Token = "0x4000A1D")]
		[FieldOffset(Offset = "0x0")]
		private ulong m_IncomingPacketQueueMaxSizeBytes;

		// Token: 0x04000A1E RID: 2590
		[Token(Token = "0x4000A1E")]
		[FieldOffset(Offset = "0x8")]
		private ulong m_IncomingPacketQueueCurrentSizeBytes;

		// Token: 0x04000A1F RID: 2591
		[Token(Token = "0x4000A1F")]
		[FieldOffset(Offset = "0x10")]
		private ulong m_IncomingPacketQueueCurrentPacketCount;

		// Token: 0x04000A20 RID: 2592
		[Token(Token = "0x4000A20")]
		[FieldOffset(Offset = "0x18")]
		private ulong m_OutgoingPacketQueueMaxSizeBytes;

		// Token: 0x04000A21 RID: 2593
		[Token(Token = "0x4000A21")]
		[FieldOffset(Offset = "0x20")]
		private ulong m_OutgoingPacketQueueCurrentSizeBytes;

		// Token: 0x04000A22 RID: 2594
		[Token(Token = "0x4000A22")]
		[FieldOffset(Offset = "0x28")]
		private ulong m_OutgoingPacketQueueCurrentPacketCount;
	}
}
