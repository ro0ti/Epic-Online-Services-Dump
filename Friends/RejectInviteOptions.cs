using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.Friends
{
	// Token: 0x02000520 RID: 1312
	[Token(Token = "0x2000520")]
	public struct RejectInviteOptions
	{
		// Token: 0x17000985 RID: 2437
		// (get) Token: 0x06002190 RID: 8592 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002191 RID: 8593 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000985")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x6002190")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002191")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000986 RID: 2438
		// (get) Token: 0x06002192 RID: 8594 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002193 RID: 8595 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000986")]
		public EpicAccountId TargetUserId
		{
			[Token(Token = "0x6002192")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002193")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
