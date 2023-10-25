using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Sessions
{
	// Token: 0x02000196 RID: 406
	[Token(Token = "0x2000196")]
	internal struct StartSessionCallbackInfoInternal : ICallbackInfoInternal, IGettable<StartSessionCallbackInfo>, ISettable<StartSessionCallbackInfo>, IDisposable
	{
		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x06000BBE RID: 3006 RVA: 0x00004394 File Offset: 0x00002594
		// (set) Token: 0x06000BBF RID: 3007 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170002A4")]
		public Result ResultCode
		{
			[Token(Token = "0x6000BBE")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x6000BBF")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x06000BC0 RID: 3008 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000BC1 RID: 3009 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170002A5")]
		public object ClientData
		{
			[Token(Token = "0x6000BC0")]
			[Address(RVA = "0x4E66F0", Offset = "0x4E4CF0", VA = "0x1804E66F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BC1")]
			[Address(RVA = "0x4E6760", Offset = "0x4E4D60", VA = "0x1804E6760")]
			set
			{
			}
		}

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x06000BC2 RID: 3010 RVA: 0x000043AC File Offset: 0x000025AC
		[Token(Token = "0x170002A6")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x6000BC2")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000BC3 RID: 3011 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BC3")]
		[Address(RVA = "0x4E6690", Offset = "0x4E4C90", VA = "0x1804E6690", Slot = "6")]
		public void Set(ref StartSessionCallbackInfo other)
		{
		}

		// Token: 0x06000BC4 RID: 3012 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BC4")]
		[Address(RVA = "0x4E65D0", Offset = "0x4E4BD0", VA = "0x1804E65D0", Slot = "7")]
		public void Set(ref StartSessionCallbackInfo? other)
		{
		}

		// Token: 0x06000BC5 RID: 3013 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BC5")]
		[Address(RVA = "0x4E6560", Offset = "0x4E4B60", VA = "0x1804E6560", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06000BC6 RID: 3014 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000BC6")]
		[Address(RVA = "0x4E65B0", Offset = "0x4E4BB0", VA = "0x1804E65B0", Slot = "5")]
		public void Get(out StartSessionCallbackInfo output)
		{
		}

		// Token: 0x0400057A RID: 1402
		[Token(Token = "0x400057A")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x0400057B RID: 1403
		[Token(Token = "0x400057B")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;
	}
}
