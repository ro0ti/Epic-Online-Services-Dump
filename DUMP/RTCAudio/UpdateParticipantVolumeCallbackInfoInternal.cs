using System;


namespace Epic.OnlineServices.RTCAudio
{
	// Token: 0x0200022B RID: 555
	[Token(Token = "0x200022B")]
	internal struct UpdateParticipantVolumeCallbackInfoInternal : ICallbackInfoInternal, IGettable<UpdateParticipantVolumeCallbackInfo>, ISettable<UpdateParticipantVolumeCallbackInfo>, IDisposable
	{
		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x06000F25 RID: 3877 RVA: 0x00004E2C File Offset: 0x0000302C
		// (set) Token: 0x06000F26 RID: 3878 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170003A0")]
		public Result ResultCode
		{
			[Token(Token = "0x6000F25")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x6000F26")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x06000F27 RID: 3879 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000F28 RID: 3880 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170003A1")]
		public object ClientData
		{
			[Token(Token = "0x6000F27")]
			[Address(RVA = "0x4E7910", Offset = "0x4E5F10", VA = "0x1804E7910")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000F28")]
			[Address(RVA = "0x4E7AF0", Offset = "0x4E60F0", VA = "0x1804E7AF0")]
			set
			{
			}
		}

		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x06000F29 RID: 3881 RVA: 0x00004E44 File Offset: 0x00003044
		[Token(Token = "0x170003A2")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x6000F29")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x06000F2A RID: 3882 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000F2B RID: 3883 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170003A3")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6000F2A")]
			[Address(RVA = "0x4E7980", Offset = "0x4E5F80", VA = "0x1804E7980")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000F2B")]
			[Address(RVA = "0x4E7B50", Offset = "0x4E6150", VA = "0x1804E7B50")]
			set
			{
			}
		}

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x06000F2C RID: 3884 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000F2D RID: 3885 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170003A4")]
		public Utf8String RoomName
		{
			[Token(Token = "0x6000F2C")]
			[Address(RVA = "0x4E7A80", Offset = "0x4E6080", VA = "0x1804E7A80")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000F2D")]
			[Address(RVA = "0x4E7C10", Offset = "0x4E6210", VA = "0x1804E7C10")]
			set
			{
			}
		}

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x06000F2E RID: 3886 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000F2F RID: 3887 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170003A5")]
		public ProductUserId ParticipantId
		{
			[Token(Token = "0x6000F2E")]
			[Address(RVA = "0x4E7A00", Offset = "0x4E6000", VA = "0x1804E7A00")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000F2F")]
			[Address(RVA = "0x4E7BB0", Offset = "0x4E61B0", VA = "0x1804E7BB0")]
			set
			{
			}
		}

		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x06000F30 RID: 3888 RVA: 0x00004E5C File Offset: 0x0000305C
		// (set) Token: 0x06000F31 RID: 3889 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170003A6")]
		public float Volume
		{
			[Token(Token = "0x6000F30")]
			[Address(RVA = "0x3E3FE0", Offset = "0x3E25E0", VA = "0x1803E3FE0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000F31")]
			[Address(RVA = "0x3E4020", Offset = "0x3E2620", VA = "0x1803E4020")]
			set
			{
			}
		}

		// Token: 0x06000F32 RID: 3890 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F32")]
		[Address(RVA = "0x4E75D0", Offset = "0x4E5BD0", VA = "0x1804E75D0", Slot = "6")]
		public void Set(ref UpdateParticipantVolumeCallbackInfo other)
		{
		}

		// Token: 0x06000F33 RID: 3891 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F33")]
		[Address(RVA = "0x4E7720", Offset = "0x4E5D20", VA = "0x1804E7720", Slot = "7")]
		public void Set(ref UpdateParticipantVolumeCallbackInfo? other)
		{
		}

		// Token: 0x06000F34 RID: 3892 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F34")]
		[Address(RVA = "0x4E7530", Offset = "0x4E5B30", VA = "0x1804E7530", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06000F35 RID: 3893 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F35")]
		[Address(RVA = "0x4E75B0", Offset = "0x4E5BB0", VA = "0x1804E75B0", Slot = "5")]
		public void Get(out UpdateParticipantVolumeCallbackInfo output)
		{
		}

		// Token: 0x040006C6 RID: 1734
		[Token(Token = "0x40006C6")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x040006C7 RID: 1735
		[Token(Token = "0x40006C7")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;

		// Token: 0x040006C8 RID: 1736
		[Token(Token = "0x40006C8")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LocalUserId;

		// Token: 0x040006C9 RID: 1737
		[Token(Token = "0x40006C9")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_RoomName;

		// Token: 0x040006CA RID: 1738
		[Token(Token = "0x40006CA")]
		[FieldOffset(Offset = "0x20")]
		private IntPtr m_ParticipantId;

		// Token: 0x040006CB RID: 1739
		[Token(Token = "0x40006CB")]
		[FieldOffset(Offset = "0x28")]
		private float m_Volume;
	}
}
