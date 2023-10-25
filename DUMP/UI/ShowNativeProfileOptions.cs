using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.UI
{
	// Token: 0x0200009E RID: 158
	[Token(Token = "0x200009E")]
	public struct ShowNativeProfileOptions
	{
		// Token: 0x170000FB RID: 251
		// (get) Token: 0x0600060A RID: 1546 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600060B RID: 1547 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000FB")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x600060A")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600060B")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x0600060C RID: 1548 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600060D RID: 1549 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000FC")]
		public EpicAccountId TargetUserId
		{
			[Token(Token = "0x600060C")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600060D")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
