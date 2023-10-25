using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.RTCAudio
{
	// Token: 0x02000200 RID: 512
	[Token(Token = "0x2000200")]
	public struct OnUnregisterPlatformUserCallbackInfo : ICallbackInfo
	{
		// Token: 0x1700035A RID: 858
		// (get) Token: 0x06000E1B RID: 3611 RVA: 0x00004A84 File Offset: 0x00002C84
		// (set) Token: 0x06000E1C RID: 3612 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700035A")]
		public Result ResultCode
		{
			[Token(Token = "0x6000E1B")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x6000E1C")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700035B RID: 859
		// (get) Token: 0x06000E1D RID: 3613 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000E1E RID: 3614 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700035B")]
		public object ClientData
		{
			[Token(Token = "0x6000E1D")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000E1E")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x06000E1F RID: 3615 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000E20 RID: 3616 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700035C")]
		public Utf8String PlatformUserId
		{
			[Token(Token = "0x6000E1F")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000E20")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000E21 RID: 3617 RVA: 0x00004A9C File Offset: 0x00002C9C
		[Token(Token = "0x6000E21")]
		[Address(RVA = "0x4DCF90", Offset = "0x4DB590", VA = "0x1804DCF90", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x06000E22 RID: 3618 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000E22")]
		[Address(RVA = "0x4DCFE0", Offset = "0x4DB5E0", VA = "0x1804DCFE0")]
		internal void Set(ref OnUnregisterPlatformUserCallbackInfoInternal other)
		{
		}
	}
}
