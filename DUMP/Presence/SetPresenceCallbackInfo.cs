using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.Presence
{
	// Token: 0x020002CD RID: 717
	[Token(Token = "0x20002CD")]
	public struct SetPresenceCallbackInfo : ICallbackInfo
	{
		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x06001383 RID: 4995 RVA: 0x00005ABC File Offset: 0x00003CBC
		// (set) Token: 0x06001384 RID: 4996 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000524")]
		public Result ResultCode
		{
			[Token(Token = "0x6001383")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x6001384")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x06001385 RID: 4997 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001386 RID: 4998 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000525")]
		public object ClientData
		{
			[Token(Token = "0x6001385")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001386")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x06001387 RID: 4999 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001388 RID: 5000 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000526")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x6001387")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001388")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001389 RID: 5001 RVA: 0x00005AD4 File Offset: 0x00003CD4
		[Token(Token = "0x6001389")]
		[Address(RVA = "0x502C80", Offset = "0x501280", VA = "0x180502C80", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x0600138A RID: 5002 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600138A")]
		[Address(RVA = "0x502CD0", Offset = "0x5012D0", VA = "0x180502CD0")]
		internal void Set(ref SetPresenceCallbackInfoInternal other)
		{
		}
	}
}
