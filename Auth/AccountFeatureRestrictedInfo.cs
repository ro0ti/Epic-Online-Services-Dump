using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Auth
{
	// Token: 0x02000649 RID: 1609
	[Token(Token = "0x2000649")]
	public struct AccountFeatureRestrictedInfo
	{
		// Token: 0x17000C06 RID: 3078
		// (get) Token: 0x06002944 RID: 10564 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002945 RID: 10565 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C06")]
		public Utf8String VerificationURI
		{
			[Token(Token = "0x6002944")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002945")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06002946 RID: 10566 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002946")]
		[Address(RVA = "0x552DF0", Offset = "0x5513F0", VA = "0x180552DF0")]
		internal void Set(ref AccountFeatureRestrictedInfoInternal other)
		{
		}
	}
}
