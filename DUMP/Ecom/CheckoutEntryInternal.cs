using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Ecom
{
	// Token: 0x0200052F RID: 1327
	[Token(Token = "0x200052F")]
	internal struct CheckoutEntryInternal : IGettable<CheckoutEntry>, ISettable<CheckoutEntry>, IDisposable
	{
		// Token: 0x170009E4 RID: 2532
		// (get) Token: 0x0600226A RID: 8810 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600226B RID: 8811 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170009E4")]
		public Utf8String OfferId
		{
			[Token(Token = "0x600226A")]
			[Address(RVA = "0x53D1F0", Offset = "0x53B7F0", VA = "0x18053D1F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600226B")]
			[Address(RVA = "0x53D260", Offset = "0x53B860", VA = "0x18053D260")]
			set
			{
			}
		}

		// Token: 0x0600226C RID: 8812 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600226C")]
		[Address(RVA = "0x53D0F0", Offset = "0x53B6F0", VA = "0x18053D0F0", Slot = "5")]
		public void Set(ref CheckoutEntry other)
		{
		}

		// Token: 0x0600226D RID: 8813 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600226D")]
		[Address(RVA = "0x53D150", Offset = "0x53B750", VA = "0x18053D150", Slot = "6")]
		public void Set(ref CheckoutEntry? other)
		{
		}

		// Token: 0x0600226E RID: 8814 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600226E")]
		[Address(RVA = "0x53D080", Offset = "0x53B680", VA = "0x18053D080", Slot = "7")]
		public void Dispose()
		{
		}

		// Token: 0x0600226F RID: 8815 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600226F")]
		[Address(RVA = "0x53D0D0", Offset = "0x53B6D0", VA = "0x18053D0D0", Slot = "4")]
		public void Get(out CheckoutEntry output)
		{
		}

		// Token: 0x04000F24 RID: 3876
		[Token(Token = "0x4000F24")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000F25 RID: 3877
		[Token(Token = "0x4000F25")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_OfferId;
	}
}
