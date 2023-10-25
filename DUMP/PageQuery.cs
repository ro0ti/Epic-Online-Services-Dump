using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices
{
	// Token: 0x0200002A RID: 42
	[Token(Token = "0x200002A")]
	public struct PageQuery
	{
		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000357 RID: 855 RVA: 0x000024BC File Offset: 0x000006BC
		// (set) Token: 0x06000358 RID: 856 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000011")]
		public int StartIndex
		{
			[Token(Token = "0x6000357")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return 0;
			}
			[Token(Token = "0x6000358")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000359 RID: 857 RVA: 0x000024D4 File Offset: 0x000006D4
		// (set) Token: 0x0600035A RID: 858 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000012")]
		public int MaxCount
		{
			[Token(Token = "0x6000359")]
			[Address(RVA = "0x4A4D40", Offset = "0x4A3340", VA = "0x1804A4D40")]
			[CompilerGenerated]
			readonly get
			{
				return 0;
			}
			[Token(Token = "0x600035A")]
			[Address(RVA = "0x4A4E90", Offset = "0x4A3490", VA = "0x1804A4E90")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600035B RID: 859 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600035B")]
		[Address(RVA = "0x4ACB70", Offset = "0x4AB170", VA = "0x1804ACB70")]
		internal void Set(ref PageQueryInternal other)
		{
		}
	}
}
