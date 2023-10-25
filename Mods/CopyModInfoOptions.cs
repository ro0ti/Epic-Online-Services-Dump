using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.Mods
{
	// Token: 0x02000361 RID: 865
	[Token(Token = "0x2000361")]
	public struct CopyModInfoOptions
	{
		// Token: 0x17000657 RID: 1623
		// (get) Token: 0x06001730 RID: 5936 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001731 RID: 5937 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000657")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x6001730")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001731")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000658 RID: 1624
		// (get) Token: 0x06001732 RID: 5938 RVA: 0x000069D4 File Offset: 0x00004BD4
		// (set) Token: 0x06001733 RID: 5939 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000658")]
		public ModEnumerationType Type
		{
			[Token(Token = "0x6001732")]
			[Address(RVA = "0x4875A0", Offset = "0x485BA0", VA = "0x1804875A0")]
			[CompilerGenerated]
			readonly get
			{
				return ModEnumerationType.Installed;
			}
			[Token(Token = "0x6001733")]
			[Address(RVA = "0x4875C0", Offset = "0x485BC0", VA = "0x1804875C0")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
