using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.RTCAudio
{
	// Token: 0x020001F0 RID: 496
	[Token(Token = "0x20001F0")]
	public struct OnQueryOutputDevicesInformationCallbackInfo : ICallbackInfo
	{
		// Token: 0x17000340 RID: 832
		// (get) Token: 0x06000DB3 RID: 3507 RVA: 0x00004904 File Offset: 0x00002B04
		// (set) Token: 0x06000DB4 RID: 3508 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000340")]
		public Result ResultCode
		{
			[Token(Token = "0x6000DB3")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x6000DB4")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x06000DB5 RID: 3509 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000DB6 RID: 3510 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000341")]
		public object ClientData
		{
			[Token(Token = "0x6000DB5")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000DB6")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000DB7 RID: 3511 RVA: 0x0000491C File Offset: 0x00002B1C
		[Token(Token = "0x6000DB7")]
		[Address(RVA = "0x4DB560", Offset = "0x4D9B60", VA = "0x1804DB560", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x06000DB8 RID: 3512 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000DB8")]
		[Address(RVA = "0x4DB5B0", Offset = "0x4D9BB0", VA = "0x1804DB5B0")]
		internal void Set(ref OnQueryOutputDevicesInformationCallbackInfoInternal other)
		{
		}
	}
}
