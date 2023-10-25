using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Connect
{
	// Token: 0x0200063A RID: 1594
	[Token(Token = "0x200063A")]
	internal struct QueryProductUserIdMappingsOptionsInternal : ISettable<QueryProductUserIdMappingsOptions>, IDisposable
	{
		// Token: 0x17000BCE RID: 3022
		// (set) Token: 0x060028BC RID: 10428 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BCE")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x60028BC")]
			[Address(RVA = "0x564FC0", Offset = "0x5635C0", VA = "0x180564FC0")]
			set
			{
			}
		}

		// Token: 0x17000BCF RID: 3023
		// (set) Token: 0x060028BD RID: 10429 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BCF")]
		public ExternalAccountType AccountIdType_DEPRECATED
		{
			[Token(Token = "0x60028BD")]
			[Address(RVA = "0x457A40", Offset = "0x456040", VA = "0x180457A40")]
			set
			{
			}
		}

		// Token: 0x17000BD0 RID: 3024
		// (set) Token: 0x060028BE RID: 10430 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BD0")]
		public ProductUserId[] ProductUserIds
		{
			[Token(Token = "0x60028BE")]
			[Address(RVA = "0x565020", Offset = "0x563620", VA = "0x180565020")]
			set
			{
			}
		}

		// Token: 0x060028BF RID: 10431 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60028BF")]
		[Address(RVA = "0x564F30", Offset = "0x563530", VA = "0x180564F30", Slot = "4")]
		public void Set(ref QueryProductUserIdMappingsOptions other)
		{
		}

		// Token: 0x060028C0 RID: 10432 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60028C0")]
		[Address(RVA = "0x564E30", Offset = "0x563430", VA = "0x180564E30", Slot = "5")]
		public void Set(ref QueryProductUserIdMappingsOptions? other)
		{
		}

		// Token: 0x060028C1 RID: 10433 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60028C1")]
		[Address(RVA = "0x564DD0", Offset = "0x5633D0", VA = "0x180564DD0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x040011B1 RID: 4529
		[Token(Token = "0x40011B1")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x040011B2 RID: 4530
		[Token(Token = "0x40011B2")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x040011B3 RID: 4531
		[Token(Token = "0x40011B3")]
		[FieldOffset(Offset = "0x10")]
		private ExternalAccountType m_AccountIdType_DEPRECATED;

		// Token: 0x040011B4 RID: 4532
		[Token(Token = "0x40011B4")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_ProductUserIds;

		// Token: 0x040011B5 RID: 4533
		[Token(Token = "0x40011B5")]
		[FieldOffset(Offset = "0x20")]
		private uint m_ProductUserIdCount;
	}
}
