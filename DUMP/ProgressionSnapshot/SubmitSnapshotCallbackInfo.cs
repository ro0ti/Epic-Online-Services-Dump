using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.ProgressionSnapshot
{
	// Token: 0x0200029D RID: 669
	[Token(Token = "0x200029D")]
	public struct SubmitSnapshotCallbackInfo : ICallbackInfo
	{
		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x06001267 RID: 4711 RVA: 0x000057D4 File Offset: 0x000039D4
		// (set) Token: 0x06001268 RID: 4712 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170004CC")]
		public Result ResultCode
		{
			[Token(Token = "0x6001267")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x6001268")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x06001269 RID: 4713 RVA: 0x000057EC File Offset: 0x000039EC
		// (set) Token: 0x0600126A RID: 4714 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170004CD")]
		public uint SnapshotId
		{
			[Token(Token = "0x6001269")]
			[Address(RVA = "0x4A4D40", Offset = "0x4A3340", VA = "0x1804A4D40")]
			[CompilerGenerated]
			readonly get
			{
				return 0U;
			}
			[Token(Token = "0x600126A")]
			[Address(RVA = "0x4A4E90", Offset = "0x4A3490", VA = "0x1804A4E90")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x0600126B RID: 4715 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600126C RID: 4716 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170004CE")]
		public object ClientData
		{
			[Token(Token = "0x600126B")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600126C")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600126D RID: 4717 RVA: 0x00005804 File Offset: 0x00003A04
		[Token(Token = "0x600126D")]
		[Address(RVA = "0x503C20", Offset = "0x502220", VA = "0x180503C20", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x0600126E RID: 4718 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600126E")]
		[Address(RVA = "0x503C70", Offset = "0x502270", VA = "0x180503C70")]
		internal void Set(ref SubmitSnapshotCallbackInfoInternal other)
		{
		}
	}
}
