using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.Connect
{
	// Token: 0x0200060D RID: 1549
	[Token(Token = "0x200060D")]
	public struct GetProductUserIdMappingOptions
	{
		// Token: 0x17000B8C RID: 2956
		// (get) Token: 0x060027B8 RID: 10168 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060027B9 RID: 10169 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B8C")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x60027B8")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60027B9")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000B8D RID: 2957
		// (get) Token: 0x060027BA RID: 10170 RVA: 0x0000A184 File Offset: 0x00008384
		// (set) Token: 0x060027BB RID: 10171 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B8D")]
		public ExternalAccountType AccountIdType
		{
			[Token(Token = "0x60027BA")]
			[Address(RVA = "0x4875A0", Offset = "0x485BA0", VA = "0x1804875A0")]
			[CompilerGenerated]
			readonly get
			{
				return ExternalAccountType.Epic;
			}
			[Token(Token = "0x60027BB")]
			[Address(RVA = "0x4875C0", Offset = "0x485BC0", VA = "0x1804875C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000B8E RID: 2958
		// (get) Token: 0x060027BC RID: 10172 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060027BD RID: 10173 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B8E")]
		public ProductUserId TargetProductUserId
		{
			[Token(Token = "0x60027BC")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60027BD")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
