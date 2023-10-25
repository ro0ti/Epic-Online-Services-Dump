using System;


namespace Epic.OnlineServices.Stats
{
	// Token: 0x020000D5 RID: 213
	[Token(Token = "0x20000D5")]
	internal struct IngestDataInternal : IGettable<IngestData>, ISettable<IngestData>, IDisposable
	{
		// Token: 0x1700016D RID: 365
		// (get) Token: 0x06000784 RID: 1924 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000785 RID: 1925 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700016D")]
		public Utf8String StatName
		{
			[Token(Token = "0x6000784")]
			[Address(RVA = "0x4BD1B0", Offset = "0x4BB7B0", VA = "0x1804BD1B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000785")]
			[Address(RVA = "0x4BD220", Offset = "0x4BB820", VA = "0x1804BD220")]
			set
			{
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x06000786 RID: 1926 RVA: 0x0000341C File Offset: 0x0000161C
		// (set) Token: 0x06000787 RID: 1927 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700016E")]
		public int IngestAmount
		{
			[Token(Token = "0x6000786")]
			[Address(RVA = "0x3D2690", Offset = "0x3D0C90", VA = "0x1803D2690")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000787")]
			[Address(RVA = "0x457A40", Offset = "0x456040", VA = "0x180457A40")]
			set
			{
			}
		}

		// Token: 0x06000788 RID: 1928 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000788")]
		[Address(RVA = "0x4BD060", Offset = "0x4BB660", VA = "0x1804BD060", Slot = "5")]
		public void Set(ref IngestData other)
		{
		}

		// Token: 0x06000789 RID: 1929 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000789")]
		[Address(RVA = "0x4BD0E0", Offset = "0x4BB6E0", VA = "0x1804BD0E0", Slot = "6")]
		public void Set(ref IngestData? other)
		{
		}

		// Token: 0x0600078A RID: 1930 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600078A")]
		[Address(RVA = "0x4BCFF0", Offset = "0x4BB5F0", VA = "0x1804BCFF0", Slot = "7")]
		public void Dispose()
		{
		}

		// Token: 0x0600078B RID: 1931 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600078B")]
		[Address(RVA = "0x4BD040", Offset = "0x4BB640", VA = "0x1804BD040", Slot = "4")]
		public void Get(out IngestData output)
		{
		}

		// Token: 0x040003B2 RID: 946
		[Token(Token = "0x40003B2")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x040003B3 RID: 947
		[Token(Token = "0x40003B3")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_StatName;

		// Token: 0x040003B4 RID: 948
		[Token(Token = "0x40003B4")]
		[FieldOffset(Offset = "0x10")]
		private int m_IngestAmount;
	}
}
