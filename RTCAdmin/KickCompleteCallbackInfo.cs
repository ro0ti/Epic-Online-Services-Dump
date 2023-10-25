using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.RTCAdmin
{
	// Token: 0x02000242 RID: 578
	[Token(Token = "0x2000242")]
	public struct KickCompleteCallbackInfo : ICallbackInfo
	{
		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x06000FFA RID: 4090 RVA: 0x00005174 File Offset: 0x00003374
		// (set) Token: 0x06000FFB RID: 4091 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170003FF")]
		public Result ResultCode
		{
			[Token(Token = "0x6000FFA")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x6000FFB")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x06000FFC RID: 4092 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000FFD RID: 4093 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000400")]
		public object ClientData
		{
			[Token(Token = "0x6000FFC")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000FFD")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000FFE RID: 4094 RVA: 0x0000518C File Offset: 0x0000338C
		[Token(Token = "0x6000FFE")]
		[Address(RVA = "0x4DA0D0", Offset = "0x4D86D0", VA = "0x1804DA0D0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x06000FFF RID: 4095 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000FFF")]
		[Address(RVA = "0x4DA120", Offset = "0x4D8720", VA = "0x1804DA120")]
		internal void Set(ref KickCompleteCallbackInfoInternal other)
		{
		}
	}
}
