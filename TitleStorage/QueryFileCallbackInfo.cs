using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.TitleStorage
{
	// Token: 0x020000BD RID: 189
	[Token(Token = "0x20000BD")]
	public struct QueryFileCallbackInfo : ICallbackInfo
	{
		// Token: 0x17000129 RID: 297
		// (get) Token: 0x060006CE RID: 1742 RVA: 0x00003104 File Offset: 0x00001304
		// (set) Token: 0x060006CF RID: 1743 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000129")]
		public Result ResultCode
		{
			[Token(Token = "0x60006CE")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x60006CF")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x060006D0 RID: 1744 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060006D1 RID: 1745 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700012A")]
		public object ClientData
		{
			[Token(Token = "0x60006D0")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60006D1")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x060006D2 RID: 1746 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060006D3 RID: 1747 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700012B")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x60006D2")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60006D3")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060006D4 RID: 1748 RVA: 0x0000311C File Offset: 0x0000131C
		[Token(Token = "0x60006D4")]
		[Address(RVA = "0x4C1A80", Offset = "0x4C0080", VA = "0x1804C1A80", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x060006D5 RID: 1749 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006D5")]
		[Address(RVA = "0x4C1AD0", Offset = "0x4C00D0", VA = "0x1804C1AD0")]
		internal void Set(ref QueryFileCallbackInfoInternal other)
		{
		}
	}
}
