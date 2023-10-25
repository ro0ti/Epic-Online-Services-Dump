using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Auth
{
	// Token: 0x0200066B RID: 1643
	[Token(Token = "0x200066B")]
	public struct LogoutOptions
	{
		// Token: 0x17000C55 RID: 3157
		// (get) Token: 0x06002A30 RID: 10800 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002A31 RID: 10801 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C55")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x6002A30")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002A31")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
