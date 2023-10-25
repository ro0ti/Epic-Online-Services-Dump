using System;


namespace Epic.OnlineServices.PlayerDataStorage
{
	// Token: 0x020002E1 RID: 737
	[Token(Token = "0x20002E1")]
	internal struct DuplicateFileCallbackInfoInternal : ICallbackInfoInternal, IGettable<DuplicateFileCallbackInfo>, ISettable<DuplicateFileCallbackInfo>, IDisposable
	{
		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x060013F6 RID: 5110 RVA: 0x00005C24 File Offset: 0x00003E24
		// (set) Token: 0x060013F7 RID: 5111 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700054E")]
		public Result ResultCode
		{
			[Token(Token = "0x60013F6")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x60013F7")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x1700054F RID: 1359
		// (get) Token: 0x060013F8 RID: 5112 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060013F9 RID: 5113 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700054F")]
		public object ClientData
		{
			[Token(Token = "0x60013F8")]
			[Address(RVA = "0x4F08B0", Offset = "0x4EEEB0", VA = "0x1804F08B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60013F9")]
			[Address(RVA = "0x4F09A0", Offset = "0x4EEFA0", VA = "0x1804F09A0")]
			set
			{
			}
		}

		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x060013FA RID: 5114 RVA: 0x00005C3C File Offset: 0x00003E3C
		[Token(Token = "0x17000550")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x60013FA")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x060013FB RID: 5115 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060013FC RID: 5116 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000551")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x60013FB")]
			[Address(RVA = "0x4F0920", Offset = "0x4EEF20", VA = "0x1804F0920")]
			get
			{
				return null;
			}
			[Token(Token = "0x60013FC")]
			[Address(RVA = "0x4F0A00", Offset = "0x4EF000", VA = "0x1804F0A00")]
			set
			{
			}
		}

		// Token: 0x060013FD RID: 5117 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013FD")]
		[Address(RVA = "0x4F07F0", Offset = "0x4EEDF0", VA = "0x1804F07F0", Slot = "6")]
		public void Set(ref DuplicateFileCallbackInfo other)
		{
		}

		// Token: 0x060013FE RID: 5118 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013FE")]
		[Address(RVA = "0x4F06D0", Offset = "0x4EECD0", VA = "0x1804F06D0", Slot = "7")]
		public void Set(ref DuplicateFileCallbackInfo? other)
		{
		}

		// Token: 0x060013FF RID: 5119 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013FF")]
		[Address(RVA = "0x4F0650", Offset = "0x4EEC50", VA = "0x1804F0650", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06001400 RID: 5120 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001400")]
		[Address(RVA = "0x4F06B0", Offset = "0x4EECB0", VA = "0x1804F06B0", Slot = "5")]
		public void Get(out DuplicateFileCallbackInfo output)
		{
		}

		// Token: 0x040008DF RID: 2271
		[Token(Token = "0x40008DF")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x040008E0 RID: 2272
		[Token(Token = "0x40008E0")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;

		// Token: 0x040008E1 RID: 2273
		[Token(Token = "0x40008E1")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LocalUserId;
	}
}
