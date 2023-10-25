using System;


namespace Epic.OnlineServices.Lobby
{
	// Token: 0x020003BE RID: 958
	[Token(Token = "0x20003BE")]
	internal struct GetConnectStringOptionsInternal : ISettable<GetConnectStringOptions>, IDisposable
	{
		// Token: 0x1700070A RID: 1802
		// (set) Token: 0x0600193F RID: 6463 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700070A")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x600193F")]
			[Address(RVA = "0x50BB80", Offset = "0x50A180", VA = "0x18050BB80")]
			set
			{
			}
		}

		// Token: 0x1700070B RID: 1803
		// (set) Token: 0x06001940 RID: 6464 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700070B")]
		public Utf8String LobbyId
		{
			[Token(Token = "0x6001940")]
			[Address(RVA = "0x50BB20", Offset = "0x50A120", VA = "0x18050BB20")]
			set
			{
			}
		}

		// Token: 0x06001941 RID: 6465 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001941")]
		[Address(RVA = "0x50B950", Offset = "0x509F50", VA = "0x18050B950", Slot = "4")]
		public void Set(ref GetConnectStringOptions other)
		{
		}

		// Token: 0x06001942 RID: 6466 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001942")]
		[Address(RVA = "0x50BA10", Offset = "0x50A010", VA = "0x18050BA10", Slot = "5")]
		public void Set(ref GetConnectStringOptions? other)
		{
		}

		// Token: 0x06001943 RID: 6467 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001943")]
		[Address(RVA = "0x50B8F0", Offset = "0x509EF0", VA = "0x18050B8F0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000B60 RID: 2912
		[Token(Token = "0x4000B60")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000B61 RID: 2913
		[Token(Token = "0x4000B61")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x04000B62 RID: 2914
		[Token(Token = "0x4000B62")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LobbyId;
	}
}
