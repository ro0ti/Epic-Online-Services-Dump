using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.CustomInvites
{
	// Token: 0x0200059C RID: 1436
	[Token(Token = "0x200059C")]
	public struct AcceptRequestToJoinOptions
	{
		// Token: 0x17000AC9 RID: 2761
		// (get) Token: 0x06002500 RID: 9472 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002501 RID: 9473 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000AC9")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6002500")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002501")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000ACA RID: 2762
		// (get) Token: 0x06002502 RID: 9474 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002503 RID: 9475 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000ACA")]
		public ProductUserId TargetUserId
		{
			[Token(Token = "0x6002502")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002503")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
