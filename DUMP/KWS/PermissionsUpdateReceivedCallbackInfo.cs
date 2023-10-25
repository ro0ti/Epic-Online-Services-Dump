using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.KWS
{
	// Token: 0x020004C6 RID: 1222
	[Token(Token = "0x20004C6")]
	public struct PermissionsUpdateReceivedCallbackInfo : ICallbackInfo
	{
		// Token: 0x170008D1 RID: 2257
		// (get) Token: 0x06001F58 RID: 8024 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001F59 RID: 8025 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170008D1")]
		public object ClientData
		{
			[Token(Token = "0x6001F58")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001F59")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170008D2 RID: 2258
		// (get) Token: 0x06001F5A RID: 8026 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001F5B RID: 8027 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170008D2")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6001F5A")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001F5B")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170008D3 RID: 2259
		// (get) Token: 0x06001F5C RID: 8028 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001F5D RID: 8029 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170008D3")]
		public Utf8String KWSUserId
		{
			[Token(Token = "0x6001F5C")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001F5D")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170008D4 RID: 2260
		// (get) Token: 0x06001F5E RID: 8030 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001F5F RID: 8031 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170008D4")]
		public Utf8String DateOfBirth
		{
			[Token(Token = "0x6001F5E")]
			[Address(RVA = "0x3E4B20", Offset = "0x3E3120", VA = "0x1803E4B20")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001F5F")]
			[Address(RVA = "0x488180", Offset = "0x486780", VA = "0x180488180")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170008D5 RID: 2261
		// (get) Token: 0x06001F60 RID: 8032 RVA: 0x00008774 File Offset: 0x00006974
		// (set) Token: 0x06001F61 RID: 8033 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170008D5")]
		public bool IsMinor
		{
			[Token(Token = "0x6001F60")]
			[Address(RVA = "0x4BBE70", Offset = "0x4BA470", VA = "0x1804BBE70")]
			[CompilerGenerated]
			readonly get
			{
				return default(bool);
			}
			[Token(Token = "0x6001F61")]
			[Address(RVA = "0x4BBEA0", Offset = "0x4BA4A0", VA = "0x1804BBEA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170008D6 RID: 2262
		// (get) Token: 0x06001F62 RID: 8034 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001F63 RID: 8035 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170008D6")]
		public Utf8String ParentEmail
		{
			[Token(Token = "0x6001F62")]
			[Address(RVA = "0x444770", Offset = "0x442D70", VA = "0x180444770")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001F63")]
			[Address(RVA = "0x444800", Offset = "0x442E00", VA = "0x180444800")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001F64 RID: 8036 RVA: 0x0000878C File Offset: 0x0000698C
		[Token(Token = "0x6001F64")]
		[Address(RVA = "0x42B2A0", Offset = "0x4298A0", VA = "0x18042B2A0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x06001F65 RID: 8037 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001F65")]
		[Address(RVA = "0x5315E0", Offset = "0x52FBE0", VA = "0x1805315E0")]
		internal void Set(ref PermissionsUpdateReceivedCallbackInfoInternal other)
		{
		}
	}
}
