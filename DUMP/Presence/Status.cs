using System;


namespace Epic.OnlineServices.Presence
{
	// Token: 0x020002D3 RID: 723
	[Token(Token = "0x20002D3")]
	public enum Status
	{
		// Token: 0x040008B9 RID: 2233
		[Token(Token = "0x40008B9")]
		Offline,
		// Token: 0x040008BA RID: 2234
		[Token(Token = "0x40008BA")]
		Online,
		// Token: 0x040008BB RID: 2235
		[Token(Token = "0x40008BB")]
		Away,
		// Token: 0x040008BC RID: 2236
		[Token(Token = "0x40008BC")]
		ExtendedAway,
		// Token: 0x040008BD RID: 2237
		[Token(Token = "0x40008BD")]
		DoNotDisturb
	}
}
