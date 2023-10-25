using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.RTC
{
	// Token: 0x02000262 RID: 610
	[Token(Token = "0x2000262")]
	internal struct DisconnectedCallbackInfoInternal : ICallbackInfoInternal, IGettable<DisconnectedCallbackInfo>, ISettable<DisconnectedCallbackInfo>, IDisposable
	{
		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x060010DD RID: 4317 RVA: 0x00005414 File Offset: 0x00003614
		// (set) Token: 0x060010DE RID: 4318 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000451")]
		public Result ResultCode
		{
			[Token(Token = "0x60010DD")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x60010DE")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x060010DF RID: 4319 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060010E0 RID: 4320 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000452")]
		public object ClientData
		{
			[Token(Token = "0x60010DF")]
			[Address(RVA = "0x4D9060", Offset = "0x4D7660", VA = "0x1804D9060")]
			get
			{
				return null;
			}
			[Token(Token = "0x60010E0")]
			[Address(RVA = "0x4D91C0", Offset = "0x4D77C0", VA = "0x1804D91C0")]
			set
			{
			}
		}

		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x060010E1 RID: 4321 RVA: 0x0000542C File Offset: 0x0000362C
		[Token(Token = "0x17000453")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x60010E1")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x060010E2 RID: 4322 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060010E3 RID: 4323 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000454")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x60010E2")]
			[Address(RVA = "0x4D90D0", Offset = "0x4D76D0", VA = "0x1804D90D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60010E3")]
			[Address(RVA = "0x4D9220", Offset = "0x4D7820", VA = "0x1804D9220")]
			set
			{
			}
		}

		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x060010E4 RID: 4324 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060010E5 RID: 4325 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000455")]
		public Utf8String RoomName
		{
			[Token(Token = "0x60010E4")]
			[Address(RVA = "0x4D9150", Offset = "0x4D7750", VA = "0x1804D9150")]
			get
			{
				return null;
			}
			[Token(Token = "0x60010E5")]
			[Address(RVA = "0x4D9280", Offset = "0x4D7880", VA = "0x1804D9280")]
			set
			{
			}
		}

		// Token: 0x060010E6 RID: 4326 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60010E6")]
		[Address(RVA = "0x4D8F60", Offset = "0x4D7560", VA = "0x1804D8F60", Slot = "6")]
		public void Set(ref DisconnectedCallbackInfo other)
		{
		}

		// Token: 0x060010E7 RID: 4327 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60010E7")]
		[Address(RVA = "0x4D8DE0", Offset = "0x4D73E0", VA = "0x1804D8DE0", Slot = "7")]
		public void Set(ref DisconnectedCallbackInfo? other)
		{
		}

		// Token: 0x060010E8 RID: 4328 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60010E8")]
		[Address(RVA = "0x4D8D50", Offset = "0x4D7350", VA = "0x1804D8D50", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x060010E9 RID: 4329 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60010E9")]
		[Address(RVA = "0x4D8DC0", Offset = "0x4D73C0", VA = "0x1804D8DC0", Slot = "5")]
		public void Get(out DisconnectedCallbackInfo output)
		{
		}

		// Token: 0x04000784 RID: 1924
		[Token(Token = "0x4000784")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x04000785 RID: 1925
		[Token(Token = "0x4000785")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;

		// Token: 0x04000786 RID: 1926
		[Token(Token = "0x4000786")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LocalUserId;

		// Token: 0x04000787 RID: 1927
		[Token(Token = "0x4000787")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_RoomName;
	}
}
