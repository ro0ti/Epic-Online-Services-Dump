using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.UserInfo
{
	// Token: 0x0200004E RID: 78
	[Token(Token = "0x200004E")]
	public struct QueryUserInfoByDisplayNameOptions
	{
		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000431 RID: 1073 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000432 RID: 1074 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700005C")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x6000431")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000432")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000433 RID: 1075 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000434 RID: 1076 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700005D")]
		public Utf8String DisplayName
		{
			[Token(Token = "0x6000433")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000434")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
