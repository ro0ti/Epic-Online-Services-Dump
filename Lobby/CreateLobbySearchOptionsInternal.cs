using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Lobby
{
	// Token: 0x020003B8 RID: 952
	[Token(Token = "0x20003B8")]
	internal struct CreateLobbySearchOptionsInternal : ISettable<CreateLobbySearchOptions>, IDisposable
	{
		// Token: 0x170006FC RID: 1788
		// (set) Token: 0x0600191B RID: 6427 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170006FC")]
		public uint MaxResults
		{
			[Token(Token = "0x600191B")]
			[Address(RVA = "0x4A4E90", Offset = "0x4A3490", VA = "0x1804A4E90")]
			set
			{
			}
		}

		// Token: 0x0600191C RID: 6428 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600191C")]
		[Address(RVA = "0x4AFC00", Offset = "0x4AE200", VA = "0x1804AFC00", Slot = "4")]
		public void Set(ref CreateLobbySearchOptions other)
		{
		}

		// Token: 0x0600191D RID: 6429 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600191D")]
		[Address(RVA = "0x509E80", Offset = "0x508480", VA = "0x180509E80", Slot = "5")]
		public void Set(ref CreateLobbySearchOptions? other)
		{
		}

		// Token: 0x0600191E RID: 6430 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600191E")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000B51 RID: 2897
		[Token(Token = "0x4000B51")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000B52 RID: 2898
		[Token(Token = "0x4000B52")]
		[FieldOffset(Offset = "0x4")]
		private uint m_MaxResults;
	}
}
