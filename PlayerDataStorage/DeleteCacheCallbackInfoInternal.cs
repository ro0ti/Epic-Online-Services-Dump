using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.PlayerDataStorage
{
	// Token: 0x020002D9 RID: 729
	[Token(Token = "0x20002D9")]
	internal struct DeleteCacheCallbackInfoInternal : ICallbackInfoInternal, IGettable<DeleteCacheCallbackInfo>, ISettable<DeleteCacheCallbackInfo>, IDisposable
	{
		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x060013C1 RID: 5057 RVA: 0x00005B64 File Offset: 0x00003D64
		// (set) Token: 0x060013C2 RID: 5058 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700053A")]
		public Result ResultCode
		{
			[Token(Token = "0x60013C1")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x60013C2")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x1700053B RID: 1339
		// (get) Token: 0x060013C3 RID: 5059 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060013C4 RID: 5060 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700053B")]
		public object ClientData
		{
			[Token(Token = "0x60013C3")]
			[Address(RVA = "0x4EF340", Offset = "0x4ED940", VA = "0x1804EF340")]
			get
			{
				return null;
			}
			[Token(Token = "0x60013C4")]
			[Address(RVA = "0x4EF430", Offset = "0x4EDA30", VA = "0x1804EF430")]
			set
			{
			}
		}

		// Token: 0x1700053C RID: 1340
		// (get) Token: 0x060013C5 RID: 5061 RVA: 0x00005B7C File Offset: 0x00003D7C
		[Token(Token = "0x1700053C")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x60013C5")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x060013C6 RID: 5062 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060013C7 RID: 5063 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700053D")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x60013C6")]
			[Address(RVA = "0x4EF3B0", Offset = "0x4ED9B0", VA = "0x1804EF3B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60013C7")]
			[Address(RVA = "0x4EF490", Offset = "0x4EDA90", VA = "0x1804EF490")]
			set
			{
			}
		}

		// Token: 0x060013C8 RID: 5064 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013C8")]
		[Address(RVA = "0x4EF160", Offset = "0x4ED760", VA = "0x1804EF160", Slot = "6")]
		public void Set(ref DeleteCacheCallbackInfo other)
		{
		}

		// Token: 0x060013C9 RID: 5065 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013C9")]
		[Address(RVA = "0x4EF220", Offset = "0x4ED820", VA = "0x1804EF220", Slot = "7")]
		public void Set(ref DeleteCacheCallbackInfo? other)
		{
		}

		// Token: 0x060013CA RID: 5066 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013CA")]
		[Address(RVA = "0x4EF0E0", Offset = "0x4ED6E0", VA = "0x1804EF0E0", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x060013CB RID: 5067 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013CB")]
		[Address(RVA = "0x4EF140", Offset = "0x4ED740", VA = "0x1804EF140", Slot = "5")]
		public void Get(out DeleteCacheCallbackInfo output)
		{
		}

		// Token: 0x040008CB RID: 2251
		[Token(Token = "0x40008CB")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x040008CC RID: 2252
		[Token(Token = "0x40008CC")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;

		// Token: 0x040008CD RID: 2253
		[Token(Token = "0x40008CD")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LocalUserId;
	}
}
