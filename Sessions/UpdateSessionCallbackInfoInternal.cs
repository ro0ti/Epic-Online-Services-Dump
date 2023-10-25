using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Sessions
{
	// Token: 0x0200019E RID: 414
	[Token(Token = "0x200019E")]
	internal struct UpdateSessionCallbackInfoInternal : ICallbackInfoInternal, IGettable<UpdateSessionCallbackInfo>, ISettable<UpdateSessionCallbackInfo>, IDisposable
	{
		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x06000BF3 RID: 3059 RVA: 0x00004454 File Offset: 0x00002654
		// (set) Token: 0x06000BF4 RID: 3060 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170002B8")]
		public Result ResultCode
		{
			[Token(Token = "0x6000BF3")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x6000BF4")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x06000BF5 RID: 3061 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000BF6 RID: 3062 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170002B9")]
		public object ClientData
		{
			[Token(Token = "0x6000BF5")]
			[Address(RVA = "0x4EB330", Offset = "0x4E9930", VA = "0x1804EB330")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BF6")]
			[Address(RVA = "0x4EB480", Offset = "0x4E9A80", VA = "0x1804EB480")]
			set
			{
			}
		}

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x06000BF7 RID: 3063 RVA: 0x0000446C File Offset: 0x0000266C
		[Token(Token = "0x170002BA")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x6000BF7")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x06000BF8 RID: 3064 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000BF9 RID: 3065 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170002BB")]
		public Utf8String SessionName
		{
			[Token(Token = "0x6000BF8")]
			[Address(RVA = "0x4EB410", Offset = "0x4E9A10", VA = "0x1804EB410")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BF9")]
			[Address(RVA = "0x4EB540", Offset = "0x4E9B40", VA = "0x1804EB540")]
			set
			{
			}
		}

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x06000BFA RID: 3066 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000BFB RID: 3067 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170002BC")]
		public Utf8String SessionId
		{
			[Token(Token = "0x6000BFA")]
			[Address(RVA = "0x4EB3A0", Offset = "0x4E99A0", VA = "0x1804EB3A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BFB")]
			[Address(RVA = "0x4EB4E0", Offset = "0x4E9AE0", VA = "0x1804EB4E0")]
			set
			{
			}
		}

		// Token: 0x06000BFC RID: 3068 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BFC")]
		[Address(RVA = "0x4EB0B0", Offset = "0x4E96B0", VA = "0x1804EB0B0", Slot = "6")]
		public void Set(ref UpdateSessionCallbackInfo other)
		{
		}

		// Token: 0x06000BFD RID: 3069 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BFD")]
		[Address(RVA = "0x4EB1B0", Offset = "0x4E97B0", VA = "0x1804EB1B0", Slot = "7")]
		public void Set(ref UpdateSessionCallbackInfo? other)
		{
		}

		// Token: 0x06000BFE RID: 3070 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BFE")]
		[Address(RVA = "0x4EB020", Offset = "0x4E9620", VA = "0x1804EB020", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06000BFF RID: 3071 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BFF")]
		[Address(RVA = "0x4EB090", Offset = "0x4E9690", VA = "0x1804EB090", Slot = "5")]
		public void Get(out UpdateSessionCallbackInfo output)
		{
		}

		// Token: 0x04000590 RID: 1424
		[Token(Token = "0x4000590")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x04000591 RID: 1425
		[Token(Token = "0x4000591")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;

		// Token: 0x04000592 RID: 1426
		[Token(Token = "0x4000592")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_SessionName;

		// Token: 0x04000593 RID: 1427
		[Token(Token = "0x4000593")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_SessionId;
	}
}
