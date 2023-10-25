using System;


namespace Epic.OnlineServices.Sessions
{
	// Token: 0x02000117 RID: 279
	[Token(Token = "0x2000117")]
	internal struct GetInviteIdByIndexOptionsInternal : ISettable<GetInviteIdByIndexOptions>, IDisposable
	{
		// Token: 0x170001DE RID: 478
		// (set) Token: 0x060008DB RID: 2267 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001DE")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x60008DB")]
			[Address(RVA = "0x4BCDE0", Offset = "0x4BB3E0", VA = "0x1804BCDE0")]
			set
			{
			}
		}

		// Token: 0x170001DF RID: 479
		// (set) Token: 0x060008DC RID: 2268 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001DF")]
		public uint Index
		{
			[Token(Token = "0x60008DC")]
			[Address(RVA = "0x457A40", Offset = "0x456040", VA = "0x180457A40")]
			set
			{
			}
		}

		// Token: 0x060008DD RID: 2269 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008DD")]
		[Address(RVA = "0x4BCC90", Offset = "0x4BB290", VA = "0x1804BCC90", Slot = "4")]
		public void Set(ref GetInviteIdByIndexOptions other)
		{
		}

		// Token: 0x060008DE RID: 2270 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008DE")]
		[Address(RVA = "0x4BCD10", Offset = "0x4BB310", VA = "0x1804BCD10", Slot = "5")]
		public void Set(ref GetInviteIdByIndexOptions? other)
		{
		}

		// Token: 0x060008DF RID: 2271 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008DF")]
		[Address(RVA = "0x4BCC40", Offset = "0x4BB240", VA = "0x1804BCC40", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x0400044B RID: 1099
		[Token(Token = "0x400044B")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x0400044C RID: 1100
		[Token(Token = "0x400044C")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x0400044D RID: 1101
		[Token(Token = "0x400044D")]
		[FieldOffset(Offset = "0x10")]
		private uint m_Index;
	}
}
