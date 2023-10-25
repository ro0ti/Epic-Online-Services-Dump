using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.AntiCheatServer
{
	// Token: 0x0200069B RID: 1691
	[Token(Token = "0x200069B")]
	internal struct BeginSessionOptionsInternal : ISettable<BeginSessionOptions>, IDisposable
	{
		// Token: 0x17000CBA RID: 3258
		// (set) Token: 0x06002B8E RID: 11150 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000CBA")]
		public uint RegisterTimeoutSeconds
		{
			[Token(Token = "0x6002B8E")]
			[Address(RVA = "0x4A4E90", Offset = "0x4A3490", VA = "0x1804A4E90")]
			set
			{
			}
		}

		// Token: 0x17000CBB RID: 3259
		// (set) Token: 0x06002B8F RID: 11151 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000CBB")]
		public Utf8String ServerName
		{
			[Token(Token = "0x6002B8F")]
			[Address(RVA = "0x56FD60", Offset = "0x56E360", VA = "0x18056FD60")]
			set
			{
			}
		}

		// Token: 0x17000CBC RID: 3260
		// (set) Token: 0x06002B90 RID: 11152 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000CBC")]
		public bool EnableGameplayData
		{
			[Token(Token = "0x6002B90")]
			[Address(RVA = "0x56FC40", Offset = "0x56E240", VA = "0x18056FC40")]
			set
			{
			}
		}

		// Token: 0x17000CBD RID: 3261
		// (set) Token: 0x06002B91 RID: 11153 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000CBD")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6002B91")]
			[Address(RVA = "0x56FD00", Offset = "0x56E300", VA = "0x18056FD00")]
			set
			{
			}
		}

		// Token: 0x06002B92 RID: 11154 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002B92")]
		[Address(RVA = "0x56F8E0", Offset = "0x56DEE0", VA = "0x18056F8E0", Slot = "4")]
		public void Set(ref BeginSessionOptions other)
		{
		}

		// Token: 0x06002B93 RID: 11155 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002B93")]
		[Address(RVA = "0x56F9F0", Offset = "0x56DFF0", VA = "0x18056F9F0", Slot = "5")]
		public void Set(ref BeginSessionOptions? other)
		{
		}

		// Token: 0x06002B94 RID: 11156 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002B94")]
		[Address(RVA = "0x56F800", Offset = "0x56DE00", VA = "0x18056F800", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x040012E5 RID: 4837
		[Token(Token = "0x40012E5")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x040012E6 RID: 4838
		[Token(Token = "0x40012E6")]
		[FieldOffset(Offset = "0x4")]
		private uint m_RegisterTimeoutSeconds;

		// Token: 0x040012E7 RID: 4839
		[Token(Token = "0x40012E7")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ServerName;

		// Token: 0x040012E8 RID: 4840
		[Token(Token = "0x40012E8")]
		[FieldOffset(Offset = "0x10")]
		private int m_EnableGameplayData;

		// Token: 0x040012E9 RID: 4841
		[Token(Token = "0x40012E9")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_LocalUserId;
	}
}
