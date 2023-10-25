using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Auth
{
	// Token: 0x0200064A RID: 1610
	[Token(Token = "0x200064A")]
	internal struct AccountFeatureRestrictedInfoInternal : IGettable<AccountFeatureRestrictedInfo>, ISettable<AccountFeatureRestrictedInfo>, IDisposable
	{
		// Token: 0x17000C07 RID: 3079
		// (get) Token: 0x06002947 RID: 10567 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002948 RID: 10568 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C07")]
		public Utf8String VerificationURI
		{
			[Token(Token = "0x6002947")]
			[Address(RVA = "0x552D20", Offset = "0x551320", VA = "0x180552D20")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002948")]
			[Address(RVA = "0x552D90", Offset = "0x551390", VA = "0x180552D90")]
			set
			{
			}
		}

		// Token: 0x06002949 RID: 10569 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002949")]
		[Address(RVA = "0x552C20", Offset = "0x551220", VA = "0x180552C20", Slot = "5")]
		public void Set(ref AccountFeatureRestrictedInfo other)
		{
		}

		// Token: 0x0600294A RID: 10570 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600294A")]
		[Address(RVA = "0x552C80", Offset = "0x551280", VA = "0x180552C80", Slot = "6")]
		public void Set(ref AccountFeatureRestrictedInfo? other)
		{
		}

		// Token: 0x0600294B RID: 10571 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600294B")]
		[Address(RVA = "0x552BB0", Offset = "0x5511B0", VA = "0x180552BB0", Slot = "7")]
		public void Dispose()
		{
		}

		// Token: 0x0600294C RID: 10572 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600294C")]
		[Address(RVA = "0x552C00", Offset = "0x551200", VA = "0x180552C00", Slot = "4")]
		public void Get(out AccountFeatureRestrictedInfo output)
		{
		}

		// Token: 0x040011ED RID: 4589
		[Token(Token = "0x40011ED")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x040011EE RID: 4590
		[Token(Token = "0x40011EE")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_VerificationURI;
	}
}
