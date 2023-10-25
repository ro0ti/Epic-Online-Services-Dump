using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.Sessions
{
	// Token: 0x0200014E RID: 334
	[Token(Token = "0x200014E")]
	public struct RejectInviteOptions
	{
		// Token: 0x1700021A RID: 538
		// (get) Token: 0x060009F5 RID: 2549 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060009F6 RID: 2550 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700021A")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x60009F5")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60009F6")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x060009F7 RID: 2551 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060009F8 RID: 2552 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700021B")]
		public Utf8String InviteId
		{
			[Token(Token = "0x60009F7")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60009F8")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
