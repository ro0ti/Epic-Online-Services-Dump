using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.Connect
{
	// Token: 0x02000635 RID: 1589
	[Token(Token = "0x2000635")]
	public struct QueryExternalAccountMappingsOptions
	{
		// Token: 0x17000BBE RID: 3006
		// (get) Token: 0x06002897 RID: 10391 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002898 RID: 10392 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BBE")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6002897")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002898")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000BBF RID: 3007
		// (get) Token: 0x06002899 RID: 10393 RVA: 0x0000A37C File Offset: 0x0000857C
		// (set) Token: 0x0600289A RID: 10394 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BBF")]
		public ExternalAccountType AccountIdType
		{
			[Token(Token = "0x6002899")]
			[Address(RVA = "0x4875A0", Offset = "0x485BA0", VA = "0x1804875A0")]
			[CompilerGenerated]
			readonly get
			{
				return ExternalAccountType.Epic;
			}
			[Token(Token = "0x600289A")]
			[Address(RVA = "0x4875C0", Offset = "0x485BC0", VA = "0x1804875C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000BC0 RID: 3008
		// (get) Token: 0x0600289B RID: 10395 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600289C RID: 10396 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BC0")]
		public Utf8String[] ExternalAccountIds
		{
			[Token(Token = "0x600289B")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600289C")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
