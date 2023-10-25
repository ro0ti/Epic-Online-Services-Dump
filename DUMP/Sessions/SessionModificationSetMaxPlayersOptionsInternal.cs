using System;


namespace Epic.OnlineServices.Sessions
{
	// Token: 0x0200017C RID: 380
	[Token(Token = "0x200017C")]
	internal struct SessionModificationSetMaxPlayersOptionsInternal : ISettable<SessionModificationSetMaxPlayersOptions>, IDisposable
	{
		// Token: 0x17000288 RID: 648
		// (set) Token: 0x06000B24 RID: 2852 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000288")]
		public uint MaxPlayers
		{
			[Token(Token = "0x6000B24")]
			[Address(RVA = "0x4A4E90", Offset = "0x4A3490", VA = "0x1804A4E90")]
			set
			{
			}
		}

		// Token: 0x06000B25 RID: 2853 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B25")]
		[Address(RVA = "0x4AFC00", Offset = "0x4AE200", VA = "0x1804AFC00", Slot = "4")]
		public void Set(ref SessionModificationSetMaxPlayersOptions other)
		{
		}

		// Token: 0x06000B26 RID: 2854 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B26")]
		[Address(RVA = "0x4CB640", Offset = "0x4C9C40", VA = "0x1804CB640", Slot = "5")]
		public void Set(ref SessionModificationSetMaxPlayersOptions? other)
		{
		}

		// Token: 0x06000B27 RID: 2855 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B27")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000528 RID: 1320
		[Token(Token = "0x4000528")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000529 RID: 1321
		[Token(Token = "0x4000529")]
		[FieldOffset(Offset = "0x4")]
		private uint m_MaxPlayers;
	}
}
