using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.Ecom
{
	// Token: 0x0200053E RID: 1342
	[Token(Token = "0x200053E")]
	public struct CopyLastRedeemedEntitlementByIndexOptions
	{
		// Token: 0x17000A09 RID: 2569
		// (get) Token: 0x060022BB RID: 8891 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060022BC RID: 8892 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A09")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x60022BB")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60022BC")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000A0A RID: 2570
		// (get) Token: 0x060022BD RID: 8893 RVA: 0x000092FC File Offset: 0x000074FC
		// (set) Token: 0x060022BE RID: 8894 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A0A")]
		public uint RedeemedEntitlementIndex
		{
			[Token(Token = "0x60022BD")]
			[Address(RVA = "0x4875A0", Offset = "0x485BA0", VA = "0x1804875A0")]
			[CompilerGenerated]
			readonly get
			{
				return 0U;
			}
			[Token(Token = "0x60022BE")]
			[Address(RVA = "0x4875C0", Offset = "0x485BC0", VA = "0x1804875C0")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
