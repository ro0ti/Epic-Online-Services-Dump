using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Ecom
{
	// Token: 0x0200054E RID: 1358
	[Token(Token = "0x200054E")]
	public struct Entitlement
	{
		// Token: 0x17000A29 RID: 2601
		// (get) Token: 0x06002328 RID: 9000 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002329 RID: 9001 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A29")]
		public Utf8String EntitlementName
		{
			[Token(Token = "0x6002328")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002329")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000A2A RID: 2602
		// (get) Token: 0x0600232A RID: 9002 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600232B RID: 9003 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A2A")]
		public Utf8String EntitlementId
		{
			[Token(Token = "0x600232A")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600232B")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000A2B RID: 2603
		// (get) Token: 0x0600232C RID: 9004 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600232D RID: 9005 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A2B")]
		public Utf8String CatalogItemId
		{
			[Token(Token = "0x600232C")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600232D")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000A2C RID: 2604
		// (get) Token: 0x0600232E RID: 9006 RVA: 0x00009584 File Offset: 0x00007784
		// (set) Token: 0x0600232F RID: 9007 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A2C")]
		public int ServerIndex
		{
			[Token(Token = "0x600232E")]
			[Address(RVA = "0x4447E0", Offset = "0x442DE0", VA = "0x1804447E0")]
			[CompilerGenerated]
			readonly get
			{
				return 0;
			}
			[Token(Token = "0x600232F")]
			[Address(RVA = "0x444820", Offset = "0x442E20", VA = "0x180444820")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000A2D RID: 2605
		// (get) Token: 0x06002330 RID: 9008 RVA: 0x0000959C File Offset: 0x0000779C
		// (set) Token: 0x06002331 RID: 9009 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A2D")]
		public bool Redeemed
		{
			[Token(Token = "0x6002330")]
			[Address(RVA = "0x4C45B0", Offset = "0x4C2BB0", VA = "0x1804C45B0")]
			[CompilerGenerated]
			readonly get
			{
				return default(bool);
			}
			[Token(Token = "0x6002331")]
			[Address(RVA = "0x4C45E0", Offset = "0x4C2BE0", VA = "0x1804C45E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000A2E RID: 2606
		// (get) Token: 0x06002332 RID: 9010 RVA: 0x000095B4 File Offset: 0x000077B4
		// (set) Token: 0x06002333 RID: 9011 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A2E")]
		public long EndTimestamp
		{
			[Token(Token = "0x6002332")]
			[Address(RVA = "0x4447A0", Offset = "0x442DA0", VA = "0x1804447A0")]
			[CompilerGenerated]
			readonly get
			{
				return 0L;
			}
			[Token(Token = "0x6002333")]
			[Address(RVA = "0x4F4050", Offset = "0x4F2650", VA = "0x1804F4050")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06002334 RID: 9012 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002334")]
		[Address(RVA = "0x5450B0", Offset = "0x5436B0", VA = "0x1805450B0")]
		internal void Set(ref EntitlementInternal other)
		{
		}
	}
}
