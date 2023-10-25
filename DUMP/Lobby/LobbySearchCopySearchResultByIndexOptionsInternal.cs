using System;


namespace Epic.OnlineServices.Lobby
{
	// Token: 0x0200041D RID: 1053
	[Token(Token = "0x200041D")]
	internal struct LobbySearchCopySearchResultByIndexOptionsInternal : ISettable<LobbySearchCopySearchResultByIndexOptions>, IDisposable
	{
		// Token: 0x170007EB RID: 2027
		// (set) Token: 0x06001BDB RID: 7131 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170007EB")]
		public uint LobbyIndex
		{
			[Token(Token = "0x6001BDB")]
			[Address(RVA = "0x4A4E90", Offset = "0x4A3490", VA = "0x1804A4E90")]
			set
			{
			}
		}

		// Token: 0x06001BDC RID: 7132 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001BDC")]
		[Address(RVA = "0x4AFC00", Offset = "0x4AE200", VA = "0x1804AFC00", Slot = "4")]
		public void Set(ref LobbySearchCopySearchResultByIndexOptions other)
		{
		}

		// Token: 0x06001BDD RID: 7133 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001BDD")]
		[Address(RVA = "0x52B5F0", Offset = "0x529BF0", VA = "0x18052B5F0", Slot = "5")]
		public void Set(ref LobbySearchCopySearchResultByIndexOptions? other)
		{
		}

		// Token: 0x06001BDE RID: 7134 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001BDE")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000CB4 RID: 3252
		[Token(Token = "0x4000CB4")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000CB5 RID: 3253
		[Token(Token = "0x4000CB5")]
		[FieldOffset(Offset = "0x4")]
		private uint m_LobbyIndex;
	}
}
