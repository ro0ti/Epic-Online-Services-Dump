using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Ecom
{
	// Token: 0x02000563 RID: 1379
	[Token(Token = "0x2000563")]
	internal struct ItemOwnershipInternal : IGettable<ItemOwnership>, ISettable<ItemOwnership>, IDisposable
	{
		// Token: 0x17000A53 RID: 2643
		// (get) Token: 0x0600238F RID: 9103 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002390 RID: 9104 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A53")]
		public Utf8String Id
		{
			[Token(Token = "0x600238F")]
			[Address(RVA = "0x548810", Offset = "0x546E10", VA = "0x180548810")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002390")]
			[Address(RVA = "0x548880", Offset = "0x546E80", VA = "0x180548880")]
			set
			{
			}
		}

		// Token: 0x17000A54 RID: 2644
		// (get) Token: 0x06002391 RID: 9105 RVA: 0x0000962C File Offset: 0x0000782C
		// (set) Token: 0x06002392 RID: 9106 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A54")]
		public OwnershipStatus OwnershipStatus
		{
			[Token(Token = "0x6002391")]
			[Address(RVA = "0x3D2690", Offset = "0x3D0C90", VA = "0x1803D2690")]
			get
			{
				return OwnershipStatus.NotOwned;
			}
			[Token(Token = "0x6002392")]
			[Address(RVA = "0x457A40", Offset = "0x456040", VA = "0x180457A40")]
			set
			{
			}
		}

		// Token: 0x06002393 RID: 9107 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002393")]
		[Address(RVA = "0x5486C0", Offset = "0x546CC0", VA = "0x1805486C0", Slot = "5")]
		public void Set(ref ItemOwnership other)
		{
		}

		// Token: 0x06002394 RID: 9108 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002394")]
		[Address(RVA = "0x548740", Offset = "0x546D40", VA = "0x180548740", Slot = "6")]
		public void Set(ref ItemOwnership? other)
		{
		}

		// Token: 0x06002395 RID: 9109 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002395")]
		[Address(RVA = "0x548650", Offset = "0x546C50", VA = "0x180548650", Slot = "7")]
		public void Dispose()
		{
		}

		// Token: 0x06002396 RID: 9110 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002396")]
		[Address(RVA = "0x5486A0", Offset = "0x546CA0", VA = "0x1805486A0", Slot = "4")]
		public void Get(out ItemOwnership output)
		{
		}

		// Token: 0x04000FE4 RID: 4068
		[Token(Token = "0x4000FE4")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000FE5 RID: 4069
		[Token(Token = "0x4000FE5")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_Id;

		// Token: 0x04000FE6 RID: 4070
		[Token(Token = "0x4000FE6")]
		[FieldOffset(Offset = "0x10")]
		private OwnershipStatus m_OwnershipStatus;
	}
}
