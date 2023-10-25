using System;


namespace Epic.OnlineServices.RTCAudio
{
	// Token: 0x020001C3 RID: 451
	[Token(Token = "0x20001C3")]
	internal struct AudioDevicesChangedCallbackInfoInternal : ICallbackInfoInternal, IGettable<AudioDevicesChangedCallbackInfo>, ISettable<AudioDevicesChangedCallbackInfo>, IDisposable
	{
		// Token: 0x1700030D RID: 781
		// (get) Token: 0x06000CD8 RID: 3288 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000CD9 RID: 3289 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700030D")]
		public object ClientData
		{
			[Token(Token = "0x6000CD8")]
			[Address(RVA = "0x4D5D50", Offset = "0x4D4350", VA = "0x1804D5D50")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000CD9")]
			[Address(RVA = "0x4D5DC0", Offset = "0x4D43C0", VA = "0x1804D5DC0")]
			set
			{
			}
		}

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x06000CDA RID: 3290 RVA: 0x000046DC File Offset: 0x000028DC
		[Token(Token = "0x1700030E")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x6000CDA")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000CDB RID: 3291 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000CDB")]
		[Address(RVA = "0x4D5CF0", Offset = "0x4D42F0", VA = "0x1804D5CF0", Slot = "6")]
		public void Set(ref AudioDevicesChangedCallbackInfo other)
		{
		}

		// Token: 0x06000CDC RID: 3292 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000CDC")]
		[Address(RVA = "0x4D5C50", Offset = "0x4D4250", VA = "0x1804D5C50", Slot = "7")]
		public void Set(ref AudioDevicesChangedCallbackInfo? other)
		{
		}

		// Token: 0x06000CDD RID: 3293 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000CDD")]
		[Address(RVA = "0x4D5BE0", Offset = "0x4D41E0", VA = "0x1804D5BE0", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06000CDE RID: 3294 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000CDE")]
		[Address(RVA = "0x4D5C30", Offset = "0x4D4230", VA = "0x1804D5C30", Slot = "5")]
		public void Get(out AudioDevicesChangedCallbackInfo output)
		{
		}

		// Token: 0x040005F3 RID: 1523
		[Token(Token = "0x40005F3")]
		[FieldOffset(Offset = "0x0")]
		private IntPtr m_ClientData;
	}
}
