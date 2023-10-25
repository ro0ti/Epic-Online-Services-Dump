using System;


namespace Epic.OnlineServices.RTCAdmin
{
	// Token: 0x02000252 RID: 594
	[Token(Token = "0x2000252")]
	internal struct SetParticipantHardMuteCompleteCallbackInfoInternal : ICallbackInfoInternal, IGettable<SetParticipantHardMuteCompleteCallbackInfo>, ISettable<SetParticipantHardMuteCompleteCallbackInfo>, IDisposable
	{
		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x06001068 RID: 4200 RVA: 0x000052F4 File Offset: 0x000034F4
		// (set) Token: 0x06001069 RID: 4201 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700041F")]
		public Result ResultCode
		{
			[Token(Token = "0x6001068")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x6001069")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x0600106A RID: 4202 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600106B RID: 4203 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000420")]
		public object ClientData
		{
			[Token(Token = "0x600106A")]
			[Address(RVA = "0x4E5FE0", Offset = "0x4E45E0", VA = "0x1804E5FE0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600106B")]
			[Address(RVA = "0x4E6050", Offset = "0x4E4650", VA = "0x1804E6050")]
			set
			{
			}
		}

		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x0600106C RID: 4204 RVA: 0x0000530C File Offset: 0x0000350C
		[Token(Token = "0x17000421")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x600106C")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600106D RID: 4205 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600106D")]
		[Address(RVA = "0x4E5F80", Offset = "0x4E4580", VA = "0x1804E5F80", Slot = "6")]
		public void Set(ref SetParticipantHardMuteCompleteCallbackInfo other)
		{
		}

		// Token: 0x0600106E RID: 4206 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600106E")]
		[Address(RVA = "0x4E5EC0", Offset = "0x4E44C0", VA = "0x1804E5EC0", Slot = "7")]
		public void Set(ref SetParticipantHardMuteCompleteCallbackInfo? other)
		{
		}

		// Token: 0x0600106F RID: 4207 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600106F")]
		[Address(RVA = "0x4E5E50", Offset = "0x4E4450", VA = "0x1804E5E50", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06001070 RID: 4208 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001070")]
		[Address(RVA = "0x4E5EA0", Offset = "0x4E44A0", VA = "0x1804E5EA0", Slot = "5")]
		public void Get(out SetParticipantHardMuteCompleteCallbackInfo output)
		{
		}

		// Token: 0x0400074E RID: 1870
		[Token(Token = "0x400074E")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x0400074F RID: 1871
		[Token(Token = "0x400074F")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;
	}
}
