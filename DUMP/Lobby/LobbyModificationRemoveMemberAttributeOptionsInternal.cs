using System;


namespace Epic.OnlineServices.Lobby
{
	// Token: 0x0200040F RID: 1039
	[Token(Token = "0x200040F")]
	internal struct LobbyModificationRemoveMemberAttributeOptionsInternal : ISettable<LobbyModificationRemoveMemberAttributeOptions>, IDisposable
	{
		// Token: 0x170007DF RID: 2015
		// (set) Token: 0x06001BAB RID: 7083 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170007DF")]
		public Utf8String Key
		{
			[Token(Token = "0x6001BAB")]
			[Address(RVA = "0x52A850", Offset = "0x528E50", VA = "0x18052A850")]
			set
			{
			}
		}

		// Token: 0x06001BAC RID: 7084 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001BAC")]
		[Address(RVA = "0x52A7F0", Offset = "0x528DF0", VA = "0x18052A7F0", Slot = "4")]
		public void Set(ref LobbyModificationRemoveMemberAttributeOptions other)
		{
		}

		// Token: 0x06001BAD RID: 7085 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001BAD")]
		[Address(RVA = "0x52A750", Offset = "0x528D50", VA = "0x18052A750", Slot = "5")]
		public void Set(ref LobbyModificationRemoveMemberAttributeOptions? other)
		{
		}

		// Token: 0x06001BAE RID: 7086 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001BAE")]
		[Address(RVA = "0x52A700", Offset = "0x528D00", VA = "0x18052A700", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000C95 RID: 3221
		[Token(Token = "0x4000C95")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000C96 RID: 3222
		[Token(Token = "0x4000C96")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_Key;
	}
}
