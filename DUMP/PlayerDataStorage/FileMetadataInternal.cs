using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.PlayerDataStorage
{
	// Token: 0x020002E5 RID: 741
	[Token(Token = "0x20002E5")]
	internal struct FileMetadataInternal : IGettable<FileMetadata>, ISettable<FileMetadata>, IDisposable
	{
		// Token: 0x1700055D RID: 1373
		// (get) Token: 0x06001418 RID: 5144 RVA: 0x00005C9C File Offset: 0x00003E9C
		// (set) Token: 0x06001419 RID: 5145 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700055D")]
		public uint FileSizeBytes
		{
			[Token(Token = "0x6001418")]
			[Address(RVA = "0x4A4D40", Offset = "0x4A3340", VA = "0x1804A4D40")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001419")]
			[Address(RVA = "0x4A4E90", Offset = "0x4A3490", VA = "0x1804A4E90")]
			set
			{
			}
		}

		// Token: 0x1700055E RID: 1374
		// (get) Token: 0x0600141A RID: 5146 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600141B RID: 5147 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700055E")]
		public Utf8String MD5Hash
		{
			[Token(Token = "0x600141A")]
			[Address(RVA = "0x4F1420", Offset = "0x4EFA20", VA = "0x1804F1420")]
			get
			{
				return null;
			}
			[Token(Token = "0x600141B")]
			[Address(RVA = "0x4F1560", Offset = "0x4EFB60", VA = "0x1804F1560")]
			set
			{
			}
		}

		// Token: 0x1700055F RID: 1375
		// (get) Token: 0x0600141C RID: 5148 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600141D RID: 5149 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700055F")]
		public Utf8String Filename
		{
			[Token(Token = "0x600141C")]
			[Address(RVA = "0x4F1340", Offset = "0x4EF940", VA = "0x1804F1340")]
			get
			{
				return null;
			}
			[Token(Token = "0x600141D")]
			[Address(RVA = "0x4F1490", Offset = "0x4EFA90", VA = "0x1804F1490")]
			set
			{
			}
		}

		// Token: 0x17000560 RID: 1376
		// (get) Token: 0x0600141E RID: 5150 RVA: 0x00005CB4 File Offset: 0x00003EB4
		// (set) Token: 0x0600141F RID: 5151 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000560")]
		public DateTimeOffset? LastModifiedTime
		{
			[Token(Token = "0x600141E")]
			[Address(RVA = "0x4F13B0", Offset = "0x4EF9B0", VA = "0x1804F13B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600141F")]
			[Address(RVA = "0x4F14F0", Offset = "0x4EFAF0", VA = "0x1804F14F0")]
			set
			{
			}
		}

		// Token: 0x17000561 RID: 1377
		// (get) Token: 0x06001420 RID: 5152 RVA: 0x00005CCC File Offset: 0x00003ECC
		// (set) Token: 0x06001421 RID: 5153 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000561")]
		public uint UnencryptedDataSizeBytes
		{
			[Token(Token = "0x6001420")]
			[Address(RVA = "0x3D2F80", Offset = "0x3D1580", VA = "0x1803D2F80")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001421")]
			[Address(RVA = "0x488190", Offset = "0x486790", VA = "0x180488190")]
			set
			{
			}
		}

		// Token: 0x06001422 RID: 5154 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001422")]
		[Address(RVA = "0x4F1040", Offset = "0x4EF640", VA = "0x1804F1040", Slot = "5")]
		public void Set(ref FileMetadata other)
		{
		}

		// Token: 0x06001423 RID: 5155 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001423")]
		[Address(RVA = "0x4F1180", Offset = "0x4EF780", VA = "0x1804F1180", Slot = "6")]
		public void Set(ref FileMetadata? other)
		{
		}

		// Token: 0x06001424 RID: 5156 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001424")]
		[Address(RVA = "0x4F0FB0", Offset = "0x4EF5B0", VA = "0x1804F0FB0", Slot = "7")]
		public void Dispose()
		{
		}

		// Token: 0x06001425 RID: 5157 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001425")]
		[Address(RVA = "0x4F1010", Offset = "0x4EF610", VA = "0x1804F1010", Slot = "4")]
		public void Get(out FileMetadata output)
		{
		}

		// Token: 0x040008EE RID: 2286
		[Token(Token = "0x40008EE")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x040008EF RID: 2287
		[Token(Token = "0x40008EF")]
		[FieldOffset(Offset = "0x4")]
		private uint m_FileSizeBytes;

		// Token: 0x040008F0 RID: 2288
		[Token(Token = "0x40008F0")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_MD5Hash;

		// Token: 0x040008F1 RID: 2289
		[Token(Token = "0x40008F1")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_Filename;

		// Token: 0x040008F2 RID: 2290
		[Token(Token = "0x40008F2")]
		[FieldOffset(Offset = "0x18")]
		private long m_LastModifiedTime;

		// Token: 0x040008F3 RID: 2291
		[Token(Token = "0x40008F3")]
		[FieldOffset(Offset = "0x20")]
		private uint m_UnencryptedDataSizeBytes;
	}
}
