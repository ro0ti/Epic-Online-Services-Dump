using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.RTC
{
	// Token: 0x02000260 RID: 608
	[Token(Token = "0x2000260")]
	internal struct BlockParticipantOptionsInternal : ISettable<BlockParticipantOptions>, IDisposable
	{
		// Token: 0x17000449 RID: 1097
		// (set) Token: 0x060010CC RID: 4300 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000449")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x60010CC")]
			[Address(RVA = "0x4D86D0", Offset = "0x4D6CD0", VA = "0x1804D86D0")]
			set
			{
			}
		}

		// Token: 0x1700044A RID: 1098
		// (set) Token: 0x060010CD RID: 4301 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700044A")]
		public Utf8String RoomName
		{
			[Token(Token = "0x60010CD")]
			[Address(RVA = "0x4D8790", Offset = "0x4D6D90", VA = "0x1804D8790")]
			set
			{
			}
		}

		// Token: 0x1700044B RID: 1099
		// (set) Token: 0x060010CE RID: 4302 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700044B")]
		public ProductUserId ParticipantId
		{
			[Token(Token = "0x60010CE")]
			[Address(RVA = "0x4D8730", Offset = "0x4D6D30", VA = "0x1804D8730")]
			set
			{
			}
		}

		// Token: 0x1700044C RID: 1100
		// (set) Token: 0x060010CF RID: 4303 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700044C")]
		public bool Blocked
		{
			[Token(Token = "0x60010CF")]
			[Address(RVA = "0x4D8670", Offset = "0x4D6C70", VA = "0x1804D8670")]
			set
			{
			}
		}

		// Token: 0x060010D0 RID: 4304 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60010D0")]
		[Address(RVA = "0x4D8520", Offset = "0x4D6B20", VA = "0x1804D8520", Slot = "4")]
		public void Set(ref BlockParticipantOptions other)
		{
		}

		// Token: 0x060010D1 RID: 4305 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60010D1")]
		[Address(RVA = "0x4D8360", Offset = "0x4D6960", VA = "0x1804D8360", Slot = "5")]
		public void Set(ref BlockParticipantOptions? other)
		{
		}

		// Token: 0x060010D2 RID: 4306 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60010D2")]
		[Address(RVA = "0x4D82F0", Offset = "0x4D68F0", VA = "0x1804D82F0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x0400077B RID: 1915
		[Token(Token = "0x400077B")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x0400077C RID: 1916
		[Token(Token = "0x400077C")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x0400077D RID: 1917
		[Token(Token = "0x400077D")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_RoomName;

		// Token: 0x0400077E RID: 1918
		[Token(Token = "0x400077E")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_ParticipantId;

		// Token: 0x0400077F RID: 1919
		[Token(Token = "0x400077F")]
		[FieldOffset(Offset = "0x20")]
		private int m_Blocked;
	}
}
