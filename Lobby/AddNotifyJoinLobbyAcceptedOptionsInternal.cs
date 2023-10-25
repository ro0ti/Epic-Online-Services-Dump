using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Lobby
{
	// Token: 0x02000394 RID: 916
	[Token(Token = "0x2000394")]
	internal struct AddNotifyJoinLobbyAcceptedOptionsInternal : ISettable<AddNotifyJoinLobbyAcceptedOptions>, IDisposable
	{
		// Token: 0x0600186A RID: 6250 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600186A")]
		[Address(RVA = "0x4875E0", Offset = "0x485BE0", VA = "0x1804875E0", Slot = "4")]
		public void Set(ref AddNotifyJoinLobbyAcceptedOptions other)
		{
		}

		// Token: 0x0600186B RID: 6251 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600186B")]
		[Address(RVA = "0x5051B0", Offset = "0x5037B0", VA = "0x1805051B0", Slot = "5")]
		public void Set(ref AddNotifyJoinLobbyAcceptedOptions? other)
		{
		}

		// Token: 0x0600186C RID: 6252 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600186C")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000AFF RID: 2815
		[Token(Token = "0x4000AFF")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;
	}
}
