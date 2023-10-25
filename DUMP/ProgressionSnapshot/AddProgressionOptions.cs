using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.ProgressionSnapshot
{
	// Token: 0x0200028E RID: 654
	[Token(Token = "0x200028E")]
	public struct AddProgressionOptions
	{
		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x0600121D RID: 4637 RVA: 0x000056FC File Offset: 0x000038FC
		// (set) Token: 0x0600121E RID: 4638 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170004B9")]
		public uint SnapshotId
		{
			[Token(Token = "0x600121D")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return 0U;
			}
			[Token(Token = "0x600121E")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x0600121F RID: 4639 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001220 RID: 4640 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170004BA")]
		public Utf8String Key
		{
			[Token(Token = "0x600121F")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001220")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x06001221 RID: 4641 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001222 RID: 4642 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170004BB")]
		public Utf8String Value
		{
			[Token(Token = "0x6001221")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001222")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
