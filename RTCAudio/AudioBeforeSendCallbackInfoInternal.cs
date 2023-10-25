using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.RTCAudio
{
	// Token: 0x020001BF RID: 447
	[Token(Token = "0x20001BF")]
	internal struct AudioBeforeSendCallbackInfoInternal : ICallbackInfoInternal, IGettable<AudioBeforeSendCallbackInfo>, ISettable<AudioBeforeSendCallbackInfo>, IDisposable
	{
		// Token: 0x17000301 RID: 769
		// (get) Token: 0x06000CB6 RID: 3254 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000CB7 RID: 3255 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000301")]
		public object ClientData
		{
			[Token(Token = "0x6000CB6")]
			[Address(RVA = "0x4D5490", Offset = "0x4D3A90", VA = "0x1804D5490")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000CB7")]
			[Address(RVA = "0x4D5660", Offset = "0x4D3C60", VA = "0x1804D5660")]
			set
			{
			}
		}

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x06000CB8 RID: 3256 RVA: 0x00004634 File Offset: 0x00002834
		[Token(Token = "0x17000302")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x6000CB8")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x06000CB9 RID: 3257 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000CBA RID: 3258 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000303")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6000CB9")]
			[Address(RVA = "0x4D5500", Offset = "0x4D3B00", VA = "0x1804D5500")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000CBA")]
			[Address(RVA = "0x4D56C0", Offset = "0x4D3CC0", VA = "0x1804D56C0")]
			set
			{
			}
		}

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x06000CBB RID: 3259 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000CBC RID: 3260 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000304")]
		public Utf8String RoomName
		{
			[Token(Token = "0x6000CBB")]
			[Address(RVA = "0x4D5580", Offset = "0x4D3B80", VA = "0x1804D5580")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000CBC")]
			[Address(RVA = "0x4D5720", Offset = "0x4D3D20", VA = "0x1804D5720")]
			set
			{
			}
		}

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x06000CBD RID: 3261 RVA: 0x0000464C File Offset: 0x0000284C
		// (set) Token: 0x06000CBE RID: 3262 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000305")]
		public AudioBuffer? Buffer
		{
			[Token(Token = "0x6000CBD")]
			[Address(RVA = "0x4D5410", Offset = "0x4D3A10", VA = "0x1804D5410")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000CBE")]
			[Address(RVA = "0x4D55F0", Offset = "0x4D3BF0", VA = "0x1804D55F0")]
			set
			{
			}
		}

		// Token: 0x06000CBF RID: 3263 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000CBF")]
		[Address(RVA = "0x4D50D0", Offset = "0x4D36D0", VA = "0x1804D50D0", Slot = "6")]
		public void Set(ref AudioBeforeSendCallbackInfo other)
		{
		}

		// Token: 0x06000CC0 RID: 3264 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000CC0")]
		[Address(RVA = "0x4D5230", Offset = "0x4D3830", VA = "0x1804D5230", Slot = "7")]
		public void Set(ref AudioBeforeSendCallbackInfo? other)
		{
		}

		// Token: 0x06000CC1 RID: 3265 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000CC1")]
		[Address(RVA = "0x4D5040", Offset = "0x4D3640", VA = "0x1804D5040", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06000CC2 RID: 3266 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000CC2")]
		[Address(RVA = "0x4D50B0", Offset = "0x4D36B0", VA = "0x1804D50B0", Slot = "5")]
		public void Get(out AudioBeforeSendCallbackInfo output)
		{
		}

		// Token: 0x040005E6 RID: 1510
		[Token(Token = "0x40005E6")]
		[FieldOffset(Offset = "0x0")]
		private IntPtr m_ClientData;

		// Token: 0x040005E7 RID: 1511
		[Token(Token = "0x40005E7")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x040005E8 RID: 1512
		[Token(Token = "0x40005E8")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_RoomName;

		// Token: 0x040005E9 RID: 1513
		[Token(Token = "0x40005E9")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_Buffer;
	}
}
