using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Lobby
{
	// Token: 0x020003CA RID: 970
	[Token(Token = "0x20003CA")]
	internal struct IsRTCRoomConnectedOptionsInternal : ISettable<IsRTCRoomConnectedOptions>, IDisposable
	{
		// Token: 0x17000729 RID: 1833
		// (set) Token: 0x06001986 RID: 6534 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000729")]
		public Utf8String LobbyId
		{
			[Token(Token = "0x6001986")]
			[Address(RVA = "0x50DD50", Offset = "0x50C350", VA = "0x18050DD50")]
			set
			{
			}
		}

		// Token: 0x1700072A RID: 1834
		// (set) Token: 0x06001987 RID: 6535 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700072A")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6001987")]
			[Address(RVA = "0x50DDB0", Offset = "0x50C3B0", VA = "0x18050DDB0")]
			set
			{
			}
		}

		// Token: 0x06001988 RID: 6536 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001988")]
		[Address(RVA = "0x50DB80", Offset = "0x50C180", VA = "0x18050DB80", Slot = "4")]
		public void Set(ref IsRTCRoomConnectedOptions other)
		{
		}

		// Token: 0x06001989 RID: 6537 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001989")]
		[Address(RVA = "0x50DC40", Offset = "0x50C240", VA = "0x18050DC40", Slot = "5")]
		public void Set(ref IsRTCRoomConnectedOptions? other)
		{
		}

		// Token: 0x0600198A RID: 6538 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600198A")]
		[Address(RVA = "0x50DB20", Offset = "0x50C120", VA = "0x18050DB20", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000B83 RID: 2947
		[Token(Token = "0x4000B83")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000B84 RID: 2948
		[Token(Token = "0x4000B84")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LobbyId;

		// Token: 0x04000B85 RID: 2949
		[Token(Token = "0x4000B85")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LocalUserId;
	}
}
