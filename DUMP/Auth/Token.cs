using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.Auth
{
	// Token: 0x02000683 RID: 1667
	[Token(Token = "0x2000683")]
	public struct Token
	{
		// Token: 0x17000C6C RID: 3180
		// (get) Token: 0x06002AAB RID: 10923 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002AAC RID: 10924 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C6C")]
		public Utf8String App
		{
			[Token(Token = "0x6002AAB")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002AAC")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000C6D RID: 3181
		// (get) Token: 0x06002AAD RID: 10925 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002AAE RID: 10926 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C6D")]
		public Utf8String ClientId
		{
			[Token(Token = "0x6002AAD")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002AAE")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000C6E RID: 3182
		// (get) Token: 0x06002AAF RID: 10927 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002AB0 RID: 10928 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C6E")]
		public EpicAccountId AccountId
		{
			[Token(Token = "0x6002AAF")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002AB0")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000C6F RID: 3183
		// (get) Token: 0x06002AB1 RID: 10929 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002AB2 RID: 10930 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C6F")]
		public Utf8String AccessToken
		{
			[Token(Token = "0x6002AB1")]
			[Address(RVA = "0x3E4B20", Offset = "0x3E3120", VA = "0x1803E4B20")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002AB2")]
			[Address(RVA = "0x488180", Offset = "0x486780", VA = "0x180488180")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000C70 RID: 3184
		// (get) Token: 0x06002AB3 RID: 10931 RVA: 0x0000AA6C File Offset: 0x00008C6C
		// (set) Token: 0x06002AB4 RID: 10932 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C70")]
		public double ExpiresIn
		{
			[Token(Token = "0x6002AB3")]
			[Address(RVA = "0x580080", Offset = "0x57E680", VA = "0x180580080")]
			[CompilerGenerated]
			readonly get
			{
				return 0.0;
			}
			[Token(Token = "0x6002AB4")]
			[Address(RVA = "0x5800A0", Offset = "0x57E6A0", VA = "0x1805800A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000C71 RID: 3185
		// (get) Token: 0x06002AB5 RID: 10933 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002AB6 RID: 10934 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C71")]
		public Utf8String ExpiresAt
		{
			[Token(Token = "0x6002AB5")]
			[Address(RVA = "0x444770", Offset = "0x442D70", VA = "0x180444770")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002AB6")]
			[Address(RVA = "0x444800", Offset = "0x442E00", VA = "0x180444800")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000C72 RID: 3186
		// (get) Token: 0x06002AB7 RID: 10935 RVA: 0x0000AA84 File Offset: 0x00008C84
		// (set) Token: 0x06002AB8 RID: 10936 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C72")]
		public AuthTokenType AuthType
		{
			[Token(Token = "0x6002AB7")]
			[Address(RVA = "0x3D2E80", Offset = "0x3D1480", VA = "0x1803D2E80")]
			[CompilerGenerated]
			readonly get
			{
				return AuthTokenType.Client;
			}
			[Token(Token = "0x6002AB8")]
			[Address(RVA = "0x3D2EB0", Offset = "0x3D14B0", VA = "0x1803D2EB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000C73 RID: 3187
		// (get) Token: 0x06002AB9 RID: 10937 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002ABA RID: 10938 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C73")]
		public Utf8String RefreshToken
		{
			[Token(Token = "0x6002AB9")]
			[Address(RVA = "0x4BBE60", Offset = "0x4BA460", VA = "0x1804BBE60")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002ABA")]
			[Address(RVA = "0x4BBE90", Offset = "0x4BA490", VA = "0x1804BBE90")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000C74 RID: 3188
		// (get) Token: 0x06002ABB RID: 10939 RVA: 0x0000AA9C File Offset: 0x00008C9C
		// (set) Token: 0x06002ABC RID: 10940 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C74")]
		public double RefreshExpiresIn
		{
			[Token(Token = "0x6002ABB")]
			[Address(RVA = "0x580090", Offset = "0x57E690", VA = "0x180580090")]
			[CompilerGenerated]
			readonly get
			{
				return 0.0;
			}
			[Token(Token = "0x6002ABC")]
			[Address(RVA = "0x5800B0", Offset = "0x57E6B0", VA = "0x1805800B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000C75 RID: 3189
		// (get) Token: 0x06002ABD RID: 10941 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002ABE RID: 10942 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C75")]
		public Utf8String RefreshExpiresAt
		{
			[Token(Token = "0x6002ABD")]
			[Address(RVA = "0x4C8040", Offset = "0x4C6640", VA = "0x1804C8040")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002ABE")]
			[Address(RVA = "0x4C8070", Offset = "0x4C6670", VA = "0x1804C8070")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06002ABF RID: 10943 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002ABF")]
		[Address(RVA = "0x57FDF0", Offset = "0x57E3F0", VA = "0x18057FDF0")]
		internal void Set(ref TokenInternal other)
		{
		}
	}
}
