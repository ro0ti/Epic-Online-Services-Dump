using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.Friends
{
	// Token: 0x02000508 RID: 1288
	[Token(Token = "0x2000508")]
	public struct GetStatusOptions
	{
		// Token: 0x1700095B RID: 2395
		// (get) Token: 0x060020F5 RID: 8437 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060020F6 RID: 8438 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700095B")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x60020F5")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60020F6")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700095C RID: 2396
		// (get) Token: 0x060020F7 RID: 8439 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060020F8 RID: 8440 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700095C")]
		public EpicAccountId TargetUserId
		{
			[Token(Token = "0x60020F7")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60020F8")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
