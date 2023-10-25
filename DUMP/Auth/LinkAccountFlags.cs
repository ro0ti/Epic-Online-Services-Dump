using System;


namespace Epic.OnlineServices.Auth
{
	// Token: 0x0200065E RID: 1630
	[Token(Token = "0x200065E")]
	[Flags]
	public enum LinkAccountFlags
	{
		// Token: 0x04001231 RID: 4657
		[Token(Token = "0x4001231")]
		NoFlags = 0,
		// Token: 0x04001232 RID: 4658
		[Token(Token = "0x4001232")]
		NintendoNsaId = 1
	}
}
