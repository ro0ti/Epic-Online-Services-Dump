using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.Reports
{
	// Token: 0x0200028A RID: 650
	[Token(Token = "0x200028A")]
	public struct SendPlayerBehaviorReportCompleteCallbackInfo : ICallbackInfo
	{
		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x060011FC RID: 4604 RVA: 0x00005684 File Offset: 0x00003884
		// (set) Token: 0x060011FD RID: 4605 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170004AA")]
		public Result ResultCode
		{
			[Token(Token = "0x60011FC")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x60011FD")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x060011FE RID: 4606 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060011FF RID: 4607 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170004AB")]
		public object ClientData
		{
			[Token(Token = "0x60011FE")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60011FF")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001200 RID: 4608 RVA: 0x0000569C File Offset: 0x0000389C
		[Token(Token = "0x6001200")]
		[Address(RVA = "0x502280", Offset = "0x500880", VA = "0x180502280", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x06001201 RID: 4609 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001201")]
		[Address(RVA = "0x5022D0", Offset = "0x5008D0", VA = "0x1805022D0")]
		internal void Set(ref SendPlayerBehaviorReportCompleteCallbackInfoInternal other)
		{
		}
	}
}
