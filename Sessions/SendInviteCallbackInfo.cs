using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.Sessions
{
	// Token: 0x02000150 RID: 336
	[Token(Token = "0x2000150")]
	public struct SendInviteCallbackInfo : ICallbackInfo
	{
		// Token: 0x1700021E RID: 542
		// (get) Token: 0x060009FE RID: 2558 RVA: 0x00003B6C File Offset: 0x00001D6C
		// (set) Token: 0x060009FF RID: 2559 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700021E")]
		public Result ResultCode
		{
			[Token(Token = "0x60009FE")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x60009FF")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x06000A00 RID: 2560 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000A01 RID: 2561 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700021F")]
		public object ClientData
		{
			[Token(Token = "0x6000A00")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000A01")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000A02 RID: 2562 RVA: 0x00003B84 File Offset: 0x00001D84
		[Token(Token = "0x6000A02")]
		[Address(RVA = "0x4C5ED0", Offset = "0x4C44D0", VA = "0x1804C5ED0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x06000A03 RID: 2563 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A03")]
		[Address(RVA = "0x4C5F20", Offset = "0x4C4520", VA = "0x1804C5F20")]
		internal void Set(ref SendInviteCallbackInfoInternal other)
		{
		}
	}
}
