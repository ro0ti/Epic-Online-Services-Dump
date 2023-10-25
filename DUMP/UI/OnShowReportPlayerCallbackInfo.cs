using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.UI
{
	// Token: 0x02000086 RID: 134
	[Token(Token = "0x2000086")]
	public struct OnShowReportPlayerCallbackInfo : ICallbackInfo
	{
		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x06000560 RID: 1376 RVA: 0x00002A8C File Offset: 0x00000C8C
		// (set) Token: 0x06000561 RID: 1377 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000B2")]
		public Result ResultCode
		{
			[Token(Token = "0x6000560")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x6000561")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x06000562 RID: 1378 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000563 RID: 1379 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000B3")]
		public object ClientData
		{
			[Token(Token = "0x6000562")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000563")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x06000564 RID: 1380 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000565 RID: 1381 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000B4")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x6000564")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000565")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x06000566 RID: 1382 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000567 RID: 1383 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000B5")]
		public EpicAccountId TargetUserId
		{
			[Token(Token = "0x6000566")]
			[Address(RVA = "0x3E4B20", Offset = "0x3E3120", VA = "0x1803E4B20")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000567")]
			[Address(RVA = "0x488180", Offset = "0x486780", VA = "0x180488180")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000568 RID: 1384 RVA: 0x00002AA4 File Offset: 0x00000CA4
		[Token(Token = "0x6000568")]
		[Address(RVA = "0x4AC8D0", Offset = "0x4AAED0", VA = "0x1804AC8D0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000569")]
		[Address(RVA = "0x4AC920", Offset = "0x4AAF20", VA = "0x1804AC920")]
		internal void Set(ref OnShowReportPlayerCallbackInfoInternal other)
		{
		}
	}
}
