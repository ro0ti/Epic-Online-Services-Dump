using System;


namespace Epic.OnlineServices.RTCAudio
{
	// Token: 0x020001B9 RID: 441
	[Token(Token = "0x20001B9")]
	internal struct AddNotifyAudioOutputStateOptionsInternal : ISettable<AddNotifyAudioOutputStateOptions>, IDisposable
	{
		// Token: 0x170002EC RID: 748
		// (set) Token: 0x06000C83 RID: 3203 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170002EC")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6000C83")]
			[Address(RVA = "0x4D38E0", Offset = "0x4D1EE0", VA = "0x1804D38E0")]
			set
			{
			}
		}

		// Token: 0x170002ED RID: 749
		// (set) Token: 0x06000C84 RID: 3204 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170002ED")]
		public Utf8String RoomName
		{
			[Token(Token = "0x6000C84")]
			[Address(RVA = "0x4D3940", Offset = "0x4D1F40", VA = "0x1804D3940")]
			set
			{
			}
		}

		// Token: 0x06000C85 RID: 3205 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C85")]
		[Address(RVA = "0x4D3820", Offset = "0x4D1E20", VA = "0x1804D3820", Slot = "4")]
		public void Set(ref AddNotifyAudioOutputStateOptions other)
		{
		}

		// Token: 0x06000C86 RID: 3206 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C86")]
		[Address(RVA = "0x4D3710", Offset = "0x4D1D10", VA = "0x1804D3710", Slot = "5")]
		public void Set(ref AddNotifyAudioOutputStateOptions? other)
		{
		}

		// Token: 0x06000C87 RID: 3207 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C87")]
		[Address(RVA = "0x4D36B0", Offset = "0x4D1CB0", VA = "0x1804D36B0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x040005D0 RID: 1488
		[Token(Token = "0x40005D0")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x040005D1 RID: 1489
		[Token(Token = "0x40005D1")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x040005D2 RID: 1490
		[Token(Token = "0x40005D2")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_RoomName;
	}
}
