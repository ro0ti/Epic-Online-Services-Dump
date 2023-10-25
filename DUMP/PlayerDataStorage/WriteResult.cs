using System;


namespace Epic.OnlineServices.PlayerDataStorage
{
	// Token: 0x02000315 RID: 789
	[Token(Token = "0x2000315")]
	public enum WriteResult
	{
		// Token: 0x04000972 RID: 2418
		[Token(Token = "0x4000972")]
		ContinueWriting = 1,
		// Token: 0x04000973 RID: 2419
		[Token(Token = "0x4000973")]
		CompleteRequest,
		// Token: 0x04000974 RID: 2420
		[Token(Token = "0x4000974")]
		FailRequest,
		// Token: 0x04000975 RID: 2421
		[Token(Token = "0x4000975")]
		CancelRequest
	}
}
