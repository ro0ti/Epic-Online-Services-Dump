using System;


namespace Epic.OnlineServices.PlayerDataStorage
{
	// Token: 0x02000303 RID: 771
	[Token(Token = "0x2000303")]
	internal struct QueryFileListCallbackInfoInternal : ICallbackInfoInternal, IGettable<QueryFileListCallbackInfo>, ISettable<QueryFileListCallbackInfo>, IDisposable
	{
		// Token: 0x1700057A RID: 1402
		// (get) Token: 0x060014D0 RID: 5328 RVA: 0x00005EF4 File Offset: 0x000040F4
		// (set) Token: 0x060014D1 RID: 5329 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700057A")]
		public Result ResultCode
		{
			[Token(Token = "0x60014D0")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x60014D1")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x1700057B RID: 1403
		// (get) Token: 0x060014D2 RID: 5330 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060014D3 RID: 5331 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700057B")]
		public object ClientData
		{
			[Token(Token = "0x60014D2")]
			[Address(RVA = "0x4FDA30", Offset = "0x4FC030", VA = "0x1804FDA30")]
			get
			{
				return null;
			}
			[Token(Token = "0x60014D3")]
			[Address(RVA = "0x4FDB20", Offset = "0x4FC120", VA = "0x1804FDB20")]
			set
			{
			}
		}

		// Token: 0x1700057C RID: 1404
		// (get) Token: 0x060014D4 RID: 5332 RVA: 0x00005F0C File Offset: 0x0000410C
		[Token(Token = "0x1700057C")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x60014D4")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700057D RID: 1405
		// (get) Token: 0x060014D5 RID: 5333 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060014D6 RID: 5334 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700057D")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x60014D5")]
			[Address(RVA = "0x4FDAA0", Offset = "0x4FC0A0", VA = "0x1804FDAA0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60014D6")]
			[Address(RVA = "0x4FDB80", Offset = "0x4FC180", VA = "0x1804FDB80")]
			set
			{
			}
		}

		// Token: 0x1700057E RID: 1406
		// (get) Token: 0x060014D7 RID: 5335 RVA: 0x00005F24 File Offset: 0x00004124
		// (set) Token: 0x060014D8 RID: 5336 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700057E")]
		public uint FileCount
		{
			[Token(Token = "0x60014D7")]
			[Address(RVA = "0x4447E0", Offset = "0x442DE0", VA = "0x1804447E0")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x60014D8")]
			[Address(RVA = "0x444820", Offset = "0x442E20", VA = "0x180444820")]
			set
			{
			}
		}

		// Token: 0x060014D9 RID: 5337 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60014D9")]
		[Address(RVA = "0x4FD960", Offset = "0x4FBF60", VA = "0x1804FD960", Slot = "6")]
		public void Set(ref QueryFileListCallbackInfo other)
		{
		}

		// Token: 0x060014DA RID: 5338 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60014DA")]
		[Address(RVA = "0x4FD820", Offset = "0x4FBE20", VA = "0x1804FD820", Slot = "7")]
		public void Set(ref QueryFileListCallbackInfo? other)
		{
		}

		// Token: 0x060014DB RID: 5339 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60014DB")]
		[Address(RVA = "0x4FD7A0", Offset = "0x4FBDA0", VA = "0x1804FD7A0", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x060014DC RID: 5340 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60014DC")]
		[Address(RVA = "0x4FD800", Offset = "0x4FBE00", VA = "0x1804FD800", Slot = "5")]
		public void Get(out QueryFileListCallbackInfo output)
		{
		}

		// Token: 0x04000922 RID: 2338
		[Token(Token = "0x4000922")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x04000923 RID: 2339
		[Token(Token = "0x4000923")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;

		// Token: 0x04000924 RID: 2340
		[Token(Token = "0x4000924")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LocalUserId;

		// Token: 0x04000925 RID: 2341
		[Token(Token = "0x4000925")]
		[FieldOffset(Offset = "0x18")]
		private uint m_FileCount;
	}
}
