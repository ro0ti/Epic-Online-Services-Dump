using System;


namespace Epic.OnlineServices.Stats
{
	// Token: 0x020000E3 RID: 227
	[Token(Token = "0x20000E3")]
	internal struct StatInternal : IGettable<Stat>, ISettable<Stat>, IDisposable
	{
		// Token: 0x17000195 RID: 405
		// (get) Token: 0x060007F1 RID: 2033 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060007F2 RID: 2034 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000195")]
		public Utf8String Name
		{
			[Token(Token = "0x60007F1")]
			[Address(RVA = "0x4D1020", Offset = "0x4CF620", VA = "0x1804D1020")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007F2")]
			[Address(RVA = "0x4D1170", Offset = "0x4CF770", VA = "0x1804D1170")]
			set
			{
			}
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x060007F3 RID: 2035 RVA: 0x0000356C File Offset: 0x0000176C
		// (set) Token: 0x060007F4 RID: 2036 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000196")]
		public DateTimeOffset? StartTime
		{
			[Token(Token = "0x60007F3")]
			[Address(RVA = "0x4D1090", Offset = "0x4CF690", VA = "0x1804D1090")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007F4")]
			[Address(RVA = "0x4D11D0", Offset = "0x4CF7D0", VA = "0x1804D11D0")]
			set
			{
			}
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x060007F5 RID: 2037 RVA: 0x00003584 File Offset: 0x00001784
		// (set) Token: 0x060007F6 RID: 2038 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000197")]
		public DateTimeOffset? EndTime
		{
			[Token(Token = "0x60007F5")]
			[Address(RVA = "0x4D0FB0", Offset = "0x4CF5B0", VA = "0x1804D0FB0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007F6")]
			[Address(RVA = "0x4D1100", Offset = "0x4CF700", VA = "0x1804D1100")]
			set
			{
			}
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x060007F7 RID: 2039 RVA: 0x0000359C File Offset: 0x0000179C
		// (set) Token: 0x060007F8 RID: 2040 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000198")]
		public int Value
		{
			[Token(Token = "0x60007F7")]
			[Address(RVA = "0x3D2F80", Offset = "0x3D1580", VA = "0x1803D2F80")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60007F8")]
			[Address(RVA = "0x488190", Offset = "0x486790", VA = "0x180488190")]
			set
			{
			}
		}

		// Token: 0x060007F9 RID: 2041 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007F9")]
		[Address(RVA = "0x4D0E50", Offset = "0x4CF450", VA = "0x1804D0E50", Slot = "5")]
		public void Set(ref Stat other)
		{
		}

		// Token: 0x060007FA RID: 2042 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007FA")]
		[Address(RVA = "0x4D0C90", Offset = "0x4CF290", VA = "0x1804D0C90", Slot = "6")]
		public void Set(ref Stat? other)
		{
		}

		// Token: 0x060007FB RID: 2043 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007FB")]
		[Address(RVA = "0x4D0C10", Offset = "0x4CF210", VA = "0x1804D0C10", Slot = "7")]
		public void Dispose()
		{
		}

		// Token: 0x060007FC RID: 2044 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007FC")]
		[Address(RVA = "0x4D0C60", Offset = "0x4CF260", VA = "0x1804D0C60", Slot = "4")]
		public void Get(out Stat output)
		{
		}

		// Token: 0x040003DD RID: 989
		[Token(Token = "0x40003DD")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x040003DE RID: 990
		[Token(Token = "0x40003DE")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_Name;

		// Token: 0x040003DF RID: 991
		[Token(Token = "0x40003DF")]
		[FieldOffset(Offset = "0x10")]
		private long m_StartTime;

		// Token: 0x040003E0 RID: 992
		[Token(Token = "0x40003E0")]
		[FieldOffset(Offset = "0x18")]
		private long m_EndTime;

		// Token: 0x040003E1 RID: 993
		[Token(Token = "0x40003E1")]
		[FieldOffset(Offset = "0x20")]
		private int m_Value;
	}
}
