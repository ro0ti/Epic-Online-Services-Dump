using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Lobby
{
	// Token: 0x0200047B RID: 1147
	[Token(Token = "0x200047B")]
	internal struct UpdateLobbyOptionsInternal : ISettable<UpdateLobbyOptions>, IDisposable
	{
		// Token: 0x17000862 RID: 2146
		// (set) Token: 0x06001DC8 RID: 7624 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000862")]
		public LobbyModification LobbyModificationHandle
		{
			[Token(Token = "0x6001DC8")]
			[Address(RVA = "0x537EA0", Offset = "0x5364A0", VA = "0x180537EA0")]
			set
			{
			}
		}

		// Token: 0x06001DC9 RID: 7625 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001DC9")]
		[Address(RVA = "0x537DA0", Offset = "0x5363A0", VA = "0x180537DA0", Slot = "4")]
		public void Set(ref UpdateLobbyOptions other)
		{
		}

		// Token: 0x06001DCA RID: 7626 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001DCA")]
		[Address(RVA = "0x537E00", Offset = "0x536400", VA = "0x180537E00", Slot = "5")]
		public void Set(ref UpdateLobbyOptions? other)
		{
		}

		// Token: 0x06001DCB RID: 7627 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001DCB")]
		[Address(RVA = "0x537D50", Offset = "0x536350", VA = "0x180537D50", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000D31 RID: 3377
		[Token(Token = "0x4000D31")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000D32 RID: 3378
		[Token(Token = "0x4000D32")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LobbyModificationHandle;
	}
}
