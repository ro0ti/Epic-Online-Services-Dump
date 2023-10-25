using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.Friends
{
	// Token: 0x02000500 RID: 1280
	[Token(Token = "0x2000500")]
	public struct GetBlockedUserAtIndexOptions
	{
		// Token: 0x1700094F RID: 2383
		// (get) Token: 0x060020D7 RID: 8407 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060020D8 RID: 8408 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700094F")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x60020D7")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60020D8")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000950 RID: 2384
		// (get) Token: 0x060020D9 RID: 8409 RVA: 0x00008CFC File Offset: 0x00006EFC
		// (set) Token: 0x060020DA RID: 8410 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000950")]
		public int Index
		{
			[Token(Token = "0x60020D9")]
			[Address(RVA = "0x4875A0", Offset = "0x485BA0", VA = "0x1804875A0")]
			[CompilerGenerated]
			readonly get
			{
				return 0;
			}
			[Token(Token = "0x60020DA")]
			[Address(RVA = "0x4875C0", Offset = "0x485BC0", VA = "0x1804875C0")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
