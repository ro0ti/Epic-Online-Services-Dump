using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.Lobby
{
	// Token: 0x0200041E RID: 1054
	[Token(Token = "0x200041E")]
	public struct LobbySearchFindCallbackInfo : ICallbackInfo
	{
		// Token: 0x170007EC RID: 2028
		// (get) Token: 0x06001BDF RID: 7135 RVA: 0x00007DCC File Offset: 0x00005FCC
		// (set) Token: 0x06001BE0 RID: 7136 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170007EC")]
		public Result ResultCode
		{
			[Token(Token = "0x6001BDF")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x6001BE0")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170007ED RID: 2029
		// (get) Token: 0x06001BE1 RID: 7137 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001BE2 RID: 7138 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170007ED")]
		public object ClientData
		{
			[Token(Token = "0x6001BE1")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001BE2")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001BE3 RID: 7139 RVA: 0x00007DE4 File Offset: 0x00005FE4
		[Token(Token = "0x6001BE3")]
		[Address(RVA = "0x52B8B0", Offset = "0x529EB0", VA = "0x18052B8B0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x06001BE4 RID: 7140 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001BE4")]
		[Address(RVA = "0x52B900", Offset = "0x529F00", VA = "0x18052B900")]
		internal void Set(ref LobbySearchFindCallbackInfoInternal other)
		{
		}
	}
}
