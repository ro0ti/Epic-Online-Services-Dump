using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.Lobby
{
	// Token: 0x02000462 RID: 1122
	[Token(Token = "0x2000462")]
	public struct PromoteMemberCallbackInfo : ICallbackInfo
	{
		// Token: 0x17000810 RID: 2064
		// (get) Token: 0x06001CFD RID: 7421 RVA: 0x00007F7C File Offset: 0x0000617C
		// (set) Token: 0x06001CFE RID: 7422 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000810")]
		public Result ResultCode
		{
			[Token(Token = "0x6001CFD")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x6001CFE")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000811 RID: 2065
		// (get) Token: 0x06001CFF RID: 7423 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001D00 RID: 7424 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000811")]
		public object ClientData
		{
			[Token(Token = "0x6001CFF")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001D00")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000812 RID: 2066
		// (get) Token: 0x06001D01 RID: 7425 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001D02 RID: 7426 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000812")]
		public Utf8String LobbyId
		{
			[Token(Token = "0x6001D01")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001D02")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001D03 RID: 7427 RVA: 0x00007F94 File Offset: 0x00006194
		[Token(Token = "0x6001D03")]
		[Address(RVA = "0x531BF0", Offset = "0x5301F0", VA = "0x180531BF0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x06001D04 RID: 7428 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001D04")]
		[Address(RVA = "0x531C40", Offset = "0x530240", VA = "0x180531C40")]
		internal void Set(ref PromoteMemberCallbackInfoInternal other)
		{
		}
	}
}
