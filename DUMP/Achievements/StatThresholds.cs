using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.Achievements
{
	// Token: 0x02000779 RID: 1913
	[Token(Token = "0x2000779")]
	public struct StatThresholds
	{
		// Token: 0x17000ED5 RID: 3797
		// (get) Token: 0x0600313E RID: 12606 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600313F RID: 12607 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000ED5")]
		public Utf8String Name
		{
			[Token(Token = "0x600313E")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600313F")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000ED6 RID: 3798
		// (get) Token: 0x06003140 RID: 12608 RVA: 0x0000CAAC File Offset: 0x0000ACAC
		// (set) Token: 0x06003141 RID: 12609 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000ED6")]
		public int Threshold
		{
			[Token(Token = "0x6003140")]
			[Address(RVA = "0x4875A0", Offset = "0x485BA0", VA = "0x1804875A0")]
			[CompilerGenerated]
			readonly get
			{
				return 0;
			}
			[Token(Token = "0x6003141")]
			[Address(RVA = "0x4875C0", Offset = "0x485BC0", VA = "0x1804875C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06003142 RID: 12610 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6003142")]
		[Address(RVA = "0x58C440", Offset = "0x58AA40", VA = "0x18058C440")]
		internal void Set(ref StatThresholdsInternal other)
		{
		}
	}
}
