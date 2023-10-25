using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.Connect
{
	// Token: 0x0200063D RID: 1597
	[Token(Token = "0x200063D")]
	public struct TransferDeviceIdAccountOptions
	{
		// Token: 0x17000BD8 RID: 3032
		// (get) Token: 0x060028D5 RID: 10453 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060028D6 RID: 10454 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BD8")]
		public ProductUserId PrimaryLocalUserId
		{
			[Token(Token = "0x60028D5")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60028D6")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000BD9 RID: 3033
		// (get) Token: 0x060028D7 RID: 10455 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060028D8 RID: 10456 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BD9")]
		public ProductUserId LocalDeviceUserId
		{
			[Token(Token = "0x60028D7")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60028D8")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000BDA RID: 3034
		// (get) Token: 0x060028D9 RID: 10457 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060028DA RID: 10458 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BDA")]
		public ProductUserId ProductUserIdToPreserve
		{
			[Token(Token = "0x60028D9")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60028DA")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
