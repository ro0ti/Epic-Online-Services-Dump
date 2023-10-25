using System;


namespace Epic.OnlineServices.P2P
{
	// Token: 0x02000335 RID: 821
	[Token(Token = "0x2000335")]
	public enum NetworkConnectionType
	{
		// Token: 0x040009C3 RID: 2499
		[Token(Token = "0x40009C3")]
		NoConnection,
		// Token: 0x040009C4 RID: 2500
		[Token(Token = "0x40009C4")]
		DirectConnection,
		// Token: 0x040009C5 RID: 2501
		[Token(Token = "0x40009C5")]
		RelayedConnection
	}
}
