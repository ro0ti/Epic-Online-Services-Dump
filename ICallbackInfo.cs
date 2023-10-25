using System;
// Dumped by ro0ti

namespace Epic.OnlineServices
{
	// Token: 0x02000013 RID: 19
	[Token(Token = "0x2000013")]
	internal interface ICallbackInfo
	{
		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600009E RID: 158
		[Token(Token = "0x1700000B")]
		object ClientData { [Token(Token = "0x600009E")] get; }

		// Token: 0x0600009F RID: 159
		[Token(Token = "0x600009F")]
		Result? GetResultCode();
	}
}
