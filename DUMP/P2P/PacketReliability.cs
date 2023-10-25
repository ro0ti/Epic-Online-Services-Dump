using System;


namespace Epic.OnlineServices.P2P
{
	// Token: 0x02000351 RID: 849
	[Token(Token = "0x2000351")]
	public enum PacketReliability
	{
		// Token: 0x04000A24 RID: 2596
		[Token(Token = "0x4000A24")]
		UnreliableUnordered,
		// Token: 0x04000A25 RID: 2597
		[Token(Token = "0x4000A25")]
		ReliableUnordered,
		// Token: 0x04000A26 RID: 2598
		[Token(Token = "0x4000A26")]
		ReliableOrdered
	}
}
