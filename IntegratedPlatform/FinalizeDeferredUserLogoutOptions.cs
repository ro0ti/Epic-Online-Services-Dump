using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.IntegratedPlatform
{
	// Token: 0x020004DE RID: 1246
	[Token(Token = "0x20004DE")]
	public struct FinalizeDeferredUserLogoutOptions
	{
		// Token: 0x1700090E RID: 2318
		// (get) Token: 0x06001FFB RID: 8187 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001FFC RID: 8188 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700090E")]
		public Utf8String PlatformType
		{
			[Token(Token = "0x6001FFB")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001FFC")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700090F RID: 2319
		// (get) Token: 0x06001FFD RID: 8189 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001FFE RID: 8190 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700090F")]
		public Utf8String LocalPlatformUserId
		{
			[Token(Token = "0x6001FFD")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001FFE")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000910 RID: 2320
		// (get) Token: 0x06001FFF RID: 8191 RVA: 0x000089B4 File Offset: 0x00006BB4
		// (set) Token: 0x06002000 RID: 8192 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000910")]
		public LoginStatus ExpectedLoginStatus
		{
			[Token(Token = "0x6001FFF")]
			[Address(RVA = "0x3D2690", Offset = "0x3D0C90", VA = "0x1803D2690")]
			[CompilerGenerated]
			readonly get
			{
				return LoginStatus.NotLoggedIn;
			}
			[Token(Token = "0x6002000")]
			[Address(RVA = "0x457A40", Offset = "0x456040", VA = "0x180457A40")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
