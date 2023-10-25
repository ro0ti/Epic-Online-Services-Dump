using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.Connect
{
	// Token: 0x020005F1 RID: 1521
	[Token(Token = "0x20005F1")]
	public struct CopyProductUserExternalAccountByAccountIdOptions
	{
		// Token: 0x17000B53 RID: 2899
		// (get) Token: 0x0600271F RID: 10015 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002720 RID: 10016 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B53")]
		public ProductUserId TargetUserId
		{
			[Token(Token = "0x600271F")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002720")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000B54 RID: 2900
		// (get) Token: 0x06002721 RID: 10017 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002722 RID: 10018 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B54")]
		public Utf8String AccountId
		{
			[Token(Token = "0x6002721")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002722")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
