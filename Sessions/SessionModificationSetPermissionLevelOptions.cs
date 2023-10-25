using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Sessions
{
	// Token: 0x0200017D RID: 381
	[Token(Token = "0x200017D")]
	public struct SessionModificationSetPermissionLevelOptions
	{
		// Token: 0x17000289 RID: 649
		// (get) Token: 0x06000B28 RID: 2856 RVA: 0x00004034 File Offset: 0x00002234
		// (set) Token: 0x06000B29 RID: 2857 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000289")]
		public OnlineSessionPermissionLevel PermissionLevel
		{
			[Token(Token = "0x6000B28")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return OnlineSessionPermissionLevel.PublicAdvertised;
			}
			[Token(Token = "0x6000B29")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
