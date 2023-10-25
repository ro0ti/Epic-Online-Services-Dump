using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Lobby
{
	// Token: 0x020003F2 RID: 1010
	[Token(Token = "0x20003F2")]
	internal struct LobbyDetailsGetMemberAttributeCountOptionsInternal : ISettable<LobbyDetailsGetMemberAttributeCountOptions>, IDisposable
	{
		// Token: 0x17000782 RID: 1922
		// (set) Token: 0x06001A73 RID: 6771 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000782")]
		public ProductUserId TargetUserId
		{
			[Token(Token = "0x6001A73")]
			[Address(RVA = "0x511CB0", Offset = "0x5102B0", VA = "0x180511CB0")]
			set
			{
			}
		}

		// Token: 0x06001A74 RID: 6772 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A74")]
		[Address(RVA = "0x511BB0", Offset = "0x5101B0", VA = "0x180511BB0", Slot = "4")]
		public void Set(ref LobbyDetailsGetMemberAttributeCountOptions other)
		{
		}

		// Token: 0x06001A75 RID: 6773 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A75")]
		[Address(RVA = "0x511C10", Offset = "0x510210", VA = "0x180511C10", Slot = "5")]
		public void Set(ref LobbyDetailsGetMemberAttributeCountOptions? other)
		{
		}

		// Token: 0x06001A76 RID: 6774 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A76")]
		[Address(RVA = "0x511B60", Offset = "0x510160", VA = "0x180511B60", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000BF3 RID: 3059
		[Token(Token = "0x4000BF3")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000BF4 RID: 3060
		[Token(Token = "0x4000BF4")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_TargetUserId;
	}
}
