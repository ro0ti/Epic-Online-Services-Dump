using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.Lobby
{
	// Token: 0x02000466 RID: 1126
	[Token(Token = "0x2000466")]
	public struct QueryInvitesCallbackInfo : ICallbackInfo
	{
		// Token: 0x1700081D RID: 2077
		// (get) Token: 0x06001D1C RID: 7452 RVA: 0x00007FDC File Offset: 0x000061DC
		// (set) Token: 0x06001D1D RID: 7453 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700081D")]
		public Result ResultCode
		{
			[Token(Token = "0x6001D1C")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x6001D1D")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700081E RID: 2078
		// (get) Token: 0x06001D1E RID: 7454 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001D1F RID: 7455 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700081E")]
		public object ClientData
		{
			[Token(Token = "0x6001D1E")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001D1F")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700081F RID: 2079
		// (get) Token: 0x06001D20 RID: 7456 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001D21 RID: 7457 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700081F")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6001D20")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001D21")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001D22 RID: 7458 RVA: 0x00007FF4 File Offset: 0x000061F4
		[Token(Token = "0x6001D22")]
		[Address(RVA = "0x532AF0", Offset = "0x5310F0", VA = "0x180532AF0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x06001D23 RID: 7459 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001D23")]
		[Address(RVA = "0x532B40", Offset = "0x531140", VA = "0x180532B40")]
		internal void Set(ref QueryInvitesCallbackInfoInternal other)
		{
		}
	}
}
