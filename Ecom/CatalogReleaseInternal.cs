using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Ecom
{
	// Token: 0x0200052B RID: 1323
	[Token(Token = "0x200052B")]
	internal struct CatalogReleaseInternal : IGettable<CatalogRelease>, ISettable<CatalogRelease>, IDisposable
	{
		// Token: 0x170009D7 RID: 2519
		// (get) Token: 0x06002246 RID: 8774 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002247 RID: 8775 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170009D7")]
		public Utf8String[] CompatibleAppIds
		{
			[Token(Token = "0x6002246")]
			[Address(RVA = "0x53C5D0", Offset = "0x53ABD0", VA = "0x18053C5D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002247")]
			[Address(RVA = "0x53C760", Offset = "0x53AD60", VA = "0x18053C760")]
			set
			{
			}
		}

		// Token: 0x170009D8 RID: 2520
		// (get) Token: 0x06002248 RID: 8776 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002249 RID: 8777 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170009D8")]
		public Utf8String[] CompatiblePlatforms
		{
			[Token(Token = "0x6002248")]
			[Address(RVA = "0x53C660", Offset = "0x53AC60", VA = "0x18053C660")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002249")]
			[Address(RVA = "0x53C7F0", Offset = "0x53ADF0", VA = "0x18053C7F0")]
			set
			{
			}
		}

		// Token: 0x170009D9 RID: 2521
		// (get) Token: 0x0600224A RID: 8778 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600224B RID: 8779 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170009D9")]
		public Utf8String ReleaseNote
		{
			[Token(Token = "0x600224A")]
			[Address(RVA = "0x53C6F0", Offset = "0x53ACF0", VA = "0x18053C6F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600224B")]
			[Address(RVA = "0x53C880", Offset = "0x53AE80", VA = "0x18053C880")]
			set
			{
			}
		}

		// Token: 0x0600224C RID: 8780 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600224C")]
		[Address(RVA = "0x53C460", Offset = "0x53AA60", VA = "0x18053C460", Slot = "5")]
		public void Set(ref CatalogRelease other)
		{
		}

		// Token: 0x0600224D RID: 8781 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600224D")]
		[Address(RVA = "0x53C4E0", Offset = "0x53AAE0", VA = "0x18053C4E0", Slot = "6")]
		public void Set(ref CatalogRelease? other)
		{
		}

		// Token: 0x0600224E RID: 8782 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600224E")]
		[Address(RVA = "0x53C3D0", Offset = "0x53A9D0", VA = "0x18053C3D0", Slot = "7")]
		public void Dispose()
		{
		}

		// Token: 0x0600224F RID: 8783 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600224F")]
		[Address(RVA = "0x53C440", Offset = "0x53AA40", VA = "0x18053C440", Slot = "4")]
		public void Get(out CatalogRelease output)
		{
		}

		// Token: 0x04000F15 RID: 3861
		[Token(Token = "0x4000F15")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000F16 RID: 3862
		[Token(Token = "0x4000F16")]
		[FieldOffset(Offset = "0x4")]
		private uint m_CompatibleAppIdCount;

		// Token: 0x04000F17 RID: 3863
		[Token(Token = "0x4000F17")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_CompatibleAppIds;

		// Token: 0x04000F18 RID: 3864
		[Token(Token = "0x4000F18")]
		[FieldOffset(Offset = "0x10")]
		private uint m_CompatiblePlatformCount;

		// Token: 0x04000F19 RID: 3865
		[Token(Token = "0x4000F19")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_CompatiblePlatforms;

		// Token: 0x04000F1A RID: 3866
		[Token(Token = "0x4000F1A")]
		[FieldOffset(Offset = "0x20")]
		private IntPtr m_ReleaseNote;
	}
}
