using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.RTCAudio
{
	// Token: 0x0200022F RID: 559
	[Token(Token = "0x200022F")]
	internal struct UpdateReceivingCallbackInfoInternal : ICallbackInfoInternal, IGettable<UpdateReceivingCallbackInfo>, ISettable<UpdateReceivingCallbackInfo>, IDisposable
	{
		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x06000F53 RID: 3923 RVA: 0x00004ED4 File Offset: 0x000030D4
		// (set) Token: 0x06000F54 RID: 3924 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170003B5")]
		public Result ResultCode
		{
			[Token(Token = "0x6000F53")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x6000F54")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x06000F55 RID: 3925 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000F56 RID: 3926 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170003B6")]
		public object ClientData
		{
			[Token(Token = "0x6000F55")]
			[Address(RVA = "0x4E86C0", Offset = "0x4E6CC0", VA = "0x1804E86C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000F56")]
			[Address(RVA = "0x4E8900", Offset = "0x4E6F00", VA = "0x1804E8900")]
			set
			{
			}
		}

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x06000F57 RID: 3927 RVA: 0x00004EEC File Offset: 0x000030EC
		[Token(Token = "0x170003B7")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x6000F57")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x06000F58 RID: 3928 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000F59 RID: 3929 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170003B8")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6000F58")]
			[Address(RVA = "0x4E8730", Offset = "0x4E6D30", VA = "0x1804E8730")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000F59")]
			[Address(RVA = "0x4E8960", Offset = "0x4E6F60", VA = "0x1804E8960")]
			set
			{
			}
		}

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x06000F5A RID: 3930 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000F5B RID: 3931 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170003B9")]
		public Utf8String RoomName
		{
			[Token(Token = "0x6000F5A")]
			[Address(RVA = "0x4E8830", Offset = "0x4E6E30", VA = "0x1804E8830")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000F5B")]
			[Address(RVA = "0x4E8A20", Offset = "0x4E7020", VA = "0x1804E8A20")]
			set
			{
			}
		}

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x06000F5C RID: 3932 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000F5D RID: 3933 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170003BA")]
		public ProductUserId ParticipantId
		{
			[Token(Token = "0x6000F5C")]
			[Address(RVA = "0x4E87B0", Offset = "0x4E6DB0", VA = "0x1804E87B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000F5D")]
			[Address(RVA = "0x4E89C0", Offset = "0x4E6FC0", VA = "0x1804E89C0")]
			set
			{
			}
		}

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x06000F5E RID: 3934 RVA: 0x00004F04 File Offset: 0x00003104
		// (set) Token: 0x06000F5F RID: 3935 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170003BB")]
		public bool AudioEnabled
		{
			[Token(Token = "0x6000F5E")]
			[Address(RVA = "0x4E8660", Offset = "0x4E6C60", VA = "0x1804E8660")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000F5F")]
			[Address(RVA = "0x4E88A0", Offset = "0x4E6EA0", VA = "0x1804E88A0")]
			set
			{
			}
		}

		// Token: 0x06000F60 RID: 3936 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F60")]
		[Address(RVA = "0x4E84D0", Offset = "0x4E6AD0", VA = "0x1804E84D0", Slot = "6")]
		public void Set(ref UpdateReceivingCallbackInfo other)
		{
		}

		// Token: 0x06000F61 RID: 3937 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F61")]
		[Address(RVA = "0x4E82B0", Offset = "0x4E68B0", VA = "0x1804E82B0", Slot = "7")]
		public void Set(ref UpdateReceivingCallbackInfo? other)
		{
		}

		// Token: 0x06000F62 RID: 3938 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F62")]
		[Address(RVA = "0x4E8210", Offset = "0x4E6810", VA = "0x1804E8210", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06000F63 RID: 3939 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F63")]
		[Address(RVA = "0x4E8290", Offset = "0x4E6890", VA = "0x1804E8290", Slot = "5")]
		public void Get(out UpdateReceivingCallbackInfo output)
		{
		}

		// Token: 0x040006DB RID: 1755
		[Token(Token = "0x40006DB")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x040006DC RID: 1756
		[Token(Token = "0x40006DC")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;

		// Token: 0x040006DD RID: 1757
		[Token(Token = "0x40006DD")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LocalUserId;

		// Token: 0x040006DE RID: 1758
		[Token(Token = "0x40006DE")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_RoomName;

		// Token: 0x040006DF RID: 1759
		[Token(Token = "0x40006DF")]
		[FieldOffset(Offset = "0x20")]
		private IntPtr m_ParticipantId;

		// Token: 0x040006E0 RID: 1760
		[Token(Token = "0x40006E0")]
		[FieldOffset(Offset = "0x28")]
		private int m_AudioEnabled;
	}
}
