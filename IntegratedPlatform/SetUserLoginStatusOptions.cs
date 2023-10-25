using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.IntegratedPlatform
{
	// Token: 0x020004EC RID: 1260
	[Token(Token = "0x20004EC")]
	public struct SetUserLoginStatusOptions
	{
		// Token: 0x1700091C RID: 2332
		// (get) Token: 0x0600203E RID: 8254 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600203F RID: 8255 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700091C")]
		public Utf8String PlatformType
		{
			[Token(Token = "0x600203E")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600203F")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700091D RID: 2333
		// (get) Token: 0x06002040 RID: 8256 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002041 RID: 8257 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700091D")]
		public Utf8String LocalPlatformUserId
		{
			[Token(Token = "0x6002040")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002041")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700091E RID: 2334
		// (get) Token: 0x06002042 RID: 8258 RVA: 0x00008AEC File Offset: 0x00006CEC
		// (set) Token: 0x06002043 RID: 8259 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700091E")]
		public LoginStatus CurrentLoginStatus
		{
			[Token(Token = "0x6002042")]
			[Address(RVA = "0x3D2690", Offset = "0x3D0C90", VA = "0x1803D2690")]
			[CompilerGenerated]
			readonly get
			{
				return LoginStatus.NotLoggedIn;
			}
			[Token(Token = "0x6002043")]
			[Address(RVA = "0x457A40", Offset = "0x456040", VA = "0x180457A40")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
