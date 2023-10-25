using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Ecom
{
	// Token: 0x0200058A RID: 1418
	[Token(Token = "0x200058A")]
	internal struct QueryOwnershipOptionsInternal : ISettable<QueryOwnershipOptions>, IDisposable
	{
		// Token: 0x17000A9B RID: 2715
		// (set) Token: 0x06002484 RID: 9348 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A9B")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x6002484")]
			[Address(RVA = "0x54E380", Offset = "0x54C980", VA = "0x18054E380")]
			set
			{
			}
		}

		// Token: 0x17000A9C RID: 2716
		// (set) Token: 0x06002485 RID: 9349 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A9C")]
		public Utf8String[] CatalogItemIds
		{
			[Token(Token = "0x6002485")]
			[Address(RVA = "0x54E2A0", Offset = "0x54C8A0", VA = "0x18054E2A0")]
			set
			{
			}
		}

		// Token: 0x17000A9D RID: 2717
		// (set) Token: 0x06002486 RID: 9350 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A9D")]
		public Utf8String CatalogNamespace
		{
			[Token(Token = "0x6002486")]
			[Address(RVA = "0x54E320", Offset = "0x54C920", VA = "0x18054E320")]
			set
			{
			}
		}

		// Token: 0x06002487 RID: 9351 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002487")]
		[Address(RVA = "0x54E1D0", Offset = "0x54C7D0", VA = "0x18054E1D0", Slot = "4")]
		public void Set(ref QueryOwnershipOptions other)
		{
		}

		// Token: 0x06002488 RID: 9352 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002488")]
		[Address(RVA = "0x54E0A0", Offset = "0x54C6A0", VA = "0x18054E0A0", Slot = "5")]
		public void Set(ref QueryOwnershipOptions? other)
		{
		}

		// Token: 0x06002489 RID: 9353 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002489")]
		[Address(RVA = "0x54E030", Offset = "0x54C630", VA = "0x18054E030", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04001035 RID: 4149
		[Token(Token = "0x4001035")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04001036 RID: 4150
		[Token(Token = "0x4001036")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x04001037 RID: 4151
		[Token(Token = "0x4001037")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_CatalogItemIds;

		// Token: 0x04001038 RID: 4152
		[Token(Token = "0x4001038")]
		[FieldOffset(Offset = "0x18")]
		private uint m_CatalogItemIdCount;

		// Token: 0x04001039 RID: 4153
		[Token(Token = "0x4001039")]
		[FieldOffset(Offset = "0x20")]
		private IntPtr m_CatalogNamespace;
	}
}
