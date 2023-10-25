using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.PlayerDataStorage
{
	// Token: 0x02000309 RID: 777
	[Token(Token = "0x2000309")]
	internal struct ReadFileCallbackInfoInternal : ICallbackInfoInternal, IGettable<ReadFileCallbackInfo>, ISettable<ReadFileCallbackInfo>, IDisposable
	{
		// Token: 0x17000589 RID: 1417
		// (get) Token: 0x060014F6 RID: 5366 RVA: 0x00005F6C File Offset: 0x0000416C
		// (set) Token: 0x060014F7 RID: 5367 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000589")]
		public Result ResultCode
		{
			[Token(Token = "0x60014F6")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x60014F7")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x1700058A RID: 1418
		// (get) Token: 0x060014F8 RID: 5368 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060014F9 RID: 5369 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700058A")]
		public object ClientData
		{
			[Token(Token = "0x60014F8")]
			[Address(RVA = "0x500050", Offset = "0x4FE650", VA = "0x180500050")]
			get
			{
				return null;
			}
			[Token(Token = "0x60014F9")]
			[Address(RVA = "0x5001B0", Offset = "0x4FE7B0", VA = "0x1805001B0")]
			set
			{
			}
		}

		// Token: 0x1700058B RID: 1419
		// (get) Token: 0x060014FA RID: 5370 RVA: 0x00005F84 File Offset: 0x00004184
		[Token(Token = "0x1700058B")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x60014FA")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700058C RID: 1420
		// (get) Token: 0x060014FB RID: 5371 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060014FC RID: 5372 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700058C")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x60014FB")]
			[Address(RVA = "0x500130", Offset = "0x4FE730", VA = "0x180500130")]
			get
			{
				return null;
			}
			[Token(Token = "0x60014FC")]
			[Address(RVA = "0x500270", Offset = "0x4FE870", VA = "0x180500270")]
			set
			{
			}
		}

		// Token: 0x1700058D RID: 1421
		// (get) Token: 0x060014FD RID: 5373 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060014FE RID: 5374 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700058D")]
		public Utf8String Filename
		{
			[Token(Token = "0x60014FD")]
			[Address(RVA = "0x5000C0", Offset = "0x4FE6C0", VA = "0x1805000C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60014FE")]
			[Address(RVA = "0x500210", Offset = "0x4FE810", VA = "0x180500210")]
			set
			{
			}
		}

		// Token: 0x060014FF RID: 5375 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60014FF")]
		[Address(RVA = "0x4FFDD0", Offset = "0x4FE3D0", VA = "0x1804FFDD0", Slot = "6")]
		public void Set(ref ReadFileCallbackInfo other)
		{
		}

		// Token: 0x06001500 RID: 5376 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001500")]
		[Address(RVA = "0x4FFED0", Offset = "0x4FE4D0", VA = "0x1804FFED0", Slot = "7")]
		public void Set(ref ReadFileCallbackInfo? other)
		{
		}

		// Token: 0x06001501 RID: 5377 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001501")]
		[Address(RVA = "0x4FFD40", Offset = "0x4FE340", VA = "0x1804FFD40", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06001502 RID: 5378 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001502")]
		[Address(RVA = "0x4FFDB0", Offset = "0x4FE3B0", VA = "0x1804FFDB0", Slot = "5")]
		public void Get(out ReadFileCallbackInfo output)
		{
		}

		// Token: 0x04000932 RID: 2354
		[Token(Token = "0x4000932")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x04000933 RID: 2355
		[Token(Token = "0x4000933")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;

		// Token: 0x04000934 RID: 2356
		[Token(Token = "0x4000934")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LocalUserId;

		// Token: 0x04000935 RID: 2357
		[Token(Token = "0x4000935")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_Filename;
	}
}
