using System;


namespace Epic.OnlineServices.ProgressionSnapshot
{
	// Token: 0x02000295 RID: 661
	[Token(Token = "0x2000295")]
	internal struct DeleteSnapshotOptionsInternal : ISettable<DeleteSnapshotOptions>, IDisposable
	{
		// Token: 0x170004C9 RID: 1225
		// (set) Token: 0x06001244 RID: 4676 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170004C9")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6001244")]
			[Address(RVA = "0x4F05F0", Offset = "0x4EEBF0", VA = "0x1804F05F0")]
			set
			{
			}
		}

		// Token: 0x06001245 RID: 4677 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001245")]
		[Address(RVA = "0x4F0590", Offset = "0x4EEB90", VA = "0x1804F0590", Slot = "4")]
		public void Set(ref DeleteSnapshotOptions other)
		{
		}

		// Token: 0x06001246 RID: 4678 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001246")]
		[Address(RVA = "0x4F04F0", Offset = "0x4EEAF0", VA = "0x1804F04F0", Slot = "5")]
		public void Set(ref DeleteSnapshotOptions? other)
		{
		}

		// Token: 0x06001247 RID: 4679 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001247")]
		[Address(RVA = "0x4F04A0", Offset = "0x4EEAA0", VA = "0x1804F04A0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000821 RID: 2081
		[Token(Token = "0x4000821")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000822 RID: 2082
		[Token(Token = "0x4000822")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;
	}
}
