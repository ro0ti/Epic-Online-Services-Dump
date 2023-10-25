using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Platform
{
	// Token: 0x02000726 RID: 1830
	[Token(Token = "0x2000726")]
	public enum DesktopCrossplayStatus
	{
		// Token: 0x040014DB RID: 5339
		[Token(Token = "0x40014DB")]
		Ok,
		// Token: 0x040014DC RID: 5340
		[Token(Token = "0x40014DC")]
		ApplicationNotBootstrapped,
		// Token: 0x040014DD RID: 5341
		[Token(Token = "0x40014DD")]
		ServiceNotInstalled,
		// Token: 0x040014DE RID: 5342
		[Token(Token = "0x40014DE")]
		ServiceStartFailed,
		// Token: 0x040014DF RID: 5343
		[Token(Token = "0x40014DF")]
		ServiceNotRunning,
		// Token: 0x040014E0 RID: 5344
		[Token(Token = "0x40014E0")]
		OverlayDisabled,
		// Token: 0x040014E1 RID: 5345
		[Token(Token = "0x40014E1")]
		OverlayNotInstalled,
		// Token: 0x040014E2 RID: 5346
		[Token(Token = "0x40014E2")]
		OverlayTrustCheckFailed,
		// Token: 0x040014E3 RID: 5347
		[Token(Token = "0x40014E3")]
		OverlayLoadFailed
	}
}
