using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Connect
{
	// Token: 0x02000603 RID: 1539
	[Token(Token = "0x2000603")]
	public struct DeleteDeviceIdCallbackInfo : ICallbackInfo
	{
		// Token: 0x17000B75 RID: 2933
		// (get) Token: 0x0600277B RID: 10107 RVA: 0x0000A0AC File Offset: 0x000082AC
		// (set) Token: 0x0600277C RID: 10108 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B75")]
		public Result ResultCode
		{
			[Token(Token = "0x600277B")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x600277C")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000B76 RID: 2934
		// (get) Token: 0x0600277D RID: 10109 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600277E RID: 10110 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B76")]
		public object ClientData
		{
			[Token(Token = "0x600277D")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600277E")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600277F RID: 10111 RVA: 0x0000A0C4 File Offset: 0x000082C4
		[Token(Token = "0x600277F")]
		[Address(RVA = "0x559B40", Offset = "0x558140", VA = "0x180559B40", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x06002780 RID: 10112 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002780")]
		[Address(RVA = "0x559B90", Offset = "0x558190", VA = "0x180559B90")]
		internal void Set(ref DeleteDeviceIdCallbackInfoInternal other)
		{
		}
	}
}
