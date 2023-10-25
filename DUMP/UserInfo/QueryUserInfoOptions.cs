using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.UserInfo
{
	// Token: 0x02000056 RID: 86
	[Token(Token = "0x2000056")]
	public struct QueryUserInfoOptions
	{
		// Token: 0x1700007C RID: 124
		// (get) Token: 0x0600047C RID: 1148 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600047D RID: 1149 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700007C")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x600047C")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600047D")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x0600047E RID: 1150 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600047F RID: 1151 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700007D")]
		public EpicAccountId TargetUserId
		{
			[Token(Token = "0x600047E")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600047F")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
