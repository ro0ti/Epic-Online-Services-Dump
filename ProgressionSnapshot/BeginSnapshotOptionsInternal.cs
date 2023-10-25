using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.ProgressionSnapshot
{
	// Token: 0x02000291 RID: 657
	[Token(Token = "0x2000291")]
	internal struct BeginSnapshotOptionsInternal : ISettable<BeginSnapshotOptions>, IDisposable
	{
		// Token: 0x170004C0 RID: 1216
		// (set) Token: 0x0600122B RID: 4651 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170004C0")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x600122B")]
			[Address(RVA = "0x4ED650", Offset = "0x4EBC50", VA = "0x1804ED650")]
			set
			{
			}
		}

		// Token: 0x0600122C RID: 4652 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600122C")]
		[Address(RVA = "0x4ED5F0", Offset = "0x4EBBF0", VA = "0x1804ED5F0", Slot = "4")]
		public void Set(ref BeginSnapshotOptions other)
		{
		}

		// Token: 0x0600122D RID: 4653 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600122D")]
		[Address(RVA = "0x4ED550", Offset = "0x4EBB50", VA = "0x1804ED550", Slot = "5")]
		public void Set(ref BeginSnapshotOptions? other)
		{
		}

		// Token: 0x0600122E RID: 4654 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600122E")]
		[Address(RVA = "0x4ED500", Offset = "0x4EBB00", VA = "0x1804ED500", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000818 RID: 2072
		[Token(Token = "0x4000818")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000819 RID: 2073
		[Token(Token = "0x4000819")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;
	}
}
