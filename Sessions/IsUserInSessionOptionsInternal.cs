using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Sessions
{
	// Token: 0x02000119 RID: 281
	[Token(Token = "0x2000119")]
	internal struct IsUserInSessionOptionsInternal : ISettable<IsUserInSessionOptions>, IDisposable
	{
		// Token: 0x170001E2 RID: 482
		// (set) Token: 0x060008E4 RID: 2276 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001E2")]
		public Utf8String SessionName
		{
			[Token(Token = "0x60008E4")]
			[Address(RVA = "0x4BDFA0", Offset = "0x4BC5A0", VA = "0x1804BDFA0")]
			set
			{
			}
		}

		// Token: 0x170001E3 RID: 483
		// (set) Token: 0x060008E5 RID: 2277 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001E3")]
		public ProductUserId TargetUserId
		{
			[Token(Token = "0x60008E5")]
			[Address(RVA = "0x4BE000", Offset = "0x4BC600", VA = "0x1804BE000")]
			set
			{
			}
		}

		// Token: 0x060008E6 RID: 2278 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008E6")]
		[Address(RVA = "0x4BDEE0", Offset = "0x4BC4E0", VA = "0x1804BDEE0", Slot = "4")]
		public void Set(ref IsUserInSessionOptions other)
		{
		}

		// Token: 0x060008E7 RID: 2279 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008E7")]
		[Address(RVA = "0x4BDDD0", Offset = "0x4BC3D0", VA = "0x1804BDDD0", Slot = "5")]
		public void Set(ref IsUserInSessionOptions? other)
		{
		}

		// Token: 0x060008E8 RID: 2280 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008E8")]
		[Address(RVA = "0x4BDD70", Offset = "0x4BC370", VA = "0x1804BDD70", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000450 RID: 1104
		[Token(Token = "0x4000450")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000451 RID: 1105
		[Token(Token = "0x4000451")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_SessionName;

		// Token: 0x04000452 RID: 1106
		[Token(Token = "0x4000452")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_TargetUserId;
	}
}
