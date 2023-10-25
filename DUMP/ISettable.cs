using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices
{
	// Token: 0x02000016 RID: 22
	[Token(Token = "0x2000016")]
	internal interface ISettable<T> where T : struct
	{
		// Token: 0x060000A2 RID: 162
		[Token(Token = "0x60000A2")]
		void Set(ref T other);

		// Token: 0x060000A3 RID: 163
		[Token(Token = "0x60000A3")]
		void Set(ref T? other);
	}
}
