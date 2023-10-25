using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Presence
{
	// Token: 0x020002CE RID: 718
	[Token(Token = "0x20002CE")]
	internal struct SetPresenceCallbackInfoInternal : ICallbackInfoInternal, IGettable<SetPresenceCallbackInfo>, ISettable<SetPresenceCallbackInfo>, IDisposable
	{
		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x0600138B RID: 5003 RVA: 0x00005AEC File Offset: 0x00003CEC
		// (set) Token: 0x0600138C RID: 5004 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000527")]
		public Result ResultCode
		{
			[Token(Token = "0x600138B")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x600138C")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x0600138D RID: 5005 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600138E RID: 5006 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000528")]
		public object ClientData
		{
			[Token(Token = "0x600138D")]
			[Address(RVA = "0x502AD0", Offset = "0x5010D0", VA = "0x180502AD0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600138E")]
			[Address(RVA = "0x502BC0", Offset = "0x5011C0", VA = "0x180502BC0")]
			set
			{
			}
		}

		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x0600138F RID: 5007 RVA: 0x00005B04 File Offset: 0x00003D04
		[Token(Token = "0x17000529")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x600138F")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x06001390 RID: 5008 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001391 RID: 5009 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700052A")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x6001390")]
			[Address(RVA = "0x502B40", Offset = "0x501140", VA = "0x180502B40")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001391")]
			[Address(RVA = "0x502C20", Offset = "0x501220", VA = "0x180502C20")]
			set
			{
			}
		}

		// Token: 0x06001392 RID: 5010 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001392")]
		[Address(RVA = "0x502A10", Offset = "0x501010", VA = "0x180502A10", Slot = "6")]
		public void Set(ref SetPresenceCallbackInfo other)
		{
		}

		// Token: 0x06001393 RID: 5011 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001393")]
		[Address(RVA = "0x5028F0", Offset = "0x500EF0", VA = "0x1805028F0", Slot = "7")]
		public void Set(ref SetPresenceCallbackInfo? other)
		{
		}

		// Token: 0x06001394 RID: 5012 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001394")]
		[Address(RVA = "0x502870", Offset = "0x500E70", VA = "0x180502870", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06001395 RID: 5013 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001395")]
		[Address(RVA = "0x5028D0", Offset = "0x500ED0", VA = "0x1805028D0", Slot = "5")]
		public void Get(out SetPresenceCallbackInfo output)
		{
		}

		// Token: 0x040008B0 RID: 2224
		[Token(Token = "0x40008B0")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x040008B1 RID: 2225
		[Token(Token = "0x40008B1")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;

		// Token: 0x040008B2 RID: 2226
		[Token(Token = "0x40008B2")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LocalUserId;
	}
}
