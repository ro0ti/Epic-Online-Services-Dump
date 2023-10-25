using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.Sanctions
{
	// Token: 0x020001AB RID: 427
	[Token(Token = "0x20001AB")]
	public struct QueryActivePlayerSanctionsCallbackInfo : ICallbackInfo
	{
		// Token: 0x170002CF RID: 719
		// (get) Token: 0x06000C38 RID: 3128 RVA: 0x000044FC File Offset: 0x000026FC
		// (set) Token: 0x06000C39 RID: 3129 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170002CF")]
		public Result ResultCode
		{
			[Token(Token = "0x6000C38")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x6000C39")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x06000C3A RID: 3130 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000C3B RID: 3131 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170002D0")]
		public object ClientData
		{
			[Token(Token = "0x6000C3A")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000C3B")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x06000C3C RID: 3132 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000C3D RID: 3133 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170002D1")]
		public ProductUserId TargetUserId
		{
			[Token(Token = "0x6000C3C")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000C3D")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x06000C3E RID: 3134 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000C3F RID: 3135 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170002D2")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6000C3E")]
			[Address(RVA = "0x3E4B20", Offset = "0x3E3120", VA = "0x1803E4B20")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000C3F")]
			[Address(RVA = "0x488180", Offset = "0x486780", VA = "0x180488180")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000C40 RID: 3136 RVA: 0x00004514 File Offset: 0x00002714
		[Token(Token = "0x6000C40")]
		[Address(RVA = "0x4DF2F0", Offset = "0x4DD8F0", VA = "0x1804DF2F0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x06000C41 RID: 3137 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C41")]
		[Address(RVA = "0x4DF340", Offset = "0x4DD940", VA = "0x1804DF340")]
		internal void Set(ref QueryActivePlayerSanctionsCallbackInfoInternal other)
		{
		}
	}
}
