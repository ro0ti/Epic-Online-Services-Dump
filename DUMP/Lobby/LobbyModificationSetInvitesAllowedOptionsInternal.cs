using System;


namespace Epic.OnlineServices.Lobby
{
	// Token: 0x02000415 RID: 1045
	[Token(Token = "0x2000415")]
	internal struct LobbyModificationSetInvitesAllowedOptionsInternal : ISettable<LobbyModificationSetInvitesAllowedOptions>, IDisposable
	{
		// Token: 0x170007E5 RID: 2021
		// (set) Token: 0x06001BBD RID: 7101 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170007E5")]
		public bool InvitesAllowed
		{
			[Token(Token = "0x6001BBD")]
			[Address(RVA = "0x52ACD0", Offset = "0x5292D0", VA = "0x18052ACD0")]
			set
			{
			}
		}

		// Token: 0x06001BBE RID: 7102 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001BBE")]
		[Address(RVA = "0x52ABC0", Offset = "0x5291C0", VA = "0x18052ABC0", Slot = "4")]
		public void Set(ref LobbyModificationSetInvitesAllowedOptions other)
		{
		}

		// Token: 0x06001BBF RID: 7103 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001BBF")]
		[Address(RVA = "0x52AC30", Offset = "0x529230", VA = "0x18052AC30", Slot = "5")]
		public void Set(ref LobbyModificationSetInvitesAllowedOptions? other)
		{
		}

		// Token: 0x06001BC0 RID: 7104 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001BC0")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000C9F RID: 3231
		[Token(Token = "0x4000C9F")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000CA0 RID: 3232
		[Token(Token = "0x4000CA0")]
		[FieldOffset(Offset = "0x4")]
		private int m_InvitesAllowed;
	}
}
