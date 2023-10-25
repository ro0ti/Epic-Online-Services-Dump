using System;


namespace Epic.OnlineServices.Ecom
{
	// Token: 0x02000599 RID: 1433
	[Token(Token = "0x2000599")]
	internal struct TransactionGetEntitlementsCountOptionsInternal : ISettable<TransactionGetEntitlementsCountOptions>, IDisposable
	{
		// Token: 0x060024E6 RID: 9446 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60024E6")]
		[Address(RVA = "0x4875E0", Offset = "0x485BE0", VA = "0x1804875E0", Slot = "4")]
		public void Set(ref TransactionGetEntitlementsCountOptions other)
		{
		}

		// Token: 0x060024E7 RID: 9447 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60024E7")]
		[Address(RVA = "0x551520", Offset = "0x54FB20", VA = "0x180551520", Slot = "5")]
		public void Set(ref TransactionGetEntitlementsCountOptions? other)
		{
		}

		// Token: 0x060024E8 RID: 9448 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60024E8")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04001062 RID: 4194
		[Token(Token = "0x4001062")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;
	}
}
