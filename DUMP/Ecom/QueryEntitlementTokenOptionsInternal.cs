using System;


namespace Epic.OnlineServices.Ecom
{
	// Token: 0x0200057E RID: 1406
	[Token(Token = "0x200057E")]
	internal struct QueryEntitlementTokenOptionsInternal : ISettable<QueryEntitlementTokenOptions>, IDisposable
	{
		// Token: 0x17000A75 RID: 2677
		// (set) Token: 0x06002426 RID: 9254 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A75")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x6002426")]
			[Address(RVA = "0x54B8D0", Offset = "0x549ED0", VA = "0x18054B8D0")]
			set
			{
			}
		}

		// Token: 0x17000A76 RID: 2678
		// (set) Token: 0x06002427 RID: 9255 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A76")]
		public Utf8String[] EntitlementNames
		{
			[Token(Token = "0x6002427")]
			[Address(RVA = "0x54B850", Offset = "0x549E50", VA = "0x18054B850")]
			set
			{
			}
		}

		// Token: 0x06002428 RID: 9256 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002428")]
		[Address(RVA = "0x54B6E0", Offset = "0x549CE0", VA = "0x18054B6E0", Slot = "4")]
		public void Set(ref QueryEntitlementTokenOptions other)
		{
		}

		// Token: 0x06002429 RID: 9257 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002429")]
		[Address(RVA = "0x54B770", Offset = "0x549D70", VA = "0x18054B770", Slot = "5")]
		public void Set(ref QueryEntitlementTokenOptions? other)
		{
		}

		// Token: 0x0600242A RID: 9258 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600242A")]
		[Address(RVA = "0x54B680", Offset = "0x549C80", VA = "0x18054B680", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x0400100B RID: 4107
		[Token(Token = "0x400100B")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x0400100C RID: 4108
		[Token(Token = "0x400100C")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x0400100D RID: 4109
		[Token(Token = "0x400100D")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_EntitlementNames;

		// Token: 0x0400100E RID: 4110
		[Token(Token = "0x400100E")]
		[FieldOffset(Offset = "0x18")]
		private uint m_EntitlementNameCount;
	}
}
