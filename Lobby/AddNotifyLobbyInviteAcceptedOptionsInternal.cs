using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Lobby
{
	// Token: 0x02000398 RID: 920
	[Token(Token = "0x2000398")]
	internal struct AddNotifyLobbyInviteAcceptedOptionsInternal : ISettable<AddNotifyLobbyInviteAcceptedOptions>, IDisposable
	{
		// Token: 0x06001870 RID: 6256 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001870")]
		[Address(RVA = "0x4875E0", Offset = "0x485BE0", VA = "0x1804875E0", Slot = "4")]
		public void Set(ref AddNotifyLobbyInviteAcceptedOptions other)
		{
		}

		// Token: 0x06001871 RID: 6257 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001871")]
		[Address(RVA = "0x505250", Offset = "0x503850", VA = "0x180505250", Slot = "5")]
		public void Set(ref AddNotifyLobbyInviteAcceptedOptions? other)
		{
		}

		// Token: 0x06001872 RID: 6258 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001872")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000B01 RID: 2817
		[Token(Token = "0x4000B01")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;
	}
}
