using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Auth
{
	// Token: 0x0200065A RID: 1626
	[Token(Token = "0x200065A")]
	public struct IdToken
	{
		// Token: 0x17000C1B RID: 3099
		// (get) Token: 0x060029A3 RID: 10659 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060029A4 RID: 10660 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C1B")]
		public EpicAccountId AccountId
		{
			[Token(Token = "0x60029A3")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60029A4")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000C1C RID: 3100
		// (get) Token: 0x060029A5 RID: 10661 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060029A6 RID: 10662 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C1C")]
		public Utf8String JsonWebToken
		{
			[Token(Token = "0x60029A5")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60029A6")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060029A7 RID: 10663 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60029A7")]
		[Address(RVA = "0x55BEE0", Offset = "0x55A4E0", VA = "0x18055BEE0")]
		internal void Set(ref IdTokenInternal other)
		{
		}
	}
}
