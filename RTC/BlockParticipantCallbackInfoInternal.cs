using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.RTC
{
	// Token: 0x0200025E RID: 606
	[Token(Token = "0x200025E")]
	internal struct BlockParticipantCallbackInfoInternal : ICallbackInfoInternal, IGettable<BlockParticipantCallbackInfo>, ISettable<BlockParticipantCallbackInfo>, IDisposable
	{
		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x060010B3 RID: 4275 RVA: 0x00005384 File Offset: 0x00003584
		// (set) Token: 0x060010B4 RID: 4276 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700043E")]
		public Result ResultCode
		{
			[Token(Token = "0x60010B3")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x60010B4")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x060010B5 RID: 4277 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060010B6 RID: 4278 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700043F")]
		public object ClientData
		{
			[Token(Token = "0x60010B5")]
			[Address(RVA = "0x4D7D70", Offset = "0x4D6370", VA = "0x1804D7D70")]
			get
			{
				return null;
			}
			[Token(Token = "0x60010B6")]
			[Address(RVA = "0x4D7FB0", Offset = "0x4D65B0", VA = "0x1804D7FB0")]
			set
			{
			}
		}

		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x060010B7 RID: 4279 RVA: 0x0000539C File Offset: 0x0000359C
		[Token(Token = "0x17000440")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x60010B7")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x060010B8 RID: 4280 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060010B9 RID: 4281 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000441")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x60010B8")]
			[Address(RVA = "0x4D7DE0", Offset = "0x4D63E0", VA = "0x1804D7DE0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60010B9")]
			[Address(RVA = "0x4D8010", Offset = "0x4D6610", VA = "0x1804D8010")]
			set
			{
			}
		}

		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x060010BA RID: 4282 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060010BB RID: 4283 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000442")]
		public Utf8String RoomName
		{
			[Token(Token = "0x60010BA")]
			[Address(RVA = "0x4D7EE0", Offset = "0x4D64E0", VA = "0x1804D7EE0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60010BB")]
			[Address(RVA = "0x4D80D0", Offset = "0x4D66D0", VA = "0x1804D80D0")]
			set
			{
			}
		}

		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x060010BC RID: 4284 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060010BD RID: 4285 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000443")]
		public ProductUserId ParticipantId
		{
			[Token(Token = "0x60010BC")]
			[Address(RVA = "0x4D7E60", Offset = "0x4D6460", VA = "0x1804D7E60")]
			get
			{
				return null;
			}
			[Token(Token = "0x60010BD")]
			[Address(RVA = "0x4D8070", Offset = "0x4D6670", VA = "0x1804D8070")]
			set
			{
			}
		}

		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x060010BE RID: 4286 RVA: 0x000053B4 File Offset: 0x000035B4
		// (set) Token: 0x060010BF RID: 4287 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000444")]
		public bool Blocked
		{
			[Token(Token = "0x60010BE")]
			[Address(RVA = "0x4D7D10", Offset = "0x4D6310", VA = "0x1804D7D10")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60010BF")]
			[Address(RVA = "0x4D7F50", Offset = "0x4D6550", VA = "0x1804D7F50")]
			set
			{
			}
		}

		// Token: 0x060010C0 RID: 4288 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60010C0")]
		[Address(RVA = "0x4D7B80", Offset = "0x4D6180", VA = "0x1804D7B80", Slot = "6")]
		public void Set(ref BlockParticipantCallbackInfo other)
		{
		}

		// Token: 0x060010C1 RID: 4289 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60010C1")]
		[Address(RVA = "0x4D7960", Offset = "0x4D5F60", VA = "0x1804D7960", Slot = "7")]
		public void Set(ref BlockParticipantCallbackInfo? other)
		{
		}

		// Token: 0x060010C2 RID: 4290 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60010C2")]
		[Address(RVA = "0x4D78C0", Offset = "0x4D5EC0", VA = "0x1804D78C0", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x060010C3 RID: 4291 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60010C3")]
		[Address(RVA = "0x4D7940", Offset = "0x4D5F40", VA = "0x1804D7940", Slot = "5")]
		public void Get(out BlockParticipantCallbackInfo output)
		{
		}

		// Token: 0x04000771 RID: 1905
		[Token(Token = "0x4000771")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x04000772 RID: 1906
		[Token(Token = "0x4000772")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;

		// Token: 0x04000773 RID: 1907
		[Token(Token = "0x4000773")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LocalUserId;

		// Token: 0x04000774 RID: 1908
		[Token(Token = "0x4000774")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_RoomName;

		// Token: 0x04000775 RID: 1909
		[Token(Token = "0x4000775")]
		[FieldOffset(Offset = "0x20")]
		private IntPtr m_ParticipantId;

		// Token: 0x04000776 RID: 1910
		[Token(Token = "0x4000776")]
		[FieldOffset(Offset = "0x28")]
		private int m_Blocked;
	}
}
