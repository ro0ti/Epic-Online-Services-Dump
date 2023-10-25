using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.RTCAudio
{
	// Token: 0x0200023B RID: 571
	[Token(Token = "0x200023B")]
	internal struct UpdateSendingVolumeCallbackInfoInternal : ICallbackInfoInternal, IGettable<UpdateSendingVolumeCallbackInfo>, ISettable<UpdateSendingVolumeCallbackInfo>, IDisposable
	{
		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x06000FCD RID: 4045 RVA: 0x000050CC File Offset: 0x000032CC
		// (set) Token: 0x06000FCE RID: 4046 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170003EB")]
		public Result ResultCode
		{
			[Token(Token = "0x6000FCD")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x6000FCE")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x06000FCF RID: 4047 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000FD0 RID: 4048 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170003EC")]
		public object ClientData
		{
			[Token(Token = "0x6000FCF")]
			[Address(RVA = "0x4EA920", Offset = "0x4E8F20", VA = "0x1804EA920")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000FD0")]
			[Address(RVA = "0x4EAA80", Offset = "0x4E9080", VA = "0x1804EAA80")]
			set
			{
			}
		}

		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x06000FD1 RID: 4049 RVA: 0x000050E4 File Offset: 0x000032E4
		[Token(Token = "0x170003ED")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x6000FD1")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x06000FD2 RID: 4050 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000FD3 RID: 4051 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170003EE")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6000FD2")]
			[Address(RVA = "0x4EA990", Offset = "0x4E8F90", VA = "0x1804EA990")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000FD3")]
			[Address(RVA = "0x4EAAE0", Offset = "0x4E90E0", VA = "0x1804EAAE0")]
			set
			{
			}
		}

		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x06000FD4 RID: 4052 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000FD5 RID: 4053 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170003EF")]
		public Utf8String RoomName
		{
			[Token(Token = "0x6000FD4")]
			[Address(RVA = "0x4EAA10", Offset = "0x4E9010", VA = "0x1804EAA10")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000FD5")]
			[Address(RVA = "0x4EAB40", Offset = "0x4E9140", VA = "0x1804EAB40")]
			set
			{
			}
		}

		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x06000FD6 RID: 4054 RVA: 0x000050FC File Offset: 0x000032FC
		// (set) Token: 0x06000FD7 RID: 4055 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170003F0")]
		public float Volume
		{
			[Token(Token = "0x6000FD6")]
			[Address(RVA = "0x3E4000", Offset = "0x3E2600", VA = "0x1803E4000")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000FD7")]
			[Address(RVA = "0x3E4040", Offset = "0x3E2640", VA = "0x1803E4040")]
			set
			{
			}
		}

		// Token: 0x06000FD8 RID: 4056 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000FD8")]
		[Address(RVA = "0x4EA810", Offset = "0x4E8E10", VA = "0x1804EA810", Slot = "6")]
		public void Set(ref UpdateSendingVolumeCallbackInfo other)
		{
		}

		// Token: 0x06000FD9 RID: 4057 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000FD9")]
		[Address(RVA = "0x4EA670", Offset = "0x4E8C70", VA = "0x1804EA670", Slot = "7")]
		public void Set(ref UpdateSendingVolumeCallbackInfo? other)
		{
		}

		// Token: 0x06000FDA RID: 4058 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000FDA")]
		[Address(RVA = "0x4EA5D0", Offset = "0x4E8BD0", VA = "0x1804EA5D0", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06000FDB RID: 4059 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000FDB")]
		[Address(RVA = "0x4EA640", Offset = "0x4E8C40", VA = "0x1804EA640", Slot = "5")]
		public void Get(out UpdateSendingVolumeCallbackInfo output)
		{
		}

		// Token: 0x04000711 RID: 1809
		[Token(Token = "0x4000711")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x04000712 RID: 1810
		[Token(Token = "0x4000712")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;

		// Token: 0x04000713 RID: 1811
		[Token(Token = "0x4000713")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LocalUserId;

		// Token: 0x04000714 RID: 1812
		[Token(Token = "0x4000714")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_RoomName;

		// Token: 0x04000715 RID: 1813
		[Token(Token = "0x4000715")]
		[FieldOffset(Offset = "0x20")]
		private float m_Volume;
	}
}
