using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Stats
{
	// Token: 0x020000D8 RID: 216
	[Token(Token = "0x20000D8")]
	public struct IngestStatOptions
	{
		// Token: 0x17000178 RID: 376
		// (get) Token: 0x060007A3 RID: 1955 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060007A4 RID: 1956 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000178")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x60007A3")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60007A4")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x060007A5 RID: 1957 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060007A6 RID: 1958 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000179")]
		public IngestData[] Stats
		{
			[Token(Token = "0x60007A5")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60007A6")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x060007A7 RID: 1959 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060007A8 RID: 1960 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700017A")]
		public ProductUserId TargetUserId
		{
			[Token(Token = "0x60007A7")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60007A8")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
