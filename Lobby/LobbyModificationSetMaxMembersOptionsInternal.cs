using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Lobby
{
	// Token: 0x02000417 RID: 1047
	[Token(Token = "0x2000417")]
	internal struct LobbyModificationSetMaxMembersOptionsInternal : ISettable<LobbyModificationSetMaxMembersOptions>, IDisposable
	{
		// Token: 0x170007E7 RID: 2023
		// (set) Token: 0x06001BC3 RID: 7107 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170007E7")]
		public uint MaxMembers
		{
			[Token(Token = "0x6001BC3")]
			[Address(RVA = "0x4A4E90", Offset = "0x4A3490", VA = "0x1804A4E90")]
			set
			{
			}
		}

		// Token: 0x06001BC4 RID: 7108 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001BC4")]
		[Address(RVA = "0x4AFC00", Offset = "0x4AE200", VA = "0x1804AFC00", Slot = "4")]
		public void Set(ref LobbyModificationSetMaxMembersOptions other)
		{
		}

		// Token: 0x06001BC5 RID: 7109 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001BC5")]
		[Address(RVA = "0x52AD30", Offset = "0x529330", VA = "0x18052AD30", Slot = "5")]
		public void Set(ref LobbyModificationSetMaxMembersOptions? other)
		{
		}

		// Token: 0x06001BC6 RID: 7110 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001BC6")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000CA2 RID: 3234
		[Token(Token = "0x4000CA2")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000CA3 RID: 3235
		[Token(Token = "0x4000CA3")]
		[FieldOffset(Offset = "0x4")]
		private uint m_MaxMembers;
	}
}
