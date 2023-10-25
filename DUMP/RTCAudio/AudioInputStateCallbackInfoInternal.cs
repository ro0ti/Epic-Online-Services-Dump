using System;


namespace Epic.OnlineServices.RTCAudio
{
	// Token: 0x020001C7 RID: 455
	[Token(Token = "0x20001C7")]
	internal struct AudioInputStateCallbackInfoInternal : ICallbackInfoInternal, IGettable<AudioInputStateCallbackInfo>, ISettable<AudioInputStateCallbackInfo>, IDisposable
	{
		// Token: 0x17000319 RID: 793
		// (get) Token: 0x06000CFA RID: 3322 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000CFB RID: 3323 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000319")]
		public object ClientData
		{
			[Token(Token = "0x6000CFA")]
			[Address(RVA = "0x4D6820", Offset = "0x4D4E20", VA = "0x1804D6820")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000CFB")]
			[Address(RVA = "0x4D6980", Offset = "0x4D4F80", VA = "0x1804D6980")]
			set
			{
			}
		}

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x06000CFC RID: 3324 RVA: 0x00004754 File Offset: 0x00002954
		[Token(Token = "0x1700031A")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x6000CFC")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x06000CFD RID: 3325 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000CFE RID: 3326 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700031B")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6000CFD")]
			[Address(RVA = "0x4D6890", Offset = "0x4D4E90", VA = "0x1804D6890")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000CFE")]
			[Address(RVA = "0x4D69E0", Offset = "0x4D4FE0", VA = "0x1804D69E0")]
			set
			{
			}
		}

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x06000CFF RID: 3327 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000D00 RID: 3328 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700031C")]
		public Utf8String RoomName
		{
			[Token(Token = "0x6000CFF")]
			[Address(RVA = "0x4D6910", Offset = "0x4D4F10", VA = "0x1804D6910")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000D00")]
			[Address(RVA = "0x4D6A40", Offset = "0x4D5040", VA = "0x1804D6A40")]
			set
			{
			}
		}

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x06000D01 RID: 3329 RVA: 0x0000476C File Offset: 0x0000296C
		// (set) Token: 0x06000D02 RID: 3330 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700031D")]
		public RTCAudioInputStatus Status
		{
			[Token(Token = "0x6000D01")]
			[Address(RVA = "0x4447E0", Offset = "0x442DE0", VA = "0x1804447E0")]
			get
			{
				return RTCAudioInputStatus.Idle;
			}
			[Token(Token = "0x6000D02")]
			[Address(RVA = "0x444820", Offset = "0x442E20", VA = "0x180444820")]
			set
			{
			}
		}

		// Token: 0x06000D03 RID: 3331 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D03")]
		[Address(RVA = "0x4D6720", Offset = "0x4D4D20", VA = "0x1804D6720", Slot = "6")]
		public void Set(ref AudioInputStateCallbackInfo other)
		{
		}

		// Token: 0x06000D04 RID: 3332 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D04")]
		[Address(RVA = "0x4D65A0", Offset = "0x4D4BA0", VA = "0x1804D65A0", Slot = "7")]
		public void Set(ref AudioInputStateCallbackInfo? other)
		{
		}

		// Token: 0x06000D05 RID: 3333 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D05")]
		[Address(RVA = "0x4D6520", Offset = "0x4D4B20", VA = "0x1804D6520", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06000D06 RID: 3334 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D06")]
		[Address(RVA = "0x4D6580", Offset = "0x4D4B80", VA = "0x1804D6580", Slot = "5")]
		public void Get(out AudioInputStateCallbackInfo output)
		{
		}

		// Token: 0x040005FF RID: 1535
		[Token(Token = "0x40005FF")]
		[FieldOffset(Offset = "0x0")]
		private IntPtr m_ClientData;

		// Token: 0x04000600 RID: 1536
		[Token(Token = "0x4000600")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x04000601 RID: 1537
		[Token(Token = "0x4000601")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_RoomName;

		// Token: 0x04000602 RID: 1538
		[Token(Token = "0x4000602")]
		[FieldOffset(Offset = "0x18")]
		private RTCAudioInputStatus m_Status;
	}
}
