using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.UI
{
	// Token: 0x0200007F RID: 127
	[Token(Token = "0x200007F")]
	internal struct OnShowBlockPlayerCallbackInfoInternal : ICallbackInfoInternal, IGettable<OnShowBlockPlayerCallbackInfo>, ISettable<OnShowBlockPlayerCallbackInfo>, IDisposable
	{
		// Token: 0x170000AD RID: 173
		// (get) Token: 0x0600053B RID: 1339 RVA: 0x00002A5C File Offset: 0x00000C5C
		// (set) Token: 0x0600053C RID: 1340 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000AD")]
		public Result ResultCode
		{
			[Token(Token = "0x600053B")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x600053C")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x0600053D RID: 1341 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600053E RID: 1342 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000AE")]
		public object ClientData
		{
			[Token(Token = "0x600053D")]
			[Address(RVA = "0x4ABAA0", Offset = "0x4AA0A0", VA = "0x1804ABAA0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600053E")]
			[Address(RVA = "0x4ABC40", Offset = "0x4AA240", VA = "0x1804ABC40")]
			set
			{
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x0600053F RID: 1343 RVA: 0x00002A74 File Offset: 0x00000C74
		[Token(Token = "0x170000AF")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x600053F")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x06000540 RID: 1344 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000541 RID: 1345 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000B0")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x6000540")]
			[Address(RVA = "0x4ABB40", Offset = "0x4AA140", VA = "0x1804ABB40")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000541")]
			[Address(RVA = "0x4ABCE0", Offset = "0x4AA2E0", VA = "0x1804ABCE0")]
			set
			{
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x06000542 RID: 1346 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000543 RID: 1347 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000B1")]
		public EpicAccountId TargetUserId
		{
			[Token(Token = "0x6000542")]
			[Address(RVA = "0x4ABBC0", Offset = "0x4AA1C0", VA = "0x1804ABBC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000543")]
			[Address(RVA = "0x4ABD90", Offset = "0x4AA390", VA = "0x1804ABD90")]
			set
			{
			}
		}

		// Token: 0x06000544 RID: 1348 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000544")]
		[Address(RVA = "0x4AB970", Offset = "0x4A9F70", VA = "0x1804AB970", Slot = "6")]
		public void Set(ref OnShowBlockPlayerCallbackInfo other)
		{
		}

		// Token: 0x06000545 RID: 1349 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000545")]
		[Address(RVA = "0x4AB9C0", Offset = "0x4A9FC0", VA = "0x1804AB9C0", Slot = "7")]
		public void Set(ref OnShowBlockPlayerCallbackInfo? other)
		{
		}

		// Token: 0x06000546 RID: 1350 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000546")]
		[Address(RVA = "0x4AB7D0", Offset = "0x4A9DD0", VA = "0x1804AB7D0", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06000547 RID: 1351 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000547")]
		[Address(RVA = "0x4AB8F0", Offset = "0x4A9EF0", VA = "0x1804AB8F0", Slot = "5")]
		public void Get(out OnShowBlockPlayerCallbackInfo output)
		{
		}

		// Token: 0x040002B6 RID: 694
		[Token(Token = "0x40002B6")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x040002B7 RID: 695
		[Token(Token = "0x40002B7")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;

		// Token: 0x040002B8 RID: 696
		[Token(Token = "0x40002B8")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LocalUserId;

		// Token: 0x040002B9 RID: 697
		[Token(Token = "0x40002B9")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_TargetUserId;
	}
}
