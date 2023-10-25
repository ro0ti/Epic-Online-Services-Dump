using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Sessions
{
	// Token: 0x0200011C RID: 284
	[Token(Token = "0x200011C")]
	public struct JoinSessionCallbackInfo : ICallbackInfo
	{
		// Token: 0x170001EB RID: 491
		// (get) Token: 0x060008FC RID: 2300 RVA: 0x000039A4 File Offset: 0x00001BA4
		// (set) Token: 0x060008FD RID: 2301 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001EB")]
		public Result ResultCode
		{
			[Token(Token = "0x60008FC")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x60008FD")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x060008FE RID: 2302 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060008FF RID: 2303 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001EC")]
		public object ClientData
		{
			[Token(Token = "0x60008FE")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60008FF")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000900 RID: 2304 RVA: 0x000039BC File Offset: 0x00001BBC
		[Token(Token = "0x6000900")]
		[Address(RVA = "0x4BE780", Offset = "0x4BCD80", VA = "0x1804BE780", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x06000901 RID: 2305 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000901")]
		[Address(RVA = "0x4BE7D0", Offset = "0x4BCDD0", VA = "0x1804BE7D0")]
		internal void Set(ref JoinSessionCallbackInfoInternal other)
		{
		}
	}
}
