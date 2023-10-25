using System;


namespace Epic.OnlineServices.Presence
{
	// Token: 0x020002AC RID: 684
	[Token(Token = "0x20002AC")]
	internal struct GetJoinInfoOptionsInternal : ISettable<GetJoinInfoOptions>, IDisposable
	{
		// Token: 0x170004E1 RID: 1249
		// (set) Token: 0x060012A6 RID: 4774 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170004E1")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x60012A6")]
			[Address(RVA = "0x4F21E0", Offset = "0x4F07E0", VA = "0x1804F21E0")]
			set
			{
			}
		}

		// Token: 0x170004E2 RID: 1250
		// (set) Token: 0x060012A7 RID: 4775 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170004E2")]
		public EpicAccountId TargetUserId
		{
			[Token(Token = "0x60012A7")]
			[Address(RVA = "0x4F2240", Offset = "0x4F0840", VA = "0x1804F2240")]
			set
			{
			}
		}

		// Token: 0x060012A8 RID: 4776 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60012A8")]
		[Address(RVA = "0x4F2120", Offset = "0x4F0720", VA = "0x1804F2120", Slot = "4")]
		public void Set(ref GetJoinInfoOptions other)
		{
		}

		// Token: 0x060012A9 RID: 4777 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60012A9")]
		[Address(RVA = "0x4F2010", Offset = "0x4F0610", VA = "0x1804F2010", Slot = "5")]
		public void Set(ref GetJoinInfoOptions? other)
		{
		}

		// Token: 0x060012AA RID: 4778 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60012AA")]
		[Address(RVA = "0x4F1FB0", Offset = "0x4F05B0", VA = "0x1804F1FB0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000846 RID: 2118
		[Token(Token = "0x4000846")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000847 RID: 2119
		[Token(Token = "0x4000847")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x04000848 RID: 2120
		[Token(Token = "0x4000848")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_TargetUserId;
	}
}
