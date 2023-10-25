using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Sessions
{
	// Token: 0x020000EC RID: 236
	[Token(Token = "0x20000EC")]
	public struct ActiveSessionInfo
	{
		// Token: 0x1700019B RID: 411
		// (get) Token: 0x06000818 RID: 2072 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000819 RID: 2073 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700019B")]
		public Utf8String SessionName
		{
			[Token(Token = "0x6000818")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000819")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x0600081A RID: 2074 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600081B RID: 2075 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700019C")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x600081A")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600081B")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x0600081C RID: 2076 RVA: 0x00003644 File Offset: 0x00001844
		// (set) Token: 0x0600081D RID: 2077 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700019D")]
		public OnlineSessionState State
		{
			[Token(Token = "0x600081C")]
			[Address(RVA = "0x3D2690", Offset = "0x3D0C90", VA = "0x1803D2690")]
			[CompilerGenerated]
			readonly get
			{
				return OnlineSessionState.NoSession;
			}
			[Token(Token = "0x600081D")]
			[Address(RVA = "0x457A40", Offset = "0x456040", VA = "0x180457A40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x0600081E RID: 2078 RVA: 0x0000365C File Offset: 0x0000185C
		// (set) Token: 0x0600081F RID: 2079 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700019E")]
		public SessionDetailsInfo? SessionDetails
		{
			[Token(Token = "0x600081E")]
			[Address(RVA = "0x4B8D00", Offset = "0x4B7300", VA = "0x1804B8D00")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600081F")]
			[Address(RVA = "0x4B8D40", Offset = "0x4B7340", VA = "0x1804B8D40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000820 RID: 2080 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000820")]
		[Address(RVA = "0x4B8B90", Offset = "0x4B7190", VA = "0x1804B8B90")]
		internal void Set(ref ActiveSessionInfoInternal other)
		{
		}
	}
}
