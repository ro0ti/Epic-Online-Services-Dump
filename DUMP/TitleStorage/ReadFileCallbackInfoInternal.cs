using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.TitleStorage
{
	// Token: 0x020000C6 RID: 198
	[Token(Token = "0x20000C6")]
	internal struct ReadFileCallbackInfoInternal : ICallbackInfoInternal, IGettable<ReadFileCallbackInfo>, ISettable<ReadFileCallbackInfo>, IDisposable
	{
		// Token: 0x17000145 RID: 325
		// (get) Token: 0x06000714 RID: 1812 RVA: 0x00003224 File Offset: 0x00001424
		// (set) Token: 0x06000715 RID: 1813 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000145")]
		public Result ResultCode
		{
			[Token(Token = "0x6000714")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x6000715")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x06000716 RID: 1814 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000717 RID: 1815 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000146")]
		public object ClientData
		{
			[Token(Token = "0x6000716")]
			[Address(RVA = "0x4C3740", Offset = "0x4C1D40", VA = "0x1804C3740")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000717")]
			[Address(RVA = "0x4C38A0", Offset = "0x4C1EA0", VA = "0x1804C38A0")]
			set
			{
			}
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x06000718 RID: 1816 RVA: 0x0000323C File Offset: 0x0000143C
		[Token(Token = "0x17000147")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x6000718")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x06000719 RID: 1817 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600071A RID: 1818 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000148")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6000719")]
			[Address(RVA = "0x4C3820", Offset = "0x4C1E20", VA = "0x1804C3820")]
			get
			{
				return null;
			}
			[Token(Token = "0x600071A")]
			[Address(RVA = "0x4C3960", Offset = "0x4C1F60", VA = "0x1804C3960")]
			set
			{
			}
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x0600071B RID: 1819 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600071C RID: 1820 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000149")]
		public Utf8String Filename
		{
			[Token(Token = "0x600071B")]
			[Address(RVA = "0x4C37B0", Offset = "0x4C1DB0", VA = "0x1804C37B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600071C")]
			[Address(RVA = "0x4C3900", Offset = "0x4C1F00", VA = "0x1804C3900")]
			set
			{
			}
		}

		// Token: 0x0600071D RID: 1821 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600071D")]
		[Address(RVA = "0x4C3640", Offset = "0x4C1C40", VA = "0x1804C3640", Slot = "6")]
		public void Set(ref ReadFileCallbackInfo other)
		{
		}

		// Token: 0x0600071E RID: 1822 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600071E")]
		[Address(RVA = "0x4C34C0", Offset = "0x4C1AC0", VA = "0x1804C34C0", Slot = "7")]
		public void Set(ref ReadFileCallbackInfo? other)
		{
		}

		// Token: 0x0600071F RID: 1823 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600071F")]
		[Address(RVA = "0x4C3430", Offset = "0x4C1A30", VA = "0x1804C3430", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06000720 RID: 1824 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000720")]
		[Address(RVA = "0x4C34A0", Offset = "0x4C1AA0", VA = "0x1804C34A0", Slot = "5")]
		public void Get(out ReadFileCallbackInfo output)
		{
		}

		// Token: 0x04000371 RID: 881
		[Token(Token = "0x4000371")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x04000372 RID: 882
		[Token(Token = "0x4000372")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;

		// Token: 0x04000373 RID: 883
		[Token(Token = "0x4000373")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LocalUserId;

		// Token: 0x04000374 RID: 884
		[Token(Token = "0x4000374")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_Filename;
	}
}
