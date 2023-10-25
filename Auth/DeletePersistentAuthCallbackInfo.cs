using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.Auth
{
	// Token: 0x02000656 RID: 1622
	[Token(Token = "0x2000656")]
	public struct DeletePersistentAuthCallbackInfo : ICallbackInfo
	{
		// Token: 0x17000C14 RID: 3092
		// (get) Token: 0x0600298E RID: 10638 RVA: 0x0000A6DC File Offset: 0x000088DC
		// (set) Token: 0x0600298F RID: 10639 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C14")]
		public Result ResultCode
		{
			[Token(Token = "0x600298E")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x600298F")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000C15 RID: 3093
		// (get) Token: 0x06002990 RID: 10640 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002991 RID: 10641 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C15")]
		public object ClientData
		{
			[Token(Token = "0x6002990")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002991")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06002992 RID: 10642 RVA: 0x0000A6F4 File Offset: 0x000088F4
		[Token(Token = "0x6002992")]
		[Address(RVA = "0x559EC0", Offset = "0x5584C0", VA = "0x180559EC0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x06002993 RID: 10643 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002993")]
		[Address(RVA = "0x559F10", Offset = "0x558510", VA = "0x180559F10")]
		internal void Set(ref DeletePersistentAuthCallbackInfoInternal other)
		{
		}
	}
}
