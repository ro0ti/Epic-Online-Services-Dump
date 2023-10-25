using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.CustomInvites
{
	// Token: 0x020005DE RID: 1502
	[Token(Token = "0x20005DE")]
	public struct SendCustomInviteOptions
	{
		// Token: 0x17000B2A RID: 2858
		// (get) Token: 0x0600268C RID: 9868 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600268D RID: 9869 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B2A")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x600268C")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600268D")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000B2B RID: 2859
		// (get) Token: 0x0600268E RID: 9870 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600268F RID: 9871 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B2B")]
		public ProductUserId[] TargetUserIds
		{
			[Token(Token = "0x600268E")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600268F")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
