using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Auth
{
	// Token: 0x02000657 RID: 1623
	[Token(Token = "0x2000657")]
	internal struct DeletePersistentAuthCallbackInfoInternal : ICallbackInfoInternal, IGettable<DeletePersistentAuthCallbackInfo>, ISettable<DeletePersistentAuthCallbackInfo>, IDisposable
	{
		// Token: 0x17000C16 RID: 3094
		// (get) Token: 0x06002994 RID: 10644 RVA: 0x0000A70C File Offset: 0x0000890C
		// (set) Token: 0x06002995 RID: 10645 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C16")]
		public Result ResultCode
		{
			[Token(Token = "0x6002994")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x6002995")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x17000C17 RID: 3095
		// (get) Token: 0x06002996 RID: 10646 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002997 RID: 10647 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C17")]
		public object ClientData
		{
			[Token(Token = "0x6002996")]
			[Address(RVA = "0x559DF0", Offset = "0x5583F0", VA = "0x180559DF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002997")]
			[Address(RVA = "0x559E60", Offset = "0x558460", VA = "0x180559E60")]
			set
			{
			}
		}

		// Token: 0x17000C18 RID: 3096
		// (get) Token: 0x06002998 RID: 10648 RVA: 0x0000A724 File Offset: 0x00008924
		[Token(Token = "0x17000C18")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x6002998")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06002999 RID: 10649 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002999")]
		[Address(RVA = "0x559CD0", Offset = "0x5582D0", VA = "0x180559CD0", Slot = "6")]
		public void Set(ref DeletePersistentAuthCallbackInfo other)
		{
		}

		// Token: 0x0600299A RID: 10650 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600299A")]
		[Address(RVA = "0x559D30", Offset = "0x558330", VA = "0x180559D30", Slot = "7")]
		public void Set(ref DeletePersistentAuthCallbackInfo? other)
		{
		}

		// Token: 0x0600299B RID: 10651 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600299B")]
		[Address(RVA = "0x559C60", Offset = "0x558260", VA = "0x180559C60", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x0600299C RID: 10652 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600299C")]
		[Address(RVA = "0x559CB0", Offset = "0x5582B0", VA = "0x180559CB0", Slot = "5")]
		public void Get(out DeletePersistentAuthCallbackInfo output)
		{
		}

		// Token: 0x0400121C RID: 4636
		[Token(Token = "0x400121C")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x0400121D RID: 4637
		[Token(Token = "0x400121D")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;
	}
}
