using System;


namespace Epic.OnlineServices.P2P
{
	// Token: 0x0200033D RID: 829
	[Token(Token = "0x200033D")]
	internal struct OnIncomingPacketQueueFullInfoInternal : ICallbackInfoInternal, IGettable<OnIncomingPacketQueueFullInfo>, ISettable<OnIncomingPacketQueueFullInfo>, IDisposable
	{
		// Token: 0x170005FA RID: 1530
		// (get) Token: 0x06001612 RID: 5650 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001613 RID: 5651 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170005FA")]
		public object ClientData
		{
			[Token(Token = "0x6001612")]
			[Address(RVA = "0x51A8F0", Offset = "0x518EF0", VA = "0x18051A8F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001613")]
			[Address(RVA = "0x51A9E0", Offset = "0x518FE0", VA = "0x18051A9E0")]
			set
			{
			}
		}

		// Token: 0x170005FB RID: 1531
		// (get) Token: 0x06001614 RID: 5652 RVA: 0x000062FC File Offset: 0x000044FC
		[Token(Token = "0x170005FB")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x6001614")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170005FC RID: 1532
		// (get) Token: 0x06001615 RID: 5653 RVA: 0x00006314 File Offset: 0x00004514
		// (set) Token: 0x06001616 RID: 5654 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170005FC")]
		public ulong PacketQueueMaxSizeBytes
		{
			[Token(Token = "0x6001615")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6001616")]
			[Address(RVA = "0x487590", Offset = "0x485B90", VA = "0x180487590")]
			set
			{
			}
		}

		// Token: 0x170005FD RID: 1533
		// (get) Token: 0x06001617 RID: 5655 RVA: 0x0000632C File Offset: 0x0000452C
		// (set) Token: 0x06001618 RID: 5656 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170005FD")]
		public ulong PacketQueueCurrentSizeBytes
		{
			[Token(Token = "0x6001617")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6001618")]
			[Address(RVA = "0x4A6940", Offset = "0x4A4F40", VA = "0x1804A6940")]
			set
			{
			}
		}

		// Token: 0x170005FE RID: 1534
		// (get) Token: 0x06001619 RID: 5657 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600161A RID: 5658 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170005FE")]
		public ProductUserId OverflowPacketLocalUserId
		{
			[Token(Token = "0x6001619")]
			[Address(RVA = "0x51A960", Offset = "0x518F60", VA = "0x18051A960")]
			get
			{
				return null;
			}
			[Token(Token = "0x600161A")]
			[Address(RVA = "0x51AA40", Offset = "0x519040", VA = "0x18051AA40")]
			set
			{
			}
		}

		// Token: 0x170005FF RID: 1535
		// (get) Token: 0x0600161B RID: 5659 RVA: 0x00006344 File Offset: 0x00004544
		// (set) Token: 0x0600161C RID: 5660 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170005FF")]
		public byte OverflowPacketChannel
		{
			[Token(Token = "0x600161B")]
			[Address(RVA = "0x4BBE70", Offset = "0x4BA470", VA = "0x1804BBE70")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600161C")]
			[Address(RVA = "0x4BBEA0", Offset = "0x4BA4A0", VA = "0x1804BBEA0")]
			set
			{
			}
		}

		// Token: 0x17000600 RID: 1536
		// (get) Token: 0x0600161D RID: 5661 RVA: 0x0000635C File Offset: 0x0000455C
		// (set) Token: 0x0600161E RID: 5662 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000600")]
		public uint OverflowPacketSizeBytes
		{
			[Token(Token = "0x600161D")]
			[Address(RVA = "0x3D6660", Offset = "0x3D4C60", VA = "0x1803D6660")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x600161E")]
			[Address(RVA = "0x4DE4A0", Offset = "0x4DCAA0", VA = "0x1804DE4A0")]
			set
			{
			}
		}

		// Token: 0x0600161F RID: 5663 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600161F")]
		[Address(RVA = "0x51A690", Offset = "0x518C90", VA = "0x18051A690", Slot = "6")]
		public void Set(ref OnIncomingPacketQueueFullInfo other)
		{
		}

		// Token: 0x06001620 RID: 5664 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001620")]
		[Address(RVA = "0x51A770", Offset = "0x518D70", VA = "0x18051A770", Slot = "7")]
		public void Set(ref OnIncomingPacketQueueFullInfo? other)
		{
		}

		// Token: 0x06001621 RID: 5665 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001621")]
		[Address(RVA = "0x51A600", Offset = "0x518C00", VA = "0x18051A600", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06001622 RID: 5666 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001622")]
		[Address(RVA = "0x51A660", Offset = "0x518C60", VA = "0x18051A660", Slot = "5")]
		public void Get(out OnIncomingPacketQueueFullInfo output)
		{
		}

		// Token: 0x040009D4 RID: 2516
		[Token(Token = "0x40009D4")]
		[FieldOffset(Offset = "0x0")]
		private IntPtr m_ClientData;

		// Token: 0x040009D5 RID: 2517
		[Token(Token = "0x40009D5")]
		[FieldOffset(Offset = "0x8")]
		private ulong m_PacketQueueMaxSizeBytes;

		// Token: 0x040009D6 RID: 2518
		[Token(Token = "0x40009D6")]
		[FieldOffset(Offset = "0x10")]
		private ulong m_PacketQueueCurrentSizeBytes;

		// Token: 0x040009D7 RID: 2519
		[Token(Token = "0x40009D7")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_OverflowPacketLocalUserId;

		// Token: 0x040009D8 RID: 2520
		[Token(Token = "0x40009D8")]
		[FieldOffset(Offset = "0x20")]
		private byte m_OverflowPacketChannel;

		// Token: 0x040009D9 RID: 2521
		[Token(Token = "0x40009D9")]
		[FieldOffset(Offset = "0x24")]
		private uint m_OverflowPacketSizeBytes;
	}
}
