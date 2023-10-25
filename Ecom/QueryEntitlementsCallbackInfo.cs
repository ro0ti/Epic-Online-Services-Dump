using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.Ecom
{
	// Token: 0x02000577 RID: 1399
	[Token(Token = "0x2000577")]
	public struct QueryEntitlementsCallbackInfo : ICallbackInfo
	{
		// Token: 0x17000A5D RID: 2653
		// (get) Token: 0x060023EC RID: 9196 RVA: 0x000096A4 File Offset: 0x000078A4
		// (set) Token: 0x060023ED RID: 9197 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A5D")]
		public Result ResultCode
		{
			[Token(Token = "0x60023EC")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x60023ED")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000A5E RID: 2654
		// (get) Token: 0x060023EE RID: 9198 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060023EF RID: 9199 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A5E")]
		public object ClientData
		{
			[Token(Token = "0x60023EE")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60023EF")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000A5F RID: 2655
		// (get) Token: 0x060023F0 RID: 9200 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060023F1 RID: 9201 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A5F")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x60023F0")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60023F1")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060023F2 RID: 9202 RVA: 0x000096BC File Offset: 0x000078BC
		[Token(Token = "0x60023F2")]
		[Address(RVA = "0x54BD40", Offset = "0x54A340", VA = "0x18054BD40", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x060023F3 RID: 9203 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60023F3")]
		[Address(RVA = "0x54BD90", Offset = "0x54A390", VA = "0x18054BD90")]
		internal void Set(ref QueryEntitlementsCallbackInfoInternal other)
		{
		}
	}
}
