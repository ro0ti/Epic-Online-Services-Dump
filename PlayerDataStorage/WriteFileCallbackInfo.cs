using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.PlayerDataStorage
{
	// Token: 0x0200030F RID: 783
	[Token(Token = "0x200030F")]
	public struct WriteFileCallbackInfo : ICallbackInfo
	{
		// Token: 0x170005A5 RID: 1445
		// (get) Token: 0x06001534 RID: 5428 RVA: 0x00006074 File Offset: 0x00004274
		// (set) Token: 0x06001535 RID: 5429 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170005A5")]
		public Result ResultCode
		{
			[Token(Token = "0x6001534")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x6001535")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170005A6 RID: 1446
		// (get) Token: 0x06001536 RID: 5430 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001537 RID: 5431 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170005A6")]
		public object ClientData
		{
			[Token(Token = "0x6001536")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001537")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170005A7 RID: 1447
		// (get) Token: 0x06001538 RID: 5432 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001539 RID: 5433 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170005A7")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6001538")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001539")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170005A8 RID: 1448
		// (get) Token: 0x0600153A RID: 5434 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600153B RID: 5435 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170005A8")]
		public Utf8String Filename
		{
			[Token(Token = "0x600153A")]
			[Address(RVA = "0x3E4B20", Offset = "0x3E3120", VA = "0x1803E4B20")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600153B")]
			[Address(RVA = "0x488180", Offset = "0x486780", VA = "0x180488180")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600153C RID: 5436 RVA: 0x0000608C File Offset: 0x0000428C
		[Token(Token = "0x600153C")]
		[Address(RVA = "0x5042F0", Offset = "0x5028F0", VA = "0x1805042F0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x0600153D RID: 5437 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600153D")]
		[Address(RVA = "0x504340", Offset = "0x502940", VA = "0x180504340")]
		internal void Set(ref WriteFileCallbackInfoInternal other)
		{
		}
	}
}
