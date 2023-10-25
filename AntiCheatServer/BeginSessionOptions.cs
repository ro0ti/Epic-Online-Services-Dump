using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.AntiCheatServer
{
	// Token: 0x0200069A RID: 1690
	[Token(Token = "0x200069A")]
	public struct BeginSessionOptions
	{
		// Token: 0x17000CB6 RID: 3254
		// (get) Token: 0x06002B86 RID: 11142 RVA: 0x0000AFAC File Offset: 0x000091AC
		// (set) Token: 0x06002B87 RID: 11143 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000CB6")]
		public uint RegisterTimeoutSeconds
		{
			[Token(Token = "0x6002B86")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return 0U;
			}
			[Token(Token = "0x6002B87")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000CB7 RID: 3255
		// (get) Token: 0x06002B88 RID: 11144 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002B89 RID: 11145 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000CB7")]
		public Utf8String ServerName
		{
			[Token(Token = "0x6002B88")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002B89")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000CB8 RID: 3256
		// (get) Token: 0x06002B8A RID: 11146 RVA: 0x0000AFC4 File Offset: 0x000091C4
		// (set) Token: 0x06002B8B RID: 11147 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000CB8")]
		public bool EnableGameplayData
		{
			[Token(Token = "0x6002B8A")]
			[Address(RVA = "0x3D3060", Offset = "0x3D1660", VA = "0x1803D3060")]
			[CompilerGenerated]
			readonly get
			{
				return default(bool);
			}
			[Token(Token = "0x6002B8B")]
			[Address(RVA = "0x3D3070", Offset = "0x3D1670", VA = "0x1803D3070")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000CB9 RID: 3257
		// (get) Token: 0x06002B8C RID: 11148 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002B8D RID: 11149 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000CB9")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6002B8C")]
			[Address(RVA = "0x3E4B20", Offset = "0x3E3120", VA = "0x1803E4B20")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002B8D")]
			[Address(RVA = "0x488180", Offset = "0x486780", VA = "0x180488180")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
