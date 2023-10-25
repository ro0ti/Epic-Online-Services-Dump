using System;


namespace Epic.OnlineServices.Lobby
{
	// Token: 0x020003EE RID: 1006
	[Token(Token = "0x20003EE")]
	internal struct LobbyDetailsGetAttributeCountOptionsInternal : ISettable<LobbyDetailsGetAttributeCountOptions>, IDisposable
	{
		// Token: 0x06001A6B RID: 6763 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A6B")]
		[Address(RVA = "0x4875E0", Offset = "0x485BE0", VA = "0x1804875E0", Slot = "4")]
		public void Set(ref LobbyDetailsGetAttributeCountOptions other)
		{
		}

		// Token: 0x06001A6C RID: 6764 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A6C")]
		[Address(RVA = "0x511AC0", Offset = "0x5100C0", VA = "0x180511AC0", Slot = "5")]
		public void Set(ref LobbyDetailsGetAttributeCountOptions? other)
		{
		}

		// Token: 0x06001A6D RID: 6765 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A6D")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000BF0 RID: 3056
		[Token(Token = "0x4000BF0")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;
	}
}
