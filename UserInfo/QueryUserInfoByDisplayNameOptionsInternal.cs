using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.UserInfo
{
	// Token: 0x0200004F RID: 79
	[Token(Token = "0x200004F")]
	internal struct QueryUserInfoByDisplayNameOptionsInternal : ISettable<QueryUserInfoByDisplayNameOptions>, IDisposable
	{
		// Token: 0x1700005E RID: 94
		// (set) Token: 0x06000435 RID: 1077 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700005E")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x6000435")]
			[Address(RVA = "0x4ADE90", Offset = "0x4AC490", VA = "0x1804ADE90")]
			set
			{
			}
		}

		// Token: 0x1700005F RID: 95
		// (set) Token: 0x06000436 RID: 1078 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700005F")]
		public Utf8String DisplayName
		{
			[Token(Token = "0x6000436")]
			[Address(RVA = "0x4ADE30", Offset = "0x4AC430", VA = "0x1804ADE30")]
			set
			{
			}
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000437")]
		[Address(RVA = "0x4ADCF0", Offset = "0x4AC2F0", VA = "0x1804ADCF0", Slot = "4")]
		public void Set(ref QueryUserInfoByDisplayNameOptions other)
		{
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000438")]
		[Address(RVA = "0x4ADD60", Offset = "0x4AC360", VA = "0x1804ADD60", Slot = "5")]
		public void Set(ref QueryUserInfoByDisplayNameOptions? other)
		{
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000439")]
		[Address(RVA = "0x4ADC10", Offset = "0x4AC210", VA = "0x1804ADC10", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x040001CA RID: 458
		[Token(Token = "0x40001CA")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x040001CB RID: 459
		[Token(Token = "0x40001CB")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x040001CC RID: 460
		[Token(Token = "0x40001CC")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_DisplayName;
	}
}
