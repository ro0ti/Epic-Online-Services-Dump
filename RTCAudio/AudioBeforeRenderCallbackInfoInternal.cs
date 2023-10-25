using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.RTCAudio
{
	// Token: 0x020001BD RID: 445
	[Token(Token = "0x20001BD")]
	internal struct AudioBeforeRenderCallbackInfoInternal : ICallbackInfoInternal, IGettable<AudioBeforeRenderCallbackInfo>, ISettable<AudioBeforeRenderCallbackInfo>, IDisposable
	{
		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x06000C9D RID: 3229 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000C9E RID: 3230 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170002F7")]
		public object ClientData
		{
			[Token(Token = "0x6000C9D")]
			[Address(RVA = "0x4D4A80", Offset = "0x4D3080", VA = "0x1804D4A80")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C9E")]
			[Address(RVA = "0x4D4CD0", Offset = "0x4D32D0", VA = "0x1804D4CD0")]
			set
			{
			}
		}

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x06000C9F RID: 3231 RVA: 0x000045D4 File Offset: 0x000027D4
		[Token(Token = "0x170002F8")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x6000C9F")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x06000CA0 RID: 3232 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000CA1 RID: 3233 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170002F9")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6000CA0")]
			[Address(RVA = "0x4D4AF0", Offset = "0x4D30F0", VA = "0x1804D4AF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000CA1")]
			[Address(RVA = "0x4D4D30", Offset = "0x4D3330", VA = "0x1804D4D30")]
			set
			{
			}
		}

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x06000CA2 RID: 3234 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000CA3 RID: 3235 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170002FA")]
		public Utf8String RoomName
		{
			[Token(Token = "0x6000CA2")]
			[Address(RVA = "0x4D4BF0", Offset = "0x4D31F0", VA = "0x1804D4BF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000CA3")]
			[Address(RVA = "0x4D4DF0", Offset = "0x4D33F0", VA = "0x1804D4DF0")]
			set
			{
			}
		}

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x06000CA4 RID: 3236 RVA: 0x000045EC File Offset: 0x000027EC
		// (set) Token: 0x06000CA5 RID: 3237 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170002FB")]
		public AudioBuffer? Buffer
		{
			[Token(Token = "0x6000CA4")]
			[Address(RVA = "0x4D4A00", Offset = "0x4D3000", VA = "0x1804D4A00")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000CA5")]
			[Address(RVA = "0x4D4C60", Offset = "0x4D3260", VA = "0x1804D4C60")]
			set
			{
			}
		}

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x06000CA6 RID: 3238 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000CA7 RID: 3239 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170002FC")]
		public ProductUserId ParticipantId
		{
			[Token(Token = "0x6000CA6")]
			[Address(RVA = "0x4D4B70", Offset = "0x4D3170", VA = "0x1804D4B70")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000CA7")]
			[Address(RVA = "0x4D4D90", Offset = "0x4D3390", VA = "0x1804D4D90")]
			set
			{
			}
		}

		// Token: 0x06000CA8 RID: 3240 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000CA8")]
		[Address(RVA = "0x4D4610", Offset = "0x4D2C10", VA = "0x1804D4610", Slot = "6")]
		public void Set(ref AudioBeforeRenderCallbackInfo other)
		{
		}

		// Token: 0x06000CA9 RID: 3241 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000CA9")]
		[Address(RVA = "0x4D47C0", Offset = "0x4D2DC0", VA = "0x1804D47C0", Slot = "7")]
		public void Set(ref AudioBeforeRenderCallbackInfo? other)
		{
		}

		// Token: 0x06000CAA RID: 3242 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000CAA")]
		[Address(RVA = "0x4D4560", Offset = "0x4D2B60", VA = "0x1804D4560", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06000CAB RID: 3243 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000CAB")]
		[Address(RVA = "0x4D45E0", Offset = "0x4D2BE0", VA = "0x1804D45E0", Slot = "5")]
		public void Get(out AudioBeforeRenderCallbackInfo output)
		{
		}

		// Token: 0x040005DD RID: 1501
		[Token(Token = "0x40005DD")]
		[FieldOffset(Offset = "0x0")]
		private IntPtr m_ClientData;

		// Token: 0x040005DE RID: 1502
		[Token(Token = "0x40005DE")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x040005DF RID: 1503
		[Token(Token = "0x40005DF")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_RoomName;

		// Token: 0x040005E0 RID: 1504
		[Token(Token = "0x40005E0")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_Buffer;

		// Token: 0x040005E1 RID: 1505
		[Token(Token = "0x40005E1")]
		[FieldOffset(Offset = "0x20")]
		private IntPtr m_ParticipantId;
	}
}
