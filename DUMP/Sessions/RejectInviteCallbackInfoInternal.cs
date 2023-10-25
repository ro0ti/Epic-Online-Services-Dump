using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Sessions
{
	// Token: 0x0200014D RID: 333
	[Token(Token = "0x200014D")]
	internal struct RejectInviteCallbackInfoInternal : ICallbackInfoInternal, IGettable<RejectInviteCallbackInfo>, ISettable<RejectInviteCallbackInfo>, IDisposable
	{
		// Token: 0x17000217 RID: 535
		// (get) Token: 0x060009EC RID: 2540 RVA: 0x00003B3C File Offset: 0x00001D3C
		// (set) Token: 0x060009ED RID: 2541 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000217")]
		public Result ResultCode
		{
			[Token(Token = "0x60009EC")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x60009ED")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x060009EE RID: 2542 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060009EF RID: 2543 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000218")]
		public object ClientData
		{
			[Token(Token = "0x60009EE")]
			[Address(RVA = "0x4C57E0", Offset = "0x4C3DE0", VA = "0x1804C57E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009EF")]
			[Address(RVA = "0x4C5850", Offset = "0x4C3E50", VA = "0x1804C5850")]
			set
			{
			}
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x060009F0 RID: 2544 RVA: 0x00003B54 File Offset: 0x00001D54
		[Token(Token = "0x17000219")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x60009F0")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060009F1 RID: 2545 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009F1")]
		[Address(RVA = "0x4C5780", Offset = "0x4C3D80", VA = "0x1804C5780", Slot = "6")]
		public void Set(ref RejectInviteCallbackInfo other)
		{
		}

		// Token: 0x060009F2 RID: 2546 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009F2")]
		[Address(RVA = "0x4C56C0", Offset = "0x4C3CC0", VA = "0x1804C56C0", Slot = "7")]
		public void Set(ref RejectInviteCallbackInfo? other)
		{
		}

		// Token: 0x060009F3 RID: 2547 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009F3")]
		[Address(RVA = "0x4C5650", Offset = "0x4C3C50", VA = "0x1804C5650", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x060009F4 RID: 2548 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009F4")]
		[Address(RVA = "0x4C56A0", Offset = "0x4C3CA0", VA = "0x1804C56A0", Slot = "5")]
		public void Get(out RejectInviteCallbackInfo output)
		{
		}

		// Token: 0x04000494 RID: 1172
		[Token(Token = "0x4000494")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x04000495 RID: 1173
		[Token(Token = "0x4000495")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;
	}
}
