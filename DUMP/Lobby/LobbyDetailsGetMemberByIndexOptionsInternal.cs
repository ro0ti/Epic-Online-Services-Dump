using System;


namespace Epic.OnlineServices.Lobby
{
	// Token: 0x020003F4 RID: 1012
	[Token(Token = "0x20003F4")]
	internal struct LobbyDetailsGetMemberByIndexOptionsInternal : ISettable<LobbyDetailsGetMemberByIndexOptions>, IDisposable
	{
		// Token: 0x17000784 RID: 1924
		// (set) Token: 0x06001A79 RID: 6777 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000784")]
		public uint MemberIndex
		{
			[Token(Token = "0x6001A79")]
			[Address(RVA = "0x4A4E90", Offset = "0x4A3490", VA = "0x1804A4E90")]
			set
			{
			}
		}

		// Token: 0x06001A7A RID: 6778 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A7A")]
		[Address(RVA = "0x4AFC00", Offset = "0x4AE200", VA = "0x1804AFC00", Slot = "4")]
		public void Set(ref LobbyDetailsGetMemberByIndexOptions other)
		{
		}

		// Token: 0x06001A7B RID: 6779 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A7B")]
		[Address(RVA = "0x511D10", Offset = "0x510310", VA = "0x180511D10", Slot = "5")]
		public void Set(ref LobbyDetailsGetMemberByIndexOptions? other)
		{
		}

		// Token: 0x06001A7C RID: 6780 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A7C")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000BF6 RID: 3062
		[Token(Token = "0x4000BF6")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000BF7 RID: 3063
		[Token(Token = "0x4000BF7")]
		[FieldOffset(Offset = "0x4")]
		private uint m_MemberIndex;
	}
}
