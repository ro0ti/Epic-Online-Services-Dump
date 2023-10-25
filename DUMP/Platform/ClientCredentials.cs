using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.Platform
{
	// Token: 0x02000724 RID: 1828
	[Token(Token = "0x2000724")]
	public struct ClientCredentials
	{
		// Token: 0x17000DDC RID: 3548
		// (get) Token: 0x06002EBB RID: 11963 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002EBC RID: 11964 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000DDC")]
		public Utf8String ClientId
		{
			[Token(Token = "0x6002EBB")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002EBC")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000DDD RID: 3549
		// (get) Token: 0x06002EBD RID: 11965 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002EBE RID: 11966 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000DDD")]
		public Utf8String ClientSecret
		{
			[Token(Token = "0x6002EBD")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002EBE")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06002EBF RID: 11967 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002EBF")]
		[Address(RVA = "0x570190", Offset = "0x56E790", VA = "0x180570190")]
		internal void Set(ref ClientCredentialsInternal other)
		{
		}
	}
}
