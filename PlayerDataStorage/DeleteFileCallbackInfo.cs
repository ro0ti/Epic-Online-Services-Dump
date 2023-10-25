using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.PlayerDataStorage
{
	// Token: 0x020002DC RID: 732
	[Token(Token = "0x20002DC")]
	public struct DeleteFileCallbackInfo : ICallbackInfo
	{
		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x060013D2 RID: 5074 RVA: 0x00005B94 File Offset: 0x00003D94
		// (set) Token: 0x060013D3 RID: 5075 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000540")]
		public Result ResultCode
		{
			[Token(Token = "0x60013D2")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x60013D3")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x060013D4 RID: 5076 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060013D5 RID: 5077 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000541")]
		public object ClientData
		{
			[Token(Token = "0x60013D4")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60013D5")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x060013D6 RID: 5078 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060013D7 RID: 5079 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000542")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x60013D6")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60013D7")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060013D8 RID: 5080 RVA: 0x00005BAC File Offset: 0x00003DAC
		[Token(Token = "0x60013D8")]
		[Address(RVA = "0x4EFBB0", Offset = "0x4EE1B0", VA = "0x1804EFBB0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x060013D9 RID: 5081 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013D9")]
		[Address(RVA = "0x4EFC00", Offset = "0x4EE200", VA = "0x1804EFC00")]
		internal void Set(ref DeleteFileCallbackInfoInternal other)
		{
		}
	}
}
