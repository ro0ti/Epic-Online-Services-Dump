using System;


namespace Epic.OnlineServices.TitleStorage
{
	// Token: 0x020000A6 RID: 166
	[Token(Token = "0x20000A6")]
	internal struct CopyFileMetadataByFilenameOptionsInternal : ISettable<CopyFileMetadataByFilenameOptions>, IDisposable
	{
		// Token: 0x17000109 RID: 265
		// (set) Token: 0x0600064A RID: 1610 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000109")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x600064A")]
			[Address(RVA = "0x4A1370", Offset = "0x49F970", VA = "0x1804A1370")]
			set
			{
			}
		}

		// Token: 0x1700010A RID: 266
		// (set) Token: 0x0600064B RID: 1611 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700010A")]
		public Utf8String Filename
		{
			[Token(Token = "0x600064B")]
			[Address(RVA = "0x4A1310", Offset = "0x49F910", VA = "0x1804A1310")]
			set
			{
			}
		}

		// Token: 0x0600064C RID: 1612 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600064C")]
		[Address(RVA = "0x4A12A0", Offset = "0x49F8A0", VA = "0x1804A12A0", Slot = "4")]
		public void Set(ref CopyFileMetadataByFilenameOptions other)
		{
		}

		// Token: 0x0600064D RID: 1613 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600064D")]
		[Address(RVA = "0x4A11D0", Offset = "0x49F7D0", VA = "0x1804A11D0", Slot = "5")]
		public void Set(ref CopyFileMetadataByFilenameOptions? other)
		{
		}

		// Token: 0x0600064E RID: 1614 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600064E")]
		[Address(RVA = "0x4A10F0", Offset = "0x49F6F0", VA = "0x1804A10F0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000332 RID: 818
		[Token(Token = "0x4000332")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000333 RID: 819
		[Token(Token = "0x4000333")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x04000334 RID: 820
		[Token(Token = "0x4000334")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_Filename;
	}
}
