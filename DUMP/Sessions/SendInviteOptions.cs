using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.Sessions
{
	// Token: 0x02000152 RID: 338
	[Token(Token = "0x2000152")]
	public struct SendInviteOptions
	{
		// Token: 0x17000223 RID: 547
		// (get) Token: 0x06000A0D RID: 2573 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000A0E RID: 2574 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000223")]
		public Utf8String SessionName
		{
			[Token(Token = "0x6000A0D")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000A0E")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x06000A0F RID: 2575 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000A10 RID: 2576 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000224")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6000A0F")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000A10")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x06000A11 RID: 2577 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000A12 RID: 2578 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000225")]
		public ProductUserId TargetUserId
		{
			[Token(Token = "0x6000A11")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000A12")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
