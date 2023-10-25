using System;


namespace Epic.OnlineServices.PlayerDataStorage
{
	// Token: 0x02000307 RID: 775
	[Token(Token = "0x2000307")]
	internal struct QueryFileOptionsInternal : ISettable<QueryFileOptions>, IDisposable
	{
		// Token: 0x17000583 RID: 1411
		// (set) Token: 0x060014E7 RID: 5351 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000583")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x60014E7")]
			[Address(RVA = "0x4FE120", Offset = "0x4FC720", VA = "0x1804FE120")]
			set
			{
			}
		}

		// Token: 0x17000584 RID: 1412
		// (set) Token: 0x060014E8 RID: 5352 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000584")]
		public Utf8String Filename
		{
			[Token(Token = "0x60014E8")]
			[Address(RVA = "0x4FE0C0", Offset = "0x4FC6C0", VA = "0x1804FE0C0")]
			set
			{
			}
		}

		// Token: 0x060014E9 RID: 5353 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60014E9")]
		[Address(RVA = "0x4FDEF0", Offset = "0x4FC4F0", VA = "0x1804FDEF0", Slot = "4")]
		public void Set(ref QueryFileOptions other)
		{
		}

		// Token: 0x060014EA RID: 5354 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60014EA")]
		[Address(RVA = "0x4FDFB0", Offset = "0x4FC5B0", VA = "0x1804FDFB0", Slot = "5")]
		public void Set(ref QueryFileOptions? other)
		{
		}

		// Token: 0x060014EB RID: 5355 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60014EB")]
		[Address(RVA = "0x4FDE90", Offset = "0x4FC490", VA = "0x1804FDE90", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x0400092B RID: 2347
		[Token(Token = "0x400092B")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x0400092C RID: 2348
		[Token(Token = "0x400092C")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x0400092D RID: 2349
		[Token(Token = "0x400092D")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_Filename;
	}
}
