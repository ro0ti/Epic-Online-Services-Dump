using System;


namespace Epic.OnlineServices.RTCAdmin
{
	// Token: 0x02000241 RID: 577
	[Token(Token = "0x2000241")]
	internal struct CopyUserTokenByUserIdOptionsInternal : ISettable<CopyUserTokenByUserIdOptions>, IDisposable
	{
		// Token: 0x170003FD RID: 1021
		// (set) Token: 0x06000FF5 RID: 4085 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170003FD")]
		public ProductUserId TargetUserId
		{
			[Token(Token = "0x6000FF5")]
			[Address(RVA = "0x4D8CF0", Offset = "0x4D72F0", VA = "0x1804D8CF0")]
			set
			{
			}
		}

		// Token: 0x170003FE RID: 1022
		// (set) Token: 0x06000FF6 RID: 4086 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170003FE")]
		public uint QueryId
		{
			[Token(Token = "0x6000FF6")]
			[Address(RVA = "0x457A40", Offset = "0x456040", VA = "0x180457A40")]
			set
			{
			}
		}

		// Token: 0x06000FF7 RID: 4087 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000FF7")]
		[Address(RVA = "0x4D8BA0", Offset = "0x4D71A0", VA = "0x1804D8BA0", Slot = "4")]
		public void Set(ref CopyUserTokenByUserIdOptions other)
		{
		}

		// Token: 0x06000FF8 RID: 4088 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000FF8")]
		[Address(RVA = "0x4D8C20", Offset = "0x4D7220", VA = "0x1804D8C20", Slot = "5")]
		public void Set(ref CopyUserTokenByUserIdOptions? other)
		{
		}

		// Token: 0x06000FF9 RID: 4089 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000FF9")]
		[Address(RVA = "0x4D8B50", Offset = "0x4D7150", VA = "0x1804D8B50", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000724 RID: 1828
		[Token(Token = "0x4000724")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000725 RID: 1829
		[Token(Token = "0x4000725")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_TargetUserId;

		// Token: 0x04000726 RID: 1830
		[Token(Token = "0x4000726")]
		[FieldOffset(Offset = "0x10")]
		private uint m_QueryId;
	}
}
