using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.UI
{
	// Token: 0x0200007E RID: 126
	[Token(Token = "0x200007E")]
	public struct OnShowBlockPlayerCallbackInfo : ICallbackInfo
	{
		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x06000531 RID: 1329 RVA: 0x00002A2C File Offset: 0x00000C2C
		// (set) Token: 0x06000532 RID: 1330 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000A9")]
		public Result ResultCode
		{
			[Token(Token = "0x6000531")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x6000532")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x06000533 RID: 1331 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000534 RID: 1332 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000AA")]
		public object ClientData
		{
			[Token(Token = "0x6000533")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000534")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x06000535 RID: 1333 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000536 RID: 1334 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000AB")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x6000535")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000536")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x06000537 RID: 1335 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000538 RID: 1336 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000AC")]
		public EpicAccountId TargetUserId
		{
			[Token(Token = "0x6000537")]
			[Address(RVA = "0x3E4B20", Offset = "0x3E3120", VA = "0x1803E4B20")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000538")]
			[Address(RVA = "0x488180", Offset = "0x486780", VA = "0x180488180")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000539 RID: 1337 RVA: 0x00002A44 File Offset: 0x00000C44
		[Token(Token = "0x6000539")]
		[Address(RVA = "0x4ABE40", Offset = "0x4AA440", VA = "0x1804ABE40", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x0600053A RID: 1338 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600053A")]
		[Address(RVA = "0x4ABE90", Offset = "0x4AA490", VA = "0x1804ABE90")]
		internal void Set(ref OnShowBlockPlayerCallbackInfoInternal other)
		{
		}
	}
}
