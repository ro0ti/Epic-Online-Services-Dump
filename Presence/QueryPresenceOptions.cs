using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.Presence
{
	// Token: 0x020002CB RID: 715
	[Token(Token = "0x20002CB")]
	public struct QueryPresenceOptions
	{
		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x0600137A RID: 4986 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600137B RID: 4987 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000520")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x600137A")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600137B")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x0600137C RID: 4988 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600137D RID: 4989 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000521")]
		public EpicAccountId TargetUserId
		{
			[Token(Token = "0x600137C")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600137D")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
