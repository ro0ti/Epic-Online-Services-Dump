using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Auth
{
	// Token: 0x0200065F RID: 1631
	[Token(Token = "0x200065F")]
	public struct LinkAccountOptions
	{
		// Token: 0x17000C2A RID: 3114
		// (get) Token: 0x060029CB RID: 10699 RVA: 0x0000A7CC File Offset: 0x000089CC
		// (set) Token: 0x060029CC RID: 10700 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C2A")]
		public LinkAccountFlags LinkAccountFlags
		{
			[Token(Token = "0x60029CB")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return LinkAccountFlags.NoFlags;
			}
			[Token(Token = "0x60029CC")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000C2B RID: 3115
		// (get) Token: 0x060029CD RID: 10701 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060029CE RID: 10702 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C2B")]
		public ContinuanceToken ContinuanceToken
		{
			[Token(Token = "0x60029CD")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60029CE")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000C2C RID: 3116
		// (get) Token: 0x060029CF RID: 10703 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060029D0 RID: 10704 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C2C")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x60029CF")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60029D0")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
