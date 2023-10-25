using System;


namespace Epic.OnlineServices.Ecom
{
	// Token: 0x0200057A RID: 1402
	[Token(Token = "0x200057A")]
	internal struct QueryEntitlementsOptionsInternal : ISettable<QueryEntitlementsOptions>, IDisposable
	{
		// Token: 0x17000A67 RID: 2663
		// (set) Token: 0x06002405 RID: 9221 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A67")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x6002405")]
			[Address(RVA = "0x54C180", Offset = "0x54A780", VA = "0x18054C180")]
			set
			{
			}
		}

		// Token: 0x17000A68 RID: 2664
		// (set) Token: 0x06002406 RID: 9222 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A68")]
		public Utf8String[] EntitlementNames
		{
			[Token(Token = "0x6002406")]
			[Address(RVA = "0x54C0A0", Offset = "0x54A6A0", VA = "0x18054C0A0")]
			set
			{
			}
		}

		// Token: 0x17000A69 RID: 2665
		// (set) Token: 0x06002407 RID: 9223 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A69")]
		public bool IncludeRedeemed
		{
			[Token(Token = "0x6002407")]
			[Address(RVA = "0x54C120", Offset = "0x54A720", VA = "0x18054C120")]
			set
			{
			}
		}

		// Token: 0x06002408 RID: 9224 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002408")]
		[Address(RVA = "0x54BEA0", Offset = "0x54A4A0", VA = "0x18054BEA0", Slot = "4")]
		public void Set(ref QueryEntitlementsOptions other)
		{
		}

		// Token: 0x06002409 RID: 9225 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002409")]
		[Address(RVA = "0x54BF70", Offset = "0x54A570", VA = "0x18054BF70", Slot = "5")]
		public void Set(ref QueryEntitlementsOptions? other)
		{
		}

		// Token: 0x0600240A RID: 9226 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600240A")]
		[Address(RVA = "0x54BE40", Offset = "0x54A440", VA = "0x18054BE40", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000FFC RID: 4092
		[Token(Token = "0x4000FFC")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000FFD RID: 4093
		[Token(Token = "0x4000FFD")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x04000FFE RID: 4094
		[Token(Token = "0x4000FFE")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_EntitlementNames;

		// Token: 0x04000FFF RID: 4095
		[Token(Token = "0x4000FFF")]
		[FieldOffset(Offset = "0x18")]
		private uint m_EntitlementNameCount;

		// Token: 0x04001000 RID: 4096
		[Token(Token = "0x4001000")]
		[FieldOffset(Offset = "0x1C")]
		private int m_IncludeRedeemed;
	}
}
