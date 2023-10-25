using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.Auth
{
	// Token: 0x0200068D RID: 1677
	[Token(Token = "0x200068D")]
	public struct IOSCredentials
	{
		// Token: 0x17000CA4 RID: 3236
		// (get) Token: 0x06002B2E RID: 11054 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002B2F RID: 11055 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000CA4")]
		public Utf8String Id
		{
			[Token(Token = "0x6002B2E")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002B2F")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000CA5 RID: 3237
		// (get) Token: 0x06002B30 RID: 11056 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002B31 RID: 11057 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000CA5")]
		public Utf8String Token
		{
			[Token(Token = "0x6002B30")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002B31")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000CA6 RID: 3238
		// (get) Token: 0x06002B32 RID: 11058 RVA: 0x0000AC4C File Offset: 0x00008E4C
		// (set) Token: 0x06002B33 RID: 11059 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000CA6")]
		public LoginCredentialType Type
		{
			[Token(Token = "0x6002B32")]
			[Address(RVA = "0x3D2690", Offset = "0x3D0C90", VA = "0x1803D2690")]
			[CompilerGenerated]
			readonly get
			{
				return LoginCredentialType.Password;
			}
			[Token(Token = "0x6002B33")]
			[Address(RVA = "0x457A40", Offset = "0x456040", VA = "0x180457A40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000CA7 RID: 3239
		// (get) Token: 0x06002B34 RID: 11060 RVA: 0x0000AC64 File Offset: 0x00008E64
		// (set) Token: 0x06002B35 RID: 11061 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000CA7")]
		public IOSCredentialsSystemAuthCredentialsOptions? SystemAuthCredentialsOptions
		{
			[Token(Token = "0x6002B34")]
			[Address(RVA = "0x51A4B0", Offset = "0x518AB0", VA = "0x18051A4B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002B35")]
			[Address(RVA = "0x570D00", Offset = "0x56F300", VA = "0x180570D00")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000CA8 RID: 3240
		// (get) Token: 0x06002B36 RID: 11062 RVA: 0x0000AC7C File Offset: 0x00008E7C
		// (set) Token: 0x06002B37 RID: 11063 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000CA8")]
		public ExternalCredentialType ExternalType
		{
			[Token(Token = "0x6002B36")]
			[Address(RVA = "0x3D2E70", Offset = "0x3D1470", VA = "0x1803D2E70")]
			[CompilerGenerated]
			readonly get
			{
				return ExternalCredentialType.Epic;
			}
			[Token(Token = "0x6002B37")]
			[Address(RVA = "0x3D2EA0", Offset = "0x3D14A0", VA = "0x1803D2EA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06002B38 RID: 11064 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002B38")]
		[Address(RVA = "0x570BA0", Offset = "0x56F1A0", VA = "0x180570BA0")]
		internal void Set(ref IOSCredentialsInternal other)
		{
		}
	}
}
