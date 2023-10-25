using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.Connect
{
	// Token: 0x020005F9 RID: 1529
	[Token(Token = "0x20005F9")]
	public struct CreateDeviceIdCallbackInfo : ICallbackInfo
	{
		// Token: 0x17000B61 RID: 2913
		// (get) Token: 0x06002740 RID: 10048 RVA: 0x00009FBC File Offset: 0x000081BC
		// (set) Token: 0x06002741 RID: 10049 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B61")]
		public Result ResultCode
		{
			[Token(Token = "0x6002740")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x6002741")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000B62 RID: 2914
		// (get) Token: 0x06002742 RID: 10050 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002743 RID: 10051 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B62")]
		public object ClientData
		{
			[Token(Token = "0x6002742")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002743")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06002744 RID: 10052 RVA: 0x00009FD4 File Offset: 0x000081D4
		[Token(Token = "0x6002744")]
		[Address(RVA = "0x558710", Offset = "0x556D10", VA = "0x180558710", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x06002745 RID: 10053 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002745")]
		[Address(RVA = "0x558760", Offset = "0x556D60", VA = "0x180558760")]
		internal void Set(ref CreateDeviceIdCallbackInfoInternal other)
		{
		}
	}
}
