using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices
{
	// Token: 0x0200002C RID: 44
	[Token(Token = "0x200002C")]
	public struct PageResult
	{
		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000364 RID: 868 RVA: 0x0000251C File Offset: 0x0000071C
		// (set) Token: 0x06000365 RID: 869 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000015")]
		public int StartIndex
		{
			[Token(Token = "0x6000364")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return 0;
			}
			[Token(Token = "0x6000365")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000366 RID: 870 RVA: 0x00002534 File Offset: 0x00000734
		// (set) Token: 0x06000367 RID: 871 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000016")]
		public int Count
		{
			[Token(Token = "0x6000366")]
			[Address(RVA = "0x4A4D40", Offset = "0x4A3340", VA = "0x1804A4D40")]
			[CompilerGenerated]
			readonly get
			{
				return 0;
			}
			[Token(Token = "0x6000367")]
			[Address(RVA = "0x4A4E90", Offset = "0x4A3490", VA = "0x1804A4E90")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000368 RID: 872 RVA: 0x0000254C File Offset: 0x0000074C
		// (set) Token: 0x06000369 RID: 873 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000017")]
		public int TotalCount
		{
			[Token(Token = "0x6000368")]
			[Address(RVA = "0x4875A0", Offset = "0x485BA0", VA = "0x1804875A0")]
			[CompilerGenerated]
			readonly get
			{
				return 0;
			}
			[Token(Token = "0x6000369")]
			[Address(RVA = "0x4875C0", Offset = "0x485BC0", VA = "0x1804875C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600036A RID: 874 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600036A")]
		[Address(RVA = "0x4ACC40", Offset = "0x4AB240", VA = "0x1804ACC40")]
		internal void Set(ref PageResultInternal other)
		{
		}
	}
}
