using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.Stats
{
	// Token: 0x020000E0 RID: 224
	[Token(Token = "0x20000E0")]
	public struct QueryStatsOptions
	{
		// Token: 0x17000187 RID: 391
		// (get) Token: 0x060007D6 RID: 2006 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060007D7 RID: 2007 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000187")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x60007D6")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60007D7")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x060007D8 RID: 2008 RVA: 0x000034F4 File Offset: 0x000016F4
		// (set) Token: 0x060007D9 RID: 2009 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000188")]
		public DateTimeOffset? StartTime
		{
			[Token(Token = "0x60007D8")]
			[Address(RVA = "0x4C33B0", Offset = "0x4C19B0", VA = "0x1804C33B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60007D9")]
			[Address(RVA = "0x4C3400", Offset = "0x4C1A00", VA = "0x1804C3400")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x060007DA RID: 2010 RVA: 0x0000350C File Offset: 0x0000170C
		// (set) Token: 0x060007DB RID: 2011 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000189")]
		public DateTimeOffset? EndTime
		{
			[Token(Token = "0x60007DA")]
			[Address(RVA = "0x4C3390", Offset = "0x4C1990", VA = "0x1804C3390")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60007DB")]
			[Address(RVA = "0x4C33E0", Offset = "0x4C19E0", VA = "0x1804C33E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x060007DC RID: 2012 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060007DD RID: 2013 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700018A")]
		public Utf8String[] StatNames
		{
			[Token(Token = "0x60007DC")]
			[Address(RVA = "0x4BBE60", Offset = "0x4BA460", VA = "0x1804BBE60")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60007DD")]
			[Address(RVA = "0x4BBE90", Offset = "0x4BA490", VA = "0x1804BBE90")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x060007DE RID: 2014 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060007DF RID: 2015 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700018B")]
		public ProductUserId TargetUserId
		{
			[Token(Token = "0x60007DE")]
			[Address(RVA = "0x4C33D0", Offset = "0x4C19D0", VA = "0x1804C33D0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60007DF")]
			[Address(RVA = "0x4C3420", Offset = "0x4C1A20", VA = "0x1804C3420")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
