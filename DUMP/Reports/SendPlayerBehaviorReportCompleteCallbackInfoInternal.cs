using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Reports
{
	// Token: 0x0200028B RID: 651
	[Token(Token = "0x200028B")]
	internal struct SendPlayerBehaviorReportCompleteCallbackInfoInternal : ICallbackInfoInternal, IGettable<SendPlayerBehaviorReportCompleteCallbackInfo>, ISettable<SendPlayerBehaviorReportCompleteCallbackInfo>, IDisposable
	{
		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x06001202 RID: 4610 RVA: 0x000056B4 File Offset: 0x000038B4
		// (set) Token: 0x06001203 RID: 4611 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170004AC")]
		public Result ResultCode
		{
			[Token(Token = "0x6001202")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x6001203")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x06001204 RID: 4612 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001205 RID: 4613 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170004AD")]
		public object ClientData
		{
			[Token(Token = "0x6001204")]
			[Address(RVA = "0x5021B0", Offset = "0x5007B0", VA = "0x1805021B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001205")]
			[Address(RVA = "0x502220", Offset = "0x500820", VA = "0x180502220")]
			set
			{
			}
		}

		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x06001206 RID: 4614 RVA: 0x000056CC File Offset: 0x000038CC
		[Token(Token = "0x170004AE")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x6001206")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06001207 RID: 4615 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001207")]
		[Address(RVA = "0x502090", Offset = "0x500690", VA = "0x180502090", Slot = "6")]
		public void Set(ref SendPlayerBehaviorReportCompleteCallbackInfo other)
		{
		}

		// Token: 0x06001208 RID: 4616 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001208")]
		[Address(RVA = "0x5020F0", Offset = "0x5006F0", VA = "0x1805020F0", Slot = "7")]
		public void Set(ref SendPlayerBehaviorReportCompleteCallbackInfo? other)
		{
		}

		// Token: 0x06001209 RID: 4617 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001209")]
		[Address(RVA = "0x502020", Offset = "0x500620", VA = "0x180502020", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x0600120A RID: 4618 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600120A")]
		[Address(RVA = "0x502070", Offset = "0x500670", VA = "0x180502070", Slot = "5")]
		public void Get(out SendPlayerBehaviorReportCompleteCallbackInfo output)
		{
		}

		// Token: 0x04000803 RID: 2051
		[Token(Token = "0x4000803")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x04000804 RID: 2052
		[Token(Token = "0x4000804")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;
	}
}
