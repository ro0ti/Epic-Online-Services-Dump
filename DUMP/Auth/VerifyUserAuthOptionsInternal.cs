using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Auth
{
	// Token: 0x0200068C RID: 1676
	[Token(Token = "0x200068C")]
	internal struct VerifyUserAuthOptionsInternal : ISettable<VerifyUserAuthOptions>, IDisposable
	{
		// Token: 0x17000CA3 RID: 3235
		// (set) Token: 0x06002B2A RID: 11050 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000CA3")]
		public Token? AuthToken
		{
			[Token(Token = "0x6002B2A")]
			[Address(RVA = "0x5824E0", Offset = "0x580AE0", VA = "0x1805824E0")]
			set
			{
			}
		}

		// Token: 0x06002B2B RID: 11051 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002B2B")]
		[Address(RVA = "0x582310", Offset = "0x580910", VA = "0x180582310", Slot = "4")]
		public void Set(ref VerifyUserAuthOptions other)
		{
		}

		// Token: 0x06002B2C RID: 11052 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002B2C")]
		[Address(RVA = "0x5823C0", Offset = "0x5809C0", VA = "0x1805823C0", Slot = "5")]
		public void Set(ref VerifyUserAuthOptions? other)
		{
		}

		// Token: 0x06002B2D RID: 11053 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002B2D")]
		[Address(RVA = "0x5822C0", Offset = "0x5808C0", VA = "0x1805822C0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x040012B9 RID: 4793
		[Token(Token = "0x40012B9")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x040012BA RID: 4794
		[Token(Token = "0x40012BA")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_AuthToken;
	}
}
