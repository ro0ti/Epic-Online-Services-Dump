using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.RTCAudio
{
	// Token: 0x020001CB RID: 459
	[Token(Token = "0x20001CB")]
	internal struct AudioOutputStateCallbackInfoInternal : ICallbackInfoInternal, IGettable<AudioOutputStateCallbackInfo>, ISettable<AudioOutputStateCallbackInfo>, IDisposable
	{
		// Token: 0x17000328 RID: 808
		// (get) Token: 0x06000D22 RID: 3362 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000D23 RID: 3363 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000328")]
		public object ClientData
		{
			[Token(Token = "0x6000D22")]
			[Address(RVA = "0x4D7530", Offset = "0x4D5B30", VA = "0x1804D7530")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000D23")]
			[Address(RVA = "0x4D7690", Offset = "0x4D5C90", VA = "0x1804D7690")]
			set
			{
			}
		}

		// Token: 0x17000329 RID: 809
		// (get) Token: 0x06000D24 RID: 3364 RVA: 0x000047E4 File Offset: 0x000029E4
		[Token(Token = "0x17000329")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x6000D24")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700032A RID: 810
		// (get) Token: 0x06000D25 RID: 3365 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000D26 RID: 3366 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700032A")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6000D25")]
			[Address(RVA = "0x4D75A0", Offset = "0x4D5BA0", VA = "0x1804D75A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000D26")]
			[Address(RVA = "0x4D76F0", Offset = "0x4D5CF0", VA = "0x1804D76F0")]
			set
			{
			}
		}

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x06000D27 RID: 3367 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000D28 RID: 3368 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700032B")]
		public Utf8String RoomName
		{
			[Token(Token = "0x6000D27")]
			[Address(RVA = "0x4D7620", Offset = "0x4D5C20", VA = "0x1804D7620")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000D28")]
			[Address(RVA = "0x4D7750", Offset = "0x4D5D50", VA = "0x1804D7750")]
			set
			{
			}
		}

		// Token: 0x1700032C RID: 812
		// (get) Token: 0x06000D29 RID: 3369 RVA: 0x000047FC File Offset: 0x000029FC
		// (set) Token: 0x06000D2A RID: 3370 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700032C")]
		public RTCAudioOutputStatus Status
		{
			[Token(Token = "0x6000D29")]
			[Address(RVA = "0x4447E0", Offset = "0x442DE0", VA = "0x1804447E0")]
			get
			{
				return RTCAudioOutputStatus.Idle;
			}
			[Token(Token = "0x6000D2A")]
			[Address(RVA = "0x444820", Offset = "0x442E20", VA = "0x180444820")]
			set
			{
			}
		}

		// Token: 0x06000D2B RID: 3371 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D2B")]
		[Address(RVA = "0x4D72B0", Offset = "0x4D58B0", VA = "0x1804D72B0", Slot = "6")]
		public void Set(ref AudioOutputStateCallbackInfo other)
		{
		}

		// Token: 0x06000D2C RID: 3372 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D2C")]
		[Address(RVA = "0x4D73B0", Offset = "0x4D59B0", VA = "0x1804D73B0", Slot = "7")]
		public void Set(ref AudioOutputStateCallbackInfo? other)
		{
		}

		// Token: 0x06000D2D RID: 3373 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D2D")]
		[Address(RVA = "0x4D7230", Offset = "0x4D5830", VA = "0x1804D7230", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06000D2E RID: 3374 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D2E")]
		[Address(RVA = "0x4D7290", Offset = "0x4D5890", VA = "0x1804D7290", Slot = "5")]
		public void Get(out AudioOutputStateCallbackInfo output)
		{
		}

		// Token: 0x0400060E RID: 1550
		[Token(Token = "0x400060E")]
		[FieldOffset(Offset = "0x0")]
		private IntPtr m_ClientData;

		// Token: 0x0400060F RID: 1551
		[Token(Token = "0x400060F")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x04000610 RID: 1552
		[Token(Token = "0x4000610")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_RoomName;

		// Token: 0x04000611 RID: 1553
		[Token(Token = "0x4000611")]
		[FieldOffset(Offset = "0x18")]
		private RTCAudioOutputStatus m_Status;
	}
}
