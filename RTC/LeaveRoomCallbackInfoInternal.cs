using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.RTC
{
	// Token: 0x02000269 RID: 617
	[Token(Token = "0x2000269")]
	internal struct LeaveRoomCallbackInfoInternal : ICallbackInfoInternal, IGettable<LeaveRoomCallbackInfo>, ISettable<LeaveRoomCallbackInfo>, IDisposable
	{
		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x0600112A RID: 4394 RVA: 0x0000551C File Offset: 0x0000371C
		// (set) Token: 0x0600112B RID: 4395 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000475")]
		public Result ResultCode
		{
			[Token(Token = "0x600112A")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x600112B")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x0600112C RID: 4396 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600112D RID: 4397 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000476")]
		public object ClientData
		{
			[Token(Token = "0x600112C")]
			[Address(RVA = "0x4F5550", Offset = "0x4F3B50", VA = "0x1804F5550")]
			get
			{
				return null;
			}
			[Token(Token = "0x600112D")]
			[Address(RVA = "0x4F56B0", Offset = "0x4F3CB0", VA = "0x1804F56B0")]
			set
			{
			}
		}

		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x0600112E RID: 4398 RVA: 0x00005534 File Offset: 0x00003734
		[Token(Token = "0x17000477")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x600112E")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x0600112F RID: 4399 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001130 RID: 4400 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000478")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x600112F")]
			[Address(RVA = "0x4F55C0", Offset = "0x4F3BC0", VA = "0x1804F55C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001130")]
			[Address(RVA = "0x4F5710", Offset = "0x4F3D10", VA = "0x1804F5710")]
			set
			{
			}
		}

		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x06001131 RID: 4401 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001132 RID: 4402 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000479")]
		public Utf8String RoomName
		{
			[Token(Token = "0x6001131")]
			[Address(RVA = "0x4F5640", Offset = "0x4F3C40", VA = "0x1804F5640")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001132")]
			[Address(RVA = "0x4F5770", Offset = "0x4F3D70", VA = "0x1804F5770")]
			set
			{
			}
		}

		// Token: 0x06001133 RID: 4403 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001133")]
		[Address(RVA = "0x4F5450", Offset = "0x4F3A50", VA = "0x1804F5450", Slot = "6")]
		public void Set(ref LeaveRoomCallbackInfo other)
		{
		}

		// Token: 0x06001134 RID: 4404 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001134")]
		[Address(RVA = "0x4F52D0", Offset = "0x4F38D0", VA = "0x1804F52D0", Slot = "7")]
		public void Set(ref LeaveRoomCallbackInfo? other)
		{
		}

		// Token: 0x06001135 RID: 4405 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001135")]
		[Address(RVA = "0x4F5240", Offset = "0x4F3840", VA = "0x1804F5240", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06001136 RID: 4406 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001136")]
		[Address(RVA = "0x4F52B0", Offset = "0x4F38B0", VA = "0x1804F52B0", Slot = "5")]
		public void Get(out LeaveRoomCallbackInfo output)
		{
		}

		// Token: 0x040007AC RID: 1964
		[Token(Token = "0x40007AC")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x040007AD RID: 1965
		[Token(Token = "0x40007AD")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;

		// Token: 0x040007AE RID: 1966
		[Token(Token = "0x40007AE")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LocalUserId;

		// Token: 0x040007AF RID: 1967
		[Token(Token = "0x40007AF")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_RoomName;
	}
}
