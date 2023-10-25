using System;


namespace Epic.OnlineServices.RTC
{
	// Token: 0x02000264 RID: 612
	[Token(Token = "0x2000264")]
	internal struct JoinRoomCallbackInfoInternal : ICallbackInfoInternal, IGettable<JoinRoomCallbackInfo>, ISettable<JoinRoomCallbackInfo>, IDisposable
	{
		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x060010F6 RID: 4342 RVA: 0x00005474 File Offset: 0x00003674
		// (set) Token: 0x060010F7 RID: 4343 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700045B")]
		public Result ResultCode
		{
			[Token(Token = "0x60010F6")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x60010F7")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x060010F8 RID: 4344 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060010F9 RID: 4345 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700045C")]
		public object ClientData
		{
			[Token(Token = "0x60010F8")]
			[Address(RVA = "0x4F44E0", Offset = "0x4F2AE0", VA = "0x1804F44E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60010F9")]
			[Address(RVA = "0x4F46D0", Offset = "0x4F2CD0", VA = "0x1804F46D0")]
			set
			{
			}
		}

		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x060010FA RID: 4346 RVA: 0x0000548C File Offset: 0x0000368C
		[Token(Token = "0x1700045D")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x60010FA")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x060010FB RID: 4347 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060010FC RID: 4348 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700045E")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x60010FB")]
			[Address(RVA = "0x4F4550", Offset = "0x4F2B50", VA = "0x1804F4550")]
			get
			{
				return null;
			}
			[Token(Token = "0x60010FC")]
			[Address(RVA = "0x4F4730", Offset = "0x4F2D30", VA = "0x1804F4730")]
			set
			{
			}
		}

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x060010FD RID: 4349 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060010FE RID: 4350 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700045F")]
		public Utf8String RoomName
		{
			[Token(Token = "0x60010FD")]
			[Address(RVA = "0x4F45D0", Offset = "0x4F2BD0", VA = "0x1804F45D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60010FE")]
			[Address(RVA = "0x4F4790", Offset = "0x4F2D90", VA = "0x1804F4790")]
			set
			{
			}
		}

		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x060010FF RID: 4351 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001100 RID: 4352 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000460")]
		public Option[] RoomOptions
		{
			[Token(Token = "0x60010FF")]
			[Address(RVA = "0x4F4640", Offset = "0x4F2C40", VA = "0x1804F4640")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001100")]
			[Address(RVA = "0x4F47F0", Offset = "0x4F2DF0", VA = "0x1804F47F0")]
			set
			{
			}
		}

		// Token: 0x06001101 RID: 4353 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001101")]
		[Address(RVA = "0x4F4230", Offset = "0x4F2830", VA = "0x1804F4230", Slot = "6")]
		public void Set(ref JoinRoomCallbackInfo other)
		{
		}

		// Token: 0x06001102 RID: 4354 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001102")]
		[Address(RVA = "0x4F4340", Offset = "0x4F2940", VA = "0x1804F4340", Slot = "7")]
		public void Set(ref JoinRoomCallbackInfo? other)
		{
		}

		// Token: 0x06001103 RID: 4355 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001103")]
		[Address(RVA = "0x4F4180", Offset = "0x4F2780", VA = "0x1804F4180", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06001104 RID: 4356 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001104")]
		[Address(RVA = "0x4F4200", Offset = "0x4F2800", VA = "0x1804F4200", Slot = "5")]
		public void Get(out JoinRoomCallbackInfo output)
		{
		}

		// Token: 0x0400078D RID: 1933
		[Token(Token = "0x400078D")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x0400078E RID: 1934
		[Token(Token = "0x400078E")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;

		// Token: 0x0400078F RID: 1935
		[Token(Token = "0x400078F")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LocalUserId;

		// Token: 0x04000790 RID: 1936
		[Token(Token = "0x4000790")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_RoomName;

		// Token: 0x04000791 RID: 1937
		[Token(Token = "0x4000791")]
		[FieldOffset(Offset = "0x20")]
		private uint m_RoomOptionsCount;

		// Token: 0x04000792 RID: 1938
		[Token(Token = "0x4000792")]
		[FieldOffset(Offset = "0x28")]
		private IntPtr m_RoomOptions;
	}
}
