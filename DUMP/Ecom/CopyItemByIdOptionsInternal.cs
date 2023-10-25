using System;


namespace Epic.OnlineServices.Ecom
{
	// Token: 0x02000539 RID: 1337
	[Token(Token = "0x2000539")]
	internal struct CopyItemByIdOptionsInternal : ISettable<CopyItemByIdOptions>, IDisposable
	{
		// Token: 0x170009FB RID: 2555
		// (set) Token: 0x0600229E RID: 8862 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170009FB")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x600229E")]
			[Address(RVA = "0x53E190", Offset = "0x53C790", VA = "0x18053E190")]
			set
			{
			}
		}

		// Token: 0x170009FC RID: 2556
		// (set) Token: 0x0600229F RID: 8863 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170009FC")]
		public Utf8String ItemId
		{
			[Token(Token = "0x600229F")]
			[Address(RVA = "0x53E130", Offset = "0x53C730", VA = "0x18053E130")]
			set
			{
			}
		}

		// Token: 0x060022A0 RID: 8864 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60022A0")]
		[Address(RVA = "0x53DF60", Offset = "0x53C560", VA = "0x18053DF60", Slot = "4")]
		public void Set(ref CopyItemByIdOptions other)
		{
		}

		// Token: 0x060022A1 RID: 8865 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60022A1")]
		[Address(RVA = "0x53E020", Offset = "0x53C620", VA = "0x18053E020", Slot = "5")]
		public void Set(ref CopyItemByIdOptions? other)
		{
		}

		// Token: 0x060022A2 RID: 8866 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60022A2")]
		[Address(RVA = "0x53DF00", Offset = "0x53C500", VA = "0x18053DF00", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000F41 RID: 3905
		[Token(Token = "0x4000F41")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000F42 RID: 3906
		[Token(Token = "0x4000F42")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x04000F43 RID: 3907
		[Token(Token = "0x4000F43")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_ItemId;
	}
}
