using System;


namespace Epic.OnlineServices.AntiCheatCommon
{
	// Token: 0x020006B4 RID: 1716
	[Token(Token = "0x20006B4")]
	public enum AntiCheatCommonClientAuthStatus
	{
		// Token: 0x04001329 RID: 4905
		[Token(Token = "0x4001329")]
		Invalid,
		// Token: 0x0400132A RID: 4906
		[Token(Token = "0x400132A")]
		LocalAuthComplete,
		// Token: 0x0400132B RID: 4907
		[Token(Token = "0x400132B")]
		RemoteAuthComplete
	}
}
