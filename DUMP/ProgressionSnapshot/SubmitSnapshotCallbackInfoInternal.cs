using System;


namespace Epic.OnlineServices.ProgressionSnapshot
{
	// Token: 0x0200029E RID: 670
	[Token(Token = "0x200029E")]
	internal struct SubmitSnapshotCallbackInfoInternal : ICallbackInfoInternal, IGettable<SubmitSnapshotCallbackInfo>, ISettable<SubmitSnapshotCallbackInfo>, IDisposable
	{
		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x0600126F RID: 4719 RVA: 0x0000581C File Offset: 0x00003A1C
		// (set) Token: 0x06001270 RID: 4720 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170004CF")]
		public Result ResultCode
		{
			[Token(Token = "0x600126F")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x6001270")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x06001271 RID: 4721 RVA: 0x00005834 File Offset: 0x00003A34
		// (set) Token: 0x06001272 RID: 4722 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170004D0")]
		public uint SnapshotId
		{
			[Token(Token = "0x6001271")]
			[Address(RVA = "0x4A4D40", Offset = "0x4A3340", VA = "0x1804A4D40")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001272")]
			[Address(RVA = "0x4A4E90", Offset = "0x4A3490", VA = "0x1804A4E90")]
			set
			{
			}
		}

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x06001273 RID: 4723 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001274 RID: 4724 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170004D1")]
		public object ClientData
		{
			[Token(Token = "0x6001273")]
			[Address(RVA = "0x503B50", Offset = "0x502150", VA = "0x180503B50")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001274")]
			[Address(RVA = "0x503BC0", Offset = "0x5021C0", VA = "0x180503BC0")]
			set
			{
			}
		}

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x06001275 RID: 4725 RVA: 0x0000584C File Offset: 0x00003A4C
		[Token(Token = "0x170004D2")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x6001275")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06001276 RID: 4726 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001276")]
		[Address(RVA = "0x503AE0", Offset = "0x5020E0", VA = "0x180503AE0", Slot = "6")]
		public void Set(ref SubmitSnapshotCallbackInfo other)
		{
		}

		// Token: 0x06001277 RID: 4727 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001277")]
		[Address(RVA = "0x503A00", Offset = "0x502000", VA = "0x180503A00", Slot = "7")]
		public void Set(ref SubmitSnapshotCallbackInfo? other)
		{
		}

		// Token: 0x06001278 RID: 4728 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001278")]
		[Address(RVA = "0x503990", Offset = "0x501F90", VA = "0x180503990", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06001279 RID: 4729 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001279")]
		[Address(RVA = "0x5039E0", Offset = "0x501FE0", VA = "0x1805039E0", Slot = "5")]
		public void Get(out SubmitSnapshotCallbackInfo output)
		{
		}

		// Token: 0x0400082F RID: 2095
		[Token(Token = "0x400082F")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x04000830 RID: 2096
		[Token(Token = "0x4000830")]
		[FieldOffset(Offset = "0x4")]
		private uint m_SnapshotId;

		// Token: 0x04000831 RID: 2097
		[Token(Token = "0x4000831")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;
	}
}
