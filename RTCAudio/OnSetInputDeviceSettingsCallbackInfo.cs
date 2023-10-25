using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.RTCAudio
{
	// Token: 0x020001F8 RID: 504
	[Token(Token = "0x20001F8")]
	public struct OnSetInputDeviceSettingsCallbackInfo : ICallbackInfo
	{
		// Token: 0x1700034C RID: 844
		// (get) Token: 0x06000DE5 RID: 3557 RVA: 0x000049C4 File Offset: 0x00002BC4
		// (set) Token: 0x06000DE6 RID: 3558 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700034C")]
		public Result ResultCode
		{
			[Token(Token = "0x6000DE5")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x6000DE6")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x06000DE7 RID: 3559 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000DE8 RID: 3560 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700034D")]
		public object ClientData
		{
			[Token(Token = "0x6000DE7")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000DE8")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700034E RID: 846
		// (get) Token: 0x06000DE9 RID: 3561 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000DEA RID: 3562 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700034E")]
		public Utf8String RealDeviceId
		{
			[Token(Token = "0x6000DE9")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000DEA")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000DEB RID: 3563 RVA: 0x000049DC File Offset: 0x00002BDC
		[Token(Token = "0x6000DEB")]
		[Address(RVA = "0x4DC1B0", Offset = "0x4DA7B0", VA = "0x1804DC1B0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x06000DEC RID: 3564 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000DEC")]
		[Address(RVA = "0x4DC200", Offset = "0x4DA800", VA = "0x1804DC200")]
		internal void Set(ref OnSetInputDeviceSettingsCallbackInfoInternal other)
		{
		}
	}
}
