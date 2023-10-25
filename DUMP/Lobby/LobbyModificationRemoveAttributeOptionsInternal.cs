using System;


namespace Epic.OnlineServices.Lobby
{
	// Token: 0x0200040D RID: 1037
	[Token(Token = "0x200040D")]
	internal struct LobbyModificationRemoveAttributeOptionsInternal : ISettable<LobbyModificationRemoveAttributeOptions>, IDisposable
	{
		// Token: 0x170007DD RID: 2013
		// (set) Token: 0x06001BA5 RID: 7077 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170007DD")]
		public Utf8String Key
		{
			[Token(Token = "0x6001BA5")]
			[Address(RVA = "0x52A6A0", Offset = "0x528CA0", VA = "0x18052A6A0")]
			set
			{
			}
		}

		// Token: 0x06001BA6 RID: 7078 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001BA6")]
		[Address(RVA = "0x52A5A0", Offset = "0x528BA0", VA = "0x18052A5A0", Slot = "4")]
		public void Set(ref LobbyModificationRemoveAttributeOptions other)
		{
		}

		// Token: 0x06001BA7 RID: 7079 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001BA7")]
		[Address(RVA = "0x52A600", Offset = "0x528C00", VA = "0x18052A600", Slot = "5")]
		public void Set(ref LobbyModificationRemoveAttributeOptions? other)
		{
		}

		// Token: 0x06001BA8 RID: 7080 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001BA8")]
		[Address(RVA = "0x52A550", Offset = "0x528B50", VA = "0x18052A550", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000C92 RID: 3218
		[Token(Token = "0x4000C92")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000C93 RID: 3219
		[Token(Token = "0x4000C93")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_Key;
	}
}
