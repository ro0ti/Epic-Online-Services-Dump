using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Lobby
{
	// Token: 0x0200042B RID: 1067
	[Token(Token = "0x200042B")]
	internal struct LobbySearchSetMaxResultsOptionsInternal : ISettable<LobbySearchSetMaxResultsOptions>, IDisposable
	{
		// Token: 0x170007FA RID: 2042
		// (set) Token: 0x06001C10 RID: 7184 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170007FA")]
		public uint MaxResults
		{
			[Token(Token = "0x6001C10")]
			[Address(RVA = "0x4A4E90", Offset = "0x4A3490", VA = "0x1804A4E90")]
			set
			{
			}
		}

		// Token: 0x06001C11 RID: 7185 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001C11")]
		[Address(RVA = "0x4AFC00", Offset = "0x4AE200", VA = "0x1804AFC00", Slot = "4")]
		public void Set(ref LobbySearchSetMaxResultsOptions other)
		{
		}

		// Token: 0x06001C12 RID: 7186 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001C12")]
		[Address(RVA = "0x52C050", Offset = "0x52A650", VA = "0x18052C050", Slot = "5")]
		public void Set(ref LobbySearchSetMaxResultsOptions? other)
		{
		}

		// Token: 0x06001C13 RID: 7187 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001C13")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000CC7 RID: 3271
		[Token(Token = "0x4000CC7")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000CC8 RID: 3272
		[Token(Token = "0x4000CC8")]
		[FieldOffset(Offset = "0x4")]
		private uint m_MaxResults;
	}
}
