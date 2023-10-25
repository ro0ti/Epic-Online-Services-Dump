using System;


namespace Epic.OnlineServices.Lobby
{
	// Token: 0x020003AE RID: 942
	[Token(Token = "0x20003AE")]
	internal struct CopyLobbyDetailsHandleByInviteIdOptionsInternal : ISettable<CopyLobbyDetailsHandleByInviteIdOptions>, IDisposable
	{
		// Token: 0x170006D1 RID: 1745
		// (set) Token: 0x060018C6 RID: 6342 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170006D1")]
		public Utf8String InviteId
		{
			[Token(Token = "0x60018C6")]
			[Address(RVA = "0x508580", Offset = "0x506B80", VA = "0x180508580")]
			set
			{
			}
		}

		// Token: 0x060018C7 RID: 6343 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60018C7")]
		[Address(RVA = "0x508520", Offset = "0x506B20", VA = "0x180508520", Slot = "4")]
		public void Set(ref CopyLobbyDetailsHandleByInviteIdOptions other)
		{
		}

		// Token: 0x060018C8 RID: 6344 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60018C8")]
		[Address(RVA = "0x508480", Offset = "0x506A80", VA = "0x180508480", Slot = "5")]
		public void Set(ref CopyLobbyDetailsHandleByInviteIdOptions? other)
		{
		}

		// Token: 0x060018C9 RID: 6345 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60018C9")]
		[Address(RVA = "0x508430", Offset = "0x506A30", VA = "0x180508430", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000B22 RID: 2850
		[Token(Token = "0x4000B22")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000B23 RID: 2851
		[Token(Token = "0x4000B23")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_InviteId;
	}
}
