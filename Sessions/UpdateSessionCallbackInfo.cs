using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.Sessions
{
	// Token: 0x0200019D RID: 413
	[Token(Token = "0x200019D")]
	public struct UpdateSessionCallbackInfo : ICallbackInfo
	{
		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x06000BE9 RID: 3049 RVA: 0x00004424 File Offset: 0x00002624
		// (set) Token: 0x06000BEA RID: 3050 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170002B4")]
		public Result ResultCode
		{
			[Token(Token = "0x6000BE9")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x6000BEA")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x06000BEB RID: 3051 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000BEC RID: 3052 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170002B5")]
		public object ClientData
		{
			[Token(Token = "0x6000BEB")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000BEC")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x06000BED RID: 3053 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000BEE RID: 3054 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170002B6")]
		public Utf8String SessionName
		{
			[Token(Token = "0x6000BED")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000BEE")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x06000BEF RID: 3055 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000BF0 RID: 3056 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170002B7")]
		public Utf8String SessionId
		{
			[Token(Token = "0x6000BEF")]
			[Address(RVA = "0x3E4B20", Offset = "0x3E3120", VA = "0x1803E4B20")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000BF0")]
			[Address(RVA = "0x488180", Offset = "0x486780", VA = "0x180488180")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000BF1 RID: 3057 RVA: 0x0000443C File Offset: 0x0000263C
		[Token(Token = "0x6000BF1")]
		[Address(RVA = "0x4EB5A0", Offset = "0x4E9BA0", VA = "0x1804EB5A0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x06000BF2 RID: 3058 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BF2")]
		[Address(RVA = "0x4EB5F0", Offset = "0x4E9BF0", VA = "0x1804EB5F0")]
		internal void Set(ref UpdateSessionCallbackInfoInternal other)
		{
		}
	}
}
