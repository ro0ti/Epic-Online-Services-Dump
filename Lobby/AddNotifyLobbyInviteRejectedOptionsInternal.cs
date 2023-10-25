using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Lobby
{
	// Token: 0x0200039C RID: 924
	[Token(Token = "0x200039C")]
	internal struct AddNotifyLobbyInviteRejectedOptionsInternal : ISettable<AddNotifyLobbyInviteRejectedOptions>, IDisposable
	{
		// Token: 0x06001876 RID: 6262 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001876")]
		[Address(RVA = "0x4875E0", Offset = "0x485BE0", VA = "0x1804875E0", Slot = "4")]
		public void Set(ref AddNotifyLobbyInviteRejectedOptions other)
		{
		}

		// Token: 0x06001877 RID: 6263 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001877")]
		[Address(RVA = "0x5052F0", Offset = "0x5038F0", VA = "0x1805052F0", Slot = "5")]
		public void Set(ref AddNotifyLobbyInviteRejectedOptions? other)
		{
		}

		// Token: 0x06001878 RID: 6264 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001878")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000B03 RID: 2819
		[Token(Token = "0x4000B03")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;
	}
}
