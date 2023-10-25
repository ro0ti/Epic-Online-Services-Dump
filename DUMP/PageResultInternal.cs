using System;


namespace Epic.OnlineServices
{
	// Token: 0x0200002D RID: 45
	[Token(Token = "0x200002D")]
	internal struct PageResultInternal : IGettable<PageResult>, ISettable<PageResult>, IDisposable
	{
		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600036B RID: 875 RVA: 0x00002564 File Offset: 0x00000764
		// (set) Token: 0x0600036C RID: 876 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000018")]
		public int StartIndex
		{
			[Token(Token = "0x600036B")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600036C")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600036D RID: 877 RVA: 0x0000257C File Offset: 0x0000077C
		// (set) Token: 0x0600036E RID: 878 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000019")]
		public int Count
		{
			[Token(Token = "0x600036D")]
			[Address(RVA = "0x4A4D40", Offset = "0x4A3340", VA = "0x1804A4D40")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600036E")]
			[Address(RVA = "0x4A4E90", Offset = "0x4A3490", VA = "0x1804A4E90")]
			set
			{
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600036F RID: 879 RVA: 0x00002594 File Offset: 0x00000794
		// (set) Token: 0x06000370 RID: 880 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700001A")]
		public int TotalCount
		{
			[Token(Token = "0x600036F")]
			[Address(RVA = "0x4875A0", Offset = "0x485BA0", VA = "0x1804875A0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000370")]
			[Address(RVA = "0x4875C0", Offset = "0x485BC0", VA = "0x1804875C0")]
			set
			{
			}
		}

		// Token: 0x06000371 RID: 881 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000371")]
		[Address(RVA = "0x4ACC40", Offset = "0x4AB240", VA = "0x1804ACC40", Slot = "5")]
		public void Set(ref PageResult other)
		{
		}

		// Token: 0x06000372 RID: 882 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000372")]
		[Address(RVA = "0x4ACBA0", Offset = "0x4AB1A0", VA = "0x1804ACBA0", Slot = "6")]
		public void Set(ref PageResult? other)
		{
		}

		// Token: 0x06000373 RID: 883 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000373")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "7")]
		public void Dispose()
		{
		}

		// Token: 0x06000374 RID: 884 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000374")]
		[Address(RVA = "0x4ACB80", Offset = "0x4AB180", VA = "0x1804ACB80", Slot = "4")]
		public void Get(out PageResult output)
		{
		}

		// Token: 0x04000090 RID: 144
		[Token(Token = "0x4000090")]
		[FieldOffset(Offset = "0x0")]
		private int m_StartIndex;

		// Token: 0x04000091 RID: 145
		[Token(Token = "0x4000091")]
		[FieldOffset(Offset = "0x4")]
		private int m_Count;

		// Token: 0x04000092 RID: 146
		[Token(Token = "0x4000092")]
		[FieldOffset(Offset = "0x8")]
		private int m_TotalCount;
	}
}
