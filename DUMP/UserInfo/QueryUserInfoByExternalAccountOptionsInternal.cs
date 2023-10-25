using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.UserInfo
{
	// Token: 0x02000053 RID: 83
	[Token(Token = "0x2000053")]
	internal struct QueryUserInfoByExternalAccountOptionsInternal : ISettable<QueryUserInfoByExternalAccountOptions>, IDisposable
	{
		// Token: 0x17000070 RID: 112
		// (set) Token: 0x0600045F RID: 1119 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000070")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x600045F")]
			[Address(RVA = "0x4AEB40", Offset = "0x4AD140", VA = "0x1804AEB40")]
			set
			{
			}
		}

		// Token: 0x17000071 RID: 113
		// (set) Token: 0x06000460 RID: 1120 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000071")]
		public Utf8String ExternalAccountId
		{
			[Token(Token = "0x6000460")]
			[Address(RVA = "0x4AEAE0", Offset = "0x4AD0E0", VA = "0x1804AEAE0")]
			set
			{
			}
		}

		// Token: 0x17000072 RID: 114
		// (set) Token: 0x06000461 RID: 1121 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000072")]
		public ExternalAccountType AccountType
		{
			[Token(Token = "0x6000461")]
			[Address(RVA = "0x444820", Offset = "0x442E20", VA = "0x180444820")]
			set
			{
			}
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000462")]
		[Address(RVA = "0x4AEA50", Offset = "0x4AD050", VA = "0x1804AEA50", Slot = "4")]
		public void Set(ref QueryUserInfoByExternalAccountOptions other)
		{
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000463")]
		[Address(RVA = "0x4AE950", Offset = "0x4ACF50", VA = "0x1804AE950", Slot = "5")]
		public void Set(ref QueryUserInfoByExternalAccountOptions? other)
		{
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000464")]
		[Address(RVA = "0x4AE870", Offset = "0x4ACE70", VA = "0x1804AE870", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x040001DC RID: 476
		[Token(Token = "0x40001DC")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x040001DD RID: 477
		[Token(Token = "0x40001DD")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x040001DE RID: 478
		[Token(Token = "0x40001DE")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_ExternalAccountId;

		// Token: 0x040001DF RID: 479
		[Token(Token = "0x40001DF")]
		[FieldOffset(Offset = "0x18")]
		private ExternalAccountType m_AccountType;
	}
}
