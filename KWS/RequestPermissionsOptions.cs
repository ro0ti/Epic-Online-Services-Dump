using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.KWS
{
	// Token: 0x020004D2 RID: 1234
	[Token(Token = "0x20004D2")]
	public struct RequestPermissionsOptions
	{
		// Token: 0x170008FF RID: 2303
		// (get) Token: 0x06001FCD RID: 8141 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001FCE RID: 8142 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170008FF")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6001FCD")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001FCE")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000900 RID: 2304
		// (get) Token: 0x06001FCF RID: 8143 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001FD0 RID: 8144 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000900")]
		public Utf8String[] PermissionKeys
		{
			[Token(Token = "0x6001FCF")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001FD0")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
