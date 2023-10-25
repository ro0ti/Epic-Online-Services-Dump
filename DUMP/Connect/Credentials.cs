using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.Connect
{
	// Token: 0x02000601 RID: 1537
	[Token(Token = "0x2000601")]
	public struct Credentials
	{
		// Token: 0x17000B71 RID: 2929
		// (get) Token: 0x0600276E RID: 10094 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600276F RID: 10095 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B71")]
		public Utf8String Token
		{
			[Token(Token = "0x600276E")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600276F")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000B72 RID: 2930
		// (get) Token: 0x06002770 RID: 10096 RVA: 0x0000A07C File Offset: 0x0000827C
		// (set) Token: 0x06002771 RID: 10097 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B72")]
		public ExternalCredentialType Type
		{
			[Token(Token = "0x6002770")]
			[Address(RVA = "0x4875A0", Offset = "0x485BA0", VA = "0x1804875A0")]
			[CompilerGenerated]
			readonly get
			{
				return ExternalCredentialType.Epic;
			}
			[Token(Token = "0x6002771")]
			[Address(RVA = "0x4875C0", Offset = "0x485BC0", VA = "0x1804875C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06002772 RID: 10098 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002772")]
		[Address(RVA = "0x559850", Offset = "0x557E50", VA = "0x180559850")]
		internal void Set(ref CredentialsInternal other)
		{
		}
	}
}
