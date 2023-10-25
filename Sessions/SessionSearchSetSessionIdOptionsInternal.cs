using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Sessions
{
	// Token: 0x02000191 RID: 401
	[Token(Token = "0x2000191")]
	internal struct SessionSearchSetSessionIdOptionsInternal : ISettable<SessionSearchSetSessionIdOptions>, IDisposable
	{
		// Token: 0x1700029F RID: 671
		// (set) Token: 0x06000B7A RID: 2938 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700029F")]
		public Utf8String SessionId
		{
			[Token(Token = "0x6000B7A")]
			[Address(RVA = "0x4CCBB0", Offset = "0x4CB1B0", VA = "0x1804CCBB0")]
			set
			{
			}
		}

		// Token: 0x06000B7B RID: 2939 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B7B")]
		[Address(RVA = "0x4CCAB0", Offset = "0x4CB0B0", VA = "0x1804CCAB0", Slot = "4")]
		public void Set(ref SessionSearchSetSessionIdOptions other)
		{
		}

		// Token: 0x06000B7C RID: 2940 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B7C")]
		[Address(RVA = "0x4CCB10", Offset = "0x4CB110", VA = "0x1804CCB10", Slot = "5")]
		public void Set(ref SessionSearchSetSessionIdOptions? other)
		{
		}

		// Token: 0x06000B7D RID: 2941 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B7D")]
		[Address(RVA = "0x4CCA60", Offset = "0x4CB060", VA = "0x1804CCA60", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x0400054E RID: 1358
		[Token(Token = "0x400054E")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x0400054F RID: 1359
		[Token(Token = "0x400054F")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_SessionId;
	}
}
