using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Lobby
{
	// Token: 0x020003E8 RID: 1000
	[Token(Token = "0x20003E8")]
	internal struct LobbyDetailsCopyMemberAttributeByIndexOptionsInternal : ISettable<LobbyDetailsCopyMemberAttributeByIndexOptions>, IDisposable
	{
		// Token: 0x17000779 RID: 1913
		// (set) Token: 0x06001A57 RID: 6743 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000779")]
		public ProductUserId TargetUserId
		{
			[Token(Token = "0x6001A57")]
			[Address(RVA = "0x5115C0", Offset = "0x50FBC0", VA = "0x1805115C0")]
			set
			{
			}
		}

		// Token: 0x1700077A RID: 1914
		// (set) Token: 0x06001A58 RID: 6744 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700077A")]
		public uint AttrIndex
		{
			[Token(Token = "0x6001A58")]
			[Address(RVA = "0x457A40", Offset = "0x456040", VA = "0x180457A40")]
			set
			{
			}
		}

		// Token: 0x06001A59 RID: 6745 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A59")]
		[Address(RVA = "0x511540", Offset = "0x50FB40", VA = "0x180511540", Slot = "4")]
		public void Set(ref LobbyDetailsCopyMemberAttributeByIndexOptions other)
		{
		}

		// Token: 0x06001A5A RID: 6746 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A5A")]
		[Address(RVA = "0x511470", Offset = "0x50FA70", VA = "0x180511470", Slot = "5")]
		public void Set(ref LobbyDetailsCopyMemberAttributeByIndexOptions? other)
		{
		}

		// Token: 0x06001A5B RID: 6747 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A5B")]
		[Address(RVA = "0x511420", Offset = "0x50FA20", VA = "0x180511420", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000BE5 RID: 3045
		[Token(Token = "0x4000BE5")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000BE6 RID: 3046
		[Token(Token = "0x4000BE6")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_TargetUserId;

		// Token: 0x04000BE7 RID: 3047
		[Token(Token = "0x4000BE7")]
		[FieldOffset(Offset = "0x10")]
		private uint m_AttrIndex;
	}
}
