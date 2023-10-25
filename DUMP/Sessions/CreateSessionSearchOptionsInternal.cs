using System;


namespace Epic.OnlineServices.Sessions
{
	// Token: 0x02000109 RID: 265
	[Token(Token = "0x2000109")]
	internal struct CreateSessionSearchOptionsInternal : ISettable<CreateSessionSearchOptions>, IDisposable
	{
		// Token: 0x170001C9 RID: 457
		// (set) Token: 0x0600089D RID: 2205 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001C9")]
		public uint MaxSearchResults
		{
			[Token(Token = "0x600089D")]
			[Address(RVA = "0x4A4E90", Offset = "0x4A3490", VA = "0x1804A4E90")]
			set
			{
			}
		}

		// Token: 0x0600089E RID: 2206 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600089E")]
		[Address(RVA = "0x4AFC00", Offset = "0x4AE200", VA = "0x1804AFC00", Slot = "4")]
		public void Set(ref CreateSessionSearchOptions other)
		{
		}

		// Token: 0x0600089F RID: 2207 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600089F")]
		[Address(RVA = "0x4BBEC0", Offset = "0x4BA4C0", VA = "0x1804BBEC0", Slot = "5")]
		public void Set(ref CreateSessionSearchOptions? other)
		{
		}

		// Token: 0x060008A0 RID: 2208 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008A0")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000433 RID: 1075
		[Token(Token = "0x4000433")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000434 RID: 1076
		[Token(Token = "0x4000434")]
		[FieldOffset(Offset = "0x4")]
		private uint m_MaxSearchResults;
	}
}
