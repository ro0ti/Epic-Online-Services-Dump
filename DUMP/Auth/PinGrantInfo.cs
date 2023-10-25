using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.Auth
{
	// Token: 0x0200067D RID: 1661
	[Token(Token = "0x200067D")]
	public struct PinGrantInfo
	{
		// Token: 0x17000C57 RID: 3159
		// (get) Token: 0x06002A76 RID: 10870 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002A77 RID: 10871 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C57")]
		public Utf8String UserCode
		{
			[Token(Token = "0x6002A76")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002A77")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000C58 RID: 3160
		// (get) Token: 0x06002A78 RID: 10872 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002A79 RID: 10873 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C58")]
		public Utf8String VerificationURI
		{
			[Token(Token = "0x6002A78")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002A79")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000C59 RID: 3161
		// (get) Token: 0x06002A7A RID: 10874 RVA: 0x0000A9DC File Offset: 0x00008BDC
		// (set) Token: 0x06002A7B RID: 10875 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C59")]
		public int ExpiresIn
		{
			[Token(Token = "0x6002A7A")]
			[Address(RVA = "0x3D2690", Offset = "0x3D0C90", VA = "0x1803D2690")]
			[CompilerGenerated]
			readonly get
			{
				return 0;
			}
			[Token(Token = "0x6002A7B")]
			[Address(RVA = "0x457A40", Offset = "0x456040", VA = "0x180457A40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000C5A RID: 3162
		// (get) Token: 0x06002A7C RID: 10876 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002A7D RID: 10877 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C5A")]
		public Utf8String VerificationURIComplete
		{
			[Token(Token = "0x6002A7C")]
			[Address(RVA = "0x3E4B20", Offset = "0x3E3120", VA = "0x1803E4B20")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002A7D")]
			[Address(RVA = "0x488180", Offset = "0x486780", VA = "0x180488180")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06002A7E RID: 10878 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002A7E")]
		[Address(RVA = "0x57AAB0", Offset = "0x5790B0", VA = "0x18057AAB0")]
		internal void Set(ref PinGrantInfoInternal other)
		{
		}
	}
}
