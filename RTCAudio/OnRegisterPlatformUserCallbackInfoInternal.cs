using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.RTCAudio
{
	// Token: 0x020001F5 RID: 501
	[Token(Token = "0x20001F5")]
	internal struct OnRegisterPlatformUserCallbackInfoInternal : ICallbackInfoInternal, IGettable<OnRegisterPlatformUserCallbackInfo>, ISettable<OnRegisterPlatformUserCallbackInfo>, IDisposable
	{
		// Token: 0x17000348 RID: 840
		// (get) Token: 0x06000DD2 RID: 3538 RVA: 0x00004994 File Offset: 0x00002B94
		// (set) Token: 0x06000DD3 RID: 3539 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000348")]
		public Result ResultCode
		{
			[Token(Token = "0x6000DD2")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x6000DD3")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x06000DD4 RID: 3540 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000DD5 RID: 3541 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000349")]
		public object ClientData
		{
			[Token(Token = "0x6000DD4")]
			[Address(RVA = "0x4DB9B0", Offset = "0x4D9FB0", VA = "0x1804DB9B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000DD5")]
			[Address(RVA = "0x4DBA90", Offset = "0x4DA090", VA = "0x1804DBA90")]
			set
			{
			}
		}

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x06000DD6 RID: 3542 RVA: 0x000049AC File Offset: 0x00002BAC
		[Token(Token = "0x1700034A")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x6000DD6")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x06000DD7 RID: 3543 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000DD8 RID: 3544 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700034B")]
		public Utf8String PlatformUserId
		{
			[Token(Token = "0x6000DD7")]
			[Address(RVA = "0x4DBA20", Offset = "0x4DA020", VA = "0x1804DBA20")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000DD8")]
			[Address(RVA = "0x4DBAF0", Offset = "0x4DA0F0", VA = "0x1804DBAF0")]
			set
			{
			}
		}

		// Token: 0x06000DD9 RID: 3545 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000DD9")]
		[Address(RVA = "0x4DB8F0", Offset = "0x4D9EF0", VA = "0x1804DB8F0", Slot = "6")]
		public void Set(ref OnRegisterPlatformUserCallbackInfo other)
		{
		}

		// Token: 0x06000DDA RID: 3546 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000DDA")]
		[Address(RVA = "0x4DB7D0", Offset = "0x4D9DD0", VA = "0x1804DB7D0", Slot = "7")]
		public void Set(ref OnRegisterPlatformUserCallbackInfo? other)
		{
		}

		// Token: 0x06000DDB RID: 3547 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000DDB")]
		[Address(RVA = "0x4DB750", Offset = "0x4D9D50", VA = "0x1804DB750", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06000DDC RID: 3548 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000DDC")]
		[Address(RVA = "0x4DB7B0", Offset = "0x4D9DB0", VA = "0x1804DB7B0", Slot = "5")]
		public void Get(out OnRegisterPlatformUserCallbackInfo output)
		{
		}

		// Token: 0x04000634 RID: 1588
		[Token(Token = "0x4000634")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x04000635 RID: 1589
		[Token(Token = "0x4000635")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;

		// Token: 0x04000636 RID: 1590
		[Token(Token = "0x4000636")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_PlatformUserId;
	}
}
