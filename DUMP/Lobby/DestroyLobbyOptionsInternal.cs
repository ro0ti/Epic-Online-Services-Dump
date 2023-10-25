using System;


namespace Epic.OnlineServices.Lobby
{
	// Token: 0x020003BC RID: 956
	[Token(Token = "0x20003BC")]
	internal struct DestroyLobbyOptionsInternal : ISettable<DestroyLobbyOptions>, IDisposable
	{
		// Token: 0x17000706 RID: 1798
		// (set) Token: 0x06001936 RID: 6454 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000706")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6001936")]
			[Address(RVA = "0x50A6B0", Offset = "0x508CB0", VA = "0x18050A6B0")]
			set
			{
			}
		}

		// Token: 0x17000707 RID: 1799
		// (set) Token: 0x06001937 RID: 6455 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000707")]
		public Utf8String LobbyId
		{
			[Token(Token = "0x6001937")]
			[Address(RVA = "0x50A650", Offset = "0x508C50", VA = "0x18050A650")]
			set
			{
			}
		}

		// Token: 0x06001938 RID: 6456 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001938")]
		[Address(RVA = "0x50A480", Offset = "0x508A80", VA = "0x18050A480", Slot = "4")]
		public void Set(ref DestroyLobbyOptions other)
		{
		}

		// Token: 0x06001939 RID: 6457 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001939")]
		[Address(RVA = "0x50A540", Offset = "0x508B40", VA = "0x18050A540", Slot = "5")]
		public void Set(ref DestroyLobbyOptions? other)
		{
		}

		// Token: 0x0600193A RID: 6458 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600193A")]
		[Address(RVA = "0x50A420", Offset = "0x508A20", VA = "0x18050A420", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000B5B RID: 2907
		[Token(Token = "0x4000B5B")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000B5C RID: 2908
		[Token(Token = "0x4000B5C")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x04000B5D RID: 2909
		[Token(Token = "0x4000B5D")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LobbyId;
	}
}
