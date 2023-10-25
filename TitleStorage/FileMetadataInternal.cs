using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.TitleStorage
{
	// Token: 0x020000AC RID: 172
	[Token(Token = "0x20000AC")]
	internal struct FileMetadataInternal : IGettable<FileMetadata>, ISettable<FileMetadata>, IDisposable
	{
		// Token: 0x17000118 RID: 280
		// (get) Token: 0x06000671 RID: 1649 RVA: 0x00003044 File Offset: 0x00001244
		// (set) Token: 0x06000672 RID: 1650 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000118")]
		public uint FileSizeBytes
		{
			[Token(Token = "0x6000671")]
			[Address(RVA = "0x4A4D40", Offset = "0x4A3340", VA = "0x1804A4D40")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6000672")]
			[Address(RVA = "0x4A4E90", Offset = "0x4A3490", VA = "0x1804A4E90")]
			set
			{
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x06000673 RID: 1651 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000674 RID: 1652 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000119")]
		public Utf8String MD5Hash
		{
			[Token(Token = "0x6000673")]
			[Address(RVA = "0x4A5430", Offset = "0x4A3A30", VA = "0x1804A5430")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000674")]
			[Address(RVA = "0x4A5500", Offset = "0x4A3B00", VA = "0x1804A5500")]
			set
			{
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x06000675 RID: 1653 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000676 RID: 1654 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700011A")]
		public Utf8String Filename
		{
			[Token(Token = "0x6000675")]
			[Address(RVA = "0x4A53C0", Offset = "0x4A39C0", VA = "0x1804A53C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000676")]
			[Address(RVA = "0x4A54A0", Offset = "0x4A3AA0", VA = "0x1804A54A0")]
			set
			{
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x06000677 RID: 1655 RVA: 0x0000305C File Offset: 0x0000125C
		// (set) Token: 0x06000678 RID: 1656 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700011B")]
		public uint UnencryptedDataSizeBytes
		{
			[Token(Token = "0x6000677")]
			[Address(RVA = "0x4447E0", Offset = "0x442DE0", VA = "0x1804447E0")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6000678")]
			[Address(RVA = "0x444820", Offset = "0x442E20", VA = "0x180444820")]
			set
			{
			}
		}

		// Token: 0x06000679 RID: 1657 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000679")]
		[Address(RVA = "0x4A51B0", Offset = "0x4A37B0", VA = "0x1804A51B0", Slot = "5")]
		public void Set(ref FileMetadata other)
		{
		}

		// Token: 0x0600067A RID: 1658 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600067A")]
		[Address(RVA = "0x4A5280", Offset = "0x4A3880", VA = "0x1804A5280", Slot = "6")]
		public void Set(ref FileMetadata? other)
		{
		}

		// Token: 0x0600067B RID: 1659 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600067B")]
		[Address(RVA = "0x4A50B0", Offset = "0x4A36B0", VA = "0x1804A50B0", Slot = "7")]
		public void Dispose()
		{
		}

		// Token: 0x0600067C RID: 1660 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600067C")]
		[Address(RVA = "0x4A5190", Offset = "0x4A3790", VA = "0x1804A5190", Slot = "4")]
		public void Get(out FileMetadata output)
		{
		}

		// Token: 0x04000342 RID: 834
		[Token(Token = "0x4000342")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000343 RID: 835
		[Token(Token = "0x4000343")]
		[FieldOffset(Offset = "0x4")]
		private uint m_FileSizeBytes;

		// Token: 0x04000344 RID: 836
		[Token(Token = "0x4000344")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_MD5Hash;

		// Token: 0x04000345 RID: 837
		[Token(Token = "0x4000345")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_Filename;

		// Token: 0x04000346 RID: 838
		[Token(Token = "0x4000346")]
		[FieldOffset(Offset = "0x18")]
		private uint m_UnencryptedDataSizeBytes;
	}
}
