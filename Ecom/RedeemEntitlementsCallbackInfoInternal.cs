using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Ecom
{
	// Token: 0x02000590 RID: 1424
	[Token(Token = "0x2000590")]
	internal struct RedeemEntitlementsCallbackInfoInternal : ICallbackInfoInternal, IGettable<RedeemEntitlementsCallbackInfo>, ISettable<RedeemEntitlementsCallbackInfo>, IDisposable
	{
		// Token: 0x17000AB1 RID: 2737
		// (get) Token: 0x060024B7 RID: 9399 RVA: 0x00009944 File Offset: 0x00007B44
		// (set) Token: 0x060024B8 RID: 9400 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000AB1")]
		public Result ResultCode
		{
			[Token(Token = "0x60024B7")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x60024B8")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x17000AB2 RID: 2738
		// (get) Token: 0x060024B9 RID: 9401 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060024BA RID: 9402 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000AB2")]
		public object ClientData
		{
			[Token(Token = "0x60024B9")]
			[Address(RVA = "0x54F110", Offset = "0x54D710", VA = "0x18054F110")]
			get
			{
				return null;
			}
			[Token(Token = "0x60024BA")]
			[Address(RVA = "0x54F200", Offset = "0x54D800", VA = "0x18054F200")]
			set
			{
			}
		}

		// Token: 0x17000AB3 RID: 2739
		// (get) Token: 0x060024BB RID: 9403 RVA: 0x0000995C File Offset: 0x00007B5C
		[Token(Token = "0x17000AB3")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x60024BB")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000AB4 RID: 2740
		// (get) Token: 0x060024BC RID: 9404 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060024BD RID: 9405 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000AB4")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x60024BC")]
			[Address(RVA = "0x54F180", Offset = "0x54D780", VA = "0x18054F180")]
			get
			{
				return null;
			}
			[Token(Token = "0x60024BD")]
			[Address(RVA = "0x54F260", Offset = "0x54D860", VA = "0x18054F260")]
			set
			{
			}
		}

		// Token: 0x17000AB5 RID: 2741
		// (get) Token: 0x060024BE RID: 9406 RVA: 0x00009974 File Offset: 0x00007B74
		// (set) Token: 0x060024BF RID: 9407 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000AB5")]
		public uint RedeemedEntitlementIdsCount
		{
			[Token(Token = "0x60024BE")]
			[Address(RVA = "0x4447E0", Offset = "0x442DE0", VA = "0x1804447E0")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x60024BF")]
			[Address(RVA = "0x444820", Offset = "0x442E20", VA = "0x180444820")]
			set
			{
			}
		}

		// Token: 0x060024C0 RID: 9408 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60024C0")]
		[Address(RVA = "0x54F040", Offset = "0x54D640", VA = "0x18054F040", Slot = "6")]
		public void Set(ref RedeemEntitlementsCallbackInfo other)
		{
		}

		// Token: 0x060024C1 RID: 9409 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60024C1")]
		[Address(RVA = "0x54EF00", Offset = "0x54D500", VA = "0x18054EF00", Slot = "7")]
		public void Set(ref RedeemEntitlementsCallbackInfo? other)
		{
		}

		// Token: 0x060024C2 RID: 9410 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60024C2")]
		[Address(RVA = "0x54EE80", Offset = "0x54D480", VA = "0x18054EE80", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x060024C3 RID: 9411 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60024C3")]
		[Address(RVA = "0x54EEE0", Offset = "0x54D4E0", VA = "0x18054EEE0", Slot = "5")]
		public void Get(out RedeemEntitlementsCallbackInfo output)
		{
		}

		// Token: 0x0400104E RID: 4174
		[Token(Token = "0x400104E")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x0400104F RID: 4175
		[Token(Token = "0x400104F")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;

		// Token: 0x04001050 RID: 4176
		[Token(Token = "0x4001050")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LocalUserId;

		// Token: 0x04001051 RID: 4177
		[Token(Token = "0x4001051")]
		[FieldOffset(Offset = "0x18")]
		private uint m_RedeemedEntitlementIdsCount;
	}
}
