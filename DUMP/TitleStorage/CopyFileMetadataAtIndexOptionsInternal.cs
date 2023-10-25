using System;


namespace Epic.OnlineServices.TitleStorage
{
	// Token: 0x020000A4 RID: 164
	[Token(Token = "0x20000A4")]
	internal struct CopyFileMetadataAtIndexOptionsInternal : ISettable<CopyFileMetadataAtIndexOptions>, IDisposable
	{
		// Token: 0x17000105 RID: 261
		// (set) Token: 0x06000641 RID: 1601 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000105")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6000641")]
			[Address(RVA = "0x4A1040", Offset = "0x49F640", VA = "0x1804A1040")]
			set
			{
			}
		}

		// Token: 0x17000106 RID: 262
		// (set) Token: 0x06000642 RID: 1602 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000106")]
		public uint Index
		{
			[Token(Token = "0x6000642")]
			[Address(RVA = "0x457A40", Offset = "0x456040", VA = "0x180457A40")]
			set
			{
			}
		}

		// Token: 0x06000643 RID: 1603 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000643")]
		[Address(RVA = "0x4A0F70", Offset = "0x49F570", VA = "0x1804A0F70", Slot = "4")]
		public void Set(ref CopyFileMetadataAtIndexOptions other)
		{
		}

		// Token: 0x06000644 RID: 1604 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000644")]
		[Address(RVA = "0x4A0FB0", Offset = "0x49F5B0", VA = "0x1804A0FB0", Slot = "5")]
		public void Set(ref CopyFileMetadataAtIndexOptions? other)
		{
		}

		// Token: 0x06000645 RID: 1605 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000645")]
		[Address(RVA = "0x4A0EE0", Offset = "0x49F4E0", VA = "0x1804A0EE0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x0400032D RID: 813
		[Token(Token = "0x400032D")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x0400032E RID: 814
		[Token(Token = "0x400032E")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x0400032F RID: 815
		[Token(Token = "0x400032F")]
		[FieldOffset(Offset = "0x10")]
		private uint m_Index;
	}
}
