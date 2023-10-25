using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Ecom
{
	// Token: 0x02000592 RID: 1426
	[Token(Token = "0x2000592")]
	internal struct RedeemEntitlementsOptionsInternal : ISettable<RedeemEntitlementsOptions>, IDisposable
	{
		// Token: 0x17000AB8 RID: 2744
		// (set) Token: 0x060024C8 RID: 9416 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000AB8")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x60024C8")]
			[Address(RVA = "0x54F610", Offset = "0x54DC10", VA = "0x18054F610")]
			set
			{
			}
		}

		// Token: 0x17000AB9 RID: 2745
		// (set) Token: 0x060024C9 RID: 9417 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000AB9")]
		public Utf8String[] EntitlementIds
		{
			[Token(Token = "0x60024C9")]
			[Address(RVA = "0x54F590", Offset = "0x54DB90", VA = "0x18054F590")]
			set
			{
			}
		}

		// Token: 0x060024CA RID: 9418 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60024CA")]
		[Address(RVA = "0x54F420", Offset = "0x54DA20", VA = "0x18054F420", Slot = "4")]
		public void Set(ref RedeemEntitlementsOptions other)
		{
		}

		// Token: 0x060024CB RID: 9419 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60024CB")]
		[Address(RVA = "0x54F4B0", Offset = "0x54DAB0", VA = "0x18054F4B0", Slot = "5")]
		public void Set(ref RedeemEntitlementsOptions? other)
		{
		}

		// Token: 0x060024CC RID: 9420 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60024CC")]
		[Address(RVA = "0x54F3C0", Offset = "0x54D9C0", VA = "0x18054F3C0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04001054 RID: 4180
		[Token(Token = "0x4001054")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04001055 RID: 4181
		[Token(Token = "0x4001055")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x04001056 RID: 4182
		[Token(Token = "0x4001056")]
		[FieldOffset(Offset = "0x10")]
		private uint m_EntitlementIdCount;

		// Token: 0x04001057 RID: 4183
		[Token(Token = "0x4001057")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_EntitlementIds;
	}
}
