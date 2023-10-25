using System;
// Dumped by ro0ti

namespace Epic.OnlineServices
{
	// Token: 0x02000015 RID: 21
	[Token(Token = "0x2000015")]
	internal interface IGettable<T> where T : struct
	{
		// Token: 0x060000A1 RID: 161
		[Token(Token = "0x60000A1")]
		void Get(out T other);
	}
}
