using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Connect
{
	// Token: 0x02000600 RID: 1536
	[Token(Token = "0x2000600")]
	internal struct CreateUserOptionsInternal : ISettable<CreateUserOptions>, IDisposable
	{
		// Token: 0x17000B70 RID: 2928
		// (set) Token: 0x0600276A RID: 10090 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B70")]
		public ContinuanceToken ContinuanceToken
		{
			[Token(Token = "0x600276A")]
			[Address(RVA = "0x558FF0", Offset = "0x5575F0", VA = "0x180558FF0")]
			set
			{
			}
		}

		// Token: 0x0600276B RID: 10091 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600276B")]
		[Address(RVA = "0x558F90", Offset = "0x557590", VA = "0x180558F90", Slot = "4")]
		public void Set(ref CreateUserOptions other)
		{
		}

		// Token: 0x0600276C RID: 10092 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600276C")]
		[Address(RVA = "0x558EF0", Offset = "0x5574F0", VA = "0x180558EF0", Slot = "5")]
		public void Set(ref CreateUserOptions? other)
		{
		}

		// Token: 0x0600276D RID: 10093 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600276D")]
		[Address(RVA = "0x558EA0", Offset = "0x5574A0", VA = "0x180558EA0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x0400114D RID: 4429
		[Token(Token = "0x400114D")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x0400114E RID: 4430
		[Token(Token = "0x400114E")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ContinuanceToken;
	}
}
