using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.Lobby
{
	// Token: 0x020003C1 RID: 961
	[Token(Token = "0x20003C1")]
	public struct GetInviteIdByIndexOptions
	{
		// Token: 0x1700070E RID: 1806
		// (get) Token: 0x0600194A RID: 6474 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600194B RID: 6475 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700070E")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x600194A")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600194B")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700070F RID: 1807
		// (get) Token: 0x0600194C RID: 6476 RVA: 0x00007214 File Offset: 0x00005414
		// (set) Token: 0x0600194D RID: 6477 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700070F")]
		public uint Index
		{
			[Token(Token = "0x600194C")]
			[Address(RVA = "0x4875A0", Offset = "0x485BA0", VA = "0x1804875A0")]
			[CompilerGenerated]
			readonly get
			{
				return 0U;
			}
			[Token(Token = "0x600194D")]
			[Address(RVA = "0x4875C0", Offset = "0x485BC0", VA = "0x1804875C0")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
