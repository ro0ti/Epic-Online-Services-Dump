using System;


namespace Epic.OnlineServices.RTC
{
	// Token: 0x02000283 RID: 643
	[Token(Token = "0x2000283")]
	internal struct SetRoomSettingOptionsInternal : ISettable<SetRoomSettingOptions>, IDisposable
	{
		// Token: 0x170004A2 RID: 1186
		// (set) Token: 0x060011E0 RID: 4576 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170004A2")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x60011E0")]
			[Address(RVA = "0x503520", Offset = "0x501B20", VA = "0x180503520")]
			set
			{
			}
		}

		// Token: 0x170004A3 RID: 1187
		// (set) Token: 0x060011E1 RID: 4577 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170004A3")]
		public Utf8String RoomName
		{
			[Token(Token = "0x60011E1")]
			[Address(RVA = "0x503580", Offset = "0x501B80", VA = "0x180503580")]
			set
			{
			}
		}

		// Token: 0x170004A4 RID: 1188
		// (set) Token: 0x060011E2 RID: 4578 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170004A4")]
		public Utf8String SettingName
		{
			[Token(Token = "0x60011E2")]
			[Address(RVA = "0x5035E0", Offset = "0x501BE0", VA = "0x1805035E0")]
			set
			{
			}
		}

		// Token: 0x170004A5 RID: 1189
		// (set) Token: 0x060011E3 RID: 4579 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170004A5")]
		public Utf8String SettingValue
		{
			[Token(Token = "0x60011E3")]
			[Address(RVA = "0x503640", Offset = "0x501C40", VA = "0x180503640")]
			set
			{
			}
		}

		// Token: 0x060011E4 RID: 4580 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60011E4")]
		[Address(RVA = "0x5033D0", Offset = "0x5019D0", VA = "0x1805033D0", Slot = "4")]
		public void Set(ref SetRoomSettingOptions other)
		{
		}

		// Token: 0x060011E5 RID: 4581 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60011E5")]
		[Address(RVA = "0x503210", Offset = "0x501810", VA = "0x180503210", Slot = "5")]
		public void Set(ref SetRoomSettingOptions? other)
		{
		}

		// Token: 0x060011E6 RID: 4582 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60011E6")]
		[Address(RVA = "0x503190", Offset = "0x501790", VA = "0x180503190", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x040007EB RID: 2027
		[Token(Token = "0x40007EB")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x040007EC RID: 2028
		[Token(Token = "0x40007EC")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x040007ED RID: 2029
		[Token(Token = "0x40007ED")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_RoomName;

		// Token: 0x040007EE RID: 2030
		[Token(Token = "0x40007EE")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_SettingName;

		// Token: 0x040007EF RID: 2031
		[Token(Token = "0x40007EF")]
		[FieldOffset(Offset = "0x20")]
		private IntPtr m_SettingValue;
	}
}
