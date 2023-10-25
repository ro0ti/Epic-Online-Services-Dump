using System;


namespace Epic.OnlineServices.Lobby
{
	// Token: 0x0200042F RID: 1071
	[Token(Token = "0x200042F")]
	internal struct LobbySearchSetTargetUserIdOptionsInternal : ISettable<LobbySearchSetTargetUserIdOptions>, IDisposable
	{
		// Token: 0x17000800 RID: 2048
		// (set) Token: 0x06001C1F RID: 7199 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000800")]
		public ProductUserId TargetUserId
		{
			[Token(Token = "0x6001C1F")]
			[Address(RVA = "0x52C4A0", Offset = "0x52AAA0", VA = "0x18052C4A0")]
			set
			{
			}
		}

		// Token: 0x06001C20 RID: 7200 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001C20")]
		[Address(RVA = "0x52C440", Offset = "0x52AA40", VA = "0x18052C440", Slot = "4")]
		public void Set(ref LobbySearchSetTargetUserIdOptions other)
		{
		}

		// Token: 0x06001C21 RID: 7201 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001C21")]
		[Address(RVA = "0x52C3A0", Offset = "0x52A9A0", VA = "0x18052C3A0", Slot = "5")]
		public void Set(ref LobbySearchSetTargetUserIdOptions? other)
		{
		}

		// Token: 0x06001C22 RID: 7202 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001C22")]
		[Address(RVA = "0x52C350", Offset = "0x52A950", VA = "0x18052C350", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000CCF RID: 3279
		[Token(Token = "0x4000CCF")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000CD0 RID: 3280
		[Token(Token = "0x4000CD0")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_TargetUserId;
	}
}
