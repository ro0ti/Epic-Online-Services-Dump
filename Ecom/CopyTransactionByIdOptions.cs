using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.Ecom
{
	// Token: 0x02000548 RID: 1352
	[Token(Token = "0x2000548")]
	public struct CopyTransactionByIdOptions
	{
		// Token: 0x17000A21 RID: 2593
		// (get) Token: 0x060022EE RID: 8942 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060022EF RID: 8943 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A21")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x60022EE")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60022EF")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000A22 RID: 2594
		// (get) Token: 0x060022F0 RID: 8944 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060022F1 RID: 8945 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A22")]
		public Utf8String TransactionId
		{
			[Token(Token = "0x60022F0")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60022F1")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
