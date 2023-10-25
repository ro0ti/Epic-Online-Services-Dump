using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Auth
{
	// Token: 0x02000691 RID: 1681
	[Token(Token = "0x2000691")]
	public struct IOSLoginOptions
	{
		// Token: 0x17000CB0 RID: 3248
		// (get) Token: 0x06002B50 RID: 11088 RVA: 0x0000AD0C File Offset: 0x00008F0C
		// (set) Token: 0x06002B51 RID: 11089 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000CB0")]
		public IOSCredentials? Credentials
		{
			[Token(Token = "0x6002B50")]
			[Address(RVA = "0x570FC0", Offset = "0x56F5C0", VA = "0x180570FC0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002B51")]
			[Address(RVA = "0x570FF0", Offset = "0x56F5F0", VA = "0x180570FF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000CB1 RID: 3249
		// (get) Token: 0x06002B52 RID: 11090 RVA: 0x0000AD24 File Offset: 0x00008F24
		// (set) Token: 0x06002B53 RID: 11091 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000CB1")]
		public AuthScopeFlags ScopeFlags
		{
			[Token(Token = "0x6002B52")]
			[Address(RVA = "0x4D13A0", Offset = "0x4CF9A0", VA = "0x1804D13A0")]
			[CompilerGenerated]
			readonly get
			{
				return AuthScopeFlags.NoFlags;
			}
			[Token(Token = "0x6002B53")]
			[Address(RVA = "0x4D13B0", Offset = "0x4CF9B0", VA = "0x1804D13B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000CB2 RID: 3250
		// (get) Token: 0x06002B54 RID: 11092 RVA: 0x0000AD3C File Offset: 0x00008F3C
		// (set) Token: 0x06002B55 RID: 11093 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000CB2")]
		public LoginFlags LoginFlags
		{
			[Token(Token = "0x6002B54")]
			[Address(RVA = "0x4C33D0", Offset = "0x4C19D0", VA = "0x1804C33D0")]
			[CompilerGenerated]
			readonly get
			{
				return LoginFlags.None;
			}
			[Token(Token = "0x6002B55")]
			[Address(RVA = "0x571020", Offset = "0x56F620", VA = "0x180571020")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
