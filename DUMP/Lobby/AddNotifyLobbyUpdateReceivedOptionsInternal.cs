using System;


namespace Epic.OnlineServices.Lobby
{
	// Token: 0x020003A2 RID: 930
	[Token(Token = "0x20003A2")]
	internal struct AddNotifyLobbyUpdateReceivedOptionsInternal : ISettable<AddNotifyLobbyUpdateReceivedOptions>, IDisposable
	{
		// Token: 0x0600187F RID: 6271 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600187F")]
		[Address(RVA = "0x4875E0", Offset = "0x485BE0", VA = "0x1804875E0", Slot = "4")]
		public void Set(ref AddNotifyLobbyUpdateReceivedOptions other)
		{
		}

		// Token: 0x06001880 RID: 6272 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001880")]
		[Address(RVA = "0x5053E0", Offset = "0x5039E0", VA = "0x1805053E0", Slot = "5")]
		public void Set(ref AddNotifyLobbyUpdateReceivedOptions? other)
		{
		}

		// Token: 0x06001881 RID: 6273 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001881")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000B06 RID: 2822
		[Token(Token = "0x4000B06")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;
	}
}
