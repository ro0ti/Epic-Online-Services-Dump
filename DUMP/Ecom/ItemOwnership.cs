using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.Ecom
{
	// Token: 0x02000562 RID: 1378
	[Token(Token = "0x2000562")]
	public struct ItemOwnership
	{
		// Token: 0x17000A51 RID: 2641
		// (get) Token: 0x0600238A RID: 9098 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600238B RID: 9099 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A51")]
		public Utf8String Id
		{
			[Token(Token = "0x600238A")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600238B")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000A52 RID: 2642
		// (get) Token: 0x0600238C RID: 9100 RVA: 0x00009614 File Offset: 0x00007814
		// (set) Token: 0x0600238D RID: 9101 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A52")]
		public OwnershipStatus OwnershipStatus
		{
			[Token(Token = "0x600238C")]
			[Address(RVA = "0x4875A0", Offset = "0x485BA0", VA = "0x1804875A0")]
			[CompilerGenerated]
			readonly get
			{
				return OwnershipStatus.NotOwned;
			}
			[Token(Token = "0x600238D")]
			[Address(RVA = "0x4875C0", Offset = "0x485BC0", VA = "0x1804875C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600238E RID: 9102 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600238E")]
		[Address(RVA = "0x5488E0", Offset = "0x546EE0", VA = "0x1805488E0")]
		internal void Set(ref ItemOwnershipInternal other)
		{
		}
	}
}
