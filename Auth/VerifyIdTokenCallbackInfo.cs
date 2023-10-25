using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.Auth
{
	// Token: 0x02000685 RID: 1669
	[Token(Token = "0x2000685")]
	public struct VerifyIdTokenCallbackInfo : ICallbackInfo
	{
		// Token: 0x17000C80 RID: 3200
		// (get) Token: 0x06002AD8 RID: 10968 RVA: 0x0000AAFC File Offset: 0x00008CFC
		// (set) Token: 0x06002AD9 RID: 10969 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C80")]
		public Result ResultCode
		{
			[Token(Token = "0x6002AD8")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x6002AD9")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000C81 RID: 3201
		// (get) Token: 0x06002ADA RID: 10970 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002ADB RID: 10971 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C81")]
		public object ClientData
		{
			[Token(Token = "0x6002ADA")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002ADB")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000C82 RID: 3202
		// (get) Token: 0x06002ADC RID: 10972 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002ADD RID: 10973 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C82")]
		public Utf8String ApplicationId
		{
			[Token(Token = "0x6002ADC")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002ADD")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000C83 RID: 3203
		// (get) Token: 0x06002ADE RID: 10974 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002ADF RID: 10975 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C83")]
		public Utf8String ClientId
		{
			[Token(Token = "0x6002ADE")]
			[Address(RVA = "0x3E4B20", Offset = "0x3E3120", VA = "0x1803E4B20")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002ADF")]
			[Address(RVA = "0x488180", Offset = "0x486780", VA = "0x180488180")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000C84 RID: 3204
		// (get) Token: 0x06002AE0 RID: 10976 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002AE1 RID: 10977 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C84")]
		public Utf8String ProductId
		{
			[Token(Token = "0x6002AE0")]
			[Address(RVA = "0x4447A0", Offset = "0x442DA0", VA = "0x1804447A0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002AE1")]
			[Address(RVA = "0x444810", Offset = "0x442E10", VA = "0x180444810")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000C85 RID: 3205
		// (get) Token: 0x06002AE2 RID: 10978 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002AE3 RID: 10979 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C85")]
		public Utf8String SandboxId
		{
			[Token(Token = "0x6002AE2")]
			[Address(RVA = "0x444770", Offset = "0x442D70", VA = "0x180444770")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002AE3")]
			[Address(RVA = "0x444800", Offset = "0x442E00", VA = "0x180444800")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000C86 RID: 3206
		// (get) Token: 0x06002AE4 RID: 10980 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002AE5 RID: 10981 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C86")]
		public Utf8String DeploymentId
		{
			[Token(Token = "0x6002AE4")]
			[Address(RVA = "0x475020", Offset = "0x473620", VA = "0x180475020")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002AE5")]
			[Address(RVA = "0x4D5030", Offset = "0x4D3630", VA = "0x1804D5030")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000C87 RID: 3207
		// (get) Token: 0x06002AE6 RID: 10982 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002AE7 RID: 10983 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C87")]
		public Utf8String DisplayName
		{
			[Token(Token = "0x6002AE6")]
			[Address(RVA = "0x4BBE60", Offset = "0x4BA460", VA = "0x1804BBE60")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002AE7")]
			[Address(RVA = "0x4BBE90", Offset = "0x4BA490", VA = "0x1804BBE90")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000C88 RID: 3208
		// (get) Token: 0x06002AE8 RID: 10984 RVA: 0x0000AB14 File Offset: 0x00008D14
		// (set) Token: 0x06002AE9 RID: 10985 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C88")]
		public bool IsExternalAccountInfoPresent
		{
			[Token(Token = "0x6002AE8")]
			[Address(RVA = "0x51F940", Offset = "0x51DF40", VA = "0x18051F940")]
			[CompilerGenerated]
			readonly get
			{
				return default(bool);
			}
			[Token(Token = "0x6002AE9")]
			[Address(RVA = "0x51F970", Offset = "0x51DF70", VA = "0x18051F970")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000C89 RID: 3209
		// (get) Token: 0x06002AEA RID: 10986 RVA: 0x0000AB2C File Offset: 0x00008D2C
		// (set) Token: 0x06002AEB RID: 10987 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C89")]
		public ExternalAccountType ExternalAccountIdType
		{
			[Token(Token = "0x6002AEA")]
			[Address(RVA = "0x53BBD0", Offset = "0x53A1D0", VA = "0x18053BBD0")]
			[CompilerGenerated]
			readonly get
			{
				return ExternalAccountType.Epic;
			}
			[Token(Token = "0x6002AEB")]
			[Address(RVA = "0x53BF60", Offset = "0x53A560", VA = "0x18053BF60")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000C8A RID: 3210
		// (get) Token: 0x06002AEC RID: 10988 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002AED RID: 10989 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C8A")]
		public Utf8String ExternalAccountId
		{
			[Token(Token = "0x6002AEC")]
			[Address(RVA = "0x4C8040", Offset = "0x4C6640", VA = "0x1804C8040")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002AED")]
			[Address(RVA = "0x4C8070", Offset = "0x4C6670", VA = "0x1804C8070")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000C8B RID: 3211
		// (get) Token: 0x06002AEE RID: 10990 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002AEF RID: 10991 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C8B")]
		public Utf8String ExternalAccountDisplayName
		{
			[Token(Token = "0x6002AEE")]
			[Address(RVA = "0x3D6650", Offset = "0x3D4C50", VA = "0x1803D6650")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002AEF")]
			[Address(RVA = "0x4562B0", Offset = "0x4548B0", VA = "0x1804562B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000C8C RID: 3212
		// (get) Token: 0x06002AF0 RID: 10992 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002AF1 RID: 10993 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C8C")]
		public Utf8String Platform
		{
			[Token(Token = "0x6002AF0")]
			[Address(RVA = "0x55E7E0", Offset = "0x55CDE0", VA = "0x18055E7E0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002AF1")]
			[Address(RVA = "0x55E810", Offset = "0x55CE10", VA = "0x18055E810")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06002AF2 RID: 10994 RVA: 0x0000AB44 File Offset: 0x00008D44
		[Token(Token = "0x6002AF2")]
		[Address(RVA = "0x581920", Offset = "0x57FF20", VA = "0x180581920", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x06002AF3 RID: 10995 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002AF3")]
		[Address(RVA = "0x581970", Offset = "0x57FF70", VA = "0x180581970")]
		internal void Set(ref VerifyIdTokenCallbackInfoInternal other)
		{
		}
	}
}
