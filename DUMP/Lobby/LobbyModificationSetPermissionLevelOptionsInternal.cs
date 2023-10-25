using System;


namespace Epic.OnlineServices.Lobby
{
	// Token: 0x02000419 RID: 1049
	[Token(Token = "0x2000419")]
	internal struct LobbyModificationSetPermissionLevelOptionsInternal : ISettable<LobbyModificationSetPermissionLevelOptions>, IDisposable
	{
		// Token: 0x170007E9 RID: 2025
		// (set) Token: 0x06001BC9 RID: 7113 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170007E9")]
		public LobbyPermissionLevel PermissionLevel
		{
			[Token(Token = "0x6001BC9")]
			[Address(RVA = "0x4A4E90", Offset = "0x4A3490", VA = "0x1804A4E90")]
			set
			{
			}
		}

		// Token: 0x06001BCA RID: 7114 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001BCA")]
		[Address(RVA = "0x4AFC00", Offset = "0x4AE200", VA = "0x1804AFC00", Slot = "4")]
		public void Set(ref LobbyModificationSetPermissionLevelOptions other)
		{
		}

		// Token: 0x06001BCB RID: 7115 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001BCB")]
		[Address(RVA = "0x52AD90", Offset = "0x529390", VA = "0x18052AD90", Slot = "5")]
		public void Set(ref LobbyModificationSetPermissionLevelOptions? other)
		{
		}

		// Token: 0x06001BCC RID: 7116 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001BCC")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000CA5 RID: 3237
		[Token(Token = "0x4000CA5")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000CA6 RID: 3238
		[Token(Token = "0x4000CA6")]
		[FieldOffset(Offset = "0x4")]
		private LobbyPermissionLevel m_PermissionLevel;
	}
}
