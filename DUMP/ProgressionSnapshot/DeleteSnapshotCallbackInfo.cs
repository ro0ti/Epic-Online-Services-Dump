using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.ProgressionSnapshot
{
	// Token: 0x02000292 RID: 658
	[Token(Token = "0x2000292")]
	public struct DeleteSnapshotCallbackInfo : ICallbackInfo
	{
		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x0600122F RID: 4655 RVA: 0x00005714 File Offset: 0x00003914
		// (set) Token: 0x06001230 RID: 4656 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170004C1")]
		public Result ResultCode
		{
			[Token(Token = "0x600122F")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x6001230")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x06001231 RID: 4657 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001232 RID: 4658 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170004C2")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6001231")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001232")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x06001233 RID: 4659 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001234 RID: 4660 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170004C3")]
		public object ClientData
		{
			[Token(Token = "0x6001233")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001234")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001235 RID: 4661 RVA: 0x0000572C File Offset: 0x0000392C
		[Token(Token = "0x6001235")]
		[Address(RVA = "0x4F03B0", Offset = "0x4EE9B0", VA = "0x1804F03B0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x06001236 RID: 4662 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001236")]
		[Address(RVA = "0x4F0400", Offset = "0x4EEA00", VA = "0x1804F0400")]
		internal void Set(ref DeleteSnapshotCallbackInfoInternal other)
		{
		}
	}
}
