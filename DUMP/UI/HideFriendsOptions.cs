using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.UI
{
	// Token: 0x0200006B RID: 107
	[Token(Token = "0x200006B")]
	public struct HideFriendsOptions
	{
		// Token: 0x1700009B RID: 155
		// (get) Token: 0x060004E6 RID: 1254 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060004E7 RID: 1255 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700009B")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x60004E6")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60004E7")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
