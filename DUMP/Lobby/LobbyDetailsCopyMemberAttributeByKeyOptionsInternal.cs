using System;


namespace Epic.OnlineServices.Lobby
{
	// Token: 0x020003EA RID: 1002
	[Token(Token = "0x20003EA")]
	internal struct LobbyDetailsCopyMemberAttributeByKeyOptionsInternal : ISettable<LobbyDetailsCopyMemberAttributeByKeyOptions>, IDisposable
	{
		// Token: 0x1700077D RID: 1917
		// (set) Token: 0x06001A60 RID: 6752 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700077D")]
		public ProductUserId TargetUserId
		{
			[Token(Token = "0x6001A60")]
			[Address(RVA = "0x5118B0", Offset = "0x50FEB0", VA = "0x1805118B0")]
			set
			{
			}
		}

		// Token: 0x1700077E RID: 1918
		// (set) Token: 0x06001A61 RID: 6753 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700077E")]
		public Utf8String AttrKey
		{
			[Token(Token = "0x6001A61")]
			[Address(RVA = "0x511850", Offset = "0x50FE50", VA = "0x180511850")]
			set
			{
			}
		}

		// Token: 0x06001A62 RID: 6754 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A62")]
		[Address(RVA = "0x511680", Offset = "0x50FC80", VA = "0x180511680", Slot = "4")]
		public void Set(ref LobbyDetailsCopyMemberAttributeByKeyOptions other)
		{
		}

		// Token: 0x06001A63 RID: 6755 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A63")]
		[Address(RVA = "0x511740", Offset = "0x50FD40", VA = "0x180511740", Slot = "5")]
		public void Set(ref LobbyDetailsCopyMemberAttributeByKeyOptions? other)
		{
		}

		// Token: 0x06001A64 RID: 6756 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A64")]
		[Address(RVA = "0x511620", Offset = "0x50FC20", VA = "0x180511620", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000BEA RID: 3050
		[Token(Token = "0x4000BEA")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000BEB RID: 3051
		[Token(Token = "0x4000BEB")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_TargetUserId;

		// Token: 0x04000BEC RID: 3052
		[Token(Token = "0x4000BEC")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_AttrKey;
	}
}
