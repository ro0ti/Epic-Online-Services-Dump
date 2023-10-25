using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.Ecom
{
	// Token: 0x0200054A RID: 1354
	[Token(Token = "0x200054A")]
	public struct CopyTransactionByIndexOptions
	{
		// Token: 0x17000A25 RID: 2597
		// (get) Token: 0x060022F7 RID: 8951 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060022F8 RID: 8952 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A25")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x60022F7")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60022F8")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000A26 RID: 2598
		// (get) Token: 0x060022F9 RID: 8953 RVA: 0x0000935C File Offset: 0x0000755C
		// (set) Token: 0x060022FA RID: 8954 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A26")]
		public uint TransactionIndex
		{
			[Token(Token = "0x60022F9")]
			[Address(RVA = "0x4875A0", Offset = "0x485BA0", VA = "0x1804875A0")]
			[CompilerGenerated]
			readonly get
			{
				return 0U;
			}
			[Token(Token = "0x60022FA")]
			[Address(RVA = "0x4875C0", Offset = "0x485BC0", VA = "0x1804875C0")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
