using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Auth
{
	// Token: 0x02000692 RID: 1682
	[Token(Token = "0x2000692")]
	internal struct IOSLoginOptionsInternal : ISettable<IOSLoginOptions>, IDisposable
	{
		// Token: 0x17000CB3 RID: 3251
		// (set) Token: 0x06002B56 RID: 11094 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000CB3")]
		public IOSCredentials? Credentials
		{
			[Token(Token = "0x6002B56")]
			[Address(RVA = "0x570F50", Offset = "0x56F550", VA = "0x180570F50")]
			set
			{
			}
		}

		// Token: 0x17000CB4 RID: 3252
		// (set) Token: 0x06002B57 RID: 11095 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000CB4")]
		public AuthScopeFlags ScopeFlags
		{
			[Token(Token = "0x6002B57")]
			[Address(RVA = "0x457A40", Offset = "0x456040", VA = "0x180457A40")]
			set
			{
			}
		}

		// Token: 0x17000CB5 RID: 3253
		// (set) Token: 0x06002B58 RID: 11096 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000CB5")]
		public LoginFlags LoginFlags
		{
			[Token(Token = "0x6002B58")]
			[Address(RVA = "0x4DEC40", Offset = "0x4DD240", VA = "0x1804DEC40")]
			set
			{
			}
		}

		// Token: 0x06002B59 RID: 11097 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002B59")]
		[Address(RVA = "0x570EA0", Offset = "0x56F4A0", VA = "0x180570EA0", Slot = "4")]
		public void Set(ref IOSLoginOptions other)
		{
		}

		// Token: 0x06002B5A RID: 11098 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002B5A")]
		[Address(RVA = "0x570D60", Offset = "0x56F360", VA = "0x180570D60", Slot = "5")]
		public void Set(ref IOSLoginOptions? other)
		{
		}

		// Token: 0x06002B5B RID: 11099 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002B5B")]
		[Address(RVA = "0x570D10", Offset = "0x56F310", VA = "0x180570D10", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x040012CC RID: 4812
		[Token(Token = "0x40012CC")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x040012CD RID: 4813
		[Token(Token = "0x40012CD")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_Credentials;

		// Token: 0x040012CE RID: 4814
		[Token(Token = "0x40012CE")]
		[FieldOffset(Offset = "0x10")]
		private AuthScopeFlags m_ScopeFlags;

		// Token: 0x040012CF RID: 4815
		[Token(Token = "0x40012CF")]
		[FieldOffset(Offset = "0x18")]
		private LoginFlags m_LoginFlags;
	}
}
