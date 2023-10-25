using System;


namespace Epic.OnlineServices.RTC
{
	// Token: 0x02000279 RID: 633
	[Token(Token = "0x2000279")]
	internal struct OptionInternal : IGettable<Option>, ISettable<Option>, IDisposable
	{
		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x06001175 RID: 4469 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001176 RID: 4470 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000480")]
		public Utf8String Key
		{
			[Token(Token = "0x6001175")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6070", VA = "0x1804F7A70")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001176")]
			[Address(RVA = "0x4F7B50", Offset = "0x4F6150", VA = "0x1804F7B50")]
			set
			{
			}
		}

		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x06001177 RID: 4471 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001178 RID: 4472 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000481")]
		public Utf8String Value
		{
			[Token(Token = "0x6001177")]
			[Address(RVA = "0x4F7AE0", Offset = "0x4F60E0", VA = "0x1804F7AE0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001178")]
			[Address(RVA = "0x4F7BB0", Offset = "0x4F61B0", VA = "0x1804F7BB0")]
			set
			{
			}
		}

		// Token: 0x06001179 RID: 4473 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001179")]
		[Address(RVA = "0x4F78A0", Offset = "0x4F5EA0", VA = "0x1804F78A0", Slot = "5")]
		public void Set(ref Option other)
		{
		}

		// Token: 0x0600117A RID: 4474 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600117A")]
		[Address(RVA = "0x4F7960", Offset = "0x4F5F60", VA = "0x1804F7960", Slot = "6")]
		public void Set(ref Option? other)
		{
		}

		// Token: 0x0600117B RID: 4475 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600117B")]
		[Address(RVA = "0x4F7820", Offset = "0x4F5E20", VA = "0x1804F7820", Slot = "7")]
		public void Dispose()
		{
		}

		// Token: 0x0600117C RID: 4476 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600117C")]
		[Address(RVA = "0x4F7880", Offset = "0x4F5E80", VA = "0x1804F7880", Slot = "4")]
		public void Get(out Option output)
		{
		}

		// Token: 0x040007B7 RID: 1975
		[Token(Token = "0x40007B7")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x040007B8 RID: 1976
		[Token(Token = "0x40007B8")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_Key;

		// Token: 0x040007B9 RID: 1977
		[Token(Token = "0x40007B9")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_Value;
	}
}
