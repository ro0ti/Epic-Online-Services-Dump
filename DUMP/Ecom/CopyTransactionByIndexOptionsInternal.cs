using System;


namespace Epic.OnlineServices.Ecom
{
	// Token: 0x0200054B RID: 1355
	[Token(Token = "0x200054B")]
	internal struct CopyTransactionByIndexOptionsInternal : ISettable<CopyTransactionByIndexOptions>, IDisposable
	{
		// Token: 0x17000A27 RID: 2599
		// (set) Token: 0x060022FB RID: 8955 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A27")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x60022FB")]
			[Address(RVA = "0x53F9F0", Offset = "0x53DFF0", VA = "0x18053F9F0")]
			set
			{
			}
		}

		// Token: 0x17000A28 RID: 2600
		// (set) Token: 0x060022FC RID: 8956 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A28")]
		public uint TransactionIndex
		{
			[Token(Token = "0x60022FC")]
			[Address(RVA = "0x457A40", Offset = "0x456040", VA = "0x180457A40")]
			set
			{
			}
		}

		// Token: 0x060022FD RID: 8957 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60022FD")]
		[Address(RVA = "0x53F8A0", Offset = "0x53DEA0", VA = "0x18053F8A0", Slot = "4")]
		public void Set(ref CopyTransactionByIndexOptions other)
		{
		}

		// Token: 0x060022FE RID: 8958 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60022FE")]
		[Address(RVA = "0x53F920", Offset = "0x53DF20", VA = "0x18053F920", Slot = "5")]
		public void Set(ref CopyTransactionByIndexOptions? other)
		{
		}

		// Token: 0x060022FF RID: 8959 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60022FF")]
		[Address(RVA = "0x53F850", Offset = "0x53DE50", VA = "0x18053F850", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000F76 RID: 3958
		[Token(Token = "0x4000F76")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000F77 RID: 3959
		[Token(Token = "0x4000F77")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x04000F78 RID: 3960
		[Token(Token = "0x4000F78")]
		[FieldOffset(Offset = "0x10")]
		private uint m_TransactionIndex;
	}
}
