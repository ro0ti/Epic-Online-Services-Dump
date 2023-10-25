using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Connect
{
	// Token: 0x02000636 RID: 1590
	[Token(Token = "0x2000636")]
	internal struct QueryExternalAccountMappingsOptionsInternal : ISettable<QueryExternalAccountMappingsOptions>, IDisposable
	{
		// Token: 0x17000BC1 RID: 3009
		// (set) Token: 0x0600289D RID: 10397 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BC1")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x600289D")]
			[Address(RVA = "0x564860", Offset = "0x562E60", VA = "0x180564860")]
			set
			{
			}
		}

		// Token: 0x17000BC2 RID: 3010
		// (set) Token: 0x0600289E RID: 10398 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BC2")]
		public ExternalAccountType AccountIdType
		{
			[Token(Token = "0x600289E")]
			[Address(RVA = "0x457A40", Offset = "0x456040", VA = "0x180457A40")]
			set
			{
			}
		}

		// Token: 0x17000BC3 RID: 3011
		// (set) Token: 0x0600289F RID: 10399 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BC3")]
		public Utf8String[] ExternalAccountIds
		{
			[Token(Token = "0x600289F")]
			[Address(RVA = "0x5647D0", Offset = "0x562DD0", VA = "0x1805647D0")]
			set
			{
			}
		}

		// Token: 0x060028A0 RID: 10400 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60028A0")]
		[Address(RVA = "0x564740", Offset = "0x562D40", VA = "0x180564740", Slot = "4")]
		public void Set(ref QueryExternalAccountMappingsOptions other)
		{
		}

		// Token: 0x060028A1 RID: 10401 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60028A1")]
		[Address(RVA = "0x564640", Offset = "0x562C40", VA = "0x180564640", Slot = "5")]
		public void Set(ref QueryExternalAccountMappingsOptions? other)
		{
		}

		// Token: 0x060028A2 RID: 10402 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60028A2")]
		[Address(RVA = "0x5645E0", Offset = "0x562BE0", VA = "0x1805645E0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x040011A3 RID: 4515
		[Token(Token = "0x40011A3")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x040011A4 RID: 4516
		[Token(Token = "0x40011A4")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x040011A5 RID: 4517
		[Token(Token = "0x40011A5")]
		[FieldOffset(Offset = "0x10")]
		private ExternalAccountType m_AccountIdType;

		// Token: 0x040011A6 RID: 4518
		[Token(Token = "0x40011A6")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_ExternalAccountIds;

		// Token: 0x040011A7 RID: 4519
		[Token(Token = "0x40011A7")]
		[FieldOffset(Offset = "0x20")]
		private uint m_ExternalAccountIdCount;
	}
}
