using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.UserInfo
{
	// Token: 0x02000050 RID: 80
	[Token(Token = "0x2000050")]
	public struct QueryUserInfoByExternalAccountCallbackInfo : ICallbackInfo
	{
		// Token: 0x17000060 RID: 96
		// (get) Token: 0x0600043A RID: 1082 RVA: 0x000026E4 File Offset: 0x000008E4
		// (set) Token: 0x0600043B RID: 1083 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000060")]
		public Result ResultCode
		{
			[Token(Token = "0x600043A")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x600043B")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x0600043C RID: 1084 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600043D RID: 1085 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000061")]
		public object ClientData
		{
			[Token(Token = "0x600043C")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600043D")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x0600043E RID: 1086 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600043F RID: 1087 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000062")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x600043E")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600043F")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000440 RID: 1088 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000441 RID: 1089 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000063")]
		public Utf8String ExternalAccountId
		{
			[Token(Token = "0x6000440")]
			[Address(RVA = "0x3E4B20", Offset = "0x3E3120", VA = "0x1803E4B20")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000441")]
			[Address(RVA = "0x488180", Offset = "0x486780", VA = "0x180488180")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000442 RID: 1090 RVA: 0x000026FC File Offset: 0x000008FC
		// (set) Token: 0x06000443 RID: 1091 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000064")]
		public ExternalAccountType AccountType
		{
			[Token(Token = "0x6000442")]
			[Address(RVA = "0x3D2F80", Offset = "0x3D1580", VA = "0x1803D2F80")]
			[CompilerGenerated]
			readonly get
			{
				return ExternalAccountType.Epic;
			}
			[Token(Token = "0x6000443")]
			[Address(RVA = "0x488190", Offset = "0x486790", VA = "0x180488190")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000444 RID: 1092 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000445 RID: 1093 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000065")]
		public EpicAccountId TargetUserId
		{
			[Token(Token = "0x6000444")]
			[Address(RVA = "0x444770", Offset = "0x442D70", VA = "0x180444770")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000445")]
			[Address(RVA = "0x444800", Offset = "0x442E00", VA = "0x180444800")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x00002714 File Offset: 0x00000914
		[Token(Token = "0x6000446")]
		[Address(RVA = "0x4AE740", Offset = "0x4ACD40", VA = "0x1804AE740", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000447")]
		[Address(RVA = "0x4AE790", Offset = "0x4ACD90", VA = "0x1804AE790")]
		internal void Set(ref QueryUserInfoByExternalAccountCallbackInfoInternal other)
		{
		}
	}
}
