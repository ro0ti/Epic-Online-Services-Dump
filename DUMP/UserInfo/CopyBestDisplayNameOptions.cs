using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.UserInfo
{
	// Token: 0x02000034 RID: 52
	[Token(Token = "0x2000034")]
	public struct CopyBestDisplayNameOptions
	{
		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600039B RID: 923 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600039C RID: 924 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000025")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x600039B")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600039C")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x0600039D RID: 925 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600039E RID: 926 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000026")]
		public EpicAccountId TargetUserId
		{
			[Token(Token = "0x600039D")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600039E")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
