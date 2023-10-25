using System;


namespace Epic.OnlineServices.UI
{
	// Token: 0x02000072 RID: 114
	[Token(Token = "0x2000072")]
	internal struct MemoryMonitorCallbackInfoInternal : ICallbackInfoInternal, IGettable<MemoryMonitorCallbackInfo>, ISettable<MemoryMonitorCallbackInfo>, IDisposable
	{
		// Token: 0x1700009F RID: 159
		// (get) Token: 0x060004F5 RID: 1269 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060004F6 RID: 1270 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700009F")]
		public object ClientData
		{
			[Token(Token = "0x60004F5")]
			[Address(RVA = "0x4AA8F0", Offset = "0x4A8EF0", VA = "0x1804AA8F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004F6")]
			[Address(RVA = "0x4AA990", Offset = "0x4A8F90", VA = "0x1804AA990")]
			set
			{
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x060004F7 RID: 1271 RVA: 0x0000296C File Offset: 0x00000B6C
		[Token(Token = "0x170000A0")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x60004F7")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x060004F8 RID: 1272 RVA: 0x00002984 File Offset: 0x00000B84
		// (set) Token: 0x060004F9 RID: 1273 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000A1")]
		public IntPtr SystemMemoryMonitorReport
		{
			[Token(Token = "0x60004F8")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60004F9")]
			[Address(RVA = "0x487590", Offset = "0x485B90", VA = "0x180487590")]
			set
			{
			}
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x4AA830", Offset = "0x4A8E30", VA = "0x1804AA830", Slot = "6")]
		public void Set(ref MemoryMonitorCallbackInfo other)
		{
		}

		// Token: 0x060004FB RID: 1275 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x4AA860", Offset = "0x4A8E60", VA = "0x1804AA860", Slot = "7")]
		public void Set(ref MemoryMonitorCallbackInfo? other)
		{
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x4AA720", Offset = "0x4A8D20", VA = "0x1804AA720", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x4AA7F0", Offset = "0x4A8DF0", VA = "0x1804AA7F0", Slot = "5")]
		public void Get(out MemoryMonitorCallbackInfo output)
		{
		}

		// Token: 0x040002A5 RID: 677
		[Token(Token = "0x40002A5")]
		[FieldOffset(Offset = "0x0")]
		private IntPtr m_ClientData;

		// Token: 0x040002A6 RID: 678
		[Token(Token = "0x40002A6")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_SystemMemoryMonitorReport;
	}
}
