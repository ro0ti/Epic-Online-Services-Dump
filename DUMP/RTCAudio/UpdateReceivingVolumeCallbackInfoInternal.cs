using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.RTCAudio
{
	// Token: 0x02000233 RID: 563
	[Token(Token = "0x2000233")]
	internal struct UpdateReceivingVolumeCallbackInfoInternal : ICallbackInfoInternal, IGettable<UpdateReceivingVolumeCallbackInfo>, ISettable<UpdateReceivingVolumeCallbackInfo>, IDisposable
	{
		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x06000F7F RID: 3967 RVA: 0x00004F7C File Offset: 0x0000317C
		// (set) Token: 0x06000F80 RID: 3968 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170003C9")]
		public Result ResultCode
		{
			[Token(Token = "0x6000F7F")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x6000F80")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x06000F81 RID: 3969 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000F82 RID: 3970 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170003CA")]
		public object ClientData
		{
			[Token(Token = "0x6000F81")]
			[Address(RVA = "0x4E9490", Offset = "0x4E7A90", VA = "0x1804E9490")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000F82")]
			[Address(RVA = "0x4E95F0", Offset = "0x4E7BF0", VA = "0x1804E95F0")]
			set
			{
			}
		}

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x06000F83 RID: 3971 RVA: 0x00004F94 File Offset: 0x00003194
		[Token(Token = "0x170003CB")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x6000F83")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x06000F84 RID: 3972 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000F85 RID: 3973 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170003CC")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6000F84")]
			[Address(RVA = "0x4E9500", Offset = "0x4E7B00", VA = "0x1804E9500")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000F85")]
			[Address(RVA = "0x4E9650", Offset = "0x4E7C50", VA = "0x1804E9650")]
			set
			{
			}
		}

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x06000F86 RID: 3974 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000F87 RID: 3975 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170003CD")]
		public Utf8String RoomName
		{
			[Token(Token = "0x6000F86")]
			[Address(RVA = "0x4E9580", Offset = "0x4E7B80", VA = "0x1804E9580")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000F87")]
			[Address(RVA = "0x4E96B0", Offset = "0x4E7CB0", VA = "0x1804E96B0")]
			set
			{
			}
		}

		// Token: 0x170003CE RID: 974
		// (get) Token: 0x06000F88 RID: 3976 RVA: 0x00004FAC File Offset: 0x000031AC
		// (set) Token: 0x06000F89 RID: 3977 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170003CE")]
		public float Volume
		{
			[Token(Token = "0x6000F88")]
			[Address(RVA = "0x3E4000", Offset = "0x3E2600", VA = "0x1803E4000")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000F89")]
			[Address(RVA = "0x3E4040", Offset = "0x3E2640", VA = "0x1803E4040")]
			set
			{
			}
		}

		// Token: 0x06000F8A RID: 3978 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F8A")]
		[Address(RVA = "0x4E9380", Offset = "0x4E7980", VA = "0x1804E9380", Slot = "6")]
		public void Set(ref UpdateReceivingVolumeCallbackInfo other)
		{
		}

		// Token: 0x06000F8B RID: 3979 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F8B")]
		[Address(RVA = "0x4E91E0", Offset = "0x4E77E0", VA = "0x1804E91E0", Slot = "7")]
		public void Set(ref UpdateReceivingVolumeCallbackInfo? other)
		{
		}

		// Token: 0x06000F8C RID: 3980 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F8C")]
		[Address(RVA = "0x4E9140", Offset = "0x4E7740", VA = "0x1804E9140", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06000F8D RID: 3981 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F8D")]
		[Address(RVA = "0x4E91B0", Offset = "0x4E77B0", VA = "0x1804E91B0", Slot = "5")]
		public void Get(out UpdateReceivingVolumeCallbackInfo output)
		{
		}

		// Token: 0x040006EF RID: 1775
		[Token(Token = "0x40006EF")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x040006F0 RID: 1776
		[Token(Token = "0x40006F0")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;

		// Token: 0x040006F1 RID: 1777
		[Token(Token = "0x40006F1")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LocalUserId;

		// Token: 0x040006F2 RID: 1778
		[Token(Token = "0x40006F2")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_RoomName;

		// Token: 0x040006F3 RID: 1779
		[Token(Token = "0x40006F3")]
		[FieldOffset(Offset = "0x20")]
		private float m_Volume;
	}
}
