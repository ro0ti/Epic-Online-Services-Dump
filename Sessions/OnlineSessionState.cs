using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Sessions
{
	// Token: 0x0200012D RID: 301
	[Token(Token = "0x200012D")]
	public enum OnlineSessionState
	{
		// Token: 0x04000471 RID: 1137
		[Token(Token = "0x4000471")]
		NoSession,
		// Token: 0x04000472 RID: 1138
		[Token(Token = "0x4000472")]
		Creating,
		// Token: 0x04000473 RID: 1139
		[Token(Token = "0x4000473")]
		Pending,
		// Token: 0x04000474 RID: 1140
		[Token(Token = "0x4000474")]
		Starting,
		// Token: 0x04000475 RID: 1141
		[Token(Token = "0x4000475")]
		InProgress,
		// Token: 0x04000476 RID: 1142
		[Token(Token = "0x4000476")]
		Ending,
		// Token: 0x04000477 RID: 1143
		[Token(Token = "0x4000477")]
		Ended,
		// Token: 0x04000478 RID: 1144
		[Token(Token = "0x4000478")]
		Destroying
	}
}
