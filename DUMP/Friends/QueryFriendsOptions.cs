using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.Friends
{
	// Token: 0x0200051C RID: 1308
	[Token(Token = "0x200051C")]
	public struct QueryFriendsOptions
	{
		// Token: 0x1700097A RID: 2426
		// (get) Token: 0x06002173 RID: 8563 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002174 RID: 8564 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700097A")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x6002173")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002174")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
