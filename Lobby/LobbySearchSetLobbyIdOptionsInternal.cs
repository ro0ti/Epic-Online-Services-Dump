using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Lobby
{
	// Token: 0x02000429 RID: 1065
	[Token(Token = "0x2000429")]
	internal struct LobbySearchSetLobbyIdOptionsInternal : ISettable<LobbySearchSetLobbyIdOptions>, IDisposable
	{
		// Token: 0x170007F8 RID: 2040
		// (set) Token: 0x06001C0A RID: 7178 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170007F8")]
		public Utf8String LobbyId
		{
			[Token(Token = "0x6001C0A")]
			[Address(RVA = "0x52BFF0", Offset = "0x52A5F0", VA = "0x18052BFF0")]
			set
			{
			}
		}

		// Token: 0x06001C0B RID: 7179 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001C0B")]
		[Address(RVA = "0x52BF90", Offset = "0x52A590", VA = "0x18052BF90", Slot = "4")]
		public void Set(ref LobbySearchSetLobbyIdOptions other)
		{
		}

		// Token: 0x06001C0C RID: 7180 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001C0C")]
		[Address(RVA = "0x52BEF0", Offset = "0x52A4F0", VA = "0x18052BEF0", Slot = "5")]
		public void Set(ref LobbySearchSetLobbyIdOptions? other)
		{
		}

		// Token: 0x06001C0D RID: 7181 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001C0D")]
		[Address(RVA = "0x52BEA0", Offset = "0x52A4A0", VA = "0x18052BEA0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000CC4 RID: 3268
		[Token(Token = "0x4000CC4")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000CC5 RID: 3269
		[Token(Token = "0x4000CC5")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LobbyId;
	}
}
