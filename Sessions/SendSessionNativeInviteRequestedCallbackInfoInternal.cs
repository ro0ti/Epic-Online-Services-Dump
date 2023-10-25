using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Sessions
{
	// Token: 0x02000155 RID: 341
	[Token(Token = "0x2000155")]
	internal struct SendSessionNativeInviteRequestedCallbackInfoInternal : ICallbackInfoInternal, IGettable<SendSessionNativeInviteRequestedCallbackInfo>, ISettable<SendSessionNativeInviteRequestedCallbackInfo>, IDisposable
	{
		// Token: 0x1700022F RID: 559
		// (get) Token: 0x06000A27 RID: 2599 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000A28 RID: 2600 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700022F")]
		public object ClientData
		{
			[Token(Token = "0x6000A27")]
			[Address(RVA = "0x4C67E0", Offset = "0x4C4DE0", VA = "0x1804C67E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A28")]
			[Address(RVA = "0x4C6A20", Offset = "0x4C5020", VA = "0x1804C6A20")]
			set
			{
			}
		}

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x06000A29 RID: 2601 RVA: 0x00003BFC File Offset: 0x00001DFC
		[Token(Token = "0x17000230")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x6000A29")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x06000A2A RID: 2602 RVA: 0x00003C14 File Offset: 0x00001E14
		// (set) Token: 0x06000A2B RID: 2603 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000231")]
		public ulong UiEventId
		{
			[Token(Token = "0x6000A2A")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6000A2B")]
			[Address(RVA = "0x487590", Offset = "0x485B90", VA = "0x180487590")]
			set
			{
			}
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x06000A2C RID: 2604 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000A2D RID: 2605 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000232")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6000A2C")]
			[Address(RVA = "0x4C6850", Offset = "0x4C4E50", VA = "0x1804C6850")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A2D")]
			[Address(RVA = "0x4C6A80", Offset = "0x4C5080", VA = "0x1804C6A80")]
			set
			{
			}
		}

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x06000A2E RID: 2606 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000A2F RID: 2607 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000233")]
		public Utf8String TargetNativeAccountType
		{
			[Token(Token = "0x6000A2E")]
			[Address(RVA = "0x4C6940", Offset = "0x4C4F40", VA = "0x1804C6940")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A2F")]
			[Address(RVA = "0x4C6B40", Offset = "0x4C5140", VA = "0x1804C6B40")]
			set
			{
			}
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x06000A30 RID: 2608 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000A31 RID: 2609 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000234")]
		public Utf8String TargetUserNativeAccountId
		{
			[Token(Token = "0x6000A30")]
			[Address(RVA = "0x4C69B0", Offset = "0x4C4FB0", VA = "0x1804C69B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A31")]
			[Address(RVA = "0x4C6BA0", Offset = "0x4C51A0", VA = "0x1804C6BA0")]
			set
			{
			}
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x06000A32 RID: 2610 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000A33 RID: 2611 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000235")]
		public Utf8String SessionId
		{
			[Token(Token = "0x6000A32")]
			[Address(RVA = "0x4C68D0", Offset = "0x4C4ED0", VA = "0x1804C68D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A33")]
			[Address(RVA = "0x4C6AE0", Offset = "0x4C50E0", VA = "0x1804C6AE0")]
			set
			{
			}
		}

		// Token: 0x06000A34 RID: 2612 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A34")]
		[Address(RVA = "0x4C6430", Offset = "0x4C4A30", VA = "0x1804C6430", Slot = "6")]
		public void Set(ref SendSessionNativeInviteRequestedCallbackInfo other)
		{
		}

		// Token: 0x06000A35 RID: 2613 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A35")]
		[Address(RVA = "0x4C65C0", Offset = "0x4C4BC0", VA = "0x1804C65C0", Slot = "7")]
		public void Set(ref SendSessionNativeInviteRequestedCallbackInfo? other)
		{
		}

		// Token: 0x06000A36 RID: 2614 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A36")]
		[Address(RVA = "0x4C6390", Offset = "0x4C4990", VA = "0x1804C6390", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06000A37 RID: 2615 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A37")]
		[Address(RVA = "0x4C6410", Offset = "0x4C4A10", VA = "0x1804C6410", Slot = "5")]
		public void Get(out SendSessionNativeInviteRequestedCallbackInfo output)
		{
		}

		// Token: 0x040004AC RID: 1196
		[Token(Token = "0x40004AC")]
		[FieldOffset(Offset = "0x0")]
		private IntPtr m_ClientData;

		// Token: 0x040004AD RID: 1197
		[Token(Token = "0x40004AD")]
		[FieldOffset(Offset = "0x8")]
		private ulong m_UiEventId;

		// Token: 0x040004AE RID: 1198
		[Token(Token = "0x40004AE")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LocalUserId;

		// Token: 0x040004AF RID: 1199
		[Token(Token = "0x40004AF")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_TargetNativeAccountType;

		// Token: 0x040004B0 RID: 1200
		[Token(Token = "0x40004B0")]
		[FieldOffset(Offset = "0x20")]
		private IntPtr m_TargetUserNativeAccountId;

		// Token: 0x040004B1 RID: 1201
		[Token(Token = "0x40004B1")]
		[FieldOffset(Offset = "0x28")]
		private IntPtr m_SessionId;
	}
}
