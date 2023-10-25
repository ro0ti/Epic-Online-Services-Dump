using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Ecom
{
	// Token: 0x02000551 RID: 1361
	[Token(Token = "0x2000551")]
	internal struct GetEntitlementsByNameCountOptionsInternal : ISettable<GetEntitlementsByNameCountOptions>, IDisposable
	{
		// Token: 0x17000A37 RID: 2615
		// (set) Token: 0x06002349 RID: 9033 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A37")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x6002349")]
			[Address(RVA = "0x546CD0", Offset = "0x5452D0", VA = "0x180546CD0")]
			set
			{
			}
		}

		// Token: 0x17000A38 RID: 2616
		// (set) Token: 0x0600234A RID: 9034 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A38")]
		public Utf8String EntitlementName
		{
			[Token(Token = "0x600234A")]
			[Address(RVA = "0x546C70", Offset = "0x545270", VA = "0x180546C70")]
			set
			{
			}
		}

		// Token: 0x0600234B RID: 9035 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600234B")]
		[Address(RVA = "0x546AA0", Offset = "0x5450A0", VA = "0x180546AA0", Slot = "4")]
		public void Set(ref GetEntitlementsByNameCountOptions other)
		{
		}

		// Token: 0x0600234C RID: 9036 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600234C")]
		[Address(RVA = "0x546B60", Offset = "0x545160", VA = "0x180546B60", Slot = "5")]
		public void Set(ref GetEntitlementsByNameCountOptions? other)
		{
		}

		// Token: 0x0600234D RID: 9037 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600234D")]
		[Address(RVA = "0x546A40", Offset = "0x545040", VA = "0x180546A40", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000FBF RID: 4031
		[Token(Token = "0x4000FBF")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000FC0 RID: 4032
		[Token(Token = "0x4000FC0")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x04000FC1 RID: 4033
		[Token(Token = "0x4000FC1")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_EntitlementName;
	}
}
