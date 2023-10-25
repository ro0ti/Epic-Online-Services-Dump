using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Sessions
{
	// Token: 0x02000121 RID: 289
	[Token(Token = "0x2000121")]
	internal struct LeaveSessionRequestedCallbackInfoInternal : ICallbackInfoInternal, IGettable<LeaveSessionRequestedCallbackInfo>, ISettable<LeaveSessionRequestedCallbackInfo>, IDisposable
	{
		// Token: 0x170001FB RID: 507
		// (get) Token: 0x06000922 RID: 2338 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000923 RID: 2339 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001FB")]
		public object ClientData
		{
			[Token(Token = "0x6000922")]
			[Address(RVA = "0x4BF050", Offset = "0x4BD650", VA = "0x1804BF050")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000923")]
			[Address(RVA = "0x4BF1B0", Offset = "0x4BD7B0", VA = "0x1804BF1B0")]
			set
			{
			}
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x06000924 RID: 2340 RVA: 0x00003A34 File Offset: 0x00001C34
		[Token(Token = "0x170001FC")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x6000924")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x06000925 RID: 2341 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000926 RID: 2342 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001FD")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6000925")]
			[Address(RVA = "0x4BF0C0", Offset = "0x4BD6C0", VA = "0x1804BF0C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000926")]
			[Address(RVA = "0x4BF210", Offset = "0x4BD810", VA = "0x1804BF210")]
			set
			{
			}
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x06000927 RID: 2343 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000928 RID: 2344 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001FE")]
		public Utf8String SessionName
		{
			[Token(Token = "0x6000927")]
			[Address(RVA = "0x4BF140", Offset = "0x4BD740", VA = "0x1804BF140")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000928")]
			[Address(RVA = "0x4BF270", Offset = "0x4BD870", VA = "0x1804BF270")]
			set
			{
			}
		}

		// Token: 0x06000929 RID: 2345 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000929")]
		[Address(RVA = "0x4BEF50", Offset = "0x4BD550", VA = "0x1804BEF50", Slot = "6")]
		public void Set(ref LeaveSessionRequestedCallbackInfo other)
		{
		}

		// Token: 0x0600092A RID: 2346 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600092A")]
		[Address(RVA = "0x4BEDF0", Offset = "0x4BD3F0", VA = "0x1804BEDF0", Slot = "7")]
		public void Set(ref LeaveSessionRequestedCallbackInfo? other)
		{
		}

		// Token: 0x0600092B RID: 2347 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600092B")]
		[Address(RVA = "0x4BED70", Offset = "0x4BD370", VA = "0x1804BED70", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x0600092C RID: 2348 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600092C")]
		[Address(RVA = "0x4BEDD0", Offset = "0x4BD3D0", VA = "0x1804BEDD0", Slot = "5")]
		public void Get(out LeaveSessionRequestedCallbackInfo output)
		{
		}

		// Token: 0x04000469 RID: 1129
		[Token(Token = "0x4000469")]
		[FieldOffset(Offset = "0x0")]
		private IntPtr m_ClientData;

		// Token: 0x0400046A RID: 1130
		[Token(Token = "0x400046A")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x0400046B RID: 1131
		[Token(Token = "0x400046B")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_SessionName;
	}
}
