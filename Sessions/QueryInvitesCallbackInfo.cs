using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.Sessions
{
	// Token: 0x02000144 RID: 324
	[Token(Token = "0x2000144")]
	public struct QueryInvitesCallbackInfo : ICallbackInfo
	{
		// Token: 0x170001FF RID: 511
		// (get) Token: 0x060009AD RID: 2477 RVA: 0x00003A4C File Offset: 0x00001C4C
		// (set) Token: 0x060009AE RID: 2478 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001FF")]
		public Result ResultCode
		{
			[Token(Token = "0x60009AD")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x60009AE")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x060009AF RID: 2479 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060009B0 RID: 2480 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000200")]
		public object ClientData
		{
			[Token(Token = "0x60009AF")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60009B0")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x060009B1 RID: 2481 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060009B2 RID: 2482 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000201")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x60009B1")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60009B2")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060009B3 RID: 2483 RVA: 0x00003A64 File Offset: 0x00001C64
		[Token(Token = "0x60009B3")]
		[Address(RVA = "0x4C2A70", Offset = "0x4C1070", VA = "0x1804C2A70", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x060009B4 RID: 2484 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009B4")]
		[Address(RVA = "0x4C2AC0", Offset = "0x4C10C0", VA = "0x1804C2AC0")]
		internal void Set(ref QueryInvitesCallbackInfoInternal other)
		{
		}
	}
}
