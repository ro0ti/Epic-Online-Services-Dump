using System;
using System.Runtime.CompilerServices;
using Epic.OnlineServices.AntiCheatCommon;
using Il2CppDummyDll;

namespace Epic.OnlineServices.AntiCheatServer
{
	// Token: 0x020006AA RID: 1706
	[Token(Token = "0x20006AA")]
	public struct RegisterClientOptions
	{
		// Token: 0x17000CCA RID: 3274
		// (get) Token: 0x06002BCB RID: 11211 RVA: 0x0000B06C File Offset: 0x0000926C
		// (set) Token: 0x06002BCC RID: 11212 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000CCA")]
		public IntPtr ClientHandle
		{
			[Token(Token = "0x6002BCB")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return 0;
			}
			[Token(Token = "0x6002BCC")]
			[Address(RVA = "0x4875D0", Offset = "0x485BD0", VA = "0x1804875D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000CCB RID: 3275
		// (get) Token: 0x06002BCD RID: 11213 RVA: 0x0000B084 File Offset: 0x00009284
		// (set) Token: 0x06002BCE RID: 11214 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000CCB")]
		public AntiCheatCommonClientType ClientType
		{
			[Token(Token = "0x6002BCD")]
			[Address(RVA = "0x4875A0", Offset = "0x485BA0", VA = "0x1804875A0")]
			[CompilerGenerated]
			readonly get
			{
				return AntiCheatCommonClientType.ProtectedClient;
			}
			[Token(Token = "0x6002BCE")]
			[Address(RVA = "0x4875C0", Offset = "0x485BC0", VA = "0x1804875C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000CCC RID: 3276
		// (get) Token: 0x06002BCF RID: 11215 RVA: 0x0000B09C File Offset: 0x0000929C
		// (set) Token: 0x06002BD0 RID: 11216 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000CCC")]
		public AntiCheatCommonClientPlatform ClientPlatform
		{
			[Token(Token = "0x6002BCF")]
			[Address(RVA = "0x4AF750", Offset = "0x4ADD50", VA = "0x1804AF750")]
			[CompilerGenerated]
			readonly get
			{
				return AntiCheatCommonClientPlatform.Unknown;
			}
			[Token(Token = "0x6002BD0")]
			[Address(RVA = "0x4AF760", Offset = "0x4ADD60", VA = "0x1804AF760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000CCD RID: 3277
		// (get) Token: 0x06002BD1 RID: 11217 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002BD2 RID: 11218 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000CCD")]
		public Utf8String AccountId_DEPRECATED
		{
			[Token(Token = "0x6002BD1")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002BD2")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000CCE RID: 3278
		// (get) Token: 0x06002BD3 RID: 11219 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002BD4 RID: 11220 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000CCE")]
		public Utf8String IpAddress
		{
			[Token(Token = "0x6002BD3")]
			[Address(RVA = "0x3E4B20", Offset = "0x3E3120", VA = "0x1803E4B20")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002BD4")]
			[Address(RVA = "0x488180", Offset = "0x486780", VA = "0x180488180")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000CCF RID: 3279
		// (get) Token: 0x06002BD5 RID: 11221 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002BD6 RID: 11222 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000CCF")]
		public ProductUserId UserId
		{
			[Token(Token = "0x6002BD5")]
			[Address(RVA = "0x4447A0", Offset = "0x442DA0", VA = "0x1804447A0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002BD6")]
			[Address(RVA = "0x444810", Offset = "0x442E10", VA = "0x180444810")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
