using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.P2P
{
	// Token: 0x0200034F RID: 847
	[Token(Token = "0x200034F")]
	public struct PacketQueueInfo
	{
		// Token: 0x17000629 RID: 1577
		// (get) Token: 0x060016C8 RID: 5832 RVA: 0x0000677C File Offset: 0x0000497C
		// (set) Token: 0x060016C9 RID: 5833 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000629")]
		public ulong IncomingPacketQueueMaxSizeBytes
		{
			[Token(Token = "0x60016C8")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return 0UL;
			}
			[Token(Token = "0x60016C9")]
			[Address(RVA = "0x4875D0", Offset = "0x485BD0", VA = "0x1804875D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700062A RID: 1578
		// (get) Token: 0x060016CA RID: 5834 RVA: 0x00006794 File Offset: 0x00004994
		// (set) Token: 0x060016CB RID: 5835 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700062A")]
		public ulong IncomingPacketQueueCurrentSizeBytes
		{
			[Token(Token = "0x60016CA")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return 0UL;
			}
			[Token(Token = "0x60016CB")]
			[Address(RVA = "0x487590", Offset = "0x485B90", VA = "0x180487590")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700062B RID: 1579
		// (get) Token: 0x060016CC RID: 5836 RVA: 0x000067AC File Offset: 0x000049AC
		// (set) Token: 0x060016CD RID: 5837 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700062B")]
		public ulong IncomingPacketQueueCurrentPacketCount
		{
			[Token(Token = "0x60016CC")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return 0UL;
			}
			[Token(Token = "0x60016CD")]
			[Address(RVA = "0x4A6940", Offset = "0x4A4F40", VA = "0x1804A6940")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700062C RID: 1580
		// (get) Token: 0x060016CE RID: 5838 RVA: 0x000067C4 File Offset: 0x000049C4
		// (set) Token: 0x060016CF RID: 5839 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700062C")]
		public ulong OutgoingPacketQueueMaxSizeBytes
		{
			[Token(Token = "0x60016CE")]
			[Address(RVA = "0x3E4B20", Offset = "0x3E3120", VA = "0x1803E4B20")]
			[CompilerGenerated]
			readonly get
			{
				return 0UL;
			}
			[Token(Token = "0x60016CF")]
			[Address(RVA = "0x4DEC40", Offset = "0x4DD240", VA = "0x1804DEC40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700062D RID: 1581
		// (get) Token: 0x060016D0 RID: 5840 RVA: 0x000067DC File Offset: 0x000049DC
		// (set) Token: 0x060016D1 RID: 5841 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700062D")]
		public ulong OutgoingPacketQueueCurrentSizeBytes
		{
			[Token(Token = "0x60016D0")]
			[Address(RVA = "0x4447A0", Offset = "0x442DA0", VA = "0x1804447A0")]
			[CompilerGenerated]
			readonly get
			{
				return 0UL;
			}
			[Token(Token = "0x60016D1")]
			[Address(RVA = "0x4F4050", Offset = "0x4F2650", VA = "0x1804F4050")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700062E RID: 1582
		// (get) Token: 0x060016D2 RID: 5842 RVA: 0x000067F4 File Offset: 0x000049F4
		// (set) Token: 0x060016D3 RID: 5843 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700062E")]
		public ulong OutgoingPacketQueueCurrentPacketCount
		{
			[Token(Token = "0x60016D2")]
			[Address(RVA = "0x444770", Offset = "0x442D70", VA = "0x180444770")]
			[CompilerGenerated]
			readonly get
			{
				return 0UL;
			}
			[Token(Token = "0x60016D3")]
			[Address(RVA = "0x458B00", Offset = "0x457100", VA = "0x180458B00")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060016D4 RID: 5844 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60016D4")]
		[Address(RVA = "0x51ECB0", Offset = "0x51D2B0", VA = "0x18051ECB0")]
		internal void Set(ref PacketQueueInfoInternal other)
		{
		}
	}
}
