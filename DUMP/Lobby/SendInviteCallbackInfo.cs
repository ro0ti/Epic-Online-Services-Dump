using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.Lobby
{
	// Token: 0x02000470 RID: 1136
	[Token(Token = "0x2000470")]
	public struct SendInviteCallbackInfo : ICallbackInfo
	{
		// Token: 0x1700083C RID: 2108
		// (get) Token: 0x06001D6C RID: 7532 RVA: 0x0000812C File Offset: 0x0000632C
		// (set) Token: 0x06001D6D RID: 7533 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700083C")]
		public Result ResultCode
		{
			[Token(Token = "0x6001D6C")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x6001D6D")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700083D RID: 2109
		// (get) Token: 0x06001D6E RID: 7534 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001D6F RID: 7535 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700083D")]
		public object ClientData
		{
			[Token(Token = "0x6001D6E")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001D6F")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700083E RID: 2110
		// (get) Token: 0x06001D70 RID: 7536 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001D71 RID: 7537 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700083E")]
		public Utf8String LobbyId
		{
			[Token(Token = "0x6001D70")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001D71")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001D72 RID: 7538 RVA: 0x00008144 File Offset: 0x00006344
		[Token(Token = "0x6001D72")]
		[Address(RVA = "0x5365C0", Offset = "0x534BC0", VA = "0x1805365C0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x06001D73 RID: 7539 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001D73")]
		[Address(RVA = "0x536610", Offset = "0x534C10", VA = "0x180536610")]
		internal void Set(ref SendInviteCallbackInfoInternal other)
		{
		}
	}
}
