using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.UI
{
	// Token: 0x0200009A RID: 154
	[Token(Token = "0x200009A")]
	public struct ShowFriendsOptions
	{
		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x060005ED RID: 1517 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060005EE RID: 1518 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000F0")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x60005ED")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60005EE")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
