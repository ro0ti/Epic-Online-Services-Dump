using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Lobby
{
	// Token: 0x020003E4 RID: 996
	[Token(Token = "0x20003E4")]
	internal struct LobbyDetailsCopyAttributeByKeyOptionsInternal : ISettable<LobbyDetailsCopyAttributeByKeyOptions>, IDisposable
	{
		// Token: 0x17000776 RID: 1910
		// (set) Token: 0x06001A4C RID: 6732 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000776")]
		public Utf8String AttrKey
		{
			[Token(Token = "0x6001A4C")]
			[Address(RVA = "0x511370", Offset = "0x50F970", VA = "0x180511370")]
			set
			{
			}
		}

		// Token: 0x06001A4D RID: 6733 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A4D")]
		[Address(RVA = "0x511270", Offset = "0x50F870", VA = "0x180511270", Slot = "4")]
		public void Set(ref LobbyDetailsCopyAttributeByKeyOptions other)
		{
		}

		// Token: 0x06001A4E RID: 6734 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A4E")]
		[Address(RVA = "0x5112D0", Offset = "0x50F8D0", VA = "0x1805112D0", Slot = "5")]
		public void Set(ref LobbyDetailsCopyAttributeByKeyOptions? other)
		{
		}

		// Token: 0x06001A4F RID: 6735 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A4F")]
		[Address(RVA = "0x511220", Offset = "0x50F820", VA = "0x180511220", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000BE0 RID: 3040
		[Token(Token = "0x4000BE0")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000BE1 RID: 3041
		[Token(Token = "0x4000BE1")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_AttrKey;
	}
}
