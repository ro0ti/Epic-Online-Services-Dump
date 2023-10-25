using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.Friends
{
	// Token: 0x020004F8 RID: 1272
	[Token(Token = "0x20004F8")]
	public struct AcceptInviteOptions
	{
		// Token: 0x1700094B RID: 2379
		// (get) Token: 0x060020B3 RID: 8371 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060020B4 RID: 8372 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700094B")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x60020B3")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60020B4")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700094C RID: 2380
		// (get) Token: 0x060020B5 RID: 8373 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060020B6 RID: 8374 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700094C")]
		public EpicAccountId TargetUserId
		{
			[Token(Token = "0x60020B5")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60020B6")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
