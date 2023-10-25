using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.Achievements
{
	// Token: 0x02000767 RID: 1895
	[Token(Token = "0x2000767")]
	public struct OnQueryDefinitionsCompleteCallbackInfo : ICallbackInfo
	{
		// Token: 0x17000EA0 RID: 3744
		// (get) Token: 0x060030AA RID: 12458 RVA: 0x0000C89C File Offset: 0x0000AA9C
		// (set) Token: 0x060030AB RID: 12459 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000EA0")]
		public Result ResultCode
		{
			[Token(Token = "0x60030AA")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x60030AB")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000EA1 RID: 3745
		// (get) Token: 0x060030AC RID: 12460 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060030AD RID: 12461 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000EA1")]
		public object ClientData
		{
			[Token(Token = "0x60030AC")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60030AD")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060030AE RID: 12462 RVA: 0x0000C8B4 File Offset: 0x0000AAB4
		[Token(Token = "0x60030AE")]
		[Address(RVA = "0x589AD0", Offset = "0x5880D0", VA = "0x180589AD0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x060030AF RID: 12463 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60030AF")]
		[Address(RVA = "0x589B20", Offset = "0x588120", VA = "0x180589B20")]
		internal void Set(ref OnQueryDefinitionsCompleteCallbackInfoInternal other)
		{
		}
	}
}
