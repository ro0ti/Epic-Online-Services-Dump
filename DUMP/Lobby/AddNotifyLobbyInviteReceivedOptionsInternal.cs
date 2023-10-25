using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Lobby
{
	// Token: 0x0200039A RID: 922
	[Token(Token = "0x200039A")]
	internal struct AddNotifyLobbyInviteReceivedOptionsInternal : ISettable<AddNotifyLobbyInviteReceivedOptions>, IDisposable
	{
		// Token: 0x06001873 RID: 6259 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001873")]
		[Address(RVA = "0x4875E0", Offset = "0x485BE0", VA = "0x1804875E0", Slot = "4")]
		public void Set(ref AddNotifyLobbyInviteReceivedOptions other)
		{
		}

		// Token: 0x06001874 RID: 6260 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001874")]
		[Address(RVA = "0x5052A0", Offset = "0x5038A0", VA = "0x1805052A0", Slot = "5")]
		public void Set(ref AddNotifyLobbyInviteReceivedOptions? other)
		{
		}

		// Token: 0x06001875 RID: 6261 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001875")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000B02 RID: 2818
		[Token(Token = "0x4000B02")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;
	}
}
