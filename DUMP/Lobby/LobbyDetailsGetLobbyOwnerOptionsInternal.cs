using System;


namespace Epic.OnlineServices.Lobby
{
	// Token: 0x020003F0 RID: 1008
	[Token(Token = "0x20003F0")]
	internal struct LobbyDetailsGetLobbyOwnerOptionsInternal : ISettable<LobbyDetailsGetLobbyOwnerOptions>, IDisposable
	{
		// Token: 0x06001A6E RID: 6766 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A6E")]
		[Address(RVA = "0x4875E0", Offset = "0x485BE0", VA = "0x1804875E0", Slot = "4")]
		public void Set(ref LobbyDetailsGetLobbyOwnerOptions other)
		{
		}

		// Token: 0x06001A6F RID: 6767 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A6F")]
		[Address(RVA = "0x511B10", Offset = "0x510110", VA = "0x180511B10", Slot = "5")]
		public void Set(ref LobbyDetailsGetLobbyOwnerOptions? other)
		{
		}

		// Token: 0x06001A70 RID: 6768 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A70")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000BF1 RID: 3057
		[Token(Token = "0x4000BF1")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;
	}
}
