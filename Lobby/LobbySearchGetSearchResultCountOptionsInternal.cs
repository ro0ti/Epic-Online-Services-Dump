using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Lobby
{
	// Token: 0x02000423 RID: 1059
	[Token(Token = "0x2000423")]
	internal struct LobbySearchGetSearchResultCountOptionsInternal : ISettable<LobbySearchGetSearchResultCountOptions>, IDisposable
	{
		// Token: 0x06001BF4 RID: 7156 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001BF4")]
		[Address(RVA = "0x4875E0", Offset = "0x485BE0", VA = "0x1804875E0", Slot = "4")]
		public void Set(ref LobbySearchGetSearchResultCountOptions other)
		{
		}

		// Token: 0x06001BF5 RID: 7157 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001BF5")]
		[Address(RVA = "0x52BB30", Offset = "0x52A130", VA = "0x18052BB30", Slot = "5")]
		public void Set(ref LobbySearchGetSearchResultCountOptions? other)
		{
		}

		// Token: 0x06001BF6 RID: 7158 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001BF6")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000CBD RID: 3261
		[Token(Token = "0x4000CBD")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;
	}
}
