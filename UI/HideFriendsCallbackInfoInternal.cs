using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.UI
{
	// Token: 0x0200006A RID: 106
	[Token(Token = "0x200006A")]
	internal struct HideFriendsCallbackInfoInternal : ICallbackInfoInternal, IGettable<HideFriendsCallbackInfo>, ISettable<HideFriendsCallbackInfo>, IDisposable
	{
		// Token: 0x17000097 RID: 151
		// (get) Token: 0x060004DB RID: 1243 RVA: 0x0000290C File Offset: 0x00000B0C
		// (set) Token: 0x060004DC RID: 1244 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000097")]
		public Result ResultCode
		{
			[Token(Token = "0x60004DB")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x60004DC")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x060004DD RID: 1245 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060004DE RID: 1246 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000098")]
		public object ClientData
		{
			[Token(Token = "0x60004DD")]
			[Address(RVA = "0x4AA130", Offset = "0x4A8730", VA = "0x1804AA130")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004DE")]
			[Address(RVA = "0x4AA250", Offset = "0x4A8850", VA = "0x1804AA250")]
			set
			{
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x060004DF RID: 1247 RVA: 0x00002924 File Offset: 0x00000B24
		[Token(Token = "0x17000099")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x60004DF")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x060004E0 RID: 1248 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060004E1 RID: 1249 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700009A")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x60004E0")]
			[Address(RVA = "0x4AA1D0", Offset = "0x4A87D0", VA = "0x1804AA1D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004E1")]
			[Address(RVA = "0x4AA2F0", Offset = "0x4A88F0", VA = "0x1804AA2F0")]
			set
			{
			}
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x4AA040", Offset = "0x4A8640", VA = "0x1804AA040", Slot = "6")]
		public void Set(ref HideFriendsCallbackInfo other)
		{
		}

		// Token: 0x060004E3 RID: 1251 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x4AA080", Offset = "0x4A8680", VA = "0x1804AA080", Slot = "7")]
		public void Set(ref HideFriendsCallbackInfo? other)
		{
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x4A9F00", Offset = "0x4A8500", VA = "0x1804A9F00", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x060004E5 RID: 1253 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x4A9FE0", Offset = "0x4A85E0", VA = "0x1804A9FE0", Slot = "5")]
		public void Get(out HideFriendsCallbackInfo output)
		{
		}

		// Token: 0x0400021B RID: 539
		[Token(Token = "0x400021B")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x0400021C RID: 540
		[Token(Token = "0x400021C")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;

		// Token: 0x0400021D RID: 541
		[Token(Token = "0x400021D")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LocalUserId;
	}
}
