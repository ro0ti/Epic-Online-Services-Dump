using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.UserInfo
{
	// Token: 0x0200003E RID: 62
	[Token(Token = "0x200003E")]
	public struct CopyUserInfoOptions
	{
		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060003D4 RID: 980 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060003D5 RID: 981 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000041")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x60003D4")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60003D5")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060003D6 RID: 982 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060003D7 RID: 983 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000042")]
		public EpicAccountId TargetUserId
		{
			[Token(Token = "0x60003D6")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60003D7")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
