using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Platform
{
	// Token: 0x02000723 RID: 1827
	[Token(Token = "0x2000723")]
	public enum ApplicationStatus
	{
		// Token: 0x040014D2 RID: 5330
		[Token(Token = "0x40014D2")]
		BackgroundConstrained,
		// Token: 0x040014D3 RID: 5331
		[Token(Token = "0x40014D3")]
		BackgroundUnconstrained,
		// Token: 0x040014D4 RID: 5332
		[Token(Token = "0x40014D4")]
		BackgroundSuspended,
		// Token: 0x040014D5 RID: 5333
		[Token(Token = "0x40014D5")]
		Foreground
	}
}
