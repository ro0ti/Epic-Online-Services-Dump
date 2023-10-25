using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.UserInfo
{
	// Token: 0x0200004C RID: 76
	[Token(Token = "0x200004C")]
	public struct QueryUserInfoByDisplayNameCallbackInfo : ICallbackInfo
	{
		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000416 RID: 1046 RVA: 0x00002684 File Offset: 0x00000884
		// (set) Token: 0x06000417 RID: 1047 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000051")]
		public Result ResultCode
		{
			[Token(Token = "0x6000416")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x6000417")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000418 RID: 1048 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000419 RID: 1049 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000052")]
		public object ClientData
		{
			[Token(Token = "0x6000418")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000419")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x0600041A RID: 1050 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600041B RID: 1051 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000053")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x600041A")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600041B")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x0600041C RID: 1052 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600041D RID: 1053 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000054")]
		public EpicAccountId TargetUserId
		{
			[Token(Token = "0x600041C")]
			[Address(RVA = "0x3E4B20", Offset = "0x3E3120", VA = "0x1803E4B20")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600041D")]
			[Address(RVA = "0x488180", Offset = "0x486780", VA = "0x180488180")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x0600041E RID: 1054 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600041F RID: 1055 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000055")]
		public Utf8String DisplayName
		{
			[Token(Token = "0x600041E")]
			[Address(RVA = "0x4447A0", Offset = "0x442DA0", VA = "0x1804447A0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600041F")]
			[Address(RVA = "0x444810", Offset = "0x442E10", VA = "0x180444810")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x0000269C File Offset: 0x0000089C
		[Token(Token = "0x6000420")]
		[Address(RVA = "0x4ADAF0", Offset = "0x4AC0F0", VA = "0x1804ADAF0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000421")]
		[Address(RVA = "0x4ADB40", Offset = "0x4AC140", VA = "0x1804ADB40")]
		internal void Set(ref QueryUserInfoByDisplayNameCallbackInfoInternal other)
		{
		}
	}
}
