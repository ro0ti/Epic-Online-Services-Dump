using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Lobby
{
	// Token: 0x020003E2 RID: 994
	[Token(Token = "0x20003E2")]
	internal struct LobbyDetailsCopyAttributeByIndexOptionsInternal : ISettable<LobbyDetailsCopyAttributeByIndexOptions>, IDisposable
	{
		// Token: 0x17000774 RID: 1908
		// (set) Token: 0x06001A46 RID: 6726 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000774")]
		public uint AttrIndex
		{
			[Token(Token = "0x6001A46")]
			[Address(RVA = "0x4A4E90", Offset = "0x4A3490", VA = "0x1804A4E90")]
			set
			{
			}
		}

		// Token: 0x06001A47 RID: 6727 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A47")]
		[Address(RVA = "0x4AFC00", Offset = "0x4AE200", VA = "0x1804AFC00", Slot = "4")]
		public void Set(ref LobbyDetailsCopyAttributeByIndexOptions other)
		{
		}

		// Token: 0x06001A48 RID: 6728 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A48")]
		[Address(RVA = "0x5111C0", Offset = "0x50F7C0", VA = "0x1805111C0", Slot = "5")]
		public void Set(ref LobbyDetailsCopyAttributeByIndexOptions? other)
		{
		}

		// Token: 0x06001A49 RID: 6729 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A49")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000BDD RID: 3037
		[Token(Token = "0x4000BDD")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000BDE RID: 3038
		[Token(Token = "0x4000BDE")]
		[FieldOffset(Offset = "0x4")]
		private uint m_AttrIndex;
	}
}
