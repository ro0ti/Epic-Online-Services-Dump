using System;


namespace Epic.OnlineServices.P2P
{
	// Token: 0x02000328 RID: 808
	[Token(Token = "0x2000328")]
	public enum ConnectionClosedReason
	{
		// Token: 0x040009A6 RID: 2470
		[Token(Token = "0x40009A6")]
		Unknown,
		// Token: 0x040009A7 RID: 2471
		[Token(Token = "0x40009A7")]
		ClosedByLocalUser,
		// Token: 0x040009A8 RID: 2472
		[Token(Token = "0x40009A8")]
		ClosedByPeer,
		// Token: 0x040009A9 RID: 2473
		[Token(Token = "0x40009A9")]
		TimedOut,
		// Token: 0x040009AA RID: 2474
		[Token(Token = "0x40009AA")]
		TooManyConnections,
		// Token: 0x040009AB RID: 2475
		[Token(Token = "0x40009AB")]
		InvalidMessage,
		// Token: 0x040009AC RID: 2476
		[Token(Token = "0x40009AC")]
		InvalidData,
		// Token: 0x040009AD RID: 2477
		[Token(Token = "0x40009AD")]
		ConnectionFailed,
		// Token: 0x040009AE RID: 2478
		[Token(Token = "0x40009AE")]
		ConnectionClosed,
		// Token: 0x040009AF RID: 2479
		[Token(Token = "0x40009AF")]
		NegotiationFailed,
		// Token: 0x040009B0 RID: 2480
		[Token(Token = "0x40009B0")]
		UnexpectedError
	}
}
