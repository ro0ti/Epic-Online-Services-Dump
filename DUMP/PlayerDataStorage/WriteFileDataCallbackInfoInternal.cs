using System;


namespace Epic.OnlineServices.PlayerDataStorage
{
	// Token: 0x02000312 RID: 786
	[Token(Token = "0x2000312")]
	internal struct WriteFileDataCallbackInfoInternal : ICallbackInfoInternal, IGettable<WriteFileDataCallbackInfo>, ISettable<WriteFileDataCallbackInfo>, IDisposable
	{
		// Token: 0x170005B2 RID: 1458
		// (get) Token: 0x06001555 RID: 5461 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001556 RID: 5462 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170005B2")]
		public object ClientData
		{
			[Token(Token = "0x6001555")]
			[Address(RVA = "0x504750", Offset = "0x502D50", VA = "0x180504750")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001556")]
			[Address(RVA = "0x5048B0", Offset = "0x502EB0", VA = "0x1805048B0")]
			set
			{
			}
		}

		// Token: 0x170005B3 RID: 1459
		// (get) Token: 0x06001557 RID: 5463 RVA: 0x00006104 File Offset: 0x00004304
		[Token(Token = "0x170005B3")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x6001557")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170005B4 RID: 1460
		// (get) Token: 0x06001558 RID: 5464 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001559 RID: 5465 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170005B4")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6001558")]
			[Address(RVA = "0x504830", Offset = "0x502E30", VA = "0x180504830")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001559")]
			[Address(RVA = "0x504970", Offset = "0x502F70", VA = "0x180504970")]
			set
			{
			}
		}

		// Token: 0x170005B5 RID: 1461
		// (get) Token: 0x0600155A RID: 5466 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600155B RID: 5467 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170005B5")]
		public Utf8String Filename
		{
			[Token(Token = "0x600155A")]
			[Address(RVA = "0x5047C0", Offset = "0x502DC0", VA = "0x1805047C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600155B")]
			[Address(RVA = "0x504910", Offset = "0x502F10", VA = "0x180504910")]
			set
			{
			}
		}

		// Token: 0x170005B6 RID: 1462
		// (get) Token: 0x0600155C RID: 5468 RVA: 0x0000611C File Offset: 0x0000431C
		// (set) Token: 0x0600155D RID: 5469 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170005B6")]
		public uint DataBufferLengthBytes
		{
			[Token(Token = "0x600155C")]
			[Address(RVA = "0x4447E0", Offset = "0x442DE0", VA = "0x1804447E0")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x600155D")]
			[Address(RVA = "0x444820", Offset = "0x442E20", VA = "0x180444820")]
			set
			{
			}
		}

		// Token: 0x0600155E RID: 5470 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600155E")]
		[Address(RVA = "0x504650", Offset = "0x502C50", VA = "0x180504650", Slot = "6")]
		public void Set(ref WriteFileDataCallbackInfo other)
		{
		}

		// Token: 0x0600155F RID: 5471 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600155F")]
		[Address(RVA = "0x5044D0", Offset = "0x502AD0", VA = "0x1805044D0", Slot = "7")]
		public void Set(ref WriteFileDataCallbackInfo? other)
		{
		}

		// Token: 0x06001560 RID: 5472 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001560")]
		[Address(RVA = "0x504450", Offset = "0x502A50", VA = "0x180504450", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06001561 RID: 5473 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001561")]
		[Address(RVA = "0x5044B0", Offset = "0x502AB0", VA = "0x1805044B0", Slot = "5")]
		public void Get(out WriteFileDataCallbackInfo output)
		{
		}

		// Token: 0x04000960 RID: 2400
		[Token(Token = "0x4000960")]
		[FieldOffset(Offset = "0x0")]
		private IntPtr m_ClientData;

		// Token: 0x04000961 RID: 2401
		[Token(Token = "0x4000961")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x04000962 RID: 2402
		[Token(Token = "0x4000962")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_Filename;

		// Token: 0x04000963 RID: 2403
		[Token(Token = "0x4000963")]
		[FieldOffset(Offset = "0x18")]
		private uint m_DataBufferLengthBytes;
	}
}
