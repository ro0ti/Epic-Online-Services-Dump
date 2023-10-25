using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.RTCAudio
{
	// Token: 0x020001EC RID: 492
	[Token(Token = "0x20001EC")]
	public struct OnQueryInputDevicesInformationCallbackInfo : ICallbackInfo
	{
		// Token: 0x1700033B RID: 827
		// (get) Token: 0x06000D9C RID: 3484 RVA: 0x000048A4 File Offset: 0x00002AA4
		// (set) Token: 0x06000D9D RID: 3485 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700033B")]
		public Result ResultCode
		{
			[Token(Token = "0x6000D9C")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x6000D9D")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x06000D9E RID: 3486 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000D9F RID: 3487 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700033C")]
		public object ClientData
		{
			[Token(Token = "0x6000D9E")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000D9F")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000DA0 RID: 3488 RVA: 0x000048BC File Offset: 0x00002ABC
		[Token(Token = "0x6000DA0")]
		[Address(RVA = "0x4DAFF0", Offset = "0x4D95F0", VA = "0x1804DAFF0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x06000DA1 RID: 3489 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000DA1")]
		[Address(RVA = "0x4DB040", Offset = "0x4D9640", VA = "0x1804DB040")]
		internal void Set(ref OnQueryInputDevicesInformationCallbackInfoInternal other)
		{
		}
	}
}
