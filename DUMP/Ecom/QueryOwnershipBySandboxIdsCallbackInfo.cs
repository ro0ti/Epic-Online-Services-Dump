using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.Ecom
{
	// Token: 0x02000583 RID: 1411
	[Token(Token = "0x2000583")]
	public struct QueryOwnershipBySandboxIdsCallbackInfo : ICallbackInfo
	{
		// Token: 0x17000A82 RID: 2690
		// (get) Token: 0x06002447 RID: 9287 RVA: 0x000097DC File Offset: 0x000079DC
		// (set) Token: 0x06002448 RID: 9288 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A82")]
		public Result ResultCode
		{
			[Token(Token = "0x6002447")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x6002448")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000A83 RID: 2691
		// (get) Token: 0x06002449 RID: 9289 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600244A RID: 9290 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A83")]
		public object ClientData
		{
			[Token(Token = "0x6002449")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600244A")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000A84 RID: 2692
		// (get) Token: 0x0600244B RID: 9291 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600244C RID: 9292 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A84")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x600244B")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600244C")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000A85 RID: 2693
		// (get) Token: 0x0600244D RID: 9293 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600244E RID: 9294 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A85")]
		public SandboxIdItemOwnership[] SandboxIdItemOwnerships
		{
			[Token(Token = "0x600244D")]
			[Address(RVA = "0x3E4B20", Offset = "0x3E3120", VA = "0x1803E4B20")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600244E")]
			[Address(RVA = "0x488180", Offset = "0x486780", VA = "0x180488180")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600244F RID: 9295 RVA: 0x000097F4 File Offset: 0x000079F4
		[Token(Token = "0x600244F")]
		[Address(RVA = "0x54D600", Offset = "0x54BC00", VA = "0x18054D600", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x06002450 RID: 9296 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002450")]
		[Address(RVA = "0x54D650", Offset = "0x54BC50", VA = "0x18054D650")]
		internal void Set(ref QueryOwnershipBySandboxIdsCallbackInfoInternal other)
		{
		}
	}
}
