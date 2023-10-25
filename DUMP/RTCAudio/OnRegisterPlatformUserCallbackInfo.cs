using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.RTCAudio
{
	// Token: 0x020001F4 RID: 500
	[Token(Token = "0x20001F4")]
	public struct OnRegisterPlatformUserCallbackInfo : ICallbackInfo
	{
		// Token: 0x17000345 RID: 837
		// (get) Token: 0x06000DCA RID: 3530 RVA: 0x00004964 File Offset: 0x00002B64
		// (set) Token: 0x06000DCB RID: 3531 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000345")]
		public Result ResultCode
		{
			[Token(Token = "0x6000DCA")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x6000DCB")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x06000DCC RID: 3532 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000DCD RID: 3533 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000346")]
		public object ClientData
		{
			[Token(Token = "0x6000DCC")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000DCD")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x06000DCE RID: 3534 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000DCF RID: 3535 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000347")]
		public Utf8String PlatformUserId
		{
			[Token(Token = "0x6000DCE")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000DCF")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000DD0 RID: 3536 RVA: 0x0000497C File Offset: 0x00002B7C
		[Token(Token = "0x6000DD0")]
		[Address(RVA = "0x4DBB50", Offset = "0x4DA150", VA = "0x1804DBB50", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x06000DD1 RID: 3537 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000DD1")]
		[Address(RVA = "0x4DBBA0", Offset = "0x4DA1A0", VA = "0x1804DBBA0")]
		internal void Set(ref OnRegisterPlatformUserCallbackInfoInternal other)
		{
		}
	}
}
