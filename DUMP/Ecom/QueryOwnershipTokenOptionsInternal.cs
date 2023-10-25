using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Ecom
{
	// Token: 0x0200058E RID: 1422
	[Token(Token = "0x200058E")]
	internal struct QueryOwnershipTokenOptionsInternal : ISettable<QueryOwnershipTokenOptions>, IDisposable
	{
		// Token: 0x17000AAA RID: 2730
		// (set) Token: 0x060024A7 RID: 9383 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000AAA")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x60024A7")]
			[Address(RVA = "0x54EE20", Offset = "0x54D420", VA = "0x18054EE20")]
			set
			{
			}
		}

		// Token: 0x17000AAB RID: 2731
		// (set) Token: 0x060024A8 RID: 9384 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000AAB")]
		public Utf8String[] CatalogItemIds
		{
			[Token(Token = "0x60024A8")]
			[Address(RVA = "0x54ED40", Offset = "0x54D340", VA = "0x18054ED40")]
			set
			{
			}
		}

		// Token: 0x17000AAC RID: 2732
		// (set) Token: 0x060024A9 RID: 9385 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000AAC")]
		public Utf8String CatalogNamespace
		{
			[Token(Token = "0x60024A9")]
			[Address(RVA = "0x54EDC0", Offset = "0x54D3C0", VA = "0x18054EDC0")]
			set
			{
			}
		}

		// Token: 0x060024AA RID: 9386 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60024AA")]
		[Address(RVA = "0x54EB40", Offset = "0x54D140", VA = "0x18054EB40", Slot = "4")]
		public void Set(ref QueryOwnershipTokenOptions other)
		{
		}

		// Token: 0x060024AB RID: 9387 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60024AB")]
		[Address(RVA = "0x54EC10", Offset = "0x54D210", VA = "0x18054EC10", Slot = "5")]
		public void Set(ref QueryOwnershipTokenOptions? other)
		{
		}

		// Token: 0x060024AC RID: 9388 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60024AC")]
		[Address(RVA = "0x54EAD0", Offset = "0x54D0D0", VA = "0x18054EAD0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04001045 RID: 4165
		[Token(Token = "0x4001045")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04001046 RID: 4166
		[Token(Token = "0x4001046")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x04001047 RID: 4167
		[Token(Token = "0x4001047")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_CatalogItemIds;

		// Token: 0x04001048 RID: 4168
		[Token(Token = "0x4001048")]
		[FieldOffset(Offset = "0x18")]
		private uint m_CatalogItemIdCount;

		// Token: 0x04001049 RID: 4169
		[Token(Token = "0x4001049")]
		[FieldOffset(Offset = "0x20")]
		private IntPtr m_CatalogNamespace;
	}
}
