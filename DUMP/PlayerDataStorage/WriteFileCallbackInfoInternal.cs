using System;


namespace Epic.OnlineServices.PlayerDataStorage
{
	// Token: 0x02000310 RID: 784
	[Token(Token = "0x2000310")]
	internal struct WriteFileCallbackInfoInternal : ICallbackInfoInternal, IGettable<WriteFileCallbackInfo>, ISettable<WriteFileCallbackInfo>, IDisposable
	{
		// Token: 0x170005A9 RID: 1449
		// (get) Token: 0x0600153E RID: 5438 RVA: 0x000060A4 File Offset: 0x000042A4
		// (set) Token: 0x0600153F RID: 5439 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170005A9")]
		public Result ResultCode
		{
			[Token(Token = "0x600153E")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x600153F")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x170005AA RID: 1450
		// (get) Token: 0x06001540 RID: 5440 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001541 RID: 5441 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170005AA")]
		public object ClientData
		{
			[Token(Token = "0x6001540")]
			[Address(RVA = "0x504070", Offset = "0x502670", VA = "0x180504070")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001541")]
			[Address(RVA = "0x5041D0", Offset = "0x5027D0", VA = "0x1805041D0")]
			set
			{
			}
		}

		// Token: 0x170005AB RID: 1451
		// (get) Token: 0x06001542 RID: 5442 RVA: 0x000060BC File Offset: 0x000042BC
		[Token(Token = "0x170005AB")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x6001542")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170005AC RID: 1452
		// (get) Token: 0x06001543 RID: 5443 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001544 RID: 5444 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170005AC")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6001543")]
			[Address(RVA = "0x504150", Offset = "0x502750", VA = "0x180504150")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001544")]
			[Address(RVA = "0x504290", Offset = "0x502890", VA = "0x180504290")]
			set
			{
			}
		}

		// Token: 0x170005AD RID: 1453
		// (get) Token: 0x06001545 RID: 5445 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001546 RID: 5446 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170005AD")]
		public Utf8String Filename
		{
			[Token(Token = "0x6001545")]
			[Address(RVA = "0x5040E0", Offset = "0x5026E0", VA = "0x1805040E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001546")]
			[Address(RVA = "0x504230", Offset = "0x502830", VA = "0x180504230")]
			set
			{
			}
		}

		// Token: 0x06001547 RID: 5447 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001547")]
		[Address(RVA = "0x503F70", Offset = "0x502570", VA = "0x180503F70", Slot = "6")]
		public void Set(ref WriteFileCallbackInfo other)
		{
		}

		// Token: 0x06001548 RID: 5448 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001548")]
		[Address(RVA = "0x503DF0", Offset = "0x5023F0", VA = "0x180503DF0", Slot = "7")]
		public void Set(ref WriteFileCallbackInfo? other)
		{
		}

		// Token: 0x06001549 RID: 5449 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001549")]
		[Address(RVA = "0x503D60", Offset = "0x502360", VA = "0x180503D60", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x0600154A RID: 5450 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600154A")]
		[Address(RVA = "0x503DD0", Offset = "0x5023D0", VA = "0x180503DD0", Slot = "5")]
		public void Get(out WriteFileCallbackInfo output)
		{
		}

		// Token: 0x04000958 RID: 2392
		[Token(Token = "0x4000958")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x04000959 RID: 2393
		[Token(Token = "0x4000959")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;

		// Token: 0x0400095A RID: 2394
		[Token(Token = "0x400095A")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LocalUserId;

		// Token: 0x0400095B RID: 2395
		[Token(Token = "0x400095B")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_Filename;
	}
}
