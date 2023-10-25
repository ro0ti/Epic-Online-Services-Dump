using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.RTC
{
	// Token: 0x02000285 RID: 645
	[Token(Token = "0x2000285")]
	internal struct SetSettingOptionsInternal : ISettable<SetSettingOptions>, IDisposable
	{
		// Token: 0x170004A8 RID: 1192
		// (set) Token: 0x060011EB RID: 4587 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170004A8")]
		public Utf8String SettingName
		{
			[Token(Token = "0x60011EB")]
			[Address(RVA = "0x5038D0", Offset = "0x501ED0", VA = "0x1805038D0")]
			set
			{
			}
		}

		// Token: 0x170004A9 RID: 1193
		// (set) Token: 0x060011EC RID: 4588 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170004A9")]
		public Utf8String SettingValue
		{
			[Token(Token = "0x60011EC")]
			[Address(RVA = "0x503930", Offset = "0x501F30", VA = "0x180503930")]
			set
			{
			}
		}

		// Token: 0x060011ED RID: 4589 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60011ED")]
		[Address(RVA = "0x503700", Offset = "0x501D00", VA = "0x180503700", Slot = "4")]
		public void Set(ref SetSettingOptions other)
		{
		}

		// Token: 0x060011EE RID: 4590 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60011EE")]
		[Address(RVA = "0x5037C0", Offset = "0x501DC0", VA = "0x1805037C0", Slot = "5")]
		public void Set(ref SetSettingOptions? other)
		{
		}

		// Token: 0x060011EF RID: 4591 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60011EF")]
		[Address(RVA = "0x5036A0", Offset = "0x501CA0", VA = "0x1805036A0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x040007F2 RID: 2034
		[Token(Token = "0x40007F2")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x040007F3 RID: 2035
		[Token(Token = "0x40007F3")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_SettingName;

		// Token: 0x040007F4 RID: 2036
		[Token(Token = "0x40007F4")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_SettingValue;
	}
}
