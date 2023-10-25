using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Sessions
{
	// Token: 0x0200010B RID: 267
	[Token(Token = "0x200010B")]
	internal struct DestroySessionCallbackInfoInternal : ICallbackInfoInternal, IGettable<DestroySessionCallbackInfo>, ISettable<DestroySessionCallbackInfo>, IDisposable
	{
		// Token: 0x170001CC RID: 460
		// (get) Token: 0x060008A7 RID: 2215 RVA: 0x0000389C File Offset: 0x00001A9C
		// (set) Token: 0x060008A8 RID: 2216 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001CC")]
		public Result ResultCode
		{
			[Token(Token = "0x60008A7")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x60008A8")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x060008A9 RID: 2217 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060008AA RID: 2218 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001CD")]
		public object ClientData
		{
			[Token(Token = "0x60008A9")]
			[Address(RVA = "0x4BC0B0", Offset = "0x4BA6B0", VA = "0x1804BC0B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008AA")]
			[Address(RVA = "0x4BC120", Offset = "0x4BA720", VA = "0x1804BC120")]
			set
			{
			}
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x060008AB RID: 2219 RVA: 0x000038B4 File Offset: 0x00001AB4
		[Token(Token = "0x170001CE")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x60008AB")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060008AC RID: 2220 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008AC")]
		[Address(RVA = "0x4BC050", Offset = "0x4BA650", VA = "0x1804BC050", Slot = "6")]
		public void Set(ref DestroySessionCallbackInfo other)
		{
		}

		// Token: 0x060008AD RID: 2221 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008AD")]
		[Address(RVA = "0x4BBF90", Offset = "0x4BA590", VA = "0x1804BBF90", Slot = "7")]
		public void Set(ref DestroySessionCallbackInfo? other)
		{
		}

		// Token: 0x060008AE RID: 2222 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008AE")]
		[Address(RVA = "0x4BBF20", Offset = "0x4BA520", VA = "0x1804BBF20", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x060008AF RID: 2223 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008AF")]
		[Address(RVA = "0x4BBF70", Offset = "0x4BA570", VA = "0x1804BBF70", Slot = "5")]
		public void Get(out DestroySessionCallbackInfo output)
		{
		}

		// Token: 0x04000437 RID: 1079
		[Token(Token = "0x4000437")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x04000438 RID: 1080
		[Token(Token = "0x4000438")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;
	}
}
