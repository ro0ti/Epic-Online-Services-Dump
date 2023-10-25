using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.Connect
{
	// Token: 0x02000639 RID: 1593
	[Token(Token = "0x2000639")]
	public struct QueryProductUserIdMappingsOptions
	{
		// Token: 0x17000BCB RID: 3019
		// (get) Token: 0x060028B6 RID: 10422 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060028B7 RID: 10423 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BCB")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x60028B6")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60028B7")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000BCC RID: 3020
		// (get) Token: 0x060028B8 RID: 10424 RVA: 0x0000A3F4 File Offset: 0x000085F4
		// (set) Token: 0x060028B9 RID: 10425 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BCC")]
		public ExternalAccountType AccountIdType_DEPRECATED
		{
			[Token(Token = "0x60028B8")]
			[Address(RVA = "0x4875A0", Offset = "0x485BA0", VA = "0x1804875A0")]
			[CompilerGenerated]
			readonly get
			{
				return ExternalAccountType.Epic;
			}
			[Token(Token = "0x60028B9")]
			[Address(RVA = "0x4875C0", Offset = "0x485BC0", VA = "0x1804875C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000BCD RID: 3021
		// (get) Token: 0x060028BA RID: 10426 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060028BB RID: 10427 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BCD")]
		public ProductUserId[] ProductUserIds
		{
			[Token(Token = "0x60028BA")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60028BB")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
