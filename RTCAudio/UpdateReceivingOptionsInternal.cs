using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.RTCAudio
{
	// Token: 0x02000231 RID: 561
	[Token(Token = "0x2000231")]
	internal struct UpdateReceivingOptionsInternal : ISettable<UpdateReceivingOptions>, IDisposable
	{
		// Token: 0x170003C0 RID: 960
		// (set) Token: 0x06000F6C RID: 3948 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170003C0")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6000F6C")]
			[Address(RVA = "0x4E9020", Offset = "0x4E7620", VA = "0x1804E9020")]
			set
			{
			}
		}

		// Token: 0x170003C1 RID: 961
		// (set) Token: 0x06000F6D RID: 3949 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170003C1")]
		public Utf8String RoomName
		{
			[Token(Token = "0x6000F6D")]
			[Address(RVA = "0x4E90E0", Offset = "0x4E76E0", VA = "0x1804E90E0")]
			set
			{
			}
		}

		// Token: 0x170003C2 RID: 962
		// (set) Token: 0x06000F6E RID: 3950 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170003C2")]
		public ProductUserId ParticipantId
		{
			[Token(Token = "0x6000F6E")]
			[Address(RVA = "0x4E9080", Offset = "0x4E7680", VA = "0x1804E9080")]
			set
			{
			}
		}

		// Token: 0x170003C3 RID: 963
		// (set) Token: 0x06000F6F RID: 3951 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170003C3")]
		public bool AudioEnabled
		{
			[Token(Token = "0x6000F6F")]
			[Address(RVA = "0x4E8FC0", Offset = "0x4E75C0", VA = "0x1804E8FC0")]
			set
			{
			}
		}

		// Token: 0x06000F70 RID: 3952 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F70")]
		[Address(RVA = "0x4E8CB0", Offset = "0x4E72B0", VA = "0x1804E8CB0", Slot = "4")]
		public void Set(ref UpdateReceivingOptions other)
		{
		}

		// Token: 0x06000F71 RID: 3953 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F71")]
		[Address(RVA = "0x4E8E00", Offset = "0x4E7400", VA = "0x1804E8E00", Slot = "5")]
		public void Set(ref UpdateReceivingOptions? other)
		{
		}

		// Token: 0x06000F72 RID: 3954 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F72")]
		[Address(RVA = "0x4E8C40", Offset = "0x4E7240", VA = "0x1804E8C40", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x040006E5 RID: 1765
		[Token(Token = "0x40006E5")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x040006E6 RID: 1766
		[Token(Token = "0x40006E6")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x040006E7 RID: 1767
		[Token(Token = "0x40006E7")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_RoomName;

		// Token: 0x040006E8 RID: 1768
		[Token(Token = "0x40006E8")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_ParticipantId;

		// Token: 0x040006E9 RID: 1769
		[Token(Token = "0x40006E9")]
		[FieldOffset(Offset = "0x20")]
		private int m_AudioEnabled;
	}
}
