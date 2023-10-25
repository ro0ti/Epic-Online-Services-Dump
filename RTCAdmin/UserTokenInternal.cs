using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.RTCAdmin
{
	// Token: 0x02000256 RID: 598
	[Token(Token = "0x2000256")]
	internal struct UserTokenInternal : IGettable<UserToken>, ISettable<UserToken>, IDisposable
	{
		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x06001082 RID: 4226 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001083 RID: 4227 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700042A")]
		public ProductUserId ProductUserId
		{
			[Token(Token = "0x6001082")]
			[Address(RVA = "0x4EBCF0", Offset = "0x4EA2F0", VA = "0x1804EBCF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001083")]
			[Address(RVA = "0x4EBDE0", Offset = "0x4EA3E0", VA = "0x1804EBDE0")]
			set
			{
			}
		}

		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x06001084 RID: 4228 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001085 RID: 4229 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700042B")]
		public Utf8String Token
		{
			[Token(Token = "0x6001084")]
			[Address(RVA = "0x4EBD70", Offset = "0x4EA370", VA = "0x1804EBD70")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001085")]
			[Address(RVA = "0x4EBE40", Offset = "0x4EA440", VA = "0x1804EBE40")]
			set
			{
			}
		}

		// Token: 0x06001086 RID: 4230 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001086")]
		[Address(RVA = "0x4EBB20", Offset = "0x4EA120", VA = "0x1804EBB20", Slot = "5")]
		public void Set(ref UserToken other)
		{
		}

		// Token: 0x06001087 RID: 4231 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001087")]
		[Address(RVA = "0x4EBBE0", Offset = "0x4EA1E0", VA = "0x1804EBBE0", Slot = "6")]
		public void Set(ref UserToken? other)
		{
		}

		// Token: 0x06001088 RID: 4232 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001088")]
		[Address(RVA = "0x4EBAA0", Offset = "0x4EA0A0", VA = "0x1804EBAA0", Slot = "7")]
		public void Dispose()
		{
		}

		// Token: 0x06001089 RID: 4233 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001089")]
		[Address(RVA = "0x4EBB00", Offset = "0x4EA100", VA = "0x1804EBB00", Slot = "4")]
		public void Get(out UserToken output)
		{
		}

		// Token: 0x04000759 RID: 1881
		[Token(Token = "0x4000759")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x0400075A RID: 1882
		[Token(Token = "0x400075A")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ProductUserId;

		// Token: 0x0400075B RID: 1883
		[Token(Token = "0x400075B")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_Token;
	}
}
