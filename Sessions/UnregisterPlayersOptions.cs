using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.Sessions
{
	// Token: 0x0200019B RID: 411
	[Token(Token = "0x200019B")]
	public struct UnregisterPlayersOptions
	{
		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x06000BE0 RID: 3040 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000BE1 RID: 3041 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170002B0")]
		public Utf8String SessionName
		{
			[Token(Token = "0x6000BE0")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000BE1")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x06000BE2 RID: 3042 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000BE3 RID: 3043 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170002B1")]
		public ProductUserId[] PlayersToUnregister
		{
			[Token(Token = "0x6000BE2")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000BE3")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
