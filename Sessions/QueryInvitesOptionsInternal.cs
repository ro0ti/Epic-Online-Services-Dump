using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Sessions
{
	// Token: 0x02000147 RID: 327
	[Token(Token = "0x2000147")]
	internal struct QueryInvitesOptionsInternal : ISettable<QueryInvitesOptions>, IDisposable
	{
		// Token: 0x17000207 RID: 519
		// (set) Token: 0x060009C2 RID: 2498 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000207")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x60009C2")]
			[Address(RVA = "0x4C2CC0", Offset = "0x4C12C0", VA = "0x1804C2CC0")]
			set
			{
			}
		}

		// Token: 0x060009C3 RID: 2499 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009C3")]
		[Address(RVA = "0x4C2BC0", Offset = "0x4C11C0", VA = "0x1804C2BC0", Slot = "4")]
		public void Set(ref QueryInvitesOptions other)
		{
		}

		// Token: 0x060009C4 RID: 2500 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009C4")]
		[Address(RVA = "0x4C2C20", Offset = "0x4C1220", VA = "0x1804C2C20", Slot = "5")]
		public void Set(ref QueryInvitesOptions? other)
		{
		}

		// Token: 0x060009C5 RID: 2501 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009C5")]
		[Address(RVA = "0x4C2B70", Offset = "0x4C1170", VA = "0x1804C2B70", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000480 RID: 1152
		[Token(Token = "0x4000480")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000481 RID: 1153
		[Token(Token = "0x4000481")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;
	}
}
