using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Sessions
{
	// Token: 0x0200016B RID: 363
	[Token(Token = "0x200016B")]
	internal struct SessionInviteRejectedCallbackInfoInternal : ICallbackInfoInternal, IGettable<SessionInviteRejectedCallbackInfo>, ISettable<SessionInviteRejectedCallbackInfo>, IDisposable
	{
		// Token: 0x17000271 RID: 625
		// (get) Token: 0x06000ADA RID: 2778 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000ADB RID: 2779 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000271")]
		public object ClientData
		{
			[Token(Token = "0x6000ADA")]
			[Address(RVA = "0x4CA4A0", Offset = "0x4C8AA0", VA = "0x1804CA4A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000ADB")]
			[Address(RVA = "0x4CA6F0", Offset = "0x4C8CF0", VA = "0x1804CA6F0")]
			set
			{
			}
		}

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x06000ADC RID: 2780 RVA: 0x00003ECC File Offset: 0x000020CC
		[Token(Token = "0x17000272")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x6000ADC")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x06000ADD RID: 2781 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000ADE RID: 2782 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000273")]
		public Utf8String InviteId
		{
			[Token(Token = "0x6000ADD")]
			[Address(RVA = "0x4CA510", Offset = "0x4C8B10", VA = "0x1804CA510")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000ADE")]
			[Address(RVA = "0x4CA750", Offset = "0x4C8D50", VA = "0x1804CA750")]
			set
			{
			}
		}

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x06000ADF RID: 2783 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000AE0 RID: 2784 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000274")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6000ADF")]
			[Address(RVA = "0x4CA580", Offset = "0x4C8B80", VA = "0x1804CA580")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AE0")]
			[Address(RVA = "0x4CA7B0", Offset = "0x4C8DB0", VA = "0x1804CA7B0")]
			set
			{
			}
		}

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x06000AE1 RID: 2785 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000AE2 RID: 2786 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000275")]
		public ProductUserId TargetUserId
		{
			[Token(Token = "0x6000AE1")]
			[Address(RVA = "0x4CA670", Offset = "0x4C8C70", VA = "0x1804CA670")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AE2")]
			[Address(RVA = "0x4CA870", Offset = "0x4C8E70", VA = "0x1804CA870")]
			set
			{
			}
		}

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x06000AE3 RID: 2787 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000AE4 RID: 2788 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000276")]
		public Utf8String SessionId
		{
			[Token(Token = "0x6000AE3")]
			[Address(RVA = "0x4CA600", Offset = "0x4C8C00", VA = "0x1804CA600")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AE4")]
			[Address(RVA = "0x4CA810", Offset = "0x4C8E10", VA = "0x1804CA810")]
			set
			{
			}
		}

		// Token: 0x06000AE5 RID: 2789 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AE5")]
		[Address(RVA = "0x4CA320", Offset = "0x4C8920", VA = "0x1804CA320", Slot = "6")]
		public void Set(ref SessionInviteRejectedCallbackInfo other)
		{
		}

		// Token: 0x06000AE6 RID: 2790 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AE6")]
		[Address(RVA = "0x4CA110", Offset = "0x4C8710", VA = "0x1804CA110", Slot = "7")]
		public void Set(ref SessionInviteRejectedCallbackInfo? other)
		{
		}

		// Token: 0x06000AE7 RID: 2791 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AE7")]
		[Address(RVA = "0x4CA060", Offset = "0x4C8660", VA = "0x1804CA060", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06000AE8 RID: 2792 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AE8")]
		[Address(RVA = "0x4CA0E0", Offset = "0x4C86E0", VA = "0x1804CA0E0", Slot = "5")]
		public void Get(out SessionInviteRejectedCallbackInfo output)
		{
		}

		// Token: 0x040004FD RID: 1277
		[Token(Token = "0x40004FD")]
		[FieldOffset(Offset = "0x0")]
		private IntPtr m_ClientData;

		// Token: 0x040004FE RID: 1278
		[Token(Token = "0x40004FE")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_InviteId;

		// Token: 0x040004FF RID: 1279
		[Token(Token = "0x40004FF")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LocalUserId;

		// Token: 0x04000500 RID: 1280
		[Token(Token = "0x4000500")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_TargetUserId;

		// Token: 0x04000501 RID: 1281
		[Token(Token = "0x4000501")]
		[FieldOffset(Offset = "0x20")]
		private IntPtr m_SessionId;
	}
}
