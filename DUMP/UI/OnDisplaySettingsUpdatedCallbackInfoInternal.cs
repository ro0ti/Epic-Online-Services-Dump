using System;


namespace Epic.OnlineServices.UI
{
	// Token: 0x02000077 RID: 119
	[Token(Token = "0x2000077")]
	internal struct OnDisplaySettingsUpdatedCallbackInfoInternal : ICallbackInfoInternal, IGettable<OnDisplaySettingsUpdatedCallbackInfo>, ISettable<OnDisplaySettingsUpdatedCallbackInfo>, IDisposable
	{
		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x0600050E RID: 1294 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600050F RID: 1295 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000A5")]
		public object ClientData
		{
			[Token(Token = "0x600050E")]
			[Address(RVA = "0x4AAC60", Offset = "0x4A9260", VA = "0x1804AAC60")]
			get
			{
				return null;
			}
			[Token(Token = "0x600050F")]
			[Address(RVA = "0x4AAE00", Offset = "0x4A9400", VA = "0x1804AAE00")]
			set
			{
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x06000510 RID: 1296 RVA: 0x000029E4 File Offset: 0x00000BE4
		[Token(Token = "0x170000A6")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x6000510")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x06000511 RID: 1297 RVA: 0x000029FC File Offset: 0x00000BFC
		// (set) Token: 0x06000512 RID: 1298 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000A7")]
		public bool IsVisible
		{
			[Token(Token = "0x6000511")]
			[Address(RVA = "0x4AAD80", Offset = "0x4A9380", VA = "0x1804AAD80")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000512")]
			[Address(RVA = "0x4AAF20", Offset = "0x4A9520", VA = "0x1804AAF20")]
			set
			{
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x06000513 RID: 1299 RVA: 0x00002A14 File Offset: 0x00000C14
		// (set) Token: 0x06000514 RID: 1300 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000A8")]
		public bool IsExclusiveInput
		{
			[Token(Token = "0x6000513")]
			[Address(RVA = "0x4AAD00", Offset = "0x4A9300", VA = "0x1804AAD00")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000514")]
			[Address(RVA = "0x4AAEA0", Offset = "0x4A94A0", VA = "0x1804AAEA0")]
			set
			{
			}
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000515")]
		[Address(RVA = "0x4AAB50", Offset = "0x4A9150", VA = "0x1804AAB50", Slot = "6")]
		public void Set(ref OnDisplaySettingsUpdatedCallbackInfo other)
		{
		}

		// Token: 0x06000516 RID: 1302 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000516")]
		[Address(RVA = "0x4AABA0", Offset = "0x4A91A0", VA = "0x1804AABA0", Slot = "7")]
		public void Set(ref OnDisplaySettingsUpdatedCallbackInfo? other)
		{
		}

		// Token: 0x06000517 RID: 1303 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000517")]
		[Address(RVA = "0x4AAA70", Offset = "0x4A9070", VA = "0x1804AAA70", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000518")]
		[Address(RVA = "0x4AAB00", Offset = "0x4A9100", VA = "0x1804AAB00", Slot = "5")]
		public void Get(out OnDisplaySettingsUpdatedCallbackInfo output)
		{
		}

		// Token: 0x040002AF RID: 687
		[Token(Token = "0x40002AF")]
		[FieldOffset(Offset = "0x0")]
		private IntPtr m_ClientData;

		// Token: 0x040002B0 RID: 688
		[Token(Token = "0x40002B0")]
		[FieldOffset(Offset = "0x8")]
		private int m_IsVisible;

		// Token: 0x040002B1 RID: 689
		[Token(Token = "0x40002B1")]
		[FieldOffset(Offset = "0xC")]
		private int m_IsExclusiveInput;
	}
}
