using System;


namespace Epic.OnlineServices.Sessions
{
	// Token: 0x020000E9 RID: 233
	[Token(Token = "0x20000E9")]
	internal struct ActiveSessionGetRegisteredPlayerByIndexOptionsInternal : ISettable<ActiveSessionGetRegisteredPlayerByIndexOptions>, IDisposable
	{
		// Token: 0x1700019A RID: 410
		// (set) Token: 0x06000811 RID: 2065 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700019A")]
		public uint PlayerIndex
		{
			[Token(Token = "0x6000811")]
			[Address(RVA = "0x4A4E90", Offset = "0x4A3490", VA = "0x1804A4E90")]
			set
			{
			}
		}

		// Token: 0x06000812 RID: 2066 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000812")]
		[Address(RVA = "0x4AFC00", Offset = "0x4AE200", VA = "0x1804AFC00", Slot = "4")]
		public void Set(ref ActiveSessionGetRegisteredPlayerByIndexOptions other)
		{
		}

		// Token: 0x06000813 RID: 2067 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000813")]
		[Address(RVA = "0x4B8440", Offset = "0x4B6A40", VA = "0x1804B8440", Slot = "5")]
		public void Set(ref ActiveSessionGetRegisteredPlayerByIndexOptions? other)
		{
		}

		// Token: 0x06000814 RID: 2068 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000814")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x040003F3 RID: 1011
		[Token(Token = "0x40003F3")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x040003F4 RID: 1012
		[Token(Token = "0x40003F4")]
		[FieldOffset(Offset = "0x4")]
		private uint m_PlayerIndex;
	}
}
