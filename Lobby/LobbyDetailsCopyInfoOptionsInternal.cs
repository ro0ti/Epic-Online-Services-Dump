using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Lobby
{
	// Token: 0x020003E6 RID: 998
	[Token(Token = "0x20003E6")]
	internal struct LobbyDetailsCopyInfoOptionsInternal : ISettable<LobbyDetailsCopyInfoOptions>, IDisposable
	{
		// Token: 0x06001A50 RID: 6736 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A50")]
		[Address(RVA = "0x4875E0", Offset = "0x485BE0", VA = "0x1804875E0", Slot = "4")]
		public void Set(ref LobbyDetailsCopyInfoOptions other)
		{
		}

		// Token: 0x06001A51 RID: 6737 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A51")]
		[Address(RVA = "0x5113D0", Offset = "0x50F9D0", VA = "0x1805113D0", Slot = "5")]
		public void Set(ref LobbyDetailsCopyInfoOptions? other)
		{
		}

		// Token: 0x06001A52 RID: 6738 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A52")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000BE2 RID: 3042
		[Token(Token = "0x4000BE2")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;
	}
}
