using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Connect
{
	// Token: 0x02000643 RID: 1603
	[Token(Token = "0x2000643")]
	public struct UserLoginInfo
	{
		// Token: 0x17000BE7 RID: 3047
		// (get) Token: 0x060028FA RID: 10490 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060028FB RID: 10491 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BE7")]
		public Utf8String DisplayName
		{
			[Token(Token = "0x60028FA")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60028FB")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000BE8 RID: 3048
		// (get) Token: 0x060028FC RID: 10492 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060028FD RID: 10493 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BE8")]
		public Utf8String NsaIdToken
		{
			[Token(Token = "0x60028FC")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60028FD")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060028FE RID: 10494 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60028FE")]
		[Address(RVA = "0x569A50", Offset = "0x568050", VA = "0x180569A50")]
		internal void Set(ref UserLoginInfoInternal other)
		{
		}
	}
}
