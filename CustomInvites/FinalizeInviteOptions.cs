using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.CustomInvites
{
	// Token: 0x020005B1 RID: 1457
	[Token(Token = "0x20005B1")]
	public struct FinalizeInviteOptions
	{
		// Token: 0x17000AD8 RID: 2776
		// (get) Token: 0x06002560 RID: 9568 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002561 RID: 9569 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000AD8")]
		public ProductUserId TargetUserId
		{
			[Token(Token = "0x6002560")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002561")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000AD9 RID: 2777
		// (get) Token: 0x06002562 RID: 9570 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002563 RID: 9571 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000AD9")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6002562")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002563")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000ADA RID: 2778
		// (get) Token: 0x06002564 RID: 9572 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002565 RID: 9573 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000ADA")]
		public Utf8String CustomInviteId
		{
			[Token(Token = "0x6002564")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002565")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000ADB RID: 2779
		// (get) Token: 0x06002566 RID: 9574 RVA: 0x00009B6C File Offset: 0x00007D6C
		// (set) Token: 0x06002567 RID: 9575 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000ADB")]
		public Result ProcessingResult
		{
			[Token(Token = "0x6002566")]
			[Address(RVA = "0x4447E0", Offset = "0x442DE0", VA = "0x1804447E0")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x6002567")]
			[Address(RVA = "0x444820", Offset = "0x442E20", VA = "0x180444820")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
