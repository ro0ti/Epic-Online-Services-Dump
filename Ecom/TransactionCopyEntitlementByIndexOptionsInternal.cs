using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Ecom
{
	// Token: 0x02000597 RID: 1431
	[Token(Token = "0x2000597")]
	internal struct TransactionCopyEntitlementByIndexOptionsInternal : ISettable<TransactionCopyEntitlementByIndexOptions>, IDisposable
	{
		// Token: 0x17000ABF RID: 2751
		// (set) Token: 0x060024E2 RID: 9442 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000ABF")]
		public uint EntitlementIndex
		{
			[Token(Token = "0x60024E2")]
			[Address(RVA = "0x4A4E90", Offset = "0x4A3490", VA = "0x1804A4E90")]
			set
			{
			}
		}

		// Token: 0x060024E3 RID: 9443 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60024E3")]
		[Address(RVA = "0x4AFC00", Offset = "0x4AE200", VA = "0x1804AFC00", Slot = "4")]
		public void Set(ref TransactionCopyEntitlementByIndexOptions other)
		{
		}

		// Token: 0x060024E4 RID: 9444 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60024E4")]
		[Address(RVA = "0x5514C0", Offset = "0x54FAC0", VA = "0x1805514C0", Slot = "5")]
		public void Set(ref TransactionCopyEntitlementByIndexOptions? other)
		{
		}

		// Token: 0x060024E5 RID: 9445 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60024E5")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04001060 RID: 4192
		[Token(Token = "0x4001060")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04001061 RID: 4193
		[Token(Token = "0x4001061")]
		[FieldOffset(Offset = "0x4")]
		private uint m_EntitlementIndex;
	}
}
