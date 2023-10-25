using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.Auth
{
	// Token: 0x02000681 RID: 1665
	[Token(Token = "0x2000681")]
	public struct QueryIdTokenOptions
	{
		// Token: 0x17000C68 RID: 3176
		// (get) Token: 0x06002AA2 RID: 10914 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002AA3 RID: 10915 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C68")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x6002AA2")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002AA3")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000C69 RID: 3177
		// (get) Token: 0x06002AA4 RID: 10916 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002AA5 RID: 10917 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C69")]
		public EpicAccountId TargetAccountId
		{
			[Token(Token = "0x6002AA4")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002AA5")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
