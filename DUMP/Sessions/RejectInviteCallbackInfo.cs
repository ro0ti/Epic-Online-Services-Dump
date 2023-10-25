using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Sessions
{
	// Token: 0x0200014C RID: 332
	[Token(Token = "0x200014C")]
	public struct RejectInviteCallbackInfo : ICallbackInfo
	{
		// Token: 0x17000215 RID: 533
		// (get) Token: 0x060009E6 RID: 2534 RVA: 0x00003B0C File Offset: 0x00001D0C
		// (set) Token: 0x060009E7 RID: 2535 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000215")]
		public Result ResultCode
		{
			[Token(Token = "0x60009E6")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x60009E7")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x060009E8 RID: 2536 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060009E9 RID: 2537 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000216")]
		public object ClientData
		{
			[Token(Token = "0x60009E8")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60009E9")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060009EA RID: 2538 RVA: 0x00003B24 File Offset: 0x00001D24
		[Token(Token = "0x60009EA")]
		[Address(RVA = "0x4C58B0", Offset = "0x4C3EB0", VA = "0x1804C58B0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x060009EB RID: 2539 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009EB")]
		[Address(RVA = "0x4C5900", Offset = "0x4C3F00", VA = "0x1804C5900")]
		internal void Set(ref RejectInviteCallbackInfoInternal other)
		{
		}
	}
}
