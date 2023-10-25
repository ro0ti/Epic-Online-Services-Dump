using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.RTCAudio
{
	// Token: 0x0200022D RID: 557
	[Token(Token = "0x200022D")]
	internal struct UpdateParticipantVolumeOptionsInternal : ISettable<UpdateParticipantVolumeOptions>, IDisposable
	{
		// Token: 0x170003AB RID: 939
		// (set) Token: 0x06000F3E RID: 3902 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170003AB")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6000F3E")]
			[Address(RVA = "0x4E80F0", Offset = "0x4E66F0", VA = "0x1804E80F0")]
			set
			{
			}
		}

		// Token: 0x170003AC RID: 940
		// (set) Token: 0x06000F3F RID: 3903 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170003AC")]
		public Utf8String RoomName
		{
			[Token(Token = "0x6000F3F")]
			[Address(RVA = "0x4E81B0", Offset = "0x4E67B0", VA = "0x1804E81B0")]
			set
			{
			}
		}

		// Token: 0x170003AD RID: 941
		// (set) Token: 0x06000F40 RID: 3904 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170003AD")]
		public ProductUserId ParticipantId
		{
			[Token(Token = "0x6000F40")]
			[Address(RVA = "0x4E8150", Offset = "0x4E6750", VA = "0x1804E8150")]
			set
			{
			}
		}

		// Token: 0x170003AE RID: 942
		// (set) Token: 0x06000F41 RID: 3905 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170003AE")]
		public float Volume
		{
			[Token(Token = "0x6000F41")]
			[Address(RVA = "0x3E4040", Offset = "0x3E2640", VA = "0x1803E4040")]
			set
			{
			}
		}

		// Token: 0x06000F42 RID: 3906 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F42")]
		[Address(RVA = "0x4E7FE0", Offset = "0x4E65E0", VA = "0x1804E7FE0", Slot = "4")]
		public void Set(ref UpdateParticipantVolumeOptions other)
		{
		}

		// Token: 0x06000F43 RID: 3907 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F43")]
		[Address(RVA = "0x4E7E60", Offset = "0x4E6460", VA = "0x1804E7E60", Slot = "5")]
		public void Set(ref UpdateParticipantVolumeOptions? other)
		{
		}

		// Token: 0x06000F44 RID: 3908 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F44")]
		[Address(RVA = "0x4E7DF0", Offset = "0x4E63F0", VA = "0x1804E7DF0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x040006D0 RID: 1744
		[Token(Token = "0x40006D0")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x040006D1 RID: 1745
		[Token(Token = "0x40006D1")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x040006D2 RID: 1746
		[Token(Token = "0x40006D2")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_RoomName;

		// Token: 0x040006D3 RID: 1747
		[Token(Token = "0x40006D3")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_ParticipantId;

		// Token: 0x040006D4 RID: 1748
		[Token(Token = "0x40006D4")]
		[FieldOffset(Offset = "0x20")]
		private float m_Volume;
	}
}
