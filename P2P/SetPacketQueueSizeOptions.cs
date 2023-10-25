using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.P2P
{
	// Token: 0x02000359 RID: 857
	[Token(Token = "0x2000359")]
	public struct SetPacketQueueSizeOptions
	{
		// Token: 0x1700064B RID: 1611
		// (get) Token: 0x0600170F RID: 5903 RVA: 0x0000695C File Offset: 0x00004B5C
		// (set) Token: 0x06001710 RID: 5904 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700064B")]
		public ulong IncomingPacketQueueMaxSizeBytes
		{
			[Token(Token = "0x600170F")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return 0UL;
			}
			[Token(Token = "0x6001710")]
			[Address(RVA = "0x4875D0", Offset = "0x485BD0", VA = "0x1804875D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700064C RID: 1612
		// (get) Token: 0x06001711 RID: 5905 RVA: 0x00006974 File Offset: 0x00004B74
		// (set) Token: 0x06001712 RID: 5906 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700064C")]
		public ulong OutgoingPacketQueueMaxSizeBytes
		{
			[Token(Token = "0x6001711")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return 0UL;
			}
			[Token(Token = "0x6001712")]
			[Address(RVA = "0x487590", Offset = "0x485B90", VA = "0x180487590")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
