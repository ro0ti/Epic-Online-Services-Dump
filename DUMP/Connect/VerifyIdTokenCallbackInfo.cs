using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.Connect
{
	// Token: 0x02000645 RID: 1605
	[Token(Token = "0x2000645")]
	public struct VerifyIdTokenCallbackInfo : ICallbackInfo
	{
		// Token: 0x17000BEB RID: 3051
		// (get) Token: 0x06002907 RID: 10503 RVA: 0x0000A4CC File Offset: 0x000086CC
		// (set) Token: 0x06002908 RID: 10504 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BEB")]
		public Result ResultCode
		{
			[Token(Token = "0x6002907")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x6002908")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000BEC RID: 3052
		// (get) Token: 0x06002909 RID: 10505 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600290A RID: 10506 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BEC")]
		public object ClientData
		{
			[Token(Token = "0x6002909")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600290A")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000BED RID: 3053
		// (get) Token: 0x0600290B RID: 10507 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600290C RID: 10508 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BED")]
		public ProductUserId ProductUserId
		{
			[Token(Token = "0x600290B")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600290C")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000BEE RID: 3054
		// (get) Token: 0x0600290D RID: 10509 RVA: 0x0000A4E4 File Offset: 0x000086E4
		// (set) Token: 0x0600290E RID: 10510 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BEE")]
		public bool IsAccountInfoPresent
		{
			[Token(Token = "0x600290D")]
			[Address(RVA = "0x4BED50", Offset = "0x4BD350", VA = "0x1804BED50")]
			[CompilerGenerated]
			readonly get
			{
				return default(bool);
			}
			[Token(Token = "0x600290E")]
			[Address(RVA = "0x4BED60", Offset = "0x4BD360", VA = "0x1804BED60")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000BEF RID: 3055
		// (get) Token: 0x0600290F RID: 10511 RVA: 0x0000A4FC File Offset: 0x000086FC
		// (set) Token: 0x06002910 RID: 10512 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BEF")]
		public ExternalAccountType AccountIdType
		{
			[Token(Token = "0x600290F")]
			[Address(RVA = "0x4A5AF0", Offset = "0x4A40F0", VA = "0x1804A5AF0")]
			[CompilerGenerated]
			readonly get
			{
				return ExternalAccountType.Epic;
			}
			[Token(Token = "0x6002910")]
			[Address(RVA = "0x4A5CB0", Offset = "0x4A42B0", VA = "0x1804A5CB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000BF0 RID: 3056
		// (get) Token: 0x06002911 RID: 10513 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002912 RID: 10514 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BF0")]
		public Utf8String AccountId
		{
			[Token(Token = "0x6002911")]
			[Address(RVA = "0x4447A0", Offset = "0x442DA0", VA = "0x1804447A0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002912")]
			[Address(RVA = "0x444810", Offset = "0x442E10", VA = "0x180444810")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000BF1 RID: 3057
		// (get) Token: 0x06002913 RID: 10515 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002914 RID: 10516 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BF1")]
		public Utf8String Platform
		{
			[Token(Token = "0x6002913")]
			[Address(RVA = "0x444770", Offset = "0x442D70", VA = "0x180444770")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002914")]
			[Address(RVA = "0x444800", Offset = "0x442E00", VA = "0x180444800")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000BF2 RID: 3058
		// (get) Token: 0x06002915 RID: 10517 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002916 RID: 10518 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BF2")]
		public Utf8String DeviceType
		{
			[Token(Token = "0x6002915")]
			[Address(RVA = "0x475020", Offset = "0x473620", VA = "0x180475020")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002916")]
			[Address(RVA = "0x4D5030", Offset = "0x4D3630", VA = "0x1804D5030")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000BF3 RID: 3059
		// (get) Token: 0x06002917 RID: 10519 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002918 RID: 10520 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BF3")]
		public Utf8String ClientId
		{
			[Token(Token = "0x6002917")]
			[Address(RVA = "0x4BBE60", Offset = "0x4BA460", VA = "0x1804BBE60")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002918")]
			[Address(RVA = "0x4BBE90", Offset = "0x4BA490", VA = "0x1804BBE90")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000BF4 RID: 3060
		// (get) Token: 0x06002919 RID: 10521 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600291A RID: 10522 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BF4")]
		public Utf8String ProductId
		{
			[Token(Token = "0x6002919")]
			[Address(RVA = "0x4C33D0", Offset = "0x4C19D0", VA = "0x1804C33D0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600291A")]
			[Address(RVA = "0x4C3420", Offset = "0x4C1A20", VA = "0x1804C3420")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000BF5 RID: 3061
		// (get) Token: 0x0600291B RID: 10523 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600291C RID: 10524 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BF5")]
		public Utf8String SandboxId
		{
			[Token(Token = "0x600291B")]
			[Address(RVA = "0x4C8040", Offset = "0x4C6640", VA = "0x1804C8040")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600291C")]
			[Address(RVA = "0x4C8070", Offset = "0x4C6670", VA = "0x1804C8070")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000BF6 RID: 3062
		// (get) Token: 0x0600291D RID: 10525 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600291E RID: 10526 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BF6")]
		public Utf8String DeploymentId
		{
			[Token(Token = "0x600291D")]
			[Address(RVA = "0x3D6650", Offset = "0x3D4C50", VA = "0x1803D6650")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600291E")]
			[Address(RVA = "0x4562B0", Offset = "0x4548B0", VA = "0x1804562B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600291F RID: 10527 RVA: 0x0000A514 File Offset: 0x00008714
		[Token(Token = "0x600291F")]
		[Address(RVA = "0x56AB20", Offset = "0x569120", VA = "0x18056AB20", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x06002920 RID: 10528 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002920")]
		[Address(RVA = "0x56AB70", Offset = "0x569170", VA = "0x18056AB70")]
		internal void Set(ref VerifyIdTokenCallbackInfoInternal other)
		{
		}
	}
}
