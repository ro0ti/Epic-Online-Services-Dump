using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Lobby
{
	// Token: 0x0200039E RID: 926
	[Token(Token = "0x200039E")]
	internal struct AddNotifyLobbyMemberStatusReceivedOptionsInternal : ISettable<AddNotifyLobbyMemberStatusReceivedOptions>, IDisposable
	{
		// Token: 0x06001879 RID: 6265 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001879")]
		[Address(RVA = "0x4875E0", Offset = "0x485BE0", VA = "0x1804875E0", Slot = "4")]
		public void Set(ref AddNotifyLobbyMemberStatusReceivedOptions other)
		{
		}

		// Token: 0x0600187A RID: 6266 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600187A")]
		[Address(RVA = "0x505340", Offset = "0x503940", VA = "0x180505340", Slot = "5")]
		public void Set(ref AddNotifyLobbyMemberStatusReceivedOptions? other)
		{
		}

		// Token: 0x0600187B RID: 6267 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600187B")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000B04 RID: 2820
		[Token(Token = "0x4000B04")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;
	}
}
