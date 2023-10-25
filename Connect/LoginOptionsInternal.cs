using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Connect
{
	// Token: 0x02000618 RID: 1560
	[Token(Token = "0x2000618")]
	internal struct LoginOptionsInternal : ISettable<LoginOptions>, IDisposable
	{
		// Token: 0x17000BAC RID: 2988
		// (set) Token: 0x06002808 RID: 10248 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BAC")]
		public Credentials? Credentials
		{
			[Token(Token = "0x6002808")]
			[Address(RVA = "0x55ED80", Offset = "0x55D380", VA = "0x18055ED80")]
			set
			{
			}
		}

		// Token: 0x17000BAD RID: 2989
		// (set) Token: 0x06002809 RID: 10249 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BAD")]
		public UserLoginInfo? UserLoginInfo
		{
			[Token(Token = "0x6002809")]
			[Address(RVA = "0x55EDF0", Offset = "0x55D3F0", VA = "0x18055EDF0")]
			set
			{
			}
		}

		// Token: 0x0600280A RID: 10250 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600280A")]
		[Address(RVA = "0x55EAB0", Offset = "0x55D0B0", VA = "0x18055EAB0", Slot = "4")]
		public void Set(ref LoginOptions other)
		{
		}

		// Token: 0x0600280B RID: 10251 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600280B")]
		[Address(RVA = "0x55EBB0", Offset = "0x55D1B0", VA = "0x18055EBB0", Slot = "5")]
		public void Set(ref LoginOptions? other)
		{
		}

		// Token: 0x0600280C RID: 10252 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600280C")]
		[Address(RVA = "0x55E870", Offset = "0x55CE70", VA = "0x18055E870", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x0400118F RID: 4495
		[Token(Token = "0x400118F")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04001190 RID: 4496
		[Token(Token = "0x4001190")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_Credentials;

		// Token: 0x04001191 RID: 4497
		[Token(Token = "0x4001191")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_UserLoginInfo;
	}
}
