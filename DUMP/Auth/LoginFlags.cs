using System;


namespace Epic.OnlineServices.Auth
{
	// Token: 0x02000664 RID: 1636
	[Token(Token = "0x2000664")]
	[Flags]
	public enum LoginFlags : ulong
	{
		// Token: 0x04001252 RID: 4690
		[Token(Token = "0x4001252")]
		None = 0UL,
		// Token: 0x04001253 RID: 4691
		[Token(Token = "0x4001253")]
		NoUserInterface = 1UL
	}
}
