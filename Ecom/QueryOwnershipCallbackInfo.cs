using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.Ecom
{
	// Token: 0x02000587 RID: 1415
	[Token(Token = "0x2000587")]
	public struct QueryOwnershipCallbackInfo : ICallbackInfo
	{
		// Token: 0x17000A8F RID: 2703
		// (get) Token: 0x06002467 RID: 9319 RVA: 0x0000983C File Offset: 0x00007A3C
		// (set) Token: 0x06002468 RID: 9320 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A8F")]
		public Result ResultCode
		{
			[Token(Token = "0x6002467")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x6002468")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000A90 RID: 2704
		// (get) Token: 0x06002469 RID: 9321 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600246A RID: 9322 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A90")]
		public object ClientData
		{
			[Token(Token = "0x6002469")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600246A")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000A91 RID: 2705
		// (get) Token: 0x0600246B RID: 9323 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600246C RID: 9324 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A91")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x600246B")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600246C")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000A92 RID: 2706
		// (get) Token: 0x0600246D RID: 9325 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600246E RID: 9326 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A92")]
		public ItemOwnership[] ItemOwnership
		{
			[Token(Token = "0x600246D")]
			[Address(RVA = "0x3E4B20", Offset = "0x3E3120", VA = "0x1803E4B20")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600246E")]
			[Address(RVA = "0x488180", Offset = "0x486780", VA = "0x180488180")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600246F RID: 9327 RVA: 0x00009854 File Offset: 0x00007A54
		[Token(Token = "0x600246F")]
		[Address(RVA = "0x54DF20", Offset = "0x54C520", VA = "0x18054DF20", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x06002470 RID: 9328 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002470")]
		[Address(RVA = "0x54DF70", Offset = "0x54C570", VA = "0x18054DF70")]
		internal void Set(ref QueryOwnershipCallbackInfoInternal other)
		{
		}
	}
}
