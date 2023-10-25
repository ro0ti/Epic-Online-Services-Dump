using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Sessions
{
	// Token: 0x02000182 RID: 386
	[Token(Token = "0x2000182")]
	public struct SessionSearchFindCallbackInfo : ICallbackInfo
	{
		// Token: 0x1700028D RID: 653
		// (get) Token: 0x06000B40 RID: 2880 RVA: 0x0000410C File Offset: 0x0000230C
		// (set) Token: 0x06000B41 RID: 2881 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700028D")]
		public Result ResultCode
		{
			[Token(Token = "0x6000B40")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x6000B41")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x06000B42 RID: 2882 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000B43 RID: 2883 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700028E")]
		public object ClientData
		{
			[Token(Token = "0x6000B42")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000B43")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000B44 RID: 2884 RVA: 0x00004124 File Offset: 0x00002324
		[Token(Token = "0x6000B44")]
		[Address(RVA = "0x4CC170", Offset = "0x4CA770", VA = "0x1804CC170", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x06000B45 RID: 2885 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B45")]
		[Address(RVA = "0x4CC1C0", Offset = "0x4CA7C0", VA = "0x1804CC1C0")]
		internal void Set(ref SessionSearchFindCallbackInfoInternal other)
		{
		}
	}
}
