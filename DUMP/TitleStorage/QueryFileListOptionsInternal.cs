using System;


namespace Epic.OnlineServices.TitleStorage
{
	// Token: 0x020000C2 RID: 194
	[Token(Token = "0x20000C2")]
	internal struct QueryFileListOptionsInternal : ISettable<QueryFileListOptions>, IDisposable
	{
		// Token: 0x1700013B RID: 315
		// (set) Token: 0x060006FC RID: 1788 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700013B")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x60006FC")]
			[Address(RVA = "0x4C2310", Offset = "0x4C0910", VA = "0x1804C2310")]
			set
			{
			}
		}

		// Token: 0x1700013C RID: 316
		// (set) Token: 0x060006FD RID: 1789 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700013C")]
		public Utf8String[] ListOfTags
		{
			[Token(Token = "0x60006FD")]
			[Address(RVA = "0x4C2290", Offset = "0x4C0890", VA = "0x1804C2290")]
			set
			{
			}
		}

		// Token: 0x060006FE RID: 1790 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006FE")]
		[Address(RVA = "0x4C2200", Offset = "0x4C0800", VA = "0x1804C2200", Slot = "4")]
		public void Set(ref QueryFileListOptions other)
		{
		}

		// Token: 0x060006FF RID: 1791 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006FF")]
		[Address(RVA = "0x4C2120", Offset = "0x4C0720", VA = "0x1804C2120", Slot = "5")]
		public void Set(ref QueryFileListOptions? other)
		{
		}

		// Token: 0x06000700 RID: 1792 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000700")]
		[Address(RVA = "0x4C20C0", Offset = "0x4C06C0", VA = "0x1804C20C0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000364 RID: 868
		[Token(Token = "0x4000364")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000365 RID: 869
		[Token(Token = "0x4000365")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x04000366 RID: 870
		[Token(Token = "0x4000366")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_ListOfTags;

		// Token: 0x04000367 RID: 871
		[Token(Token = "0x4000367")]
		[FieldOffset(Offset = "0x18")]
		private uint m_ListOfTagsCount;
	}
}
