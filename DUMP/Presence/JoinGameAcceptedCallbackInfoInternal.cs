using System;


namespace Epic.OnlineServices.Presence
{
	// Token: 0x020002B2 RID: 690
	[Token(Token = "0x20002B2")]
	internal struct JoinGameAcceptedCallbackInfoInternal : ICallbackInfoInternal, IGettable<JoinGameAcceptedCallbackInfo>, ISettable<JoinGameAcceptedCallbackInfo>, IDisposable
	{
		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x060012E9 RID: 4841 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060012EA RID: 4842 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170004FE")]
		public object ClientData
		{
			[Token(Token = "0x60012E9")]
			[Address(RVA = "0x4F3CF0", Offset = "0x4F22F0", VA = "0x1804F3CF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60012EA")]
			[Address(RVA = "0x4F3ED0", Offset = "0x4F24D0", VA = "0x1804F3ED0")]
			set
			{
			}
		}

		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x060012EB RID: 4843 RVA: 0x000058DC File Offset: 0x00003ADC
		[Token(Token = "0x170004FF")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x60012EB")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x060012EC RID: 4844 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060012ED RID: 4845 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000500")]
		public Utf8String JoinInfo
		{
			[Token(Token = "0x60012EC")]
			[Address(RVA = "0x4F3D60", Offset = "0x4F2360", VA = "0x1804F3D60")]
			get
			{
				return null;
			}
			[Token(Token = "0x60012ED")]
			[Address(RVA = "0x4F3F30", Offset = "0x4F2530", VA = "0x1804F3F30")]
			set
			{
			}
		}

		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x060012EE RID: 4846 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060012EF RID: 4847 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000501")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x60012EE")]
			[Address(RVA = "0x4F3DD0", Offset = "0x4F23D0", VA = "0x1804F3DD0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60012EF")]
			[Address(RVA = "0x4F3F90", Offset = "0x4F2590", VA = "0x1804F3F90")]
			set
			{
			}
		}

		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x060012F0 RID: 4848 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060012F1 RID: 4849 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000502")]
		public EpicAccountId TargetUserId
		{
			[Token(Token = "0x60012F0")]
			[Address(RVA = "0x4F3E50", Offset = "0x4F2450", VA = "0x1804F3E50")]
			get
			{
				return null;
			}
			[Token(Token = "0x60012F1")]
			[Address(RVA = "0x4F3FF0", Offset = "0x4F25F0", VA = "0x1804F3FF0")]
			set
			{
			}
		}

		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x060012F2 RID: 4850 RVA: 0x000058F4 File Offset: 0x00003AF4
		// (set) Token: 0x060012F3 RID: 4851 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000503")]
		public ulong UiEventId
		{
			[Token(Token = "0x60012F2")]
			[Address(RVA = "0x4447A0", Offset = "0x442DA0", VA = "0x1804447A0")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x60012F3")]
			[Address(RVA = "0x4F4050", Offset = "0x4F2650", VA = "0x1804F4050")]
			set
			{
			}
		}

		// Token: 0x060012F4 RID: 4852 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60012F4")]
		[Address(RVA = "0x4F3BA0", Offset = "0x4F21A0", VA = "0x1804F3BA0", Slot = "6")]
		public void Set(ref JoinGameAcceptedCallbackInfo other)
		{
		}

		// Token: 0x060012F5 RID: 4853 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60012F5")]
		[Address(RVA = "0x4F39D0", Offset = "0x4F1FD0", VA = "0x1804F39D0", Slot = "7")]
		public void Set(ref JoinGameAcceptedCallbackInfo? other)
		{
		}

		// Token: 0x060012F6 RID: 4854 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60012F6")]
		[Address(RVA = "0x4F3930", Offset = "0x4F1F30", VA = "0x1804F3930", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x060012F7 RID: 4855 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60012F7")]
		[Address(RVA = "0x4F39A0", Offset = "0x4F1FA0", VA = "0x1804F39A0", Slot = "5")]
		public void Get(out JoinGameAcceptedCallbackInfo output)
		{
		}

		// Token: 0x04000867 RID: 2151
		[Token(Token = "0x4000867")]
		[FieldOffset(Offset = "0x0")]
		private IntPtr m_ClientData;

		// Token: 0x04000868 RID: 2152
		[Token(Token = "0x4000868")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_JoinInfo;

		// Token: 0x04000869 RID: 2153
		[Token(Token = "0x4000869")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LocalUserId;

		// Token: 0x0400086A RID: 2154
		[Token(Token = "0x400086A")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_TargetUserId;

		// Token: 0x0400086B RID: 2155
		[Token(Token = "0x400086B")]
		[FieldOffset(Offset = "0x20")]
		private ulong m_UiEventId;
	}
}
