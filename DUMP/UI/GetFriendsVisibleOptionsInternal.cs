using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.UI
{
	// Token: 0x02000064 RID: 100
	[Token(Token = "0x2000064")]
	internal struct GetFriendsVisibleOptionsInternal : ISettable<GetFriendsVisibleOptions>, IDisposable
	{
		// Token: 0x17000093 RID: 147
		// (set) Token: 0x060004C9 RID: 1225 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000093")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x60004C9")]
			[Address(RVA = "0x4A6570", Offset = "0x4A4B70", VA = "0x1804A6570")]
			set
			{
			}
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x4A64E0", Offset = "0x4A4AE0", VA = "0x1804A64E0", Slot = "4")]
		public void Set(ref GetFriendsVisibleOptions other)
		{
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x4A6500", Offset = "0x4A4B00", VA = "0x1804A6500", Slot = "5")]
		public void Set(ref GetFriendsVisibleOptions? other)
		{
		}

		// Token: 0x060004CC RID: 1228 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x4A6450", Offset = "0x4A4A50", VA = "0x1804A6450", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000214 RID: 532
		[Token(Token = "0x4000214")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000215 RID: 533
		[Token(Token = "0x4000215")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;
	}
}
