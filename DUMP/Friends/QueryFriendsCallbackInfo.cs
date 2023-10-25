using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.Friends
{
	// Token: 0x0200051A RID: 1306
	[Token(Token = "0x200051A")]
	public struct QueryFriendsCallbackInfo : ICallbackInfo
	{
		// Token: 0x17000973 RID: 2419
		// (get) Token: 0x06002160 RID: 8544 RVA: 0x00008E1C File Offset: 0x0000701C
		// (set) Token: 0x06002161 RID: 8545 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000973")]
		public Result ResultCode
		{
			[Token(Token = "0x6002160")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x6002161")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000974 RID: 2420
		// (get) Token: 0x06002162 RID: 8546 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002163 RID: 8547 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000974")]
		public object ClientData
		{
			[Token(Token = "0x6002162")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002163")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000975 RID: 2421
		// (get) Token: 0x06002164 RID: 8548 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002165 RID: 8549 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000975")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x6002164")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002165")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06002166 RID: 8550 RVA: 0x00008E34 File Offset: 0x00007034
		[Token(Token = "0x6002166")]
		[Address(RVA = "0x54C5F0", Offset = "0x54ABF0", VA = "0x18054C5F0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x06002167 RID: 8551 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002167")]
		[Address(RVA = "0x54C640", Offset = "0x54AC40", VA = "0x18054C640")]
		internal void Set(ref QueryFriendsCallbackInfoInternal other)
		{
		}
	}
}
