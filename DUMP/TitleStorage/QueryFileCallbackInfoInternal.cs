using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.TitleStorage
{
	// Token: 0x020000BE RID: 190
	[Token(Token = "0x20000BE")]
	internal struct QueryFileCallbackInfoInternal : ICallbackInfoInternal, IGettable<QueryFileCallbackInfo>, ISettable<QueryFileCallbackInfo>, IDisposable
	{
		// Token: 0x1700012C RID: 300
		// (get) Token: 0x060006D6 RID: 1750 RVA: 0x00003134 File Offset: 0x00001334
		// (set) Token: 0x060006D7 RID: 1751 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700012C")]
		public Result ResultCode
		{
			[Token(Token = "0x60006D6")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x60006D7")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x060006D8 RID: 1752 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060006D9 RID: 1753 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700012D")]
		public object ClientData
		{
			[Token(Token = "0x60006D8")]
			[Address(RVA = "0x4C18D0", Offset = "0x4BFED0", VA = "0x1804C18D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006D9")]
			[Address(RVA = "0x4C19C0", Offset = "0x4BFFC0", VA = "0x1804C19C0")]
			set
			{
			}
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x060006DA RID: 1754 RVA: 0x0000314C File Offset: 0x0000134C
		[Token(Token = "0x1700012E")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x60006DA")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x060006DB RID: 1755 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060006DC RID: 1756 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700012F")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x60006DB")]
			[Address(RVA = "0x4C1940", Offset = "0x4BFF40", VA = "0x1804C1940")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006DC")]
			[Address(RVA = "0x4C1A20", Offset = "0x4C0020", VA = "0x1804C1A20")]
			set
			{
			}
		}

		// Token: 0x060006DD RID: 1757 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006DD")]
		[Address(RVA = "0x4C16F0", Offset = "0x4BFCF0", VA = "0x1804C16F0", Slot = "6")]
		public void Set(ref QueryFileCallbackInfo other)
		{
		}

		// Token: 0x060006DE RID: 1758 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006DE")]
		[Address(RVA = "0x4C17B0", Offset = "0x4BFDB0", VA = "0x1804C17B0", Slot = "7")]
		public void Set(ref QueryFileCallbackInfo? other)
		{
		}

		// Token: 0x060006DF RID: 1759 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006DF")]
		[Address(RVA = "0x4C1670", Offset = "0x4BFC70", VA = "0x1804C1670", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x060006E0 RID: 1760 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006E0")]
		[Address(RVA = "0x4C16D0", Offset = "0x4BFCD0", VA = "0x1804C16D0", Slot = "5")]
		public void Get(out QueryFileCallbackInfo output)
		{
		}

		// Token: 0x04000357 RID: 855
		[Token(Token = "0x4000357")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x04000358 RID: 856
		[Token(Token = "0x4000358")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;

		// Token: 0x04000359 RID: 857
		[Token(Token = "0x4000359")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LocalUserId;
	}
}
