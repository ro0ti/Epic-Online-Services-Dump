using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.Friends
{
	// Token: 0x0200051E RID: 1310
	[Token(Token = "0x200051E")]
	public struct RejectInviteCallbackInfo : ICallbackInfo
	{
		// Token: 0x1700097C RID: 2428
		// (get) Token: 0x06002179 RID: 8569 RVA: 0x00008E7C File Offset: 0x0000707C
		// (set) Token: 0x0600217A RID: 8570 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700097C")]
		public Result ResultCode
		{
			[Token(Token = "0x6002179")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x600217A")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700097D RID: 2429
		// (get) Token: 0x0600217B RID: 8571 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600217C RID: 8572 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700097D")]
		public object ClientData
		{
			[Token(Token = "0x600217B")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600217C")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700097E RID: 2430
		// (get) Token: 0x0600217D RID: 8573 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600217E RID: 8574 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700097E")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x600217D")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600217E")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700097F RID: 2431
		// (get) Token: 0x0600217F RID: 8575 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002180 RID: 8576 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700097F")]
		public EpicAccountId TargetUserId
		{
			[Token(Token = "0x600217F")]
			[Address(RVA = "0x3E4B20", Offset = "0x3E3120", VA = "0x1803E4B20")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002180")]
			[Address(RVA = "0x488180", Offset = "0x486780", VA = "0x180488180")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06002181 RID: 8577 RVA: 0x00008E94 File Offset: 0x00007094
		[Token(Token = "0x6002181")]
		[Address(RVA = "0x54FC10", Offset = "0x54E210", VA = "0x18054FC10", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x06002182 RID: 8578 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002182")]
		[Address(RVA = "0x54FC60", Offset = "0x54E260", VA = "0x18054FC60")]
		internal void Set(ref RejectInviteCallbackInfoInternal other)
		{
		}
	}
}
