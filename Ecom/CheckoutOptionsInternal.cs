using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Ecom
{
	// Token: 0x02000531 RID: 1329
	[Token(Token = "0x2000531")]
	internal struct CheckoutOptionsInternal : ISettable<CheckoutOptions>, IDisposable
	{
		// Token: 0x170009E8 RID: 2536
		// (set) Token: 0x06002276 RID: 8822 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170009E8")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x6002276")]
			[Address(RVA = "0x53D630", Offset = "0x53BC30", VA = "0x18053D630")]
			set
			{
			}
		}

		// Token: 0x170009E9 RID: 2537
		// (set) Token: 0x06002277 RID: 8823 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170009E9")]
		public Utf8String OverrideCatalogNamespace
		{
			[Token(Token = "0x6002277")]
			[Address(RVA = "0x53D690", Offset = "0x53BC90", VA = "0x18053D690")]
			set
			{
			}
		}

		// Token: 0x170009EA RID: 2538
		// (set) Token: 0x06002278 RID: 8824 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170009EA")]
		public CheckoutEntry[] Entries
		{
			[Token(Token = "0x6002278")]
			[Address(RVA = "0x53D5B0", Offset = "0x53BBB0", VA = "0x18053D5B0")]
			set
			{
			}
		}

		// Token: 0x06002279 RID: 8825 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002279")]
		[Address(RVA = "0x53D3B0", Offset = "0x53B9B0", VA = "0x18053D3B0", Slot = "4")]
		public void Set(ref CheckoutOptions other)
		{
		}

		// Token: 0x0600227A RID: 8826 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600227A")]
		[Address(RVA = "0x53D480", Offset = "0x53BA80", VA = "0x18053D480", Slot = "5")]
		public void Set(ref CheckoutOptions? other)
		{
		}

		// Token: 0x0600227B RID: 8827 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600227B")]
		[Address(RVA = "0x53D340", Offset = "0x53B940", VA = "0x18053D340", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000F29 RID: 3881
		[Token(Token = "0x4000F29")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000F2A RID: 3882
		[Token(Token = "0x4000F2A")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x04000F2B RID: 3883
		[Token(Token = "0x4000F2B")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_OverrideCatalogNamespace;

		// Token: 0x04000F2C RID: 3884
		[Token(Token = "0x4000F2C")]
		[FieldOffset(Offset = "0x18")]
		private uint m_EntryCount;

		// Token: 0x04000F2D RID: 3885
		[Token(Token = "0x4000F2D")]
		[FieldOffset(Offset = "0x20")]
		private IntPtr m_Entries;
	}
}
