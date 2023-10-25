using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.P2P
{
	// Token: 0x0200033C RID: 828
	[Token(Token = "0x200033C")]
	public struct OnIncomingPacketQueueFullInfo : ICallbackInfo
	{
		// Token: 0x170005F4 RID: 1524
		// (get) Token: 0x06001604 RID: 5636 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001605 RID: 5637 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170005F4")]
		public object ClientData
		{
			[Token(Token = "0x6001604")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001605")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170005F5 RID: 1525
		// (get) Token: 0x06001606 RID: 5638 RVA: 0x00006284 File Offset: 0x00004484
		// (set) Token: 0x06001607 RID: 5639 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170005F5")]
		public ulong PacketQueueMaxSizeBytes
		{
			[Token(Token = "0x6001606")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return 0UL;
			}
			[Token(Token = "0x6001607")]
			[Address(RVA = "0x487590", Offset = "0x485B90", VA = "0x180487590")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170005F6 RID: 1526
		// (get) Token: 0x06001608 RID: 5640 RVA: 0x0000629C File Offset: 0x0000449C
		// (set) Token: 0x06001609 RID: 5641 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170005F6")]
		public ulong PacketQueueCurrentSizeBytes
		{
			[Token(Token = "0x6001608")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return 0UL;
			}
			[Token(Token = "0x6001609")]
			[Address(RVA = "0x4A6940", Offset = "0x4A4F40", VA = "0x1804A6940")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170005F7 RID: 1527
		// (get) Token: 0x0600160A RID: 5642 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600160B RID: 5643 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170005F7")]
		public ProductUserId OverflowPacketLocalUserId
		{
			[Token(Token = "0x600160A")]
			[Address(RVA = "0x3E4B20", Offset = "0x3E3120", VA = "0x1803E4B20")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600160B")]
			[Address(RVA = "0x488180", Offset = "0x486780", VA = "0x180488180")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170005F8 RID: 1528
		// (get) Token: 0x0600160C RID: 5644 RVA: 0x000062B4 File Offset: 0x000044B4
		// (set) Token: 0x0600160D RID: 5645 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170005F8")]
		public byte OverflowPacketChannel
		{
			[Token(Token = "0x600160C")]
			[Address(RVA = "0x4BBE70", Offset = "0x4BA470", VA = "0x1804BBE70")]
			[CompilerGenerated]
			readonly get
			{
				return 0;
			}
			[Token(Token = "0x600160D")]
			[Address(RVA = "0x4BBEA0", Offset = "0x4BA4A0", VA = "0x1804BBEA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170005F9 RID: 1529
		// (get) Token: 0x0600160E RID: 5646 RVA: 0x000062CC File Offset: 0x000044CC
		// (set) Token: 0x0600160F RID: 5647 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170005F9")]
		public uint OverflowPacketSizeBytes
		{
			[Token(Token = "0x600160E")]
			[Address(RVA = "0x3D6660", Offset = "0x3D4C60", VA = "0x1803D6660")]
			[CompilerGenerated]
			readonly get
			{
				return 0U;
			}
			[Token(Token = "0x600160F")]
			[Address(RVA = "0x4DE4A0", Offset = "0x4DCAA0", VA = "0x1804DE4A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001610 RID: 5648 RVA: 0x000062E4 File Offset: 0x000044E4
		[Token(Token = "0x6001610")]
		[Address(RVA = "0x42B2A0", Offset = "0x4298A0", VA = "0x18042B2A0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x06001611 RID: 5649 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001611")]
		[Address(RVA = "0x51AAA0", Offset = "0x5190A0", VA = "0x18051AAA0")]
		internal void Set(ref OnIncomingPacketQueueFullInfoInternal other)
		{
		}
	}
}
