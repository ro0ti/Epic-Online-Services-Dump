using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Ecom
{
	// Token: 0x02000586 RID: 1414
	[Token(Token = "0x2000586")]
	internal struct QueryOwnershipBySandboxIdsOptionsInternal : ISettable<QueryOwnershipBySandboxIdsOptions>, IDisposable
	{
		// Token: 0x17000A8D RID: 2701
		// (set) Token: 0x06002462 RID: 9314 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A8D")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x6002462")]
			[Address(RVA = "0x54D8E0", Offset = "0x54BEE0", VA = "0x18054D8E0")]
			set
			{
			}
		}

		// Token: 0x17000A8E RID: 2702
		// (set) Token: 0x06002463 RID: 9315 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A8E")]
		public Utf8String[] SandboxIds
		{
			[Token(Token = "0x6002463")]
			[Address(RVA = "0x54D940", Offset = "0x54BF40", VA = "0x18054D940")]
			set
			{
			}
		}

		// Token: 0x06002464 RID: 9316 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002464")]
		[Address(RVA = "0x54D850", Offset = "0x54BE50", VA = "0x18054D850", Slot = "4")]
		public void Set(ref QueryOwnershipBySandboxIdsOptions other)
		{
		}

		// Token: 0x06002465 RID: 9317 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002465")]
		[Address(RVA = "0x54D770", Offset = "0x54BD70", VA = "0x18054D770", Slot = "5")]
		public void Set(ref QueryOwnershipBySandboxIdsOptions? other)
		{
		}

		// Token: 0x06002466 RID: 9318 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002466")]
		[Address(RVA = "0x54D710", Offset = "0x54BD10", VA = "0x18054D710", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04001025 RID: 4133
		[Token(Token = "0x4001025")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04001026 RID: 4134
		[Token(Token = "0x4001026")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x04001027 RID: 4135
		[Token(Token = "0x4001027")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_SandboxIds;

		// Token: 0x04001028 RID: 4136
		[Token(Token = "0x4001028")]
		[FieldOffset(Offset = "0x18")]
		private uint m_SandboxIdsCount;
	}
}
