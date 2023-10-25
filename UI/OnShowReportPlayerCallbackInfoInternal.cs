using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.UI
{
	// Token: 0x02000087 RID: 135
	[Token(Token = "0x2000087")]
	internal struct OnShowReportPlayerCallbackInfoInternal : ICallbackInfoInternal, IGettable<OnShowReportPlayerCallbackInfo>, ISettable<OnShowReportPlayerCallbackInfo>, IDisposable
	{
		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x0600056A RID: 1386 RVA: 0x00002ABC File Offset: 0x00000CBC
		// (set) Token: 0x0600056B RID: 1387 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000B6")]
		public Result ResultCode
		{
			[Token(Token = "0x600056A")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x600056B")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x0600056C RID: 1388 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600056D RID: 1389 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000B7")]
		public object ClientData
		{
			[Token(Token = "0x600056C")]
			[Address(RVA = "0x4AC530", Offset = "0x4AAB30", VA = "0x1804AC530")]
			get
			{
				return null;
			}
			[Token(Token = "0x600056D")]
			[Address(RVA = "0x4AC6D0", Offset = "0x4AACD0", VA = "0x1804AC6D0")]
			set
			{
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x0600056E RID: 1390 RVA: 0x00002AD4 File Offset: 0x00000CD4
		[Token(Token = "0x170000B8")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x600056E")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x0600056F RID: 1391 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000570 RID: 1392 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000B9")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x600056F")]
			[Address(RVA = "0x4AC5D0", Offset = "0x4AABD0", VA = "0x1804AC5D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000570")]
			[Address(RVA = "0x4AC770", Offset = "0x4AAD70", VA = "0x1804AC770")]
			set
			{
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x06000571 RID: 1393 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000572 RID: 1394 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000BA")]
		public EpicAccountId TargetUserId
		{
			[Token(Token = "0x6000571")]
			[Address(RVA = "0x4AC650", Offset = "0x4AAC50", VA = "0x1804AC650")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000572")]
			[Address(RVA = "0x4AC820", Offset = "0x4AAE20", VA = "0x1804AC820")]
			set
			{
			}
		}

		// Token: 0x06000573 RID: 1395 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000573")]
		[Address(RVA = "0x4AC400", Offset = "0x4AAA00", VA = "0x1804AC400", Slot = "6")]
		public void Set(ref OnShowReportPlayerCallbackInfo other)
		{
		}

		// Token: 0x06000574 RID: 1396 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000574")]
		[Address(RVA = "0x4AC450", Offset = "0x4AAA50", VA = "0x1804AC450", Slot = "7")]
		public void Set(ref OnShowReportPlayerCallbackInfo? other)
		{
		}

		// Token: 0x06000575 RID: 1397 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000575")]
		[Address(RVA = "0x4AC260", Offset = "0x4AA860", VA = "0x1804AC260", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06000576 RID: 1398 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000576")]
		[Address(RVA = "0x4AC380", Offset = "0x4AA980", VA = "0x1804AC380", Slot = "5")]
		public void Get(out OnShowReportPlayerCallbackInfo output)
		{
		}

		// Token: 0x040002BE RID: 702
		[Token(Token = "0x40002BE")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x040002BF RID: 703
		[Token(Token = "0x40002BF")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;

		// Token: 0x040002C0 RID: 704
		[Token(Token = "0x40002C0")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LocalUserId;

		// Token: 0x040002C1 RID: 705
		[Token(Token = "0x40002C1")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_TargetUserId;
	}
}
