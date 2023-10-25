using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.Auth
{
	// Token: 0x02000689 RID: 1673
	[Token(Token = "0x2000689")]
	public struct VerifyUserAuthCallbackInfo : ICallbackInfo
	{
		// Token: 0x17000C9D RID: 3229
		// (get) Token: 0x06002B19 RID: 11033 RVA: 0x0000ABD4 File Offset: 0x00008DD4
		// (set) Token: 0x06002B1A RID: 11034 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C9D")]
		public Result ResultCode
		{
			[Token(Token = "0x6002B19")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x6002B1A")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000C9E RID: 3230
		// (get) Token: 0x06002B1B RID: 11035 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002B1C RID: 11036 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C9E")]
		public object ClientData
		{
			[Token(Token = "0x6002B1B")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002B1C")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06002B1D RID: 11037 RVA: 0x0000ABEC File Offset: 0x00008DEC
		[Token(Token = "0x6002B1D")]
		[Address(RVA = "0x5821F0", Offset = "0x5807F0", VA = "0x1805821F0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x06002B1E RID: 11038 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002B1E")]
		[Address(RVA = "0x582240", Offset = "0x580840", VA = "0x180582240")]
		internal void Set(ref VerifyUserAuthCallbackInfoInternal other)
		{
		}
	}
}
