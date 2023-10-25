using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.PlayerDataStorage
{
	// Token: 0x020002DD RID: 733
	[Token(Token = "0x20002DD")]
	internal struct DeleteFileCallbackInfoInternal : ICallbackInfoInternal, IGettable<DeleteFileCallbackInfo>, ISettable<DeleteFileCallbackInfo>, IDisposable
	{
		// Token: 0x17000543 RID: 1347
		// (get) Token: 0x060013DA RID: 5082 RVA: 0x00005BC4 File Offset: 0x00003DC4
		// (set) Token: 0x060013DB RID: 5083 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000543")]
		public Result ResultCode
		{
			[Token(Token = "0x60013DA")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x60013DB")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x060013DC RID: 5084 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060013DD RID: 5085 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000544")]
		public object ClientData
		{
			[Token(Token = "0x60013DC")]
			[Address(RVA = "0x4EFA00", Offset = "0x4EE000", VA = "0x1804EFA00")]
			get
			{
				return null;
			}
			[Token(Token = "0x60013DD")]
			[Address(RVA = "0x4EFAF0", Offset = "0x4EE0F0", VA = "0x1804EFAF0")]
			set
			{
			}
		}

		// Token: 0x17000545 RID: 1349
		// (get) Token: 0x060013DE RID: 5086 RVA: 0x00005BDC File Offset: 0x00003DDC
		[Token(Token = "0x17000545")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x60013DE")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000546 RID: 1350
		// (get) Token: 0x060013DF RID: 5087 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060013E0 RID: 5088 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000546")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x60013DF")]
			[Address(RVA = "0x4EFA70", Offset = "0x4EE070", VA = "0x1804EFA70")]
			get
			{
				return null;
			}
			[Token(Token = "0x60013E0")]
			[Address(RVA = "0x4EFB50", Offset = "0x4EE150", VA = "0x1804EFB50")]
			set
			{
			}
		}

		// Token: 0x060013E1 RID: 5089 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013E1")]
		[Address(RVA = "0x4EF820", Offset = "0x4EDE20", VA = "0x1804EF820", Slot = "6")]
		public void Set(ref DeleteFileCallbackInfo other)
		{
		}

		// Token: 0x060013E2 RID: 5090 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013E2")]
		[Address(RVA = "0x4EF8E0", Offset = "0x4EDEE0", VA = "0x1804EF8E0", Slot = "7")]
		public void Set(ref DeleteFileCallbackInfo? other)
		{
		}

		// Token: 0x060013E3 RID: 5091 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013E3")]
		[Address(RVA = "0x4EF7A0", Offset = "0x4EDDA0", VA = "0x1804EF7A0", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x060013E4 RID: 5092 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013E4")]
		[Address(RVA = "0x4EF800", Offset = "0x4EDE00", VA = "0x1804EF800", Slot = "5")]
		public void Get(out DeleteFileCallbackInfo output)
		{
		}

		// Token: 0x040008D4 RID: 2260
		[Token(Token = "0x40008D4")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x040008D5 RID: 2261
		[Token(Token = "0x40008D5")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;

		// Token: 0x040008D6 RID: 2262
		[Token(Token = "0x40008D6")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LocalUserId;
	}
}
