using System;


namespace Epic.OnlineServices.Lobby
{
	// Token: 0x02000409 RID: 1033
	[Token(Token = "0x2000409")]
	internal struct LobbyModificationAddAttributeOptionsInternal : ISettable<LobbyModificationAddAttributeOptions>, IDisposable
	{
		// Token: 0x170007D6 RID: 2006
		// (set) Token: 0x06001B95 RID: 7061 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170007D6")]
		public AttributeData? Attribute
		{
			[Token(Token = "0x6001B95")]
			[Address(RVA = "0x52A240", Offset = "0x528840", VA = "0x18052A240")]
			set
			{
			}
		}

		// Token: 0x170007D7 RID: 2007
		// (set) Token: 0x06001B96 RID: 7062 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170007D7")]
		public LobbyAttributeVisibility Visibility
		{
			[Token(Token = "0x6001B96")]
			[Address(RVA = "0x457A40", Offset = "0x456040", VA = "0x180457A40")]
			set
			{
			}
		}

		// Token: 0x06001B97 RID: 7063 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001B97")]
		[Address(RVA = "0x52A190", Offset = "0x528790", VA = "0x18052A190", Slot = "4")]
		public void Set(ref LobbyModificationAddAttributeOptions other)
		{
		}

		// Token: 0x06001B98 RID: 7064 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001B98")]
		[Address(RVA = "0x52A060", Offset = "0x528660", VA = "0x18052A060", Slot = "5")]
		public void Set(ref LobbyModificationAddAttributeOptions? other)
		{
		}

		// Token: 0x06001B99 RID: 7065 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001B99")]
		[Address(RVA = "0x52A010", Offset = "0x528610", VA = "0x18052A010", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000C89 RID: 3209
		[Token(Token = "0x4000C89")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000C8A RID: 3210
		[Token(Token = "0x4000C8A")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_Attribute;

		// Token: 0x04000C8B RID: 3211
		[Token(Token = "0x4000C8B")]
		[FieldOffset(Offset = "0x10")]
		private LobbyAttributeVisibility m_Visibility;
	}
}
