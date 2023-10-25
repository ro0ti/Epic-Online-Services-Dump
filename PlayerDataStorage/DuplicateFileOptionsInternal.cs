using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.PlayerDataStorage
{
	// Token: 0x020002E3 RID: 739
	[Token(Token = "0x20002E3")]
	internal struct DuplicateFileOptionsInternal : ISettable<DuplicateFileOptions>, IDisposable
	{
		// Token: 0x17000555 RID: 1365
		// (set) Token: 0x06001407 RID: 5127 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000555")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6001407")]
			[Address(RVA = "0x4F0E90", Offset = "0x4EF490", VA = "0x1804F0E90")]
			set
			{
			}
		}

		// Token: 0x17000556 RID: 1366
		// (set) Token: 0x06001408 RID: 5128 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000556")]
		public Utf8String SourceFilename
		{
			[Token(Token = "0x6001408")]
			[Address(RVA = "0x4F0EF0", Offset = "0x4EF4F0", VA = "0x1804F0EF0")]
			set
			{
			}
		}

		// Token: 0x17000557 RID: 1367
		// (set) Token: 0x06001409 RID: 5129 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000557")]
		public Utf8String DestinationFilename
		{
			[Token(Token = "0x6001409")]
			[Address(RVA = "0x4F0E30", Offset = "0x4EF430", VA = "0x1804F0E30")]
			set
			{
			}
		}

		// Token: 0x0600140A RID: 5130 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600140A")]
		[Address(RVA = "0x4F0D30", Offset = "0x4EF330", VA = "0x1804F0D30", Slot = "4")]
		public void Set(ref DuplicateFileOptions other)
		{
		}

		// Token: 0x0600140B RID: 5131 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600140B")]
		[Address(RVA = "0x4F0BD0", Offset = "0x4EF1D0", VA = "0x1804F0BD0", Slot = "5")]
		public void Set(ref DuplicateFileOptions? other)
		{
		}

		// Token: 0x0600140C RID: 5132 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600140C")]
		[Address(RVA = "0x4F0B60", Offset = "0x4EF160", VA = "0x1804F0B60", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x040008E5 RID: 2277
		[Token(Token = "0x40008E5")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x040008E6 RID: 2278
		[Token(Token = "0x40008E6")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x040008E7 RID: 2279
		[Token(Token = "0x40008E7")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_SourceFilename;

		// Token: 0x040008E8 RID: 2280
		[Token(Token = "0x40008E8")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_DestinationFilename;
	}
}
