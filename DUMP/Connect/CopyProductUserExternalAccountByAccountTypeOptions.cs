using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.Connect
{
	// Token: 0x020005F3 RID: 1523
	[Token(Token = "0x20005F3")]
	public struct CopyProductUserExternalAccountByAccountTypeOptions
	{
		// Token: 0x17000B57 RID: 2903
		// (get) Token: 0x06002728 RID: 10024 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002729 RID: 10025 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B57")]
		public ProductUserId TargetUserId
		{
			[Token(Token = "0x6002728")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002729")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000B58 RID: 2904
		// (get) Token: 0x0600272A RID: 10026 RVA: 0x00009F8C File Offset: 0x0000818C
		// (set) Token: 0x0600272B RID: 10027 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B58")]
		public ExternalAccountType AccountIdType
		{
			[Token(Token = "0x600272A")]
			[Address(RVA = "0x4875A0", Offset = "0x485BA0", VA = "0x1804875A0")]
			[CompilerGenerated]
			readonly get
			{
				return ExternalAccountType.Epic;
			}
			[Token(Token = "0x600272B")]
			[Address(RVA = "0x4875C0", Offset = "0x485BC0", VA = "0x1804875C0")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
