using System;


namespace Epic.OnlineServices.Ecom
{
	// Token: 0x0200053F RID: 1343
	[Token(Token = "0x200053F")]
	internal struct CopyLastRedeemedEntitlementByIndexOptionsInternal : ISettable<CopyLastRedeemedEntitlementByIndexOptions>, IDisposable
	{
		// Token: 0x17000A0B RID: 2571
		// (set) Token: 0x060022BF RID: 8895 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A0B")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x60022BF")]
			[Address(RVA = "0x53E9D0", Offset = "0x53CFD0", VA = "0x18053E9D0")]
			set
			{
			}
		}

		// Token: 0x17000A0C RID: 2572
		// (set) Token: 0x060022C0 RID: 8896 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A0C")]
		public uint RedeemedEntitlementIndex
		{
			[Token(Token = "0x60022C0")]
			[Address(RVA = "0x457A40", Offset = "0x456040", VA = "0x180457A40")]
			set
			{
			}
		}

		// Token: 0x060022C1 RID: 8897 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60022C1")]
		[Address(RVA = "0x53E950", Offset = "0x53CF50", VA = "0x18053E950", Slot = "4")]
		public void Set(ref CopyLastRedeemedEntitlementByIndexOptions other)
		{
		}

		// Token: 0x060022C2 RID: 8898 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60022C2")]
		[Address(RVA = "0x53E880", Offset = "0x53CE80", VA = "0x18053E880", Slot = "5")]
		public void Set(ref CopyLastRedeemedEntitlementByIndexOptions? other)
		{
		}

		// Token: 0x060022C3 RID: 8899 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60022C3")]
		[Address(RVA = "0x53E830", Offset = "0x53CE30", VA = "0x18053E830", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000F54 RID: 3924
		[Token(Token = "0x4000F54")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000F55 RID: 3925
		[Token(Token = "0x4000F55")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x04000F56 RID: 3926
		[Token(Token = "0x4000F56")]
		[FieldOffset(Offset = "0x10")]
		private uint m_RedeemedEntitlementIndex;
	}
}
