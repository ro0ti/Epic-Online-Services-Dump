using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.ProgressionSnapshot
{
	// Token: 0x02000297 RID: 663
	[Token(Token = "0x2000297")]
	internal struct EndSnapshotOptionsInternal : ISettable<EndSnapshotOptions>, IDisposable
	{
		// Token: 0x170004CB RID: 1227
		// (set) Token: 0x0600124A RID: 4682 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170004CB")]
		public uint SnapshotId
		{
			[Token(Token = "0x600124A")]
			[Address(RVA = "0x4A4E90", Offset = "0x4A3490", VA = "0x1804A4E90")]
			set
			{
			}
		}

		// Token: 0x0600124B RID: 4683 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600124B")]
		[Address(RVA = "0x4AFC00", Offset = "0x4AE200", VA = "0x1804AFC00", Slot = "4")]
		public void Set(ref EndSnapshotOptions other)
		{
		}

		// Token: 0x0600124C RID: 4684 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600124C")]
		[Address(RVA = "0x4F0F50", Offset = "0x4EF550", VA = "0x1804F0F50", Slot = "5")]
		public void Set(ref EndSnapshotOptions? other)
		{
		}

		// Token: 0x0600124D RID: 4685 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600124D")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000824 RID: 2084
		[Token(Token = "0x4000824")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000825 RID: 2085
		[Token(Token = "0x4000825")]
		[FieldOffset(Offset = "0x4")]
		private uint m_SnapshotId;
	}
}
