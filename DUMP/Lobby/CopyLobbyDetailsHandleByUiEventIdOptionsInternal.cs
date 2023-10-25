using System;


namespace Epic.OnlineServices.Lobby
{
	// Token: 0x020003B0 RID: 944
	[Token(Token = "0x20003B0")]
	internal struct CopyLobbyDetailsHandleByUiEventIdOptionsInternal : ISettable<CopyLobbyDetailsHandleByUiEventIdOptions>, IDisposable
	{
		// Token: 0x170006D3 RID: 1747
		// (set) Token: 0x060018CC RID: 6348 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170006D3")]
		public ulong UiEventId
		{
			[Token(Token = "0x60018CC")]
			[Address(RVA = "0x487590", Offset = "0x485B90", VA = "0x180487590")]
			set
			{
			}
		}

		// Token: 0x060018CD RID: 6349 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60018CD")]
		[Address(RVA = "0x4ACEA0", Offset = "0x4AB4A0", VA = "0x1804ACEA0", Slot = "4")]
		public void Set(ref CopyLobbyDetailsHandleByUiEventIdOptions other)
		{
		}

		// Token: 0x060018CE RID: 6350 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60018CE")]
		[Address(RVA = "0x5085E0", Offset = "0x506BE0", VA = "0x1805085E0", Slot = "5")]
		public void Set(ref CopyLobbyDetailsHandleByUiEventIdOptions? other)
		{
		}

		// Token: 0x060018CF RID: 6351 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60018CF")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000B25 RID: 2853
		[Token(Token = "0x4000B25")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000B26 RID: 2854
		[Token(Token = "0x4000B26")]
		[FieldOffset(Offset = "0x8")]
		private ulong m_UiEventId;
	}
}
