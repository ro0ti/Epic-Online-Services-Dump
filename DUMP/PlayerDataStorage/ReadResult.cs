using System;


namespace Epic.OnlineServices.PlayerDataStorage
{
	// Token: 0x0200030E RID: 782
	[Token(Token = "0x200030E")]
	public enum ReadResult
	{
		// Token: 0x04000951 RID: 2385
		[Token(Token = "0x4000951")]
		ContinueReading = 1,
		// Token: 0x04000952 RID: 2386
		[Token(Token = "0x4000952")]
		FailRequest,
		// Token: 0x04000953 RID: 2387
		[Token(Token = "0x4000953")]
		CancelRequest
	}
}
