using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.RTCAudio
{
	// Token: 0x020001FC RID: 508
	[Token(Token = "0x20001FC")]
	public struct OnSetOutputDeviceSettingsCallbackInfo : ICallbackInfo
	{
		// Token: 0x17000353 RID: 851
		// (get) Token: 0x06000E00 RID: 3584 RVA: 0x00004A24 File Offset: 0x00002C24
		// (set) Token: 0x06000E01 RID: 3585 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000353")]
		public Result ResultCode
		{
			[Token(Token = "0x6000E00")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x6000E01")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000354 RID: 852
		// (get) Token: 0x06000E02 RID: 3586 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000E03 RID: 3587 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000354")]
		public object ClientData
		{
			[Token(Token = "0x6000E02")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000E03")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000355 RID: 853
		// (get) Token: 0x06000E04 RID: 3588 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000E05 RID: 3589 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000355")]
		public Utf8String RealDeviceId
		{
			[Token(Token = "0x6000E04")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000E05")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000E06 RID: 3590 RVA: 0x00004A3C File Offset: 0x00002C3C
		[Token(Token = "0x6000E06")]
		[Address(RVA = "0x4DC810", Offset = "0x4DAE10", VA = "0x1804DC810", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x06000E07 RID: 3591 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000E07")]
		[Address(RVA = "0x4DC860", Offset = "0x4DAE60", VA = "0x1804DC860")]
		internal void Set(ref OnSetOutputDeviceSettingsCallbackInfoInternal other)
		{
		}
	}
}
