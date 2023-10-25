using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.Connect
{
	// Token: 0x0200060F RID: 1551
	[Token(Token = "0x200060F")]
	public struct IdToken
	{
		// Token: 0x17000B92 RID: 2962
		// (get) Token: 0x060027C4 RID: 10180 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060027C5 RID: 10181 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B92")]
		public ProductUserId ProductUserId
		{
			[Token(Token = "0x60027C4")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60027C5")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000B93 RID: 2963
		// (get) Token: 0x060027C6 RID: 10182 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060027C7 RID: 10183 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B93")]
		public Utf8String JsonWebToken
		{
			[Token(Token = "0x60027C6")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60027C7")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060027C8 RID: 10184 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60027C8")]
		[Address(RVA = "0x55BE40", Offset = "0x55A440", VA = "0x18055BE40")]
		internal void Set(ref IdTokenInternal other)
		{
		}
	}
}
