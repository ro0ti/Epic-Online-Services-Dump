using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.Sessions
{
	// Token: 0x0200014A RID: 330
	[Token(Token = "0x200014A")]
	public struct RegisterPlayersOptions
	{
		// Token: 0x17000211 RID: 529
		// (get) Token: 0x060009DD RID: 2525 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060009DE RID: 2526 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000211")]
		public Utf8String SessionName
		{
			[Token(Token = "0x60009DD")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60009DE")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x060009DF RID: 2527 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060009E0 RID: 2528 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000212")]
		public ProductUserId[] PlayersToRegister
		{
			[Token(Token = "0x60009DF")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60009E0")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
